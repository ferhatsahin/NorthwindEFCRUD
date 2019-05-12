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
    public partial class ShipperListForm : Form
    {
        public ShipperListForm()
        {
            InitializeComponent();
        }

        private void ShipperListForm_Load(object sender, EventArgs e)
        {
            gridShipper.AutoGenerateColumns = false;
            RefreshGrid();
        }

        private void RefreshGrid()
        {
            using (var dbContext = DbHelper.CreateDbContext())
            {
                gridShipper.DataSource = dbContext.Shippers.AsNoTracking().ToList();
            }
        }

        private void gridShipper_CellContextMenuStripNeeded(object sender, DataGridViewCellContextMenuStripNeededEventArgs e)
        {
            gridShipper.Rows[e.RowIndex].Selected = true;
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        private void gridShipper_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var shipperId = GetShipperIdFromGrid();
            var shipperEditForm = new ShipperEditForm(shipperId);
            shipperEditForm.MdiParent = MdiParent;
            shipperEditForm.Show();
        }

        private void ctxbtnDelete_Click(object sender, EventArgs e)
        {
            var shipperId = GetShipperIdFromGrid();
            var dbContext = DbHelper.CreateDbContext();

            try
            {
                var shipper = dbContext.Shippers.FirstOrDefault(s => s.ShipperID == shipperId);
                dbContext.Shippers.Remove(shipper);
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

        private int GetShipperIdFromGrid()
        {
            return (int)gridShipper.SelectedRows[0].Cells["colShipperID"].Value;
        }
    }
}
