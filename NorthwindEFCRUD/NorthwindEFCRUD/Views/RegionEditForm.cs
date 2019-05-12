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
    public partial class RegionEditForm : Form
    {
        private int _regionId;

        public RegionEditForm()
        {
            InitializeComponent();
        }

        public RegionEditForm(int regionId) : this()
        {
            _regionId = regionId;
        }

        private void RegionEditForm_Load(object sender, EventArgs e)
        {
            if (_regionId != 0)
            {
                FillFormByRegion();
            }
        }

        private void FillFormByRegion()
        {
            var region = DbHelper.CreateDbContext()
                .Regions.AsNoTracking()
                .FirstOrDefault(r => r.RegionID == _regionId);

            if (region != null)
            {
                rtxtRegionDescription.Text = region.RegionDescription;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var region = CreateRegionByForm();
            var dbContext = DbHelper.CreateDbContext();

            if (_regionId == 0)
            {
                try
                {
                    dbContext.Regions.Add(region);
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
                region.RegionID = _regionId;

                try
                {
                    dbContext.Entry(region).State = System.Data.Entity.EntityState.Modified;
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

        private Region CreateRegionByForm()
        {
            var region = new Region();
            region.RegionDescription = rtxtRegionDescription.Text.Trim();
            region.RegionID = region.GetLastRegionID();

            return region;
        }
    }
}
