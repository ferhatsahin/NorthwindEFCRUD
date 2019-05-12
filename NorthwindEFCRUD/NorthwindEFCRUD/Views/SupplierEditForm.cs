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
    public partial class SupplierEditForm : Form
    {
        private int _supplierId;

        public SupplierEditForm()
        {
            InitializeComponent();
        }

        public SupplierEditForm(int supplierId) : this()
        {
            _supplierId = supplierId;
        }


        private void SupplierEditForm_Load(object sender, EventArgs e)
        {
            if (_supplierId != 0)
            {
                FillFormBySupplier();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var supplier = CreateSupplierByForm();

            if (_supplierId == 0)
            {
                using (var dbContext = DbHelper.CreateDbContext())
                {
                    dbContext.Suppliers.Add(supplier);
                    dbContext.SaveChanges();
                }
            }
            else
            {
                supplier.SupplierID = _supplierId;

                using (var dbContext = DbHelper.CreateDbContext())
                {
                    dbContext.Entry(supplier).State = System.Data.Entity.EntityState.Modified;
                    dbContext.SaveChanges();
                }
            }
            Dispose();
        }

        private void FillFormBySupplier()
        {
            Supplier supplier;
            using (var dbContext = DbHelper.CreateDbContext())
            {
                supplier = dbContext
                    .Suppliers
                    .AsNoTracking()
                    .FirstOrDefault(s => s.SupplierID == _supplierId);
            }
            txtAddress.Text = supplier.Address;
            txtPhoneNumber.Text = supplier.Phone;
            txtRegion.Text = supplier.Region;
            txtCity.Text = supplier.City;
            txtCountry.Text = supplier.Country;
            txtCompanyName.Text = supplier.CompanyName;
            txtContactName.Text = supplier.ContactName;
            txtContactTitle.Text = supplier.ContactTitle;
            txtHomePage.Text = supplier.HomePage;
            txtPostalCode.Text = supplier.PostalCode;
            txtFaxNumber.Text = supplier.Fax;
        }

        private Supplier CreateSupplierByForm()
        {
            return new Supplier
            {
                CompanyName = txtCompanyName.Text.Trim(),
                ContactName = txtContactName.Text.Trim(),
                Address = txtAddress.Text.Trim(),
                HomePage = txtHomePage.Text.Trim(),
                Phone = txtPhoneNumber.Text.Trim(),
                ContactTitle = txtContactTitle.Text.Trim(),
                City = txtCity.Text.Trim(),
                Country = txtCountry.Text.Trim(),
                Region = txtRegion.Text.Trim(),
                PostalCode = txtPostalCode.Text.Trim(),
                Fax = txtFaxNumber.Text.Trim()
            };
        }
    }
}
