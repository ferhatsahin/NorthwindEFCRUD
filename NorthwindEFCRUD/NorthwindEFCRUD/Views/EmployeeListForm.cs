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
    public partial class EmployeeListForm : Form
    {
        public EmployeeListForm()
        {
            InitializeComponent();
        }

        private void EmployeeListForm_Load(object sender, EventArgs e)
        {
            gridEmployee.AutoGenerateColumns = false;
            RefreshGrid();
        }

        private void RefreshGrid()
        {
            using (var dbContext = DbHelper.CreateDbContext())
            {
                gridEmployee.DataSource = dbContext.Employees.AsNoTracking().ToList();
            }
        }

        private void gridEmployee_CellContextMenuStripNeeded(object sender, DataGridViewCellContextMenuStripNeededEventArgs e)
        {
            gridEmployee.Rows[e.RowIndex].Selected = true;
        }

        private void ctxBtnRefresh_Click(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        private void ctxBtnDelete_Click(object sender, EventArgs e)
        {
            var employeId = GetEmployeeIdFromGrid();
            var dbContext = DbHelper.CreateDbContext();

            try
            {
                var employee = dbContext.Employees.FirstOrDefault(em => em.EmployeeID == employeId);
                dbContext.Employees.Remove(employee);
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

        private int GetEmployeeIdFromGrid()
        {
            return (int)gridEmployee.SelectedRows[0].Cells["colEmployeeId"].Value;
        }

        private void gridEmployee_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var employeeId = GetEmployeeIdFromGrid();

            var employeeEditForm = new EmployeeEditForm(employeeId);
            employeeEditForm.MdiParent = MdiParent;
            employeeEditForm.Show();
        }
    }
}
