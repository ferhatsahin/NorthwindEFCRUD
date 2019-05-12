using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NorthwindEFCRUD.Views;
namespace NorthwindEFCRUD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void menuBtnProductList_Click(object sender, EventArgs e)
        {
            ShowNewMdiChild<ProductListForm>();
        }

        private void menuBtnNewProduct_Click(object sender, EventArgs e)
        {
            ShowNewMdiChild<ProductEditForm>();
        }

        private void ShowNewMdiChild<TForm>() where TForm : Form, new()
        {
            var childForm = new TForm();
            childForm.MdiParent = this;
            childForm.Show();
        }

        private void menuBtnNewSupplier_Click(object sender, EventArgs e)
        {
            ShowNewMdiChild<SupplierEditForm>();
        }

        private void menuBtnSupplierList_Click(object sender, EventArgs e)
        {
            ShowNewMdiChild<SupplierListForm>();
        }

        private void menuBtnNewCategory_Click(object sender, EventArgs e)
        {
            ShowNewMdiChild<CategoryEditForm>();
        }

        private void menuBtnCategoryList_Click(object sender, EventArgs e)
        {
            ShowNewMdiChild<CategoryListForm>();
        }

        private void menuBtnNewEmployee_Click(object sender, EventArgs e)
        {
            ShowNewMdiChild<EmployeeEditForm>();
        }

        private void menuBtnEmployeesList_Click(object sender, EventArgs e)
        {
            ShowNewMdiChild<EmployeeListForm>();
        }

        private void menuBtnNewRegion_Click(object sender, EventArgs e)
        {
            ShowNewMdiChild<RegionEditForm>();
        }

        private void menuBtnRegionList_Click(object sender, EventArgs e)
        {
            ShowNewMdiChild<RegionListForm>();
        }

        private void menuBtnNewOrder_Click(object sender, EventArgs e)
        {
            ShowNewMdiChild<OrderEditForm>();
        }

        private void menuBtnOrdersList_Click(object sender, EventArgs e)
        {
            ShowNewMdiChild<OrderListForm>();
        }

        private void menuBtnNewShipper_Click(object sender, EventArgs e)
        {
            ShowNewMdiChild<ShipperEditForm>();
        }

        private void menuBtnShippersList_Click(object sender, EventArgs e)
        {
            ShowNewMdiChild<ShipperListForm>();
        }

        private void menuBtnNewCustomer_Click(object sender, EventArgs e)
        {
            ShowNewMdiChild<CustomerEditForm>();
        }

        private void menuBtnCustomersList_Click(object sender, EventArgs e)
        {
            ShowNewMdiChild<CustomerListForm>();
        }

        private void menuBtnTerritoriesList_Click(object sender, EventArgs e)
        {
            ShowNewMdiChild<TerritoryListForm>();
        }

        private void menuBtnNewTerritorie_Click(object sender, EventArgs e)
        {
            ShowNewMdiChild<TerritoryEditForm>();
        }
    }
}
