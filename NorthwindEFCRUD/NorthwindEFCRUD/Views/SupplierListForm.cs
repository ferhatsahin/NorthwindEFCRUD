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
    public partial class SupplierListForm : Form
    {
        public SupplierListForm()
        {
            InitializeComponent();
        }

        private void SupplierListForm_Load(object sender, EventArgs e)
        {
            gridSupplier.AutoGenerateColumns = false;
            RefreshGrid();
        }

        private void RefreshGrid()
        {
            using (var dbContext = DbHelper.CreateDbContext())
            {
                gridSupplier.DataSource = dbContext.Suppliers.AsNoTracking().ToList();
            }
        }

        private void ctxBtnRefresh_Click(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        private void ctxBtnDelete_Click(object sender, EventArgs e)
        {
            var supplierId = GetSupplierIdFromGrid();
            using (var dbContext = DbHelper.CreateDbContext())
            {
                var supplier = dbContext.Suppliers.FirstOrDefault(s => s.SupplierID == supplierId);

                if (supplier != null)
                {
                    dbContext.Suppliers.Remove(supplier);
                    dbContext.SaveChanges();
                }
            }
            RefreshGrid();
        }

        private void gridSupplier_CellContextMenuStripNeeded(object sender, DataGridViewCellContextMenuStripNeededEventArgs e)
        {
            gridSupplier.Rows[e.RowIndex].Selected = true; ;
        }

        private void gridSupplier_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int supplierId = GetSupplierIdFromGrid();

            var suppliertEditForm = new SupplierEditForm(supplierId);
            suppliertEditForm.MdiParent = MdiParent;
            suppliertEditForm.Show();
        }

        private int GetSupplierIdFromGrid()
        {
            return (int)gridSupplier.SelectedRows[0].Cells["colSupplierId"].Value;
        }
    }
}
