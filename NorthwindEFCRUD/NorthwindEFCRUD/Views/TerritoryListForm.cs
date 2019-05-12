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
    public partial class TerritoryListForm : Form
    {
        public TerritoryListForm()
        {
            InitializeComponent();
        }

        private void TerritoryListForm_Load(object sender, EventArgs e)
        {
            gridTerritory.AutoGenerateColumns = false;
            RefreshGrid();
        }

        private void RefreshGrid()
        {
            using (var dbContext = DbHelper.CreateDbContext())
            {
                gridTerritory.DataSource = dbContext
                    .Territories
                    .AsNoTracking()
                    .Include("Region")
                    .ToList();
            }
        }

        private void gridTerritory_CellContextMenuStripNeeded(object sender, DataGridViewCellContextMenuStripNeededEventArgs e)
        {
            gridTerritory.Rows[e.RowIndex].Selected = true;
        }

        private void ctxBtnRefresh_Click(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        private void ctxbtndelete_Click(object sender, EventArgs e)
        {
            var territoryId = GetEmployeeIdFromGrid();
            var dbContext = DbHelper.CreateDbContext();

            try
            {
                var territory = dbContext.Territories.FirstOrDefault(t => t.TerritoryID == territoryId);
                dbContext.Territories.Remove(territory);
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

        private string GetEmployeeIdFromGrid()
        {
            return (string)gridTerritory.SelectedRows[0].Cells["colTerritoryID"].Value;
        }

        private void gridTerritory_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var territoryId = GetEmployeeIdFromGrid();

            var territoryEditForm = new TerritoryEditForm(territoryId);
            territoryEditForm.MdiParent = MdiParent;
            territoryEditForm.Show();
        }
    }
}
