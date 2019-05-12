namespace NorthwindEFCRUD.Views
{
    partial class TerritoryEditForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.maskedTerritoryId = new System.Windows.Forms.MaskedTextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtterritoryDescription = new System.Windows.Forms.TextBox();
            this.numRegionId = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numRegionId)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Saha Numarası";
            // 
            // maskedTerritoryId
            // 
            this.maskedTerritoryId.Location = new System.Drawing.Point(142, 25);
            this.maskedTerritoryId.Mask = "00000";
            this.maskedTerritoryId.Name = "maskedTerritoryId";
            this.maskedTerritoryId.Size = new System.Drawing.Size(192, 20);
            this.maskedTerritoryId.TabIndex = 12;
            this.maskedTerritoryId.ValidatingType = typeof(int);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(142, 196);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(192, 23);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Kaydet";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtterritoryDescription
            // 
            this.txtterritoryDescription.Location = new System.Drawing.Point(142, 66);
            this.txtterritoryDescription.Name = "txtterritoryDescription";
            this.txtterritoryDescription.Size = new System.Drawing.Size(192, 20);
            this.txtterritoryDescription.TabIndex = 10;
            // 
            // numRegionId
            // 
            this.numRegionId.Location = new System.Drawing.Point(142, 120);
            this.numRegionId.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numRegionId.Name = "numRegionId";
            this.numRegionId.Size = new System.Drawing.Size(192, 20);
            this.numRegionId.TabIndex = 9;
            this.numRegionId.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Bölge Numarası";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Saha Açıklaması";
            // 
            // TerritoryEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 300);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.maskedTerritoryId);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtterritoryDescription);
            this.Controls.Add(this.numRegionId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TerritoryEditForm";
            this.Text = "TerritoryEditForm";
            this.Load += new System.EventHandler(this.TerritoryEditForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numRegionId)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox maskedTerritoryId;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtterritoryDescription;
        private System.Windows.Forms.NumericUpDown numRegionId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}