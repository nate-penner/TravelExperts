
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
            this.lblProductTabSupplierCount = new System.Windows.Forms.Label();
            this.lblProductTabProductId = new System.Windows.Forms.Label();
            this.lblProductTabSuppliers = new System.Windows.Forms.Label();
            this.lblProductTabProducts = new System.Windows.Forms.Label();
            this.txtProductTabTotalSuppliers = new System.Windows.Forms.TextBox();
            this.txtProductTabProductID = new System.Windows.Forms.TextBox();
            this.lstProductTabSuppliers = new System.Windows.Forms.ListBox();
            this.btnProductTabEditProduct = new System.Windows.Forms.Button();
            this.btnProductTabAddProduct = new System.Windows.Forms.Button();
            this.lstProductTabProducts = new System.Windows.Forms.ListBox();
            this.tabSuppliers = new System.Windows.Forms.TabPage();
            this.btnSupplierTabModify = new System.Windows.Forms.Button();
            this.btnSupplierTabAdd = new System.Windows.Forms.Button();
            this.lblSupplierTabProductId = new System.Windows.Forms.Label();
            this.lblSupplierTabSupplierId = new System.Windows.Forms.Label();
            this.txtSupplierTabProductCount = new System.Windows.Forms.TextBox();
            this.txtSupplierTabSupplierId = new System.Windows.Forms.TextBox();
            this.lstSupplierTabProducts = new System.Windows.Forms.ListBox();
            this.lblSupplierTabProducts = new System.Windows.Forms.Label();
            this.lblSupplierTabSuppliers = new System.Windows.Forms.Label();
            this.lstSupplierTabSuppliers = new System.Windows.Forms.ListBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabSuppliers.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabSuppliers);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
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
            this.tabPage2.Controls.Add(this.lblProductTabSupplierCount);
            this.tabPage2.Controls.Add(this.lblProductTabProductId);
            this.tabPage2.Controls.Add(this.lblProductTabSuppliers);
            this.tabPage2.Controls.Add(this.lblProductTabProducts);
            this.tabPage2.Controls.Add(this.txtProductTabTotalSuppliers);
            this.tabPage2.Controls.Add(this.txtProductTabProductID);
            this.tabPage2.Controls.Add(this.lstProductTabSuppliers);
            this.tabPage2.Controls.Add(this.btnProductTabEditProduct);
            this.tabPage2.Controls.Add(this.btnProductTabAddProduct);
            this.tabPage2.Controls.Add(this.lstProductTabProducts);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(644, 397);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Products";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblProductTabSupplierCount
            // 
            this.lblProductTabSupplierCount.AutoSize = true;
            this.lblProductTabSupplierCount.Location = new System.Drawing.Point(252, 195);
            this.lblProductTabSupplierCount.Name = "lblProductTabSupplierCount";
            this.lblProductTabSupplierCount.Size = new System.Drawing.Size(89, 15);
            this.lblProductTabSupplierCount.TabIndex = 13;
            this.lblProductTabSupplierCount.Text = "Total Suppliers: ";
            // 
            // lblProductTabProductId
            // 
            this.lblProductTabProductId.AutoSize = true;
            this.lblProductTabProductId.Location = new System.Drawing.Point(80, 195);
            this.lblProductTabProductId.Name = "lblProductTabProductId";
            this.lblProductTabProductId.Size = new System.Drawing.Size(66, 15);
            this.lblProductTabProductId.TabIndex = 12;
            this.lblProductTabProductId.Text = "Product ID:";
            // 
            // lblProductTabSuppliers
            // 
            this.lblProductTabSuppliers.AutoSize = true;
            this.lblProductTabSuppliers.Location = new System.Drawing.Point(215, 11);
            this.lblProductTabSuppliers.Name = "lblProductTabSuppliers";
            this.lblProductTabSuppliers.Size = new System.Drawing.Size(55, 15);
            this.lblProductTabSuppliers.TabIndex = 11;
            this.lblProductTabSuppliers.Text = "Suppliers";
            // 
            // lblProductTabProducts
            // 
            this.lblProductTabProducts.AutoSize = true;
            this.lblProductTabProducts.Location = new System.Drawing.Point(16, 11);
            this.lblProductTabProducts.Name = "lblProductTabProducts";
            this.lblProductTabProducts.Size = new System.Drawing.Size(54, 15);
            this.lblProductTabProducts.TabIndex = 10;
            this.lblProductTabProducts.Text = "Products";
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
            // txtProductTabProductID
            // 
            this.txtProductTabProductID.BackColor = System.Drawing.SystemColors.Info;
            this.txtProductTabProductID.Enabled = false;
            this.txtProductTabProductID.Location = new System.Drawing.Point(148, 192);
            this.txtProductTabProductID.Name = "txtProductTabProductID";
            this.txtProductTabProductID.Size = new System.Drawing.Size(37, 23);
            this.txtProductTabProductID.TabIndex = 7;
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
            // btnProductTabEditProduct
            // 
            this.btnProductTabEditProduct.Location = new System.Drawing.Point(110, 221);
            this.btnProductTabEditProduct.Name = "btnProductTabEditProduct";
            this.btnProductTabEditProduct.Size = new System.Drawing.Size(75, 39);
            this.btnProductTabEditProduct.TabIndex = 3;
            this.btnProductTabEditProduct.Text = "Edit";
            this.btnProductTabEditProduct.UseVisualStyleBackColor = true;
            this.btnProductTabEditProduct.Click += new System.EventHandler(this.btnProductTabEditProduct_Click);
            // 
            // btnProductTabAddProduct
            // 
            this.btnProductTabAddProduct.Location = new System.Drawing.Point(16, 221);
            this.btnProductTabAddProduct.Name = "btnProductTabAddProduct";
            this.btnProductTabAddProduct.Size = new System.Drawing.Size(75, 39);
            this.btnProductTabAddProduct.TabIndex = 2;
            this.btnProductTabAddProduct.Text = "Add";
            this.btnProductTabAddProduct.UseVisualStyleBackColor = true;
            this.btnProductTabAddProduct.Click += new System.EventHandler(this.btnProductTabAddProduct_Click);
            // 
            // lstProductTabProducts
            // 
            this.lstProductTabProducts.FormattingEnabled = true;
            this.lstProductTabProducts.ItemHeight = 15;
            this.lstProductTabProducts.Location = new System.Drawing.Point(16, 32);
            this.lstProductTabProducts.Name = "lstProductTabProducts";
            this.lstProductTabProducts.Size = new System.Drawing.Size(169, 154);
            this.lstProductTabProducts.TabIndex = 1;
            this.lstProductTabProducts.SelectedIndexChanged += new System.EventHandler(this.lstProductTabProducts_SelectedIndexChanged);
            // 
            // tabSuppliers
            // 
            this.tabSuppliers.Controls.Add(this.btnSupplierTabModify);
            this.tabSuppliers.Controls.Add(this.btnSupplierTabAdd);
            this.tabSuppliers.Controls.Add(this.lblSupplierTabProductId);
            this.tabSuppliers.Controls.Add(this.lblSupplierTabSupplierId);
            this.tabSuppliers.Controls.Add(this.txtSupplierTabProductCount);
            this.tabSuppliers.Controls.Add(this.txtSupplierTabSupplierId);
            this.tabSuppliers.Controls.Add(this.lstSupplierTabProducts);
            this.tabSuppliers.Controls.Add(this.lblSupplierTabProducts);
            this.tabSuppliers.Controls.Add(this.lblSupplierTabSuppliers);
            this.tabSuppliers.Controls.Add(this.lstSupplierTabSuppliers);
            this.tabSuppliers.Location = new System.Drawing.Point(4, 24);
            this.tabSuppliers.Name = "tabSuppliers";
            this.tabSuppliers.Size = new System.Drawing.Size(644, 397);
            this.tabSuppliers.TabIndex = 2;
            this.tabSuppliers.Text = "Suppliers";
            this.tabSuppliers.UseVisualStyleBackColor = true;
            // 
            // btnSupplierTabModify
            // 
            this.btnSupplierTabModify.Location = new System.Drawing.Point(153, 296);
            this.btnSupplierTabModify.Name = "btnSupplierTabModify";
            this.btnSupplierTabModify.Size = new System.Drawing.Size(75, 23);
            this.btnSupplierTabModify.TabIndex = 9;
            this.btnSupplierTabModify.Text = "Modify";
            this.btnSupplierTabModify.UseVisualStyleBackColor = true;
            // 
            // btnSupplierTabAdd
            // 
            this.btnSupplierTabAdd.Location = new System.Drawing.Point(36, 296);
            this.btnSupplierTabAdd.Name = "btnSupplierTabAdd";
            this.btnSupplierTabAdd.Size = new System.Drawing.Size(75, 23);
            this.btnSupplierTabAdd.TabIndex = 8;
            this.btnSupplierTabAdd.Text = "Add";
            this.btnSupplierTabAdd.UseVisualStyleBackColor = true;
            // 
            // lblSupplierTabProductId
            // 
            this.lblSupplierTabProductId.AutoSize = true;
            this.lblSupplierTabProductId.Location = new System.Drawing.Point(350, 243);
            this.lblSupplierTabProductId.Name = "lblSupplierTabProductId";
            this.lblSupplierTabProductId.Size = new System.Drawing.Size(62, 15);
            this.lblSupplierTabProductId.TabIndex = 7;
            this.lblSupplierTabProductId.Text = "ProductId:";
            // 
            // lblSupplierTabSupplierId
            // 
            this.lblSupplierTabSupplierId.AutoSize = true;
            this.lblSupplierTabSupplierId.Location = new System.Drawing.Point(75, 243);
            this.lblSupplierTabSupplierId.Name = "lblSupplierTabSupplierId";
            this.lblSupplierTabSupplierId.Size = new System.Drawing.Size(63, 15);
            this.lblSupplierTabSupplierId.TabIndex = 6;
            this.lblSupplierTabSupplierId.Text = "SupplierId:";
            // 
            // txtSupplierTabProductCount
            // 
            this.txtSupplierTabProductCount.Location = new System.Drawing.Point(418, 240);
            this.txtSupplierTabProductCount.Name = "txtSupplierTabProductCount";
            this.txtSupplierTabProductCount.ReadOnly = true;
            this.txtSupplierTabProductCount.Size = new System.Drawing.Size(100, 23);
            this.txtSupplierTabProductCount.TabIndex = 5;
            // 
            // txtSupplierTabSupplierId
            // 
            this.txtSupplierTabSupplierId.Location = new System.Drawing.Point(144, 240);
            this.txtSupplierTabSupplierId.Name = "txtSupplierTabSupplierId";
            this.txtSupplierTabSupplierId.ReadOnly = true;
            this.txtSupplierTabSupplierId.Size = new System.Drawing.Size(100, 23);
            this.txtSupplierTabSupplierId.TabIndex = 4;
            // 
            // lstSupplierTabProducts
            // 
            this.lstSupplierTabProducts.FormattingEnabled = true;
            this.lstSupplierTabProducts.ItemHeight = 15;
            this.lstSupplierTabProducts.Location = new System.Drawing.Point(301, 40);
            this.lstSupplierTabProducts.Name = "lstSupplierTabProducts";
            this.lstSupplierTabProducts.Size = new System.Drawing.Size(217, 184);
            this.lstSupplierTabProducts.TabIndex = 3;
            // 
            // lblSupplierTabProducts
            // 
            this.lblSupplierTabProducts.AutoSize = true;
            this.lblSupplierTabProducts.Location = new System.Drawing.Point(301, 19);
            this.lblSupplierTabProducts.Name = "lblSupplierTabProducts";
            this.lblSupplierTabProducts.Size = new System.Drawing.Size(54, 15);
            this.lblSupplierTabProducts.TabIndex = 2;
            this.lblSupplierTabProducts.Text = "Products";
            // 
            // lblSupplierTabSuppliers
            // 
            this.lblSupplierTabSuppliers.AutoSize = true;
            this.lblSupplierTabSuppliers.Location = new System.Drawing.Point(17, 19);
            this.lblSupplierTabSuppliers.Name = "lblSupplierTabSuppliers";
            this.lblSupplierTabSuppliers.Size = new System.Drawing.Size(55, 15);
            this.lblSupplierTabSuppliers.TabIndex = 1;
            this.lblSupplierTabSuppliers.Text = "Suppliers";
            // 
            // lstSupplierTabSuppliers
            // 
            this.lstSupplierTabSuppliers.FormattingEnabled = true;
            this.lstSupplierTabSuppliers.ItemHeight = 15;
            this.lstSupplierTabSuppliers.Location = new System.Drawing.Point(17, 40);
            this.lstSupplierTabSuppliers.Name = "lstSupplierTabSuppliers";
            this.lstSupplierTabSuppliers.Size = new System.Drawing.Size(227, 184);
            this.lstSupplierTabSuppliers.TabIndex = 0;
            this.lstSupplierTabSuppliers.SelectedIndexChanged += new System.EventHandler(this.lstSupplierTabSuppliers_SelectedIndexChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(0, 0);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(200, 100);
            this.tabPage3.TabIndex = 0;
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
            this.tabSuppliers.ResumeLayout(false);
            this.tabSuppliers.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ListBox lstProductTabProducts;
        private System.Windows.Forms.Label lblSupplierTabSuppliers;
        private System.Windows.Forms.Button btnProductTabEditProduct;
        private System.Windows.Forms.Button btnProductTabAddProduct;
        private System.Windows.Forms.ListBox lstProductTabSuppliers;
        private System.Windows.Forms.Label lblSupplierTabProducts;
        private System.Windows.Forms.TextBox txtProductTabProductID;
        private System.Windows.Forms.Label lblSupplierTabSupplierId;
        private System.Windows.Forms.TextBox txtProductTabTotalSuppliers;
        private System.Windows.Forms.Label lblSupplierTabProductId;
        private System.Windows.Forms.TabPage tabSuppliers;
        private System.Windows.Forms.ListBox lstSupplierTabSuppliers;
        private System.Windows.Forms.Button btnSupplierTabModify;
        private System.Windows.Forms.Button btnSupplierTabAdd;
        private System.Windows.Forms.TextBox txtSupplierTabProductCount;
        private System.Windows.Forms.TextBox txtSupplierTabSupplierId;
        private System.Windows.Forms.ListBox lstSupplierTabProducts;
        private System.Windows.Forms.Label lblProductTabSupplierCount;
        private System.Windows.Forms.Label lblProductTabProductId;
        private System.Windows.Forms.Label lblProductTabSuppliers;
        private System.Windows.Forms.Label lblProductTabProducts;
    }
}

