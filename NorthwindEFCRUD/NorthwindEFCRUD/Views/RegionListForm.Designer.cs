namespace NorthwindEFCRUD.Views
{
    partial class RegionListForm
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
            this.gridRegion = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ctxBtnRefresh = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxBtnDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.colRegionId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRegionDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridRegion)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridRegion
            // 
            this.gridRegion.AllowUserToAddRows = false;
            this.gridRegion.AllowUserToDeleteRows = false;
            this.gridRegion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridRegion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridRegion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colRegionId,
            this.colRegionDescription});
            this.gridRegion.ContextMenuStrip = this.contextMenuStrip1;
            this.gridRegion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridRegion.Location = new System.Drawing.Point(0, 0);
            this.gridRegion.MultiSelect = false;
            this.gridRegion.Name = "gridRegion";
            this.gridRegion.ReadOnly = true;
            this.gridRegion.Size = new System.Drawing.Size(800, 450);
            this.gridRegion.TabIndex = 1;
            this.gridRegion.CellContextMenuStripNeeded += new System.Windows.Forms.DataGridViewCellContextMenuStripNeededEventHandler(this.gridRegion_CellContextMenuStripNeeded);
            this.gridRegion.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gridRegion_RowHeaderMouseDoubleClick);
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
            this.ctxBtnRefresh.Click += new System.EventHandler(this.ctxBtnRefresh_Click);
            // 
            // ctxBtnDelete
            // 
            this.ctxBtnDelete.Name = "ctxBtnDelete";
            this.ctxBtnDelete.Size = new System.Drawing.Size(180, 22);
            this.ctxBtnDelete.Text = "Delete";
            this.ctxBtnDelete.Click += new System.EventHandler(this.ctxBtnDelete_Click);
            // 
            // colRegionId
            // 
            this.colRegionId.DataPropertyName = "RegionID";
            this.colRegionId.HeaderText = "Id";
            this.colRegionId.Name = "colRegionId";
            this.colRegionId.ReadOnly = true;
            // 
            // colRegionDescription
            // 
            this.colRegionDescription.DataPropertyName = "RegionDescription";
            this.colRegionDescription.HeaderText = "Bölge Açıklaması";
            this.colRegionDescription.Name = "colRegionDescription";
            this.colRegionDescription.ReadOnly = true;
            // 
            // RegionListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gridRegion);
            this.Name = "RegionListForm";
            this.Text = "RegionListForm";
            this.Load += new System.EventHandler(this.RegionListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridRegion)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridRegion;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ctxBtnRefresh;
        private System.Windows.Forms.ToolStripMenuItem ctxBtnDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRegionId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRegionDescription;
    }
}