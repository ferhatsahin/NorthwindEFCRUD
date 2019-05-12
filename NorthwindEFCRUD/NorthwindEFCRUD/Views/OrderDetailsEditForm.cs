using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static NorthwindEFCRUD.DelegateAndEvent;

namespace NorthwindEFCRUD.Views
{
    public partial class OrderDetailsEditForm : Form
    {
        private List<Order_Detail> _orderDetails;

        public event FormSavedEventHandler OrderDetailEnded;

        public OrderDetailsEditForm()
        {
            InitializeComponent();
        }

        public OrderDetailsEditForm(List<Order_Detail> orderDetails) : this()
        {
            _orderDetails = orderDetails;
        }

        private void OrderDetailsEditForm_Load(object sender, EventArgs e)
        {
            gridOrderDetails.AutoGenerateColumns = false;
            FillProductComboBox();
            FillGridOrderDetails();
        }

        private void FillGridOrderDetails()
        {
            gridOrderDetails.DataSource = null;
            gridOrderDetails.DataSource = _orderDetails;
        }

        private void FillProductComboBox()
        {
            List<Product> productList = new List<Product>();
            using (var dbContext = DbHelper.CreateDbContext())
            {
                var products = dbContext.Products.AsNoTracking().ToList();
                foreach (var item in products)
                {
                    if (!item.Discontinued)
                    {
                        productList.Add(item);
                    }
                }
                cmbProduct.DataSource = productList;
                cmbProduct.DisplayMember = "ProductName";
                cmbProduct.ValueMember = "ProductID";
            }
        }

        private void cmbProductId_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtUnitPrice.Text = ((Product)cmbProduct.SelectedItem).UnitPrice.ToString();
            numDiscount.Value = numDiscount.Minimum;
            numQuantity.Value = numQuantity.Minimum;
        }

        private void btnAddBasket_Click(object sender, EventArgs e)
        {
            var orderDetail = CreateOrderDetailByForm();

            if (!IsValidForSales(orderDetail)) //2,3
            {
                MessageBox.Show("The product is not valid for sales..");
            }
            else if (!IsProductExistInList(orderDetail))
            {
                _orderDetails.Add(orderDetail);
            }

            FillGridOrderDetails();
        }

        private bool IsValidForSales(Order_Detail orderDetail)
        {
            return !(orderDetail.Product.UnitsInStock == 0
                   || orderDetail.Product.UnitsInStock < orderDetail.Quantity);
        }

        private bool IsProductExistInList(Order_Detail orderDetail)
        {
            foreach (var item in _orderDetails)
            {
                if (item.ProductID == orderDetail.ProductID)
                {
                    item.Quantity += orderDetail.Quantity;
                    return true;
                }
            }
            return false;
        }

        private Order_Detail CreateOrderDetailByForm()
        {
            return new Order_Detail
            {
                ProductID = ((Product)cmbProduct.SelectedItem).ProductID,
                UnitPrice = decimal.Parse(txtUnitPrice.Text),
                Quantity = (short)numQuantity.Value,
                Discount = numDiscount.Value > 100
                            ? 100
                            : ((float)numDiscount.Value) / 100,
                Product = ((Product)cmbProduct.SelectedItem)
            };
        }

        private void btnEndedAdding_Click(object sender, EventArgs e)
        {
            OrderDetailEnded?.Invoke();
            Dispose();
        }
    }
}
