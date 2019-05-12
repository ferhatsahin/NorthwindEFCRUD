using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NorthwindEFCRUD.Views
{
    public partial class ProductEditForm : Form
    {
        private int _productId;
        public event DelegateAndEvent.FormSavedEventHandler FormSaved;

        public ProductEditForm()
        {
            InitializeComponent();
        }

        public ProductEditForm(int productId) : this()
        {
            _productId = productId;
        }

        private void ProductEditForm_Load(object sender, EventArgs e)
        {
            FillComboBoxes();

            if (_productId != 0)
            {
                FillFormByProduct();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var product = CreateProductByForm();

            if (_productId == 0)
            {
                using (var dbContext = DbHelper.CreateDbContext())
                {
                    dbContext.Products.Add(product);
                    dbContext.SaveChanges();
                }
            }
            else
            {
                product.ProductID = _productId;

                using (var dbContext = DbHelper.CreateDbContext())
                {
                    dbContext.Entry(product).State = EntityState.Modified;
                    dbContext.SaveChanges();
                }
            }
            Dispose();
            FormSaved?.Invoke();
        }

        private Product CreateProductByForm()
        {
            return new Product
            {
                ProductName = txtProductName.Text.Trim(),
                Discontinued = chkDiscontinued.Checked,
                QuantityPerUnit = txtQuantityPerUnit.Text.Trim(),
                UnitPrice = numUnitPrice.Value,
                UnitsInStock = (short?)numUnitsInStock.Value,
                UnitsOnOrder = (short?)numUnitsOnOrder.Value,
                SupplierID = (int?)cmbSupplier.SelectedValue,
                CategoryID = (int?)cmbCategory.SelectedValue,
                ReorderLevel = (short?)numReorderLevel.Value
            };
        }

        private void FillFormByProduct()
        {
            Product product;

            using (var dbContext = DbHelper.CreateDbContext())
            {
                product = dbContext.Products.AsNoTracking().Where(p => p.ProductID == _productId).SingleOrDefault();
            }
            if (product != null)
            {
                txtProductName.Text = product.ProductName;
                txtQuantityPerUnit.Text = product.QuantityPerUnit;
                numReorderLevel.Value = product.ReorderLevel.HasValue ? product.ReorderLevel.Value : 0;
                numUnitPrice.Value = product.UnitPrice.HasValue ? product.UnitPrice.Value : 0;
                numUnitsInStock.Value = product.UnitsInStock.HasValue ? product.UnitsInStock.Value : 0;
                numUnitsOnOrder.Value = product.UnitsOnOrder.HasValue ? product.UnitsOnOrder.Value : 0;
                cmbSupplier.SelectedValue = product.SupplierID.HasValue ? product.SupplierID : (object)DBNull.Value;
                cmbCategory.SelectedValue = product.CategoryID.HasValue ? product.CategoryID : (object)DBNull.Value;
                chkDiscontinued.Checked = product.Discontinued;
            }
        }

        private void FillComboBoxes()
        {
            using (var dbContext = DbHelper.CreateDbContext())
            {
                cmbSupplier.DataSource = dbContext.Suppliers
                    .AsNoTracking()
                    .ToList();
                cmbSupplier.DisplayMember = "CompanyName";
                cmbSupplier.ValueMember = "SupplierId";
                cmbCategory.DataSource = dbContext.Categories
                    .AsNoTracking()
                    .ToList();
                cmbCategory.DisplayMember = "CategoryName";
                cmbCategory.ValueMember = "CategoryId";
            }
        }
    }
}
