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
    public partial class CustomerEditForm : Form
    {
        private string _customerId = string.Empty;

        public CustomerEditForm()
        {
            InitializeComponent();
        }

        public CustomerEditForm(string customerId) : this()
        {
            _customerId = customerId;
        }

        private void CustomerEditForm_Load(object sender, EventArgs e)
        {
            if (_customerId != string.Empty)
            {
                FillFormByCustomer();
            }
        }

        private void FillFormByCustomer()
        {
            var customer = DbHelper.CreateDbContext()
                            .Customers
                            .AsNoTracking()
                            .FirstOrDefault(c => c.CustomerID == _customerId);

            txtCompanyName.Text = customer.CompanyName;
            txtContactName.Text = customer.ContactName;
            maskedPhone.Text = customer.Phone;
            txtContactTitle.Text = customer.ContactTitle;
            rTxtAddress.Text = customer.Address;
            txtCity.Text = customer.City;
            txtRegion.Text = customer.Region;
            txtPostalCode.Text = customer.PostalCode;
            txtCountry.Text = customer.Country;
            txtFaks.Text = customer.Fax;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var customer = CreateCustomerByForm();
            var dbContext = DbHelper.CreateDbContext();

            if (string.IsNullOrEmpty(_customerId))
            {
                try
                {
                    dbContext.Customers.Add(customer);
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
                customer.CustomerID = _customerId;

                try
                {
                    dbContext.Entry(customer).State = System.Data.Entity.EntityState.Modified;
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

        private Customer CreateCustomerByForm()
        {
            return new Customer
            {
                CustomerID = Producer.CreateCustomerID(txtCompanyName.Text.Trim()), //5
                ContactName = txtContactName.Text.Trim(),
                ContactTitle = txtContactTitle.Text.Trim(),
                CompanyName = txtCompanyName.Text.Trim() == string.Empty
                    ? null
                    : txtCompanyName.Text.Trim(),
                Fax = txtFaks.Text.Trim(),
                Address = rTxtAddress.Text.Trim(),
                City = txtCity.Text.Trim(),
                Country = txtCountry.Text.Trim(),
                Region = txtRegion.Text.Trim(),
                PostalCode = txtPostalCode.Text.Trim(),
                Phone = maskedPhone.Text.Trim(),
            };
        }
    }
}
