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
    public partial class RegionListForm : Form
    {
        public RegionListForm()
        {
            InitializeComponent();
        }

        private void RegionListForm_Load(object sender, EventArgs e)
        {
            gridRegion.AutoGenerateColumns = false;
            RefreshGrid();
        }

        private void RefreshGrid()
        {
            using (var dbContext = DbHelper.CreateDbContext())
            {
                gridRegion.DataSource = dbContext.Regions.AsNoTracking().ToList();
            }
        }

        private void gridRegion_CellContextMenuStripNeeded(object sender, DataGridViewCellContextMenuStripNeededEventArgs e)
        {
            gridRegion.Rows[e.RowIndex].Selected = true;
        }

        private void ctxBtnRefresh_Click(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        private void ctxBtnDelete_Click(object sender, EventArgs e)
        {
            var regionId = GetRegionIdFromGrid();
            var dbContext = DbHelper.CreateDbContext();

            try
            {
                var region = dbContext.Regions.FirstOrDefault(r => r.RegionID == regionId);
                dbContext.Regions.Remove(region);
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

        private int GetRegionIdFromGrid()
        {
            return (int)gridRegion.SelectedRows[0].Cells["colRegionId"].Value;
        }

        private void gridRegion_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var regionId = GetRegionIdFromGrid();

            var regionEditForm = new RegionEditForm(regionId);
            regionEditForm.MdiParent = MdiParent;
            regionEditForm.Show();
        }
    }
}
