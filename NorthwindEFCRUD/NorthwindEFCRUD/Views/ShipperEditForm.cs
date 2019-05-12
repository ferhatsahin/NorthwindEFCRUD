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
    public partial class ShipperEditForm : Form
    {
        private int _shipperId;

        public ShipperEditForm()
        {
            InitializeComponent();
        }

        public ShipperEditForm(int shipperId) : this()
        {
            _shipperId = shipperId;
        }

        private void ShipperEditForm_Load(object sender, EventArgs e)
        {
            if (_shipperId != 0)
            {
                FillFormByShipper();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var shipper = CreateEmployeeByForm();
            var dbContext = DbHelper.CreateDbContext();

            if (_shipperId == 0)
            {
                try
                {
                    dbContext.Shippers.Add(shipper);
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
                shipper.ShipperID = _shipperId;

                try
                {
                    dbContext.Entry(shipper).State = System.Data.Entity.EntityState.Modified;
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

        private Shipper CreateEmployeeByForm()
        {
            return new Shipper
            {
                CompanyName = txtCompanyName.Text.Trim(),
                Phone = maskedPhone.Text.Trim()
            };
        }

        private void FillFormByShipper()
        {
            var shipper = DbHelper.CreateDbContext()
                            .Shippers
                            .AsNoTracking()
                            .FirstOrDefault(s => s.ShipperID == _shipperId);

            txtCompanyName.Text = shipper.CompanyName;
            maskedPhone.Text = shipper.Phone;
        }
    }
}
