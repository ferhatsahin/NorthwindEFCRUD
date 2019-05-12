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
    public partial class CategoryListForm : Form
    {
        public CategoryListForm()
        {
            InitializeComponent();
        }

        private void CategoryListForm_Load(object sender, EventArgs e)
        {
            gridCategory.AutoGenerateColumns = true;
            RefreshGrid();
        }

        private void RefreshGrid()
        {
            using (var dbContext = DbHelper.CreateDbContext())
            {
                gridCategory.DataSource = dbContext.Categories.AsNoTracking().ToList();
            }
        }

        private void ctxBtnRefresh_Click(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        private void ctxBtnDelete_Click(object sender, EventArgs e)
        {
            var categoryId = GetCategoryIdFromGrid();

            using (var dbContext = DbHelper.CreateDbContext())
            {
                var category = dbContext.Categories.FirstOrDefault(c => c.CategoryID == categoryId);

                if (category != null)
                {
                    dbContext.Categories.Remove(category);
                    dbContext.SaveChanges();
                }
            }
            RefreshGrid();
        }

        private void gridCategory_CellContextMenuStripNeeded(object sender, DataGridViewCellContextMenuStripNeededEventArgs e)
        {
            gridCategory.Rows[e.RowIndex].Selected = true;
        }

        private void gridCategory_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int categoryId = GetCategoryIdFromGrid();

            var categoryEditForm = new CategoryEditForm(categoryId);
            categoryEditForm.MdiParent = MdiParent;
            categoryEditForm.Show();
        }

        private int GetCategoryIdFromGrid()
        {
            return (int)gridCategory.Rows[0].Cells["colCategoryId"].Value;
        }
    }
}
