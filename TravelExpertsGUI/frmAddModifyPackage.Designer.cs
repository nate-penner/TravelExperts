
namespace TravelExpertsGUI
{
    partial class frmAddModifyPackage
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
            this.lblPackageName = new System.Windows.Forms.Label();
            this.lblPackageStartDate = new System.Windows.Forms.Label();
            this.lblPackageEndDate = new System.Windows.Forms.Label();
            this.lblPackageDescription = new System.Windows.Forms.Label();
            this.lblPackagePrice = new System.Windows.Forms.Label();
            this.lblPackageAgencyCommission = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtBasePrice = new System.Windows.Forms.TextBox();
            this.txtAgencyCommission = new System.Windows.Forms.TextBox();
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // lblPackageName
            // 
            this.lblPackageName.AutoSize = true;
            this.lblPackageName.Location = new System.Drawing.Point(99, 43);
            this.lblPackageName.Name = "lblPackageName";
            this.lblPackageName.Size = new System.Drawing.Size(42, 15);
            this.lblPackageName.TabIndex = 0;
            this.lblPackageName.Text = "Name:";
            // 
            // lblPackageStartDate
            // 
            this.lblPackageStartDate.AutoSize = true;
            this.lblPackageStartDate.Location = new System.Drawing.Point(80, 157);
            this.lblPackageStartDate.Name = "lblPackageStartDate";
            this.lblPackageStartDate.Size = new System.Drawing.Size(61, 15);
            this.lblPackageStartDate.TabIndex = 1;
            this.lblPackageStartDate.Text = "Start Date:";
            // 
            // lblPackageEndDate
            // 
            this.lblPackageEndDate.AutoSize = true;
            this.lblPackageEndDate.Location = new System.Drawing.Point(84, 191);
            this.lblPackageEndDate.Name = "lblPackageEndDate";
            this.lblPackageEndDate.Size = new System.Drawing.Size(57, 15);
            this.lblPackageEndDate.TabIndex = 2;
            this.lblPackageEndDate.Text = "End Date:";
            // 
            // lblPackageDescription
            // 
            this.lblPackageDescription.AutoSize = true;
            this.lblPackageDescription.Location = new System.Drawing.Point(71, 103);
            this.lblPackageDescription.Name = "lblPackageDescription";
            this.lblPackageDescription.Size = new System.Drawing.Size(70, 15);
            this.lblPackageDescription.TabIndex = 3;
            this.lblPackageDescription.Text = "Description:";
            // 
            // lblPackagePrice
            // 
            this.lblPackagePrice.AutoSize = true;
            this.lblPackagePrice.Location = new System.Drawing.Point(78, 224);
            this.lblPackagePrice.Name = "lblPackagePrice";
            this.lblPackagePrice.Size = new System.Drawing.Size(63, 15);
            this.lblPackagePrice.TabIndex = 4;
            this.lblPackagePrice.Text = "Base Price:";
            // 
            // lblPackageAgencyCommission
            // 
            this.lblPackageAgencyCommission.AutoSize = true;
            this.lblPackageAgencyCommission.Location = new System.Drawing.Point(21, 258);
            this.lblPackageAgencyCommission.Name = "lblPackageAgencyCommission";
            this.lblPackageAgencyCommission.Size = new System.Drawing.Size(120, 15);
            this.lblPackageAgencyCommission.TabIndex = 5;
            this.lblPackageAgencyCommission.Text = "Agency Commission:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(167, 29);
            this.txtName.MaxLength = 50;
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(202, 43);
            this.txtName.TabIndex = 6;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(167, 89);
            this.txtDescription.MaxLength = 50;
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(202, 43);
            this.txtDescription.TabIndex = 9;
            // 
            // txtBasePrice
            // 
            this.txtBasePrice.Location = new System.Drawing.Point(167, 216);
            this.txtBasePrice.Name = "txtBasePrice";
            this.txtBasePrice.Size = new System.Drawing.Size(100, 23);
            this.txtBasePrice.TabIndex = 10;
            // 
            // txtAgencyCommission
            // 
            this.txtAgencyCommission.Location = new System.Drawing.Point(167, 250);
            this.txtAgencyCommission.Name = "txtAgencyCommission";
            this.txtAgencyCommission.Size = new System.Drawing.Size(100, 23);
            this.txtAgencyCommission.TabIndex = 11;
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(151, 310);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(75, 23);
            this.btnAccept.TabIndex = 12;
            this.btnAccept.Text = "Accept";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(247, 310);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Location = new System.Drawing.Point(167, 151);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(202, 23);
            this.dtpStartDate.TabIndex = 14;
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Location = new System.Drawing.Point(167, 183);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(202, 23);
            this.dtpEndDate.TabIndex = 15;
            // 
            // frmAddModifyPackage
            // 
            this.AcceptButton = this.btnAccept;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(427, 381);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.txtAgencyCommission);
            this.Controls.Add(this.txtBasePrice);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblPackageAgencyCommission);
            this.Controls.Add(this.lblPackagePrice);
            this.Controls.Add(this.lblPackageDescription);
            this.Controls.Add(this.lblPackageEndDate);
            this.Controls.Add(this.lblPackageStartDate);
            this.Controls.Add(this.lblPackageName);
            this.Name = "frmAddModifyPackage";
            this.Text = "New Package";
            this.Load += new System.EventHandler(this.frmAddModifyPackage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPackageName;
        private System.Windows.Forms.Label lblPackageStartDate;
        private System.Windows.Forms.Label lblPackageEndDate;
        private System.Windows.Forms.Label lblPackageDescription;
        private System.Windows.Forms.Label lblPackagePrice;
        private System.Windows.Forms.Label lblPackageAgencyCommission;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtBasePrice;
        private System.Windows.Forms.TextBox txtAgencyCommission;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
    }
}