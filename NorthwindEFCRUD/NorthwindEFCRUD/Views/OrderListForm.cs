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
    public partial class OrderListForm : Form
    {
        public OrderListForm()
        {
            InitializeComponent();
        }

        private void OrderListForm_Load(object sender, EventArgs e)
        {
            gridOrder.AutoGenerateColumns = false;
            RefreshGrid();
        }

        private void RefreshGrid()
        {
            using (var dbContext = DbHelper.CreateDbContext())
            {
                gridOrder.DataSource = dbContext
                    .Orders
                    .AsNoTracking()
                    .Include("Customer")
                    .Include("Employee")
                    .ToList();
            }
        }
        private int GetEOrderIdFromGrid()
        {
            return (int)gridOrder.SelectedRows[0].Cells["colOrderID"].Value;
        }

        private void gridOrder_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var orderId = GetEOrderIdFromGrid();

            var orderEditForm = new OrderEditForm(orderId);
            orderEditForm.MdiParent = MdiParent;
            orderEditForm.Show();
        }

        private void ctxBtnRefresh_Click(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        private void ctxBtnDelete_Click(object sender, EventArgs e)
        {
            var orderId = GetEOrderIdFromGrid();
            try
            {
                DeleteOrderDetails(orderId);
                DeleteOrder(orderId);
            }
            catch (Exception)
            {
                MessageBox.Show("Error occurred");
            }

            RefreshGrid();
        }

        private void DeleteOrder(int orderId)
        {
            using (var dbContext = DbHelper.CreateDbContext())
            {
                var order = dbContext.Orders.FirstOrDefault(o => o.OrderID == orderId);
                dbContext.Orders.Remove(order);
                dbContext.SaveChanges();
            }
        }

        private void DeleteOrderDetails(int orderId)
        {
            using (var dbContext = DbHelper.CreateDbContext())
            {
                var orderDetails = dbContext
                    .Order_Details
                    .Where(od => od.OrderID == orderId)
                    .ToList();

                foreach (var item in orderDetails)
                {
                    dbContext.Order_Details.Remove(item);
                    UpdateProductInfo(item); // 4.1
                }

                dbContext.SaveChanges();
            }
        }

        private void UpdateProductInfo(Order_Detail item)//4.1
        {
            using (var dbContext = DbHelper.CreateDbContext())
            {
                var product = dbContext.Products.FirstOrDefault(p => p.ProductID == item.ProductID);
                product.UnitsInStock += item.Quantity;
                dbContext.Entry(product).State = System.Data.Entity.EntityState.Modified;
                dbContext.SaveChanges();
            }
        }

        private void ctxBtnOrderDetails_Click(object sender, EventArgs e)
        {
            var orderId = GetEOrderIdFromGrid();
            var orderDetailsListForm = new OrderDetailsListForm(orderId);
            orderDetailsListForm.ShowDialog();
        }

        private void gridOrder_CellContextMenuStripNeeded(object sender, DataGridViewCellContextMenuStripNeededEventArgs e)
        {
            gridOrder.Rows[e.RowIndex].Selected = true;
        }
    }
}
