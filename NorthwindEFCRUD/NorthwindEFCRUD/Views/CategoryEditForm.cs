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
    public partial class CategoryEditForm : Form
    {
        private int _categoryId;

        public CategoryEditForm()
        {
            InitializeComponent();
        }

        public CategoryEditForm(int categoryId) : this()
        {
            _categoryId = categoryId;
        }

        private void CategoryEditForm_Load(object sender, EventArgs e)
        {
            if (_categoryId != 0)
            {
                FillFormByCategory();
            }
        }

        private void FillFormByCategory()
        {
            Category category;

            using (var dbContext = DbHelper.CreateDbContext())
            {
                category = dbContext
                    .Categories
                    .AsNoTracking()
                    .SingleOrDefault(c => c.CategoryID == _categoryId);
            }

            if (category != null)
            {
                txtCategoryName.Text = category.CategoryName;
                rtxtDescription.Text = category.Description;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var category = CreateCategoryByForm();

            if (_categoryId == 0)
            {
                using (var dbContext = DbHelper.CreateDbContext())
                {
                    dbContext.Categories.Add(category);
                    dbContext.SaveChanges();
                }
            }
            else
            {
                category.CategoryID = _categoryId;

                using (var dbContext = DbHelper.CreateDbContext())
                {
                    dbContext.Entry(category).State = System.Data.Entity.EntityState.Modified;
                    dbContext.SaveChanges();
                }
            }
            Dispose();
        }

        private Category CreateCategoryByForm()
        {
            return new Category
            {
                CategoryName = txtCategoryName.Text.Trim(),
                Description = rtxtDescription.Text
            };
        }
    }
}
