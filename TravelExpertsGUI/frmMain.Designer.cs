
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
            this.lstPackageTabAvailableSuppliers = new System.Windows.Forms.ListBox();
            this.lstPackageTabActiveSuppliers = new System.Windows.Forms.ListBox();
            this.lblPackageTabPackages = new System.Windows.Forms.Label();
            this.btnPackageTabRemoveProduct = new System.Windows.Forms.Button();
            this.btnPackageTabAddProduct = new System.Windows.Forms.Button();
            this.lstPackageTabAvailableProducts = new System.Windows.Forms.ListBox();
            this.lstPackageTabActiveProducts = new System.Windows.Forms.ListBox();
            this.lblPackageTabAvailableProducts = new System.Windows.Forms.Label();
            this.lblPackageTabActiveProducts = new System.Windows.Forms.Label();
            this.btnPackageTabDeletePackage = new System.Windows.Forms.Button();
            this.btnPackageTabEditPackage = new System.Windows.Forms.Button();
            this.btnPackageTabAddPackage = new System.Windows.Forms.Button();
            this.lstPackageTabPackages = new System.Windows.Forms.ListBox();
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPackagesTabPackages = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabSuppliers.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabSuppliers);
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(652, 425);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.lstPackageTabAvailableSuppliers);
            this.tabPage1.Controls.Add(this.lstPackageTabActiveSuppliers);
            this.tabPage1.Controls.Add(this.lblPackageTabPackages);
            this.tabPage1.Controls.Add(this.btnPackageTabRemoveProduct);
            this.tabPage1.Controls.Add(this.btnPackageTabAddProduct);
            this.tabPage1.Controls.Add(this.lstPackageTabAvailableProducts);
            this.tabPage1.Controls.Add(this.lstPackageTabActiveProducts);
            this.tabPage1.Controls.Add(this.lblPackageTabAvailableProducts);
            this.tabPage1.Controls.Add(this.lblPackageTabActiveProducts);
            this.tabPage1.BackColor = System.Drawing.Color.SkyBlue;
            this.tabPage1.Controls.Add(this.lblPackagesTabPackages);
            this.tabPage1.Controls.Add(this.btnPackageTabDeletePackage);
            this.tabPage1.Controls.Add(this.btnPackageTabEditPackage);
            this.tabPage1.Controls.Add(this.btnPackageTabAddPackage);
            this.tabPage1.Controls.Add(this.lstPackageTabPackages);
            this.tabPage1.Location = new System.Drawing.Point(4, 33);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(644, 388);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Packages";
            // 
            // lstPackageTabAvailableSuppliers
            // 
            this.lstPackageTabAvailableSuppliers.FormattingEnabled = true;
            this.lstPackageTabAvailableSuppliers.ItemHeight = 15;
            this.lstPackageTabAvailableSuppliers.Location = new System.Drawing.Point(505, 196);
            this.lstPackageTabAvailableSuppliers.Name = "lstPackageTabAvailableSuppliers";
            this.lstPackageTabAvailableSuppliers.Size = new System.Drawing.Size(133, 94);
            this.lstPackageTabAvailableSuppliers.TabIndex = 14;
            // 
            // lstPackageTabActiveSuppliers
            // 
            this.lstPackageTabActiveSuppliers.FormattingEnabled = true;
            this.lstPackageTabActiveSuppliers.ItemHeight = 15;
            this.lstPackageTabActiveSuppliers.Location = new System.Drawing.Point(282, 196);
            this.lstPackageTabActiveSuppliers.Name = "lstPackageTabActiveSuppliers";
            this.lstPackageTabActiveSuppliers.Size = new System.Drawing.Size(133, 94);
            this.lstPackageTabActiveSuppliers.TabIndex = 13;
            // 
            // lblPackageTabPackages
            // 
            this.lblPackageTabPackages.AutoSize = true;
            this.lblPackageTabPackages.Location = new System.Drawing.Point(27, 30);
            this.lblPackageTabPackages.Name = "lblPackageTabPackages";
            this.lblPackageTabPackages.Size = new System.Drawing.Size(56, 15);
            this.lblPackageTabPackages.TabIndex = 12;
            this.lblPackageTabPackages.Text = "Packages";
            // 
            // btnPackageTabRemoveProduct
            // 
            this.btnPackageTabRemoveProduct.Location = new System.Drawing.Point(424, 149);
            this.btnPackageTabRemoveProduct.Name = "btnPackageTabRemoveProduct";
            this.btnPackageTabRemoveProduct.Size = new System.Drawing.Size(75, 23);
            this.btnPackageTabRemoveProduct.TabIndex = 11;
            this.btnPackageTabRemoveProduct.Text = ">>";
            this.btnPackageTabRemoveProduct.UseVisualStyleBackColor = true;
            this.btnPackageTabRemoveProduct.Click += new System.EventHandler(this.btnPackageTabRemoveProduct_Click);
            // 
            // btnPackageTabAddProduct
            // 
            this.btnPackageTabAddProduct.Location = new System.Drawing.Point(424, 178);
            this.btnPackageTabAddProduct.Name = "btnPackageTabAddProduct";
            this.btnPackageTabAddProduct.Size = new System.Drawing.Size(75, 23);
            this.btnPackageTabAddProduct.TabIndex = 10;
            this.btnPackageTabAddProduct.Text = "<<";
            this.btnPackageTabAddProduct.UseVisualStyleBackColor = true;
            this.btnPackageTabAddProduct.Click += new System.EventHandler(this.btnPackageTabAddProduct_Click);
            // 
            // lstPackageTabAvailableProducts
            // 
            this.lstPackageTabAvailableProducts.FormattingEnabled = true;
            this.lstPackageTabAvailableProducts.ItemHeight = 15;
            this.lstPackageTabAvailableProducts.Location = new System.Drawing.Point(505, 60);
            this.lstPackageTabAvailableProducts.Name = "lstPackageTabAvailableProducts";
            this.lstPackageTabAvailableProducts.Size = new System.Drawing.Size(133, 94);
            this.lstPackageTabAvailableProducts.TabIndex = 9;
            this.lstPackageTabAvailableProducts.SelectedIndexChanged += new System.EventHandler(this.lstPackageTabAvailableProducts_SelectedIndexChanged);
            // 
            // lstPackageTabActiveProducts
            // 
            this.lstPackageTabActiveProducts.FormattingEnabled = true;
            this.lstPackageTabActiveProducts.ItemHeight = 15;
            this.lstPackageTabActiveProducts.Location = new System.Drawing.Point(282, 60);
            this.lstPackageTabActiveProducts.Name = "lstPackageTabActiveProducts";
            this.lstPackageTabActiveProducts.Size = new System.Drawing.Size(133, 94);
            this.lstPackageTabActiveProducts.TabIndex = 8;
            this.lstPackageTabActiveProducts.SelectedIndexChanged += new System.EventHandler(this.lstPackageTabActiveProducts_SelectedIndexChanged);
            // 
            // lblPackageTabAvailableProducts
            // 
            this.lblPackageTabAvailableProducts.AutoSize = true;
            this.lblPackageTabAvailableProducts.Location = new System.Drawing.Point(519, 30);
            this.lblPackageTabAvailableProducts.Name = "lblPackageTabAvailableProducts";
            this.lblPackageTabAvailableProducts.Size = new System.Drawing.Size(105, 15);
            this.lblPackageTabAvailableProducts.TabIndex = 1;
            this.lblPackageTabAvailableProducts.Text = "Available Products";
            // 
            // lblPackageTabActiveProducts
            // 
            this.lblPackageTabActiveProducts.AutoSize = true;
            this.lblPackageTabActiveProducts.Location = new System.Drawing.Point(303, 30);
            this.lblPackageTabActiveProducts.Name = "lblPackageTabActiveProducts";
            this.lblPackageTabActiveProducts.Size = new System.Drawing.Size(90, 15);
            this.lblPackageTabActiveProducts.TabIndex = 2;
            this.lblPackageTabActiveProducts.Text = "Active Products";
            // 
            // btnPackageTabDeletePackage
            // 
            this.btnPackageTabDeletePackage.Location = new System.Drawing.Point(192, 283);
            this.btnPackageTabDeletePackage.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPackageTabDeletePackage.Location = new System.Drawing.Point(177, 236);
            this.btnPackageTabDeletePackage.Name = "btnPackageTabDeletePackage";
            this.btnPackageTabDeletePackage.Size = new System.Drawing.Size(75, 35);
            this.btnPackageTabDeletePackage.TabIndex = 7;
            this.btnPackageTabDeletePackage.Text = "Delete";
            this.btnPackageTabDeletePackage.UseVisualStyleBackColor = true;
            this.btnPackageTabDeletePackage.Click += new System.EventHandler(this.btnPackageTabDeletePackage_Click);
            // 
            // btnPackageTabEditPackage
            // 
            this.btnPackageTabEditPackage.Location = new System.Drawing.Point(108, 283);
            this.btnPackageTabEditPackage.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPackageTabEditPackage.Location = new System.Drawing.Point(96, 236);
            this.btnPackageTabEditPackage.Name = "btnPackageTabEditPackage";
            this.btnPackageTabEditPackage.Size = new System.Drawing.Size(75, 35);
            this.btnPackageTabEditPackage.TabIndex = 6;
            this.btnPackageTabEditPackage.Text = "Edit";
            this.btnPackageTabEditPackage.UseVisualStyleBackColor = true;
            this.btnPackageTabEditPackage.Click += new System.EventHandler(this.btnPackageTabEditPackage_Click);
            // 
            // btnPackageTabAddPackage
            // 
            this.btnPackageTabAddPackage.Location = new System.Drawing.Point(27, 283);
            this.btnPackageTabAddPackage.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPackageTabAddPackage.Location = new System.Drawing.Point(16, 236);
            this.btnPackageTabAddPackage.Name = "btnPackageTabAddPackage";
            this.btnPackageTabAddPackage.Size = new System.Drawing.Size(75, 35);
            this.btnPackageTabAddPackage.TabIndex = 5;
            this.btnPackageTabAddPackage.Text = "Add";
            this.btnPackageTabAddPackage.UseVisualStyleBackColor = true;
            this.btnPackageTabAddPackage.Click += new System.EventHandler(this.btnPackageTabAddPackage_Click);
            // 
            // lstPackageTabPackages
            // 
            this.lstPackageTabPackages.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstPackageTabPackages.FormattingEnabled = true;
            this.lstPackageTabPackages.ItemHeight = 15;
            this.lstPackageTabPackages.Location = new System.Drawing.Point(27, 60);
            this.lstPackageTabPackages.ItemHeight = 21;
            this.lstPackageTabPackages.Location = new System.Drawing.Point(16, 32);
            this.lstPackageTabPackages.Name = "lstPackageTabPackages";
            this.lstPackageTabPackages.Size = new System.Drawing.Size(315, 193);
            this.lstPackageTabPackages.TabIndex = 3;
            this.lstPackageTabPackages.SelectedIndexChanged += new System.EventHandler(this.lstPackageTabPackages_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.SkyBlue;
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
            this.tabPage2.Location = new System.Drawing.Point(4, 33);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(644, 388);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Products";
            // 
            // lblProductTabSupplierCount
            // 
            this.lblProductTabSupplierCount.AutoSize = true;
            this.lblProductTabSupplierCount.Location = new System.Drawing.Point(437, 243);
            this.lblProductTabSupplierCount.Name = "lblProductTabSupplierCount";
            this.lblProductTabSupplierCount.Size = new System.Drawing.Size(118, 21);
            this.lblProductTabSupplierCount.TabIndex = 13;
            this.lblProductTabSupplierCount.Text = "Total Suppliers: ";
            // 
            // lblProductTabProductId
            // 
            this.lblProductTabProductId.AutoSize = true;
            this.lblProductTabProductId.Location = new System.Drawing.Point(175, 243);
            this.lblProductTabProductId.Name = "lblProductTabProductId";
            this.lblProductTabProductId.Size = new System.Drawing.Size(86, 21);
            this.lblProductTabProductId.TabIndex = 12;
            this.lblProductTabProductId.Text = "Product ID:";
            // 
            // lblProductTabSuppliers
            // 
            this.lblProductTabSuppliers.AutoSize = true;
            this.lblProductTabSuppliers.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblProductTabSuppliers.Location = new System.Drawing.Point(310, 4);
            this.lblProductTabSuppliers.Name = "lblProductTabSuppliers";
            this.lblProductTabSuppliers.Size = new System.Drawing.Size(90, 25);
            this.lblProductTabSuppliers.TabIndex = 11;
            this.lblProductTabSuppliers.Text = "Suppliers";
            // 
            // lblProductTabProducts
            // 
            this.lblProductTabProducts.AutoSize = true;
            this.lblProductTabProducts.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblProductTabProducts.Location = new System.Drawing.Point(16, 4);
            this.lblProductTabProducts.Name = "lblProductTabProducts";
            this.lblProductTabProducts.Size = new System.Drawing.Size(86, 25);
            this.lblProductTabProducts.TabIndex = 10;
            this.lblProductTabProducts.Text = "Products";
            // 
            // txtProductTabTotalSuppliers
            // 
            this.txtProductTabTotalSuppliers.BackColor = System.Drawing.SystemColors.Info;
            this.txtProductTabTotalSuppliers.Enabled = false;
            this.txtProductTabTotalSuppliers.Location = new System.Drawing.Point(561, 240);
            this.txtProductTabTotalSuppliers.Name = "txtProductTabTotalSuppliers";
            this.txtProductTabTotalSuppliers.Size = new System.Drawing.Size(37, 29);
            this.txtProductTabTotalSuppliers.TabIndex = 9;
            // 
            // txtProductTabProductID
            // 
            this.txtProductTabProductID.BackColor = System.Drawing.SystemColors.Info;
            this.txtProductTabProductID.Enabled = false;
            this.txtProductTabProductID.Location = new System.Drawing.Point(267, 240);
            this.txtProductTabProductID.Name = "txtProductTabProductID";
            this.txtProductTabProductID.Size = new System.Drawing.Size(37, 29);
            this.txtProductTabProductID.TabIndex = 7;
            // 
            // lstProductTabSuppliers
            // 
            this.lstProductTabSuppliers.FormattingEnabled = true;
            this.lstProductTabSuppliers.ItemHeight = 21;
            this.lstProductTabSuppliers.Location = new System.Drawing.Point(310, 32);
            this.lstProductTabSuppliers.Name = "lstProductTabSuppliers";
            this.lstProductTabSuppliers.Size = new System.Drawing.Size(288, 193);
            this.lstProductTabSuppliers.TabIndex = 5;
            // 
            // btnProductTabEditProduct
            // 
            this.btnProductTabEditProduct.Location = new System.Drawing.Point(96, 236);
            this.btnProductTabEditProduct.Name = "btnProductTabEditProduct";
            this.btnProductTabEditProduct.Size = new System.Drawing.Size(75, 35);
            this.btnProductTabEditProduct.TabIndex = 3;
            this.btnProductTabEditProduct.Text = "Edit";
            this.btnProductTabEditProduct.UseVisualStyleBackColor = true;
            this.btnProductTabEditProduct.Click += new System.EventHandler(this.btnProductTabEditProduct_Click);
            // 
            // btnProductTabAddProduct
            // 
            this.btnProductTabAddProduct.Location = new System.Drawing.Point(16, 236);
            this.btnProductTabAddProduct.Name = "btnProductTabAddProduct";
            this.btnProductTabAddProduct.Size = new System.Drawing.Size(75, 35);
            this.btnProductTabAddProduct.TabIndex = 2;
            this.btnProductTabAddProduct.Text = "Add";
            this.btnProductTabAddProduct.UseVisualStyleBackColor = true;
            this.btnProductTabAddProduct.Click += new System.EventHandler(this.btnProductTabAddProduct_Click);
            // 
            // lstProductTabProducts
            // 
            this.lstProductTabProducts.FormattingEnabled = true;
            this.lstProductTabProducts.ItemHeight = 21;
            this.lstProductTabProducts.Location = new System.Drawing.Point(16, 32);
            this.lstProductTabProducts.Name = "lstProductTabProducts";
            this.lstProductTabProducts.Size = new System.Drawing.Size(288, 193);
            this.lstProductTabProducts.TabIndex = 1;
            this.lstProductTabProducts.SelectedIndexChanged += new System.EventHandler(this.lstProductTabProducts_SelectedIndexChanged);
            // 
            // tabSuppliers
            // 
            this.tabSuppliers.BackColor = System.Drawing.Color.SkyBlue;
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
            this.tabSuppliers.Location = new System.Drawing.Point(4, 33);
            this.tabSuppliers.Name = "tabSuppliers";
            this.tabSuppliers.Size = new System.Drawing.Size(644, 388);
            this.tabSuppliers.TabIndex = 2;
            this.tabSuppliers.Text = "Suppliers";
            // 
            // btnSupplierTabModify
            // 
            this.btnSupplierTabModify.Location = new System.Drawing.Point(96, 236);
            this.btnSupplierTabModify.Name = "btnSupplierTabModify";
            this.btnSupplierTabModify.Size = new System.Drawing.Size(75, 35);
            this.btnSupplierTabModify.TabIndex = 9;
            this.btnSupplierTabModify.Text = "Edit";
            this.btnSupplierTabModify.UseVisualStyleBackColor = true;
            this.btnSupplierTabModify.Click += new System.EventHandler(this.btnSupplierTabModify_Click);
            // 
            // btnSupplierTabAdd
            // 
            this.btnSupplierTabAdd.Location = new System.Drawing.Point(16, 236);
            this.btnSupplierTabAdd.Name = "btnSupplierTabAdd";
            this.btnSupplierTabAdd.Size = new System.Drawing.Size(75, 35);
            this.btnSupplierTabAdd.TabIndex = 8;
            this.btnSupplierTabAdd.Text = "Add";
            this.btnSupplierTabAdd.UseVisualStyleBackColor = true;
            this.btnSupplierTabAdd.Click += new System.EventHandler(this.btnSupplierTabAdd_Click);
            // 
            // lblSupplierTabProductId
            // 
            this.lblSupplierTabProductId.AutoSize = true;
            this.lblSupplierTabProductId.Location = new System.Drawing.Point(475, 243);
            this.lblSupplierTabProductId.Name = "lblSupplierTabProductId";
            this.lblSupplierTabProductId.Size = new System.Drawing.Size(80, 21);
            this.lblSupplierTabProductId.TabIndex = 7;
            this.lblSupplierTabProductId.Text = "ProductId:";
            // 
            // lblSupplierTabSupplierId
            // 
            this.lblSupplierTabSupplierId.AutoSize = true;
            this.lblSupplierTabSupplierId.Location = new System.Drawing.Point(177, 243);
            this.lblSupplierTabSupplierId.Name = "lblSupplierTabSupplierId";
            this.lblSupplierTabSupplierId.Size = new System.Drawing.Size(84, 21);
            this.lblSupplierTabSupplierId.TabIndex = 6;
            this.lblSupplierTabSupplierId.Text = "SupplierId:";
            // 
            // txtSupplierTabProductCount
            // 
            this.txtSupplierTabProductCount.Location = new System.Drawing.Point(561, 240);
            this.txtSupplierTabProductCount.Name = "txtSupplierTabProductCount";
            this.txtSupplierTabProductCount.ReadOnly = true;
            this.txtSupplierTabProductCount.Size = new System.Drawing.Size(37, 29);
            this.txtSupplierTabProductCount.TabIndex = 5;
            // 
            // txtSupplierTabSupplierId
            // 
            this.txtSupplierTabSupplierId.Location = new System.Drawing.Point(267, 240);
            this.txtSupplierTabSupplierId.Name = "txtSupplierTabSupplierId";
            this.txtSupplierTabSupplierId.ReadOnly = true;
            this.txtSupplierTabSupplierId.Size = new System.Drawing.Size(37, 29);
            this.txtSupplierTabSupplierId.TabIndex = 4;
            // 
            // lstSupplierTabProducts
            // 
            this.lstSupplierTabProducts.FormattingEnabled = true;
            this.lstSupplierTabProducts.ItemHeight = 21;
            this.lstSupplierTabProducts.Location = new System.Drawing.Point(310, 32);
            this.lstSupplierTabProducts.Name = "lstSupplierTabProducts";
            this.lstSupplierTabProducts.Size = new System.Drawing.Size(288, 193);
            this.lstSupplierTabProducts.TabIndex = 3;
            // 
            // lblSupplierTabProducts
            // 
            this.lblSupplierTabProducts.AutoSize = true;
            this.lblSupplierTabProducts.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSupplierTabProducts.Location = new System.Drawing.Point(310, 4);
            this.lblSupplierTabProducts.Name = "lblSupplierTabProducts";
            this.lblSupplierTabProducts.Size = new System.Drawing.Size(86, 25);
            this.lblSupplierTabProducts.TabIndex = 2;
            this.lblSupplierTabProducts.Text = "Products";
            // 
            // lblSupplierTabSuppliers
            // 
            this.lblSupplierTabSuppliers.AutoSize = true;
            this.lblSupplierTabSuppliers.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSupplierTabSuppliers.Location = new System.Drawing.Point(16, 4);
            this.lblSupplierTabSuppliers.Name = "lblSupplierTabSuppliers";
            this.lblSupplierTabSuppliers.Size = new System.Drawing.Size(90, 25);
            this.lblSupplierTabSuppliers.TabIndex = 1;
            this.lblSupplierTabSuppliers.Text = "Suppliers";
            // 
            // lstSupplierTabSuppliers
            // 
            this.lstSupplierTabSuppliers.FormattingEnabled = true;
            this.lstSupplierTabSuppliers.ItemHeight = 21;
            this.lstSupplierTabSuppliers.Location = new System.Drawing.Point(16, 32);
            this.lstSupplierTabSuppliers.Name = "lstSupplierTabSuppliers";
            this.lstSupplierTabSuppliers.Size = new System.Drawing.Size(288, 193);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(303, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 15);
            this.label1.TabIndex = 15;
            this.label1.Text = "Active Suppliers";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(518, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 15);
            this.label2.TabIndex = 16;
            this.label2.Text = "Available Suppliers";
            // 
            // lblPackagesTabPackages
            // 
            this.lblPackagesTabPackages.AutoSize = true;
            this.lblPackagesTabPackages.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPackagesTabPackages.Location = new System.Drawing.Point(16, 4);
            this.lblPackagesTabPackages.Name = "lblPackagesTabPackages";
            this.lblPackagesTabPackages.Size = new System.Drawing.Size(89, 25);
            this.lblPackagesTabPackages.TabIndex = 8;
            this.lblPackagesTabPackages.Text = "Packages";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(651, 425);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmMain";
            this.Text = "Travel Experts 0.1-PRE-ALPHA";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
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
        private System.Windows.Forms.ListBox lstPackageTabPackages;
        private System.Windows.Forms.Button btnPackageTabEditPackage;
        private System.Windows.Forms.Button btnPackageTabAddPackage;
        private System.Windows.Forms.Button btnPackageTabDeletePackage;
        private System.Windows.Forms.Label lblPackageTabPackages;
        private System.Windows.Forms.Button btnPackageTabRemoveProduct;
        private System.Windows.Forms.Button btnPackageTabAddProduct;
        private System.Windows.Forms.ListBox lstPackageTabAvailableProducts;
        private System.Windows.Forms.ListBox lstPackageTabActiveProducts;
        private System.Windows.Forms.Label lblPackageTabAvailableProducts;
        private System.Windows.Forms.Label lblPackageTabActiveProducts;
        private System.Windows.Forms.ListBox lstPackageTabActiveSuppliers;
        private System.Windows.Forms.ListBox lstPackageTabAvailableSuppliers;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPackagesTabPackages;
    }
}

