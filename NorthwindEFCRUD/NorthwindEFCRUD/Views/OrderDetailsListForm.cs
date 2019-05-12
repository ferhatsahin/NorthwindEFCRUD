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
    public partial class OrderDetailsListForm : Form
    {
        private int _orderId;

        public OrderDetailsListForm(int orderId)
        {
            InitializeComponent();
            _orderId = orderId;
        }

        private void OrderDetailsListForm_Load(object sender, EventArgs e)
        {
            if (_orderId != 0)
            {
                RefreshGrid();
            }
        }

        private void RefreshGrid()
        {
            using (var dbContext = DbHelper.CreateDbContext())
            {
                gridOrderDetails.DataSource = dbContext
                    .Order_Details
                    .AsNoTracking()
                    .Include("Product")
                    .Include("Order")
                    .Where(od => od.OrderID == _orderId)
                    .ToList();
            }
        }

        private void ctxBtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var product = (Product)gridOrderDetails.SelectedRows[0]
                                     .Cells["colProduct"].Value;
                var order = (Order)gridOrderDetails.SelectedRows[0]
                                     .Cells["colOrder"].Value;

                using (var dbContext = DbHelper.CreateDbContext())
                {
                    var orderDetail = dbContext
                        .Order_Details
                        .Where(od => od.OrderID == order.OrderID
                                && od.ProductID == product.ProductID).FirstOrDefault();
                    dbContext.Order_Details.Remove(orderDetail);
                    dbContext.SaveChanges();
                }
            }
            catch (Exception) { }

            RefreshGrid();
        }

        private void gridOrderDetails_CellContextMenuStripNeeded(object sender, DataGridViewCellContextMenuStripNeededEventArgs e)
        {
            gridOrderDetails.Rows[e.RowIndex].Selected = true;
        }
    }
}
