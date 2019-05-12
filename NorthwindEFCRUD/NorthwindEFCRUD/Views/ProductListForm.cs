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
    public partial class ProductListForm : Form
    {
        public ProductListForm()
        {
            InitializeComponent();
        }

        private void ProductListForm_Load(object sender, EventArgs e)
        {
            gridProducts.AutoGenerateColumns = false;
            RefreshGrid();
        }

        private void ctxButtonDelete_Click(object sender, EventArgs e)
        {
            var productId = (int)gridProducts.SelectedRows[0].Cells["colProductId"].Value;
            using (var dbContext = DbHelper.CreateDbContext())
            {
                var product = dbContext.Products.Where(p => p.ProductID == productId).FirstOrDefault();
                if (product != null)
                {
                    dbContext.Products.Remove(product);
                    dbContext.SaveChanges();
                }
                else
                {
                    MessageBox.Show("Silme işlemi sorasında bir hata oluştu..");
                }
            }
            RefreshGrid();
        }

        private void RefreshGrid()
        {
            using (var dbContext = DbHelper.CreateDbContext())
            {
                gridProducts.DataSource = dbContext
                    .Products
                    .AsNoTracking()
                    // Eagerly Loading
                    .Include("Supplier")
                    .Include("Category")
                    .ToList();
            }
        }

        private void gridProducts_RowContextMenuStripNeeded(object sender, DataGridViewRowContextMenuStripNeededEventArgs e)
        {
            gridProducts.Rows[e.RowIndex].Selected = true;
        }

        private void gridProducts_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int productId = GetProductIdFromGrid();

            var productEditForm = new ProductEditForm(productId);
            productEditForm.FormSaved += RefreshGrid;
            productEditForm.MdiParent = MdiParent;
            productEditForm.Show();
        }

        private int GetProductIdFromGrid()
        {
            return (int)gridProducts.SelectedRows[0].Cells["colProductId"].Value;
        }
    }
}
