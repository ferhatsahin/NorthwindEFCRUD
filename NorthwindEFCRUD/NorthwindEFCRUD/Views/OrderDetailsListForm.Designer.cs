namespace NorthwindEFCRUD.Views
{
    partial class OrderDetailsListForm
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
            this.gridOrderDetails = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ctxBtnRefresh = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxBtnDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.colOrderID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProductId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiscount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridOrderDetails)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridOrderDetails
            // 
            this.gridOrderDetails.AllowUserToAddRows = false;
            this.gridOrderDetails.AllowUserToDeleteRows = false;
            this.gridOrderDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridOrderDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridOrderDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colOrderID,
            this.colProductId,
            this.colOrder,
            this.colProduct,
            this.colUnitPrice,
            this.colQuantity,
            this.colDiscount});
            this.gridOrderDetails.ContextMenuStrip = this.contextMenuStrip1;
            this.gridOrderDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridOrderDetails.Location = new System.Drawing.Point(0, 0);
            this.gridOrderDetails.MultiSelect = false;
            this.gridOrderDetails.Name = "gridOrderDetails";
            this.gridOrderDetails.ReadOnly = true;
            this.gridOrderDetails.Size = new System.Drawing.Size(800, 450);
            this.gridOrderDetails.TabIndex = 1;
            this.gridOrderDetails.CellContextMenuStripNeeded += new System.Windows.Forms.DataGridViewCellContextMenuStripNeededEventHandler(this.gridOrderDetails_CellContextMenuStripNeeded);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctxBtnRefresh,
            this.ctxBtnDelete});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(114, 48);
            // 
            // ctxBtnRefresh
            // 
            this.ctxBtnRefresh.Name = "ctxBtnRefresh";
            this.ctxBtnRefresh.Size = new System.Drawing.Size(180, 22);
            this.ctxBtnRefresh.Text = "Refresh";
            // 
            // ctxBtnDelete
            // 
            this.ctxBtnDelete.Name = "ctxBtnDelete";
            this.ctxBtnDelete.Size = new System.Drawing.Size(180, 22);
            this.ctxBtnDelete.Text = "Delete";
            this.ctxBtnDelete.Click += new System.EventHandler(this.ctxBtnDelete_Click);
            // 
            // colOrderID
            // 
            this.colOrderID.DataPropertyName = "OrderID";
            this.colOrderID.HeaderText = "Order Id";
            this.colOrderID.Name = "colOrderID";
            this.colOrderID.ReadOnly = true;
            this.colOrderID.Visible = false;
            // 
            // colProductId
            // 
            this.colProductId.DataPropertyName = "ProductID";
            this.colProductId.HeaderText = "Product Id";
            this.colProductId.Name = "colProductId";
            this.colProductId.ReadOnly = true;
            this.colProductId.Visible = false;
            // 
            // colOrder
            // 
            this.colOrder.DataPropertyName = "Order";
            this.colOrder.HeaderText = "Order";
            this.colOrder.Name = "colOrder";
            this.colOrder.ReadOnly = true;
            // 
            // colProduct
            // 
            this.colProduct.DataPropertyName = "Product";
            this.colProduct.HeaderText = "Product";
            this.colProduct.Name = "colProduct";
            this.colProduct.ReadOnly = true;
            // 
            // colUnitPrice
            // 
            this.colUnitPrice.DataPropertyName = "UnitPrice";
            this.colUnitPrice.HeaderText = "Unit Price";
            this.colUnitPrice.Name = "colUnitPrice";
            this.colUnitPrice.ReadOnly = true;
            // 
            // colQuantity
            // 
            this.colQuantity.DataPropertyName = "Quantity";
            this.colQuantity.HeaderText = "Quantity";
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.ReadOnly = true;
            // 
            // colDiscount
            // 
            this.colDiscount.DataPropertyName = "Discount";
            this.colDiscount.HeaderText = "Discount";
            this.colDiscount.Name = "colDiscount";
            this.colDiscount.ReadOnly = true;
            // 
            // OrderDetailsListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gridOrderDetails);
            this.Name = "OrderDetailsListForm";
            this.Text = "OrderDetailsListForm";
            this.Load += new System.EventHandler(this.OrderDetailsListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridOrderDetails)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridOrderDetails;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ctxBtnRefresh;
        private System.Windows.Forms.ToolStripMenuItem ctxBtnDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOrderID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProductId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiscount;
    }
}