namespace NorthwindEFCRUD.Views
{
    partial class OrderListForm
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
            this.components = new System.ComponentModel.Container();
            this.gridOrder = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ctxBtnDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxBtnOrderDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxBtnRefresh = new System.Windows.Forms.ToolStripMenuItem();
            this.colOrderID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCustomerId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmployeeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Customer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Employee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOrderDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRequireDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colShippedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colShipVia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFreight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colShipName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colShipAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colShipCity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colShipRegion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colShipPostalCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colShipCountry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridOrder)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridOrder
            // 
            this.gridOrder.AllowUserToAddRows = false;
            this.gridOrder.AllowUserToDeleteRows = false;
            this.gridOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colOrderID,
            this.colCustomerId,
            this.colEmployeeId,
            this.Customer,
            this.Employee,
            this.colOrderDate,
            this.colRequireDate,
            this.colShippedDate,
            this.colShipVia,
            this.colFreight,
            this.colShipName,
            this.colShipAddress,
            this.colShipCity,
            this.colShipRegion,
            this.colShipPostalCode,
            this.colShipCountry});
            this.gridOrder.ContextMenuStrip = this.contextMenuStrip1;
            this.gridOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridOrder.Location = new System.Drawing.Point(0, 0);
            this.gridOrder.MultiSelect = false;
            this.gridOrder.Name = "gridOrder";
            this.gridOrder.ReadOnly = true;
            this.gridOrder.Size = new System.Drawing.Size(800, 450);
            this.gridOrder.TabIndex = 1;
            this.gridOrder.CellContextMenuStripNeeded += new System.Windows.Forms.DataGridViewCellContextMenuStripNeededEventHandler(this.gridOrder_CellContextMenuStripNeeded);
            this.gridOrder.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gridOrder_RowHeaderMouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctxBtnRefresh,
            this.ctxBtnDelete,
            this.ctxBtnOrderDetails});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(143, 70);
            // 
            // ctxBtnDelete
            // 
            this.ctxBtnDelete.Name = "ctxBtnDelete";
            this.ctxBtnDelete.Size = new System.Drawing.Size(180, 22);
            this.ctxBtnDelete.Text = "Delete";
            this.ctxBtnDelete.Click += new System.EventHandler(this.ctxBtnDelete_Click);
            // 
            // ctxBtnOrderDetails
            // 
            this.ctxBtnOrderDetails.Name = "ctxBtnOrderDetails";
            this.ctxBtnOrderDetails.Size = new System.Drawing.Size(180, 22);
            this.ctxBtnOrderDetails.Text = "Order Details";
            this.ctxBtnOrderDetails.Click += new System.EventHandler(this.ctxBtnOrderDetails_Click);
            // 
            // ctxBtnRefresh
            // 
            this.ctxBtnRefresh.Name = "ctxBtnRefresh";
            this.ctxBtnRefresh.Size = new System.Drawing.Size(180, 22);
            this.ctxBtnRefresh.Text = "Refresh";
            this.ctxBtnRefresh.Click += new System.EventHandler(this.ctxBtnRefresh_Click);
            // 
            // colOrderID
            // 
            this.colOrderID.DataPropertyName = "OrderID";
            this.colOrderID.HeaderText = "Order Id";
            this.colOrderID.Name = "colOrderID";
            this.colOrderID.ReadOnly = true;
            // 
            // colCustomerId
            // 
            this.colCustomerId.DataPropertyName = "CustomerID";
            this.colCustomerId.HeaderText = "Customer Id";
            this.colCustomerId.Name = "colCustomerId";
            this.colCustomerId.ReadOnly = true;
            this.colCustomerId.Visible = false;
            // 
            // colEmployeeId
            // 
            this.colEmployeeId.DataPropertyName = "EmployeeID";
            this.colEmployeeId.HeaderText = "Employee Id";
            this.colEmployeeId.Name = "colEmployeeId";
            this.colEmployeeId.ReadOnly = true;
            this.colEmployeeId.Visible = false;
            // 
            // Customer
            // 
            this.Customer.DataPropertyName = "Customer";
            this.Customer.HeaderText = "Customer";
            this.Customer.Name = "Customer";
            this.Customer.ReadOnly = true;
            // 
            // Employee
            // 
            this.Employee.DataPropertyName = "Employee";
            this.Employee.HeaderText = "Employee";
            this.Employee.Name = "Employee";
            this.Employee.ReadOnly = true;
            // 
            // colOrderDate
            // 
            this.colOrderDate.DataPropertyName = "OrderDate";
            this.colOrderDate.HeaderText = "Order Date";
            this.colOrderDate.Name = "colOrderDate";
            this.colOrderDate.ReadOnly = true;
            // 
            // colRequireDate
            // 
            this.colRequireDate.DataPropertyName = "RequiredDate";
            this.colRequireDate.HeaderText = "Required Date";
            this.colRequireDate.Name = "colRequireDate";
            this.colRequireDate.ReadOnly = true;
            // 
            // colShippedDate
            // 
            this.colShippedDate.DataPropertyName = "ShippedDate";
            this.colShippedDate.HeaderText = "Shipped Date";
            this.colShippedDate.Name = "colShippedDate";
            this.colShippedDate.ReadOnly = true;
            // 
            // colShipVia
            // 
            this.colShipVia.DataPropertyName = "ShipVia";
            this.colShipVia.HeaderText = "Ship Via";
            this.colShipVia.Name = "colShipVia";
            this.colShipVia.ReadOnly = true;
            // 
            // colFreight
            // 
            this.colFreight.DataPropertyName = "Freight";
            this.colFreight.HeaderText = "Freight";
            this.colFreight.Name = "colFreight";
            this.colFreight.ReadOnly = true;
            // 
            // colShipName
            // 
            this.colShipName.DataPropertyName = "ShipName";
            this.colShipName.HeaderText = "Ship Name";
            this.colShipName.Name = "colShipName";
            this.colShipName.ReadOnly = true;
            // 
            // colShipAddress
            // 
            this.colShipAddress.DataPropertyName = "ShipAddress";
            this.colShipAddress.HeaderText = "Address";
            this.colShipAddress.Name = "colShipAddress";
            this.colShipAddress.ReadOnly = true;
            // 
            // colShipCity
            // 
            this.colShipCity.DataPropertyName = "ShipCity";
            this.colShipCity.HeaderText = "City";
            this.colShipCity.Name = "colShipCity";
            this.colShipCity.ReadOnly = true;
            // 
            // colShipRegion
            // 
            this.colShipRegion.DataPropertyName = "ShipRegion";
            this.colShipRegion.HeaderText = "Ship Region";
            this.colShipRegion.Name = "colShipRegion";
            this.colShipRegion.ReadOnly = true;
            // 
            // colShipPostalCode
            // 
            this.colShipPostalCode.DataPropertyName = "ShipPostalCode";
            this.colShipPostalCode.HeaderText = "Postal Code";
            this.colShipPostalCode.Name = "colShipPostalCode";
            this.colShipPostalCode.ReadOnly = true;
            // 
            // colShipCountry
            // 
            this.colShipCountry.DataPropertyName = "ShipCountry";
            this.colShipCountry.HeaderText = "Country";
            this.colShipCountry.Name = "colShipCountry";
            this.colShipCountry.ReadOnly = true;
            // 
            // OrderListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gridOrder);
            this.Name = "OrderListForm";
            this.Text = "OrderListForm";
            this.Load += new System.EventHandler(this.OrderListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridOrder)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridOrder;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ctxBtnDelete;
        private System.Windows.Forms.ToolStripMenuItem ctxBtnOrderDetails;
        private System.Windows.Forms.ToolStripMenuItem ctxBtnRefresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOrderID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCustomerId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmployeeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Customer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Employee;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOrderDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRequireDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colShippedDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colShipVia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFreight;
        private System.Windows.Forms.DataGridViewTextBoxColumn colShipName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colShipAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn colShipCity;
        private System.Windows.Forms.DataGridViewTextBoxColumn colShipRegion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colShipPostalCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colShipCountry;
    }
}