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
    public partial class CustomerListForm : Form
    {
        public CustomerListForm()
        {
            InitializeComponent();
        }

        private void CustomerListForm_Load(object sender, EventArgs e)
        {
            gridCustomer.AutoGenerateColumns = false;
            RefreshGrid();
        }

        private void RefreshGrid()
        {
            using (var dbContext = DbHelper.CreateDbContext())
            {
                gridCustomer.DataSource = dbContext.Customers.AsNoTracking().ToList();
            }
        }

        private void gridCustomer_CellContextMenuStripNeeded(object sender, DataGridViewCellContextMenuStripNeededEventArgs e)
        {
            gridCustomer.Rows[e.RowIndex].Selected = true;
        }

        private string GetCustomerIdFromGrid()
        {
            return (string)gridCustomer.SelectedRows[0].Cells["colCustomerID"].Value;
        }

        private void ctxBtnRefresh_Click(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        private void ctxBtnDelete_Click(object sender, EventArgs e)
        {
            var customerId = GetCustomerIdFromGrid();
            var dbContext = DbHelper.CreateDbContext();

            try
            {
                var customer = dbContext.Customers.FirstOrDefault(c => c.CustomerID == customerId);
                dbContext.Customers.Remove(customer);
                dbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred");
            }
            finally
            {
                dbContext?.Dispose();
            }
            RefreshGrid();
        }

        private void gridCustomer_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var customerId = GetCustomerIdFromGrid();

            var customerEditForm = new CustomerEditForm(customerId);
            customerEditForm.MdiParent = MdiParent;
            customerEditForm.Show();
        }
    }
}
