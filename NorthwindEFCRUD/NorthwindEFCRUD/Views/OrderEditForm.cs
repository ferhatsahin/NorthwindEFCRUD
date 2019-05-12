using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NorthwindEFCRUD.Views
{
    public partial class OrderEditForm : Form
    {
        private int _orderId;
        private List<Order_Detail> _orderDetails = new List<Order_Detail>();

        public OrderEditForm()
        {
            InitializeComponent();
        }

        public OrderEditForm(int orderId) : this()
        {
            _orderId = orderId;
        }

        private void OrderEditForm_Load(object sender, EventArgs e)
        {
            FillComboBoxes();

            if (_orderId != 0)
            {
                btnAddProduct.Enabled = false;
                FillFormByOrder();
                FillListBox();
            }
        }

        private void FillListBox()
        {
            using (var dbContext = DbHelper.CreateDbContext())
            {
                lstProducts.Items.Clear();
                lstProducts.DataSource = dbContext
                    .Order_Details
                    .AsNoTracking()
                    .Include("Product")
                    .Where(od => od.OrderID == _orderId).ToList();
            }
        }

        private void FillComboBoxes()
        {
            using (var dbContext = DbHelper.CreateDbContext())
            {
                //Empployee
                cmbEmployee.DataSource = dbContext.Employees.AsNoTracking().ToList();
                cmbEmployee.DisplayMember = "FullName";
                cmbEmployee.ValueMember = "EmployeeID";

                //Customer
                cmbCustomer.DataSource = dbContext.Customers.AsNoTracking().ToList();
                cmbCustomer.DisplayMember = "CompanyName";
                cmbCustomer.ValueMember = "CustomerID";

                //ShpVia
                cmbShipVia.DataSource = dbContext.Shippers.AsNoTracking().ToList();
                cmbShipVia.DisplayMember = "CompanyName";
                cmbShipVia.ValueMember = "ShipperID";
            }
        }

        private void FillFormByOrder()
        {
            var order = DbHelper.CreateDbContext()
                            .Orders
                            .AsNoTracking()
                            .Include("Shipper")
                            .FirstOrDefault(o => o.OrderID == _orderId);

            dtpOrderDate.Text = order.OrderDate.ToString();
            dtpRequiredDate.Text = order.RequiredDate.ToString();
            dtpShipDate.Text = order.ShippedDate.ToString();
            txtRegion.Text = order.ShipRegion;
            txtPostalCode.Text = order.ShipPostalCode;
            txtCountry.Text = order.ShipCountry;
            txtShipCity.Text = order.ShipCity;
            numFeright.Value = order.Freight.Value;
            txtShipName.Text = order.ShipName;
            txtShipAddress.Text = order.ShipAddress;
            cmbShipVia.SelectedIndex = order.Shipper.ShipperID - 1;
            cmbCustomer.SelectedValue = order.CustomerID;
            cmbEmployee.SelectedValue = order.EmployeeID;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            InsertToOrder();
            InsertToOrderDetails();
            Dispose();
        }

        private void InsertToOrderDetails()
        {
            if (_orderId == 0)
            {
                var dbContext = DbHelper.CreateDbContext();

                try
                {
                    var orderId = GetLastIndexFromOrder();
                    foreach (var item in _orderDetails)
                    {
                        UpdateProductInfo(item);
                        item.Product = null;
                        item.OrderID = orderId;
                        dbContext.Order_Details.Add(item);
                    }
                    dbContext.SaveChanges();
                }
                catch (Exception)
                {

                    throw;
                }
                finally
                {
                    dbContext?.Dispose();
                }
            }
        }

        private void UpdateProductInfo(Order_Detail item)
        {
            using (var dbContext = DbHelper.CreateDbContext())
            {
                var product = dbContext.Products.FirstOrDefault(p => p.ProductID == item.ProductID);
                product.UnitsInStock -= item.Quantity;
                dbContext.Entry(product).State = System.Data.Entity.EntityState.Modified;
                dbContext.SaveChanges();
            }
        }

        private int GetLastIndexFromOrder()
        {
            using (var dbContext = DbHelper.CreateDbContext())
            {
                return dbContext.Orders.AsNoTracking().Max(o => o.OrderID);
            }
        }

        private void InsertToOrder()
        {
            var dbContext = DbHelper.CreateDbContext();
            var order = CreateOrderByForm();
            try
            {
                if (_orderId == 0)
                    dbContext.Orders.Add(order);
                else
                {
                    order.OrderID = _orderId;
                    dbContext.Entry(order).State = System.Data.Entity.EntityState.Modified;
                }
                dbContext.SaveChanges();
            }
            catch (Exception)
            {
                MessageBox.Show("Error occurred");
            }
            finally
            {
                dbContext?.Dispose();
            }
        }

        private Order CreateOrderByForm()
        {
            return new Order
            {
                ShipCountry = txtCountry.Text.Trim(),
                ShipCity = txtShipCity.Text.Trim(),
                ShipPostalCode = txtPostalCode.Text.Trim(),
                OrderDate = DateTime.TryParse(dtpOrderDate.Text, out DateTime date)
                            ? date
                            : (DateTime?)null,
                RequiredDate = DateTime.TryParse(dtpRequiredDate.Text, out DateTime date1)
                               ? date1
                               : (DateTime?)null,
                ShippedDate = DateTime.TryParse(dtpShipDate.Text, out DateTime date2)
                              ? date2
                              : (DateTime?)null,
                ShipVia = ((Shipper)cmbShipVia.SelectedItem).ShipperID,
                Freight = numFeright.Value,
                ShipName = txtShipName.Text.Trim(),
                ShipAddress = txtShipAddress.Text.Trim(),
                ShipRegion = txtRegion.Text.Trim(),
                CustomerID = ((Customer)cmbCustomer.SelectedItem).CustomerID,
                EmployeeID = ((Employee)cmbEmployee.SelectedItem).EmployeeID
            };
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            var orderDetailsEditForm = new OrderDetailsEditForm(_orderDetails);
            orderDetailsEditForm.OrderDetailEnded += AddOrderDetailToList;
            orderDetailsEditForm.ShowDialog();
        }

        private void AddOrderDetailToList()
        {
            lstProducts.Items.Clear();

            foreach (var item in _orderDetails)
            {
                lstProducts.Items.Add(item.ToString());
            }
        }
    }
}