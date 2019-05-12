namespace NorthwindEFCRUD
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ürünYönetimiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBtnProductList = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBtnNewProduct = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tedarikçilerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBtnNewSupplier = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBtnSupplierList = new System.Windows.Forms.ToolStripMenuItem();
            this.kategorilerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBtnNewCategory = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBtnCategoryList = new System.Windows.Forms.ToolStripMenuItem();
            this.firmaYönetimiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çalışanlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBtnNewEmployee = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBtnEmployeesList = new System.Windows.Forms.ToolStripMenuItem();
            this.bölgelerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBtnNewRegion = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBtnRegionList = new System.Windows.Forms.ToolStripMenuItem();
            this.sahalarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBtnNewTerritorie = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBtnTerritoriesList = new System.Windows.Forms.ToolStripMenuItem();
            this.satışYönetimiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.müşterilerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBtnNewCustomer = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBtnCustomersList = new System.Windows.Forms.ToolStripMenuItem();
            this.siparişlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBtnNewOrder = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBtnOrdersList = new System.Windows.Forms.ToolStripMenuItem();
            this.kargoFirmalarıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBtnNewShipper = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBtnShippersList = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ürünYönetimiToolStripMenuItem,
            this.firmaYönetimiToolStripMenuItem,
            this.satışYönetimiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ürünYönetimiToolStripMenuItem
            // 
            this.ürünYönetimiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuBtnProductList,
            this.menuBtnNewProduct,
            this.toolStripSeparator1,
            this.tedarikçilerToolStripMenuItem,
            this.kategorilerToolStripMenuItem});
            this.ürünYönetimiToolStripMenuItem.Name = "ürünYönetimiToolStripMenuItem";
            this.ürünYönetimiToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.ürünYönetimiToolStripMenuItem.Text = "Ürün Yönetimi";
            // 
            // menuBtnProductList
            // 
            this.menuBtnProductList.Name = "menuBtnProductList";
            this.menuBtnProductList.Size = new System.Drawing.Size(135, 22);
            this.menuBtnProductList.Text = "Ürün Listesi";
            this.menuBtnProductList.Click += new System.EventHandler(this.menuBtnProductList_Click);
            // 
            // menuBtnNewProduct
            // 
            this.menuBtnNewProduct.Name = "menuBtnNewProduct";
            this.menuBtnNewProduct.Size = new System.Drawing.Size(135, 22);
            this.menuBtnNewProduct.Text = "Yeni Ürün";
            this.menuBtnNewProduct.Click += new System.EventHandler(this.menuBtnNewProduct_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(132, 6);
            // 
            // tedarikçilerToolStripMenuItem
            // 
            this.tedarikçilerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuBtnNewSupplier,
            this.menuBtnSupplierList});
            this.tedarikçilerToolStripMenuItem.Name = "tedarikçilerToolStripMenuItem";
            this.tedarikçilerToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.tedarikçilerToolStripMenuItem.Text = "Tedarikçiler";
            // 
            // menuBtnNewSupplier
            // 
            this.menuBtnNewSupplier.Name = "menuBtnNewSupplier";
            this.menuBtnNewSupplier.Size = new System.Drawing.Size(157, 22);
            this.menuBtnNewSupplier.Text = "Yeni Tedarikçi";
            this.menuBtnNewSupplier.Click += new System.EventHandler(this.menuBtnNewSupplier_Click);
            // 
            // menuBtnSupplierList
            // 
            this.menuBtnSupplierList.Name = "menuBtnSupplierList";
            this.menuBtnSupplierList.Size = new System.Drawing.Size(157, 22);
            this.menuBtnSupplierList.Text = "Tedarikçi Listesi";
            this.menuBtnSupplierList.Click += new System.EventHandler(this.menuBtnSupplierList_Click);
            // 
            // kategorilerToolStripMenuItem
            // 
            this.kategorilerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuBtnNewCategory,
            this.menuBtnCategoryList});
            this.kategorilerToolStripMenuItem.Name = "kategorilerToolStripMenuItem";
            this.kategorilerToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.kategorilerToolStripMenuItem.Text = "Kategoriler";
            // 
            // menuBtnNewCategory
            // 
            this.menuBtnNewCategory.Name = "menuBtnNewCategory";
            this.menuBtnNewCategory.Size = new System.Drawing.Size(153, 22);
            this.menuBtnNewCategory.Text = "Yeni Kategori";
            this.menuBtnNewCategory.Click += new System.EventHandler(this.menuBtnNewCategory_Click);
            // 
            // menuBtnCategoryList
            // 
            this.menuBtnCategoryList.Name = "menuBtnCategoryList";
            this.menuBtnCategoryList.Size = new System.Drawing.Size(153, 22);
            this.menuBtnCategoryList.Text = "Kategori Listesi";
            this.menuBtnCategoryList.Click += new System.EventHandler(this.menuBtnCategoryList_Click);
            // 
            // firmaYönetimiToolStripMenuItem
            // 
            this.firmaYönetimiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.çalışanlarToolStripMenuItem,
            this.bölgelerToolStripMenuItem,
            this.sahalarToolStripMenuItem});
            this.firmaYönetimiToolStripMenuItem.Name = "firmaYönetimiToolStripMenuItem";
            this.firmaYönetimiToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.firmaYönetimiToolStripMenuItem.Text = "Firma Yönetimi";
            // 
            // çalışanlarToolStripMenuItem
            // 
            this.çalışanlarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuBtnNewEmployee,
            this.menuBtnEmployeesList});
            this.çalışanlarToolStripMenuItem.Name = "çalışanlarToolStripMenuItem";
            this.çalışanlarToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.çalışanlarToolStripMenuItem.Text = "Çalışanlar";
            // 
            // menuBtnNewEmployee
            // 
            this.menuBtnNewEmployee.Name = "menuBtnNewEmployee";
            this.menuBtnNewEmployee.Size = new System.Drawing.Size(160, 22);
            this.menuBtnNewEmployee.Text = "Yeni Çalışan";
            this.menuBtnNewEmployee.Click += new System.EventHandler(this.menuBtnNewEmployee_Click);
            // 
            // menuBtnEmployeesList
            // 
            this.menuBtnEmployeesList.Name = "menuBtnEmployeesList";
            this.menuBtnEmployeesList.Size = new System.Drawing.Size(160, 22);
            this.menuBtnEmployeesList.Text = "Çalışanlar Listesi";
            this.menuBtnEmployeesList.Click += new System.EventHandler(this.menuBtnEmployeesList_Click);
            // 
            // bölgelerToolStripMenuItem
            // 
            this.bölgelerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuBtnNewRegion,
            this.menuBtnRegionList});
            this.bölgelerToolStripMenuItem.Name = "bölgelerToolStripMenuItem";
            this.bölgelerToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.bölgelerToolStripMenuItem.Text = "Bölgeler";
            // 
            // menuBtnNewRegion
            // 
            this.menuBtnNewRegion.Name = "menuBtnNewRegion";
            this.menuBtnNewRegion.Size = new System.Drawing.Size(139, 22);
            this.menuBtnNewRegion.Text = "Yeni Bölge";
            this.menuBtnNewRegion.Click += new System.EventHandler(this.menuBtnNewRegion_Click);
            // 
            // menuBtnRegionList
            // 
            this.menuBtnRegionList.Name = "menuBtnRegionList";
            this.menuBtnRegionList.Size = new System.Drawing.Size(139, 22);
            this.menuBtnRegionList.Text = "Bölge Listesi";
            this.menuBtnRegionList.Click += new System.EventHandler(this.menuBtnRegionList_Click);
            // 
            // sahalarToolStripMenuItem
            // 
            this.sahalarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuBtnNewTerritorie,
            this.menuBtnTerritoriesList});
            this.sahalarToolStripMenuItem.Name = "sahalarToolStripMenuItem";
            this.sahalarToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.sahalarToolStripMenuItem.Text = "Sahalar";
            // 
            // menuBtnNewTerritorie
            // 
            this.menuBtnNewTerritorie.Name = "menuBtnNewTerritorie";
            this.menuBtnNewTerritorie.Size = new System.Drawing.Size(134, 22);
            this.menuBtnNewTerritorie.Text = "Yeni Saha";
            this.menuBtnNewTerritorie.Click += new System.EventHandler(this.menuBtnNewTerritorie_Click);
            // 
            // menuBtnTerritoriesList
            // 
            this.menuBtnTerritoriesList.Name = "menuBtnTerritoriesList";
            this.menuBtnTerritoriesList.Size = new System.Drawing.Size(134, 22);
            this.menuBtnTerritoriesList.Text = "Saha Listesi";
            this.menuBtnTerritoriesList.Click += new System.EventHandler(this.menuBtnTerritoriesList_Click);
            // 
            // satışYönetimiToolStripMenuItem
            // 
            this.satışYönetimiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.müşterilerToolStripMenuItem,
            this.siparişlerToolStripMenuItem,
            this.kargoFirmalarıToolStripMenuItem});
            this.satışYönetimiToolStripMenuItem.Name = "satışYönetimiToolStripMenuItem";
            this.satışYönetimiToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.satışYönetimiToolStripMenuItem.Text = "Satış Yönetimi";
            // 
            // müşterilerToolStripMenuItem
            // 
            this.müşterilerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuBtnNewCustomer,
            this.menuBtnCustomersList});
            this.müşterilerToolStripMenuItem.Name = "müşterilerToolStripMenuItem";
            this.müşterilerToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.müşterilerToolStripMenuItem.Text = "Müşteriler";
            // 
            // menuBtnNewCustomer
            // 
            this.menuBtnNewCustomer.Name = "menuBtnNewCustomer";
            this.menuBtnNewCustomer.Size = new System.Drawing.Size(149, 22);
            this.menuBtnNewCustomer.Text = "Yeni Müşteri";
            this.menuBtnNewCustomer.Click += new System.EventHandler(this.menuBtnNewCustomer_Click);
            // 
            // menuBtnCustomersList
            // 
            this.menuBtnCustomersList.Name = "menuBtnCustomersList";
            this.menuBtnCustomersList.Size = new System.Drawing.Size(149, 22);
            this.menuBtnCustomersList.Text = "Müşteri Listesi";
            this.menuBtnCustomersList.Click += new System.EventHandler(this.menuBtnCustomersList_Click);
            // 
            // siparişlerToolStripMenuItem
            // 
            this.siparişlerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuBtnNewOrder,
            this.menuBtnOrdersList});
            this.siparişlerToolStripMenuItem.Name = "siparişlerToolStripMenuItem";
            this.siparişlerToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.siparişlerToolStripMenuItem.Text = "Siparişler";
            // 
            // menuBtnNewOrder
            // 
            this.menuBtnNewOrder.Name = "menuBtnNewOrder";
            this.menuBtnNewOrder.Size = new System.Drawing.Size(143, 22);
            this.menuBtnNewOrder.Text = "Yeni Sipariş";
            this.menuBtnNewOrder.Click += new System.EventHandler(this.menuBtnNewOrder_Click);
            // 
            // menuBtnOrdersList
            // 
            this.menuBtnOrdersList.Name = "menuBtnOrdersList";
            this.menuBtnOrdersList.Size = new System.Drawing.Size(143, 22);
            this.menuBtnOrdersList.Text = "Sipariş Listesi";
            this.menuBtnOrdersList.Click += new System.EventHandler(this.menuBtnOrdersList_Click);
            // 
            // kargoFirmalarıToolStripMenuItem
            // 
            this.kargoFirmalarıToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuBtnNewShipper,
            this.menuBtnShippersList});
            this.kargoFirmalarıToolStripMenuItem.Name = "kargoFirmalarıToolStripMenuItem";
            this.kargoFirmalarıToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.kargoFirmalarıToolStripMenuItem.Text = "Kargo Firmaları";
            // 
            // menuBtnNewShipper
            // 
            this.menuBtnNewShipper.Name = "menuBtnNewShipper";
            this.menuBtnNewShipper.Size = new System.Drawing.Size(189, 22);
            this.menuBtnNewShipper.Text = "Yeni Kargo Firması";
            this.menuBtnNewShipper.Click += new System.EventHandler(this.menuBtnNewShipper_Click);
            // 
            // menuBtnShippersList
            // 
            this.menuBtnShippersList.Name = "menuBtnShippersList";
            this.menuBtnShippersList.Size = new System.Drawing.Size(189, 22);
            this.menuBtnShippersList.Text = "Kargo Firmaları Listesi";
            this.menuBtnShippersList.Click += new System.EventHandler(this.menuBtnShippersList_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ürünYönetimiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuBtnProductList;
        private System.Windows.Forms.ToolStripMenuItem menuBtnNewProduct;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tedarikçilerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuBtnNewSupplier;
        private System.Windows.Forms.ToolStripMenuItem menuBtnSupplierList;
        private System.Windows.Forms.ToolStripMenuItem kategorilerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuBtnNewCategory;
        private System.Windows.Forms.ToolStripMenuItem menuBtnCategoryList;
        private System.Windows.Forms.ToolStripMenuItem firmaYönetimiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çalışanlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuBtnNewEmployee;
        private System.Windows.Forms.ToolStripMenuItem menuBtnEmployeesList;
        private System.Windows.Forms.ToolStripMenuItem bölgelerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuBtnNewRegion;
        private System.Windows.Forms.ToolStripMenuItem menuBtnRegionList;
        private System.Windows.Forms.ToolStripMenuItem sahalarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuBtnNewTerritorie;
        private System.Windows.Forms.ToolStripMenuItem menuBtnTerritoriesList;
        private System.Windows.Forms.ToolStripMenuItem satışYönetimiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem müşterilerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuBtnNewCustomer;
        private System.Windows.Forms.ToolStripMenuItem menuBtnCustomersList;
        private System.Windows.Forms.ToolStripMenuItem siparişlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuBtnNewOrder;
        private System.Windows.Forms.ToolStripMenuItem menuBtnOrdersList;
        private System.Windows.Forms.ToolStripMenuItem kargoFirmalarıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuBtnNewShipper;
        private System.Windows.Forms.ToolStripMenuItem menuBtnShippersList;
    }
}

