
namespace TravelExpertsGUI
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
            //Hello World Alex C.
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtProductTabTotalSuppliers = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtProductTabProductID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lstProductTabSuppliers = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnProductTabEditProduct = new System.Windows.Forms.Button();
            this.btnProductTabAddProduct = new System.Windows.Forms.Button();
            this.lstProductTabProducts = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(652, 425);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(644, 397);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Packages";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtProductTabTotalSuppliers);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.txtProductTabProductID);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.lstProductTabSuppliers);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.btnProductTabEditProduct);
            this.tabPage2.Controls.Add(this.btnProductTabAddProduct);
            this.tabPage2.Controls.Add(this.lstProductTabProducts);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(644, 397);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Products";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtProductTabTotalSuppliers
            // 
            this.txtProductTabTotalSuppliers.BackColor = System.Drawing.SystemColors.Info;
            this.txtProductTabTotalSuppliers.Enabled = false;
            this.txtProductTabTotalSuppliers.Location = new System.Drawing.Point(347, 192);
            this.txtProductTabTotalSuppliers.Name = "txtProductTabTotalSuppliers";
            this.txtProductTabTotalSuppliers.Size = new System.Drawing.Size(37, 23);
            this.txtProductTabTotalSuppliers.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(255, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Total Suppliers:";
            // 
            // txtProductTabProductID
            // 
            this.txtProductTabProductID.BackColor = System.Drawing.SystemColors.Info;
            this.txtProductTabProductID.Enabled = false;
            this.txtProductTabProductID.Location = new System.Drawing.Point(148, 192);
            this.txtProductTabProductID.Name = "txtProductTabProductID";
            this.txtProductTabProductID.Size = new System.Drawing.Size(37, 23);
            this.txtProductTabProductID.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Product ID:";
            // 
            // lstProductTabSuppliers
            // 
            this.lstProductTabSuppliers.FormattingEnabled = true;
            this.lstProductTabSuppliers.ItemHeight = 15;
            this.lstProductTabSuppliers.Location = new System.Drawing.Point(215, 32);
            this.lstProductTabSuppliers.Name = "lstProductTabSuppliers";
            this.lstProductTabSuppliers.Size = new System.Drawing.Size(169, 154);
            this.lstProductTabSuppliers.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(215, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Suppliers:";
            // 
            // btnProductTabEditProduct
            // 
            this.btnProductTabEditProduct.Location = new System.Drawing.Point(110, 221);
            this.btnProductTabEditProduct.Name = "btnProductTabEditProduct";
            this.btnProductTabEditProduct.Size = new System.Drawing.Size(75, 39);
            this.btnProductTabEditProduct.TabIndex = 3;
            this.btnProductTabEditProduct.Text = "Edit";
            this.btnProductTabEditProduct.UseVisualStyleBackColor = true;
            // 
            // btnProductTabAddProduct
            // 
            this.btnProductTabAddProduct.Location = new System.Drawing.Point(16, 221);
            this.btnProductTabAddProduct.Name = "btnProductTabAddProduct";
            this.btnProductTabAddProduct.Size = new System.Drawing.Size(75, 39);
            this.btnProductTabAddProduct.TabIndex = 2;
            this.btnProductTabAddProduct.Text = "Add";
            this.btnProductTabAddProduct.UseVisualStyleBackColor = true;
            // 
            // lstProductTabProducts
            // 
            this.lstProductTabProducts.FormattingEnabled = true;
            this.lstProductTabProducts.ItemHeight = 15;
            this.lstProductTabProducts.Location = new System.Drawing.Point(16, 32);
            this.lstProductTabProducts.Name = "lstProductTabProducts";
            this.lstProductTabProducts.Size = new System.Drawing.Size(169, 154);
            this.lstProductTabProducts.TabIndex = 1;
            this.lstProductTabProducts.SelectedIndexChanged += new System.EventHandler(this.lstProducts_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product List:";
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(644, 397);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Suppliers";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 446);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmMain";
            this.Text = "Travel Experts 0.1-PRE-ALPHA";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ListBox lstProductTabProducts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnProductTabEditProduct;
        private System.Windows.Forms.Button btnProductTabAddProduct;
        private System.Windows.Forms.ListBox lstProductTabSuppliers;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtProductTabProductID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtProductTabTotalSuppliers;
        private System.Windows.Forms.Label label4;
    }
}

