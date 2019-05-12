namespace NorthwindEFCRUD.Views
{
    partial class EmployeeListForm
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
            this.gridEmployee = new System.Windows.Forms.DataGridView();
            this.colEmployeeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTitleOfCourtesy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBirthDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHireDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRegion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPostalCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCountry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHomaPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colExtension = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colReportsTo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNotes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ctxBtnRefresh = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxBtnDelete = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.gridEmployee)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridEmployee
            // 
            this.gridEmployee.AllowUserToAddRows = false;
            this.gridEmployee.AllowUserToDeleteRows = false;
            this.gridEmployee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridEmployee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colEmployeeId,
            this.colFirstName,
            this.colLastName,
            this.colTitle,
            this.colTitleOfCourtesy,
            this.colBirthDate,
            this.colHireDate,
            this.colAddress,
            this.colCity,
            this.colRegion,
            this.colPostalCode,
            this.colCountry,
            this.colHomaPhone,
            this.colExtension,
            this.colReportsTo,
            this.colNotes});
            this.gridEmployee.ContextMenuStrip = this.contextMenuStrip1;
            this.gridEmployee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridEmployee.Location = new System.Drawing.Point(0, 0);
            this.gridEmployee.MultiSelect = false;
            this.gridEmployee.Name = "gridEmployee";
            this.gridEmployee.ReadOnly = true;
            this.gridEmployee.Size = new System.Drawing.Size(800, 450);
            this.gridEmployee.TabIndex = 1;
            this.gridEmployee.CellContextMenuStripNeeded += new System.Windows.Forms.DataGridViewCellContextMenuStripNeededEventHandler(this.gridEmployee_CellContextMenuStripNeeded);
            this.gridEmployee.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gridEmployee_RowHeaderMouseDoubleClick);
            // 
            // colEmployeeId
            // 
            this.colEmployeeId.DataPropertyName = "EmployeeID";
            this.colEmployeeId.HeaderText = "Id";
            this.colEmployeeId.Name = "colEmployeeId";
            this.colEmployeeId.ReadOnly = true;
            // 
            // colFirstName
            // 
            this.colFirstName.DataPropertyName = "FirstName";
            this.colFirstName.HeaderText = "First Name";
            this.colFirstName.Name = "colFirstName";
            this.colFirstName.ReadOnly = true;
            // 
            // colLastName
            // 
            this.colLastName.DataPropertyName = "LastName";
            this.colLastName.HeaderText = "Last Name";
            this.colLastName.Name = "colLastName";
            this.colLastName.ReadOnly = true;
            // 
            // colTitle
            // 
            this.colTitle.DataPropertyName = "Title";
            this.colTitle.HeaderText = "Ünvan";
            this.colTitle.Name = "colTitle";
            this.colTitle.ReadOnly = true;
            // 
            // colTitleOfCourtesy
            // 
            this.colTitleOfCourtesy.DataPropertyName = "TitleOfCourtesy";
            this.colTitleOfCourtesy.HeaderText = "Ünvan Ön Eki";
            this.colTitleOfCourtesy.Name = "colTitleOfCourtesy";
            this.colTitleOfCourtesy.ReadOnly = true;
            // 
            // colBirthDate
            // 
            this.colBirthDate.DataPropertyName = "BirthDate";
            this.colBirthDate.HeaderText = "Doğum Tarihi";
            this.colBirthDate.Name = "colBirthDate";
            this.colBirthDate.ReadOnly = true;
            // 
            // colHireDate
            // 
            this.colHireDate.DataPropertyName = "HireDate";
            this.colHireDate.HeaderText = "Başlama Tarihi";
            this.colHireDate.Name = "colHireDate";
            this.colHireDate.ReadOnly = true;
            // 
            // colAddress
            // 
            this.colAddress.DataPropertyName = "Address";
            this.colAddress.HeaderText = "Adres";
            this.colAddress.Name = "colAddress";
            this.colAddress.ReadOnly = true;
            // 
            // colCity
            // 
            this.colCity.DataPropertyName = "City";
            this.colCity.HeaderText = "Şehir";
            this.colCity.Name = "colCity";
            this.colCity.ReadOnly = true;
            // 
            // colRegion
            // 
            this.colRegion.DataPropertyName = "Region";
            this.colRegion.HeaderText = "Bölge";
            this.colRegion.Name = "colRegion";
            this.colRegion.ReadOnly = true;
            // 
            // colPostalCode
            // 
            this.colPostalCode.DataPropertyName = "PostalCode";
            this.colPostalCode.HeaderText = "Posta Kodu";
            this.colPostalCode.Name = "colPostalCode";
            this.colPostalCode.ReadOnly = true;
            // 
            // colCountry
            // 
            this.colCountry.DataPropertyName = "Country";
            this.colCountry.HeaderText = "Ülke";
            this.colCountry.Name = "colCountry";
            this.colCountry.ReadOnly = true;
            // 
            // colHomaPhone
            // 
            this.colHomaPhone.DataPropertyName = "HomePhone";
            this.colHomaPhone.HeaderText = "Ev Telefonu";
            this.colHomaPhone.Name = "colHomaPhone";
            this.colHomaPhone.ReadOnly = true;
            // 
            // colExtension
            // 
            this.colExtension.DataPropertyName = "Extension";
            this.colExtension.HeaderText = "Uzantı";
            this.colExtension.Name = "colExtension";
            this.colExtension.ReadOnly = true;
            // 
            // colReportsTo
            // 
            this.colReportsTo.DataPropertyName = "ReportsTo";
            this.colReportsTo.HeaderText = "Raporlar";
            this.colReportsTo.Name = "colReportsTo";
            this.colReportsTo.ReadOnly = true;
            // 
            // colNotes
            // 
            this.colNotes.DataPropertyName = "Extension";
            this.colNotes.HeaderText = "Notlar";
            this.colNotes.Name = "colNotes";
            this.colNotes.ReadOnly = true;
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
            this.ctxBtnRefresh.Size = new System.Drawing.Size(113, 22);
            this.ctxBtnRefresh.Text = "Refresh";
            this.ctxBtnRefresh.Click += new System.EventHandler(this.ctxBtnRefresh_Click);
            // 
            // ctxBtnDelete
            // 
            this.ctxBtnDelete.Name = "ctxBtnDelete";
            this.ctxBtnDelete.Size = new System.Drawing.Size(113, 22);
            this.ctxBtnDelete.Text = "Delete";
            this.ctxBtnDelete.Click += new System.EventHandler(this.ctxBtnDelete_Click);
            // 
            // EmployeeListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gridEmployee);
            this.Name = "EmployeeListForm";
            this.Text = "EmployeeListForm";
            this.Load += new System.EventHandler(this.EmployeeListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridEmployee)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridEmployee;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ctxBtnRefresh;
        private System.Windows.Forms.ToolStripMenuItem ctxBtnDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmployeeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTitleOfCourtesy;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBirthDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHireDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCity;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRegion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPostalCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCountry;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHomaPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn colExtension;
        private System.Windows.Forms.DataGridViewTextBoxColumn colReportsTo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNotes;
    }
}