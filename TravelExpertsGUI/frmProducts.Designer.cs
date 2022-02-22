
namespace TravelExpertsGUI
{
    partial class frmProducts
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
            this.lblProductName = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.lstCurrentSuppliers = new System.Windows.Forms.ListBox();
            this.lstPotentialSuppliers = new System.Windows.Forms.ListBox();
            this.btnAddSuppliers = new System.Windows.Forms.Button();
            this.btnRemoveSuppliers = new System.Windows.Forms.Button();
            this.lblCurrentSuppliers = new System.Windows.Forms.Label();
            this.lblProductSupplier = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(17, 42);
            this.lblProductName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(113, 21);
            this.lblProductName.TabIndex = 0;
            this.lblProductName.Text = "Product Name:";
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(136, 38);
            this.txtProductName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(127, 29);
            this.txtProductName.TabIndex = 1;
            // 
            // lstCurrentSuppliers
            // 
            this.lstCurrentSuppliers.FormattingEnabled = true;
            this.lstCurrentSuppliers.ItemHeight = 21;
            this.lstCurrentSuppliers.Location = new System.Drawing.Point(18, 126);
            this.lstCurrentSuppliers.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstCurrentSuppliers.Name = "lstCurrentSuppliers";
            this.lstCurrentSuppliers.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstCurrentSuppliers.Size = new System.Drawing.Size(247, 214);
            this.lstCurrentSuppliers.TabIndex = 2;
            // 
            // lstPotentialSuppliers
            // 
            this.lstPotentialSuppliers.FormattingEnabled = true;
            this.lstPotentialSuppliers.ItemHeight = 21;
            this.lstPotentialSuppliers.Location = new System.Drawing.Point(387, 126);
            this.lstPotentialSuppliers.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstPotentialSuppliers.Name = "lstPotentialSuppliers";
            this.lstPotentialSuppliers.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstPotentialSuppliers.Size = new System.Drawing.Size(247, 214);
            this.lstPotentialSuppliers.TabIndex = 3;
            // 
            // btnAddSuppliers
            // 
            this.btnAddSuppliers.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddSuppliers.Location = new System.Drawing.Point(275, 161);
            this.btnAddSuppliers.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddSuppliers.Name = "btnAddSuppliers";
            this.btnAddSuppliers.Size = new System.Drawing.Size(96, 49);
            this.btnAddSuppliers.TabIndex = 4;
            this.btnAddSuppliers.Text = "<< &Add Suppliers";
            this.btnAddSuppliers.UseVisualStyleBackColor = true;
            this.btnAddSuppliers.Click += new System.EventHandler(this.btnAddSuppliers_Click);
            // 
            // btnRemoveSuppliers
            // 
            this.btnRemoveSuppliers.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRemoveSuppliers.Location = new System.Drawing.Point(275, 262);
            this.btnRemoveSuppliers.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRemoveSuppliers.Name = "btnRemoveSuppliers";
            this.btnRemoveSuppliers.Size = new System.Drawing.Size(96, 49);
            this.btnRemoveSuppliers.TabIndex = 5;
            this.btnRemoveSuppliers.Text = "&Remove Suppliers >>";
            this.btnRemoveSuppliers.UseVisualStyleBackColor = true;
            this.btnRemoveSuppliers.Click += new System.EventHandler(this.btnRemoveSuppliers_Click);
            // 
            // lblCurrentSuppliers
            // 
            this.lblCurrentSuppliers.AutoSize = true;
            this.lblCurrentSuppliers.Location = new System.Drawing.Point(18, 81);
            this.lblCurrentSuppliers.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCurrentSuppliers.Name = "lblCurrentSuppliers";
            this.lblCurrentSuppliers.Size = new System.Drawing.Size(135, 21);
            this.lblCurrentSuppliers.TabIndex = 6;
            this.lblCurrentSuppliers.Text = "Current Suppliers:";
            // 
            // lblProductSupplier
            // 
            this.lblProductSupplier.AutoSize = true;
            this.lblProductSupplier.Location = new System.Drawing.Point(387, 81);
            this.lblProductSupplier.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProductSupplier.Name = "lblProductSupplier";
            this.lblProductSupplier.Size = new System.Drawing.Size(78, 21);
            this.lblProductSupplier.TabIndex = 7;
            this.lblProductSupplier.Text = "Suppliers:";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(18, 350);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(111, 55);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(156, 350);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(111, 55);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmProducts
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(651, 425);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblProductSupplier);
            this.Controls.Add(this.lblCurrentSuppliers);
            this.Controls.Add(this.btnRemoveSuppliers);
            this.Controls.Add(this.btnAddSuppliers);
            this.Controls.Add(this.lstPotentialSuppliers);
            this.Controls.Add(this.lstCurrentSuppliers);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.lblProductName);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmProducts";
            this.Load += new System.EventHandler(this.frmProducts_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.ListBox lstCurrentSuppliers;
        private System.Windows.Forms.ListBox lstPotentialSuppliers;
        private System.Windows.Forms.Button btnAddSuppliers;
        private System.Windows.Forms.Button btnRemoveSuppliers;
        private System.Windows.Forms.Label lblCurrentSuppliers;
        private System.Windows.Forms.Label lblProductSupplier;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}