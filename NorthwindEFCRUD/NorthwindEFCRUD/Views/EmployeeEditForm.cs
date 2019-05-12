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
    public partial class EmployeeEditForm : Form
    {
        private int _employeeId;

        public EmployeeEditForm()
        {
            InitializeComponent();
        }

        public EmployeeEditForm(int employeeId) : this()
        {
            _employeeId = employeeId;
        }
        private void EmployeeEditForm_Load(object sender, EventArgs e)
        {
            FillReportsToComboBox();

            if (_employeeId != 0)
            {
                FillFormByEmployee();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var employee = CreateEmployeeByForm();
            var dbContext = DbHelper.CreateDbContext();

            if (_employeeId == 0)
            {
                try
                {
                    dbContext.Employees.Add(employee);
                    dbContext.SaveChanges();
                    Dispose();
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
                employee.EmployeeID = _employeeId;

                try
                {
                    if (employee.EmployeeID != employee.ReportsTo)
                    {
                        dbContext.Entry(employee).State = System.Data.Entity.EntityState.Modified;
                        dbContext.SaveChanges();
                        Dispose();
                    }
                    else
                    {
                        MessageBox.Show("You cannot report to yourself.");
                    }
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
        }

        private Employee CreateEmployeeByForm()
        {
            return new Employee
            {
                LastName = txtLastName.Text.Trim(),
                FirstName = txtFirstNane.Text.Trim(),
                Title = txtTitle.Text.Trim(),
                TitleOfCourtesy = txtTitleOfCourtesy.Text.Trim(),
                BirthDate = DateTime.TryParse(maskedTxtBirthDate.Text, out DateTime date)
                            ? date
                            : (DateTime?)null,
                HireDate = DateTime.TryParse(maskedTxtHireDate.Text, out DateTime date1)
                            ? date
                            : (DateTime?)null,
                Address = rtxtAddress.Text.Trim(),
                City = txtCity.Text.Trim(),
                Country = txtCountry.Text.Trim(),
                Region = txtRegion.Text.Trim(),
                PostalCode = txtPostalCode.Text.Trim(),
                HomePhone = txtHomePhone.Text.Trim(),
                Notes = txtNotes.Text.Trim(),
                Extension = txtExtension.Text.Trim(),
                ReportsTo = ((Employee)cmbReportsTo.SelectedItem).EmployeeID
            };
        }

        private void FillFormByEmployee()
        {
            var employee = DbHelper.CreateDbContext()
                            .Employees
                            .AsNoTracking()
                            .FirstOrDefault(em => em.EmployeeID == _employeeId);

            txtFirstNane.Text = employee.FirstName;
            txtLastName.Text = employee.LastName;
            txtHomePhone.Text = employee.HomePhone;
            txtTitle.Text = employee.Title;
            txtTitleOfCourtesy.Text = employee.TitleOfCourtesy;
            maskedTxtBirthDate.Text = employee.BirthDate.ToString();
            maskedTxtHireDate.Text = employee.HireDate.ToString();
            rtxtAddress.Text = employee.Address;
            txtCity.Text = employee.City;
            txtRegion.Text = employee.Region;
            txtPostalCode.Text = employee.PostalCode;
            txtCountry.Text = employee.Country;
            txtExtension.Text = employee.Extension;
            txtNotes.Text = employee.Notes;
            cmbReportsTo.SelectedValue = employee.ReportsTo;
        }

        private void FillReportsToComboBox()
        {
            using (var dbContext = DbHelper.CreateDbContext())
            {
                var employee = dbContext.Employees.AsNoTracking().ToList();
                cmbReportsTo.DataSource = employee;
                cmbReportsTo.DisplayMember = "FullName";
                cmbReportsTo.ValueMember = "EmployeeID";
            }
        }
    }
}
