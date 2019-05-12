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
    public partial class TerritoryEditForm : Form
    {
        private string _territoryId = string.Empty;

        public TerritoryEditForm()
        {
            InitializeComponent();
        }

        public TerritoryEditForm(string territoryId) : this()
        {
            _territoryId = territoryId;
        }

        private void TerritoryEditForm_Load(object sender, EventArgs e)
        {
            if (_territoryId != string.Empty)
            {
                FillFormByTerritory();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var territory = CreateEmployeeByForm();
            var dbContext = DbHelper.CreateDbContext();

            if (_territoryId == string.Empty)
            {
                try
                {
                    dbContext.Territories.Add(territory);
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
            }
            else
            {
                territory.TerritoryID = _territoryId;

                try
                {
                    dbContext.Entry(territory).State = System.Data.Entity.EntityState.Modified;
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
            }
            Dispose();
        }

        private Territory CreateEmployeeByForm()
        {
            return new Territory
            {
                TerritoryID = maskedTerritoryId.Text.Trim(),
                TerritoryDescription = txtterritoryDescription.Text.Trim(),
                RegionID = (int)numRegionId.Value
            };
        }

        private void FillFormByTerritory()
        {
            var territory = DbHelper.CreateDbContext()
                            .Territories
                            .AsNoTracking()
                            .Include("Region")
                            .FirstOrDefault(t => t.TerritoryID == _territoryId);

            maskedTerritoryId.Text = territory.TerritoryID;
            txtterritoryDescription.Text = territory.TerritoryDescription;
            numRegionId.Value = territory.Region.RegionID;
        }
    }
}
