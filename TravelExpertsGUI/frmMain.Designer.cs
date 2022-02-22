
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gvPackageTabProductsSupplier = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPackageTabRemoveProductSupplier = new System.Windows.Forms.Button();
            this.gbPackageTabAddProductSupplier = new System.Windows.Forms.GroupBox();
            this.radPackageTabBySupplier = new System.Windows.Forms.RadioButton();
            this.radPackageTabByProduct = new System.Windows.Forms.RadioButton();
            this.btnPackageTabAddProduct = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPackageTabAvailableProducts = new System.Windows.Forms.Label();
            this.lstPackageTabAvailableSuppliers = new System.Windows.Forms.ListBox();
            this.lstPackageTabAvailableProducts = new System.Windows.Forms.ListBox();
            this.gbPackageTabSelectedPackage = new System.Windows.Forms.GroupBox();
            this.txtPackageTabPackageEndDate = new System.Windows.Forms.TextBox();
            this.txtPackageTabPackageStartDate = new System.Windows.Forms.TextBox();
            this.lblPackageAgencyCommission = new System.Windows.Forms.Label();
            this.btnPackageTabAddPackage = new System.Windows.Forms.Button();
            this.txtPackageTabPackageAgencyCommission = new System.Windows.Forms.TextBox();
            this.btnPackageTabDeletePackage = new System.Windows.Forms.Button();
            this.btnPackageTabEditPackage = new System.Windows.Forms.Button();
            this.txtPackageTabPackageBasePrice = new System.Windows.Forms.TextBox();
            this.lblPackagePrice = new System.Windows.Forms.Label();
            this.lblPackageEndDate = new System.Windows.Forms.Label();
            this.lblPackageStartDate = new System.Windows.Forms.Label();
            this.lblPackageTabPackageName = new System.Windows.Forms.Label();
            this.lblPackageDescription = new System.Windows.Forms.Label();
            this.txtPackageTabPackageDescription = new System.Windows.Forms.TextBox();
            this.lstPackageTabPackages = new System.Windows.Forms.ListBox();
            this.lblPackagesTabPackages = new System.Windows.Forms.Label();
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvPackageTabProductsSupplier)).BeginInit();
            this.gbPackageTabAddProductSupplier.SuspendLayout();
            this.gbPackageTabSelectedPackage.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabSuppliers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabSuppliers);
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1080, 665);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.SkyBlue;
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.gbPackageTabAddProductSupplier);
            this.tabPage1.Controls.Add(this.gbPackageTabSelectedPackage);
            this.tabPage1.Controls.Add(this.lstPackageTabPackages);
            this.tabPage1.Controls.Add(this.lblPackagesTabPackages);
            this.tabPage1.Location = new System.Drawing.Point(4, 33);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1072, 628);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Packages";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.gvPackageTabProductsSupplier);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnPackageTabRemoveProductSupplier);
            this.groupBox1.Location = new System.Drawing.Point(619, 307);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(435, 315);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Product Suppliers";
            // 
            // gvPackageTabProductsSupplier
            // 
            this.gvPackageTabProductsSupplier.AllowUserToAddRows = false;
            this.gvPackageTabProductsSupplier.AllowUserToDeleteRows = false;
            this.gvPackageTabProductsSupplier.AllowUserToOrderColumns = true;
            this.gvPackageTabProductsSupplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvPackageTabProductsSupplier.Location = new System.Drawing.Point(16, 85);
            this.gvPackageTabProductsSupplier.MultiSelect = false;
            this.gvPackageTabProductsSupplier.Name = "gvPackageTabProductsSupplier";
            this.gvPackageTabProductsSupplier.RowHeadersVisible = false;
            this.gvPackageTabProductsSupplier.RowTemplate.Height = 25;
            this.gvPackageTabProductsSupplier.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvPackageTabProductsSupplier.Size = new System.Drawing.Size(400, 172);
            this.gvPackageTabProductsSupplier.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(127, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 21);
            this.label3.TabIndex = 24;
            this.label3.Text = "Active Product Suppliers";
            // 
            // btnPackageTabRemoveProductSupplier
            // 
            this.btnPackageTabRemoveProductSupplier.Location = new System.Drawing.Point(179, 269);
            this.btnPackageTabRemoveProductSupplier.Name = "btnPackageTabRemoveProductSupplier";
            this.btnPackageTabRemoveProductSupplier.Size = new System.Drawing.Size(75, 35);
            this.btnPackageTabRemoveProductSupplier.TabIndex = 11;
            this.btnPackageTabRemoveProductSupplier.Text = "Remove";
            this.btnPackageTabRemoveProductSupplier.UseVisualStyleBackColor = true;
            this.btnPackageTabRemoveProductSupplier.Click += new System.EventHandler(this.btnPackageTabRemoveProductSupplier_Click);
            // 
            // gbPackageTabAddProductSupplier
            // 
            this.gbPackageTabAddProductSupplier.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbPackageTabAddProductSupplier.Controls.Add(this.radPackageTabBySupplier);
            this.gbPackageTabAddProductSupplier.Controls.Add(this.radPackageTabByProduct);
            this.gbPackageTabAddProductSupplier.Controls.Add(this.btnPackageTabAddProduct);
            this.gbPackageTabAddProductSupplier.Controls.Add(this.label2);
            this.gbPackageTabAddProductSupplier.Controls.Add(this.lblPackageTabAvailableProducts);
            this.gbPackageTabAddProductSupplier.Controls.Add(this.lstPackageTabAvailableSuppliers);
            this.gbPackageTabAddProductSupplier.Controls.Add(this.lstPackageTabAvailableProducts);
            this.gbPackageTabAddProductSupplier.Location = new System.Drawing.Point(16, 307);
            this.gbPackageTabAddProductSupplier.Name = "gbPackageTabAddProductSupplier";
            this.gbPackageTabAddProductSupplier.Size = new System.Drawing.Size(581, 316);
            this.gbPackageTabAddProductSupplier.TabIndex = 25;
            this.gbPackageTabAddProductSupplier.TabStop = false;
            this.gbPackageTabAddProductSupplier.Text = "Add Product Supplier";
            // 
            // radPackageTabBySupplier
            // 
            this.radPackageTabBySupplier.AutoSize = true;
            this.radPackageTabBySupplier.Location = new System.Drawing.Point(292, 33);
            this.radPackageTabBySupplier.Name = "radPackageTabBySupplier";
            this.radPackageTabBySupplier.Size = new System.Drawing.Size(107, 25);
            this.radPackageTabBySupplier.TabIndex = 18;
            this.radPackageTabBySupplier.Text = "By Supplier";
            this.radPackageTabBySupplier.UseVisualStyleBackColor = true;
            this.radPackageTabBySupplier.CheckedChanged += new System.EventHandler(this.radGrpPackageTabAddProductsSupplier_CheckChanged);
            // 
            // radPackageTabByProduct
            // 
            this.radPackageTabByProduct.AutoSize = true;
            this.radPackageTabByProduct.Checked = true;
            this.radPackageTabByProduct.Location = new System.Drawing.Point(33, 33);
            this.radPackageTabByProduct.Name = "radPackageTabByProduct";
            this.radPackageTabByProduct.Size = new System.Drawing.Size(103, 25);
            this.radPackageTabByProduct.TabIndex = 17;
            this.radPackageTabByProduct.TabStop = true;
            this.radPackageTabByProduct.Text = "By Product";
            this.radPackageTabByProduct.UseVisualStyleBackColor = true;
            this.radPackageTabByProduct.CheckedChanged += new System.EventHandler(this.radGrpPackageTabAddProductsSupplier_CheckChanged);
            // 
            // btnPackageTabAddProduct
            // 
            this.btnPackageTabAddProduct.Location = new System.Drawing.Point(235, 269);
            this.btnPackageTabAddProduct.Name = "btnPackageTabAddProduct";
            this.btnPackageTabAddProduct.Size = new System.Drawing.Size(75, 31);
            this.btnPackageTabAddProduct.TabIndex = 10;
            this.btnPackageTabAddProduct.Text = "Add";
            this.btnPackageTabAddProduct.UseVisualStyleBackColor = true;
            this.btnPackageTabAddProduct.Click += new System.EventHandler(this.btnPackageTabAddProductSupplier_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(289, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 21);
            this.label2.TabIndex = 16;
            this.label2.Text = "Available Suppliers";
            // 
            // lblPackageTabAvailableProducts
            // 
            this.lblPackageTabAvailableProducts.AutoSize = true;
            this.lblPackageTabAvailableProducts.Location = new System.Drawing.Point(30, 61);
            this.lblPackageTabAvailableProducts.Name = "lblPackageTabAvailableProducts";
            this.lblPackageTabAvailableProducts.Size = new System.Drawing.Size(138, 21);
            this.lblPackageTabAvailableProducts.TabIndex = 1;
            this.lblPackageTabAvailableProducts.Text = "Available Products";
            // 
            // lstPackageTabAvailableSuppliers
            // 
            this.lstPackageTabAvailableSuppliers.FormattingEnabled = true;
            this.lstPackageTabAvailableSuppliers.ItemHeight = 21;
            this.lstPackageTabAvailableSuppliers.Location = new System.Drawing.Point(289, 85);
            this.lstPackageTabAvailableSuppliers.Name = "lstPackageTabAvailableSuppliers";
            this.lstPackageTabAvailableSuppliers.Size = new System.Drawing.Size(260, 172);
            this.lstPackageTabAvailableSuppliers.TabIndex = 14;
            this.lstPackageTabAvailableSuppliers.SelectedIndexChanged += new System.EventHandler(this.lstPackageTabSuppliers_SelectedIndexChanged);
            // 
            // lstPackageTabAvailableProducts
            // 
            this.lstPackageTabAvailableProducts.FormattingEnabled = true;
            this.lstPackageTabAvailableProducts.ItemHeight = 21;
            this.lstPackageTabAvailableProducts.Location = new System.Drawing.Point(30, 85);
            this.lstPackageTabAvailableProducts.Name = "lstPackageTabAvailableProducts";
            this.lstPackageTabAvailableProducts.Size = new System.Drawing.Size(230, 172);
            this.lstPackageTabAvailableProducts.TabIndex = 9;
            this.lstPackageTabAvailableProducts.SelectedIndexChanged += new System.EventHandler(this.lstPackageTabProducts_SelectedIndexChanged);
            // 
            // gbPackageTabSelectedPackage
            // 
            this.gbPackageTabSelectedPackage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbPackageTabSelectedPackage.Controls.Add(this.txtPackageTabPackageEndDate);
            this.gbPackageTabSelectedPackage.Controls.Add(this.txtPackageTabPackageStartDate);
            this.gbPackageTabSelectedPackage.Controls.Add(this.lblPackageAgencyCommission);
            this.gbPackageTabSelectedPackage.Controls.Add(this.btnPackageTabAddPackage);
            this.gbPackageTabSelectedPackage.Controls.Add(this.txtPackageTabPackageAgencyCommission);
            this.gbPackageTabSelectedPackage.Controls.Add(this.btnPackageTabDeletePackage);
            this.gbPackageTabSelectedPackage.Controls.Add(this.btnPackageTabEditPackage);
            this.gbPackageTabSelectedPackage.Controls.Add(this.txtPackageTabPackageBasePrice);
            this.gbPackageTabSelectedPackage.Controls.Add(this.lblPackagePrice);
            this.gbPackageTabSelectedPackage.Controls.Add(this.lblPackageEndDate);
            this.gbPackageTabSelectedPackage.Controls.Add(this.lblPackageStartDate);
            this.gbPackageTabSelectedPackage.Controls.Add(this.lblPackageTabPackageName);
            this.gbPackageTabSelectedPackage.Controls.Add(this.lblPackageDescription);
            this.gbPackageTabSelectedPackage.Controls.Add(this.txtPackageTabPackageDescription);
            this.gbPackageTabSelectedPackage.Location = new System.Drawing.Point(325, 6);
            this.gbPackageTabSelectedPackage.Name = "gbPackageTabSelectedPackage";
            this.gbPackageTabSelectedPackage.Size = new System.Drawing.Size(488, 295);
            this.gbPackageTabSelectedPackage.TabIndex = 25;
            this.gbPackageTabSelectedPackage.TabStop = false;
            this.gbPackageTabSelectedPackage.Text = "Selected Package";
            // 
            // txtPackageTabPackageEndDate
            // 
            this.txtPackageTabPackageEndDate.Location = new System.Drawing.Point(115, 190);
            this.txtPackageTabPackageEndDate.Name = "txtPackageTabPackageEndDate";
            this.txtPackageTabPackageEndDate.ReadOnly = true;
            this.txtPackageTabPackageEndDate.Size = new System.Drawing.Size(101, 29);
            this.txtPackageTabPackageEndDate.TabIndex = 27;
            // 
            // txtPackageTabPackageStartDate
            // 
            this.txtPackageTabPackageStartDate.Location = new System.Drawing.Point(115, 144);
            this.txtPackageTabPackageStartDate.Name = "txtPackageTabPackageStartDate";
            this.txtPackageTabPackageStartDate.ReadOnly = true;
            this.txtPackageTabPackageStartDate.Size = new System.Drawing.Size(100, 29);
            this.txtPackageTabPackageStartDate.TabIndex = 26;
            // 
            // lblPackageAgencyCommission
            // 
            this.lblPackageAgencyCommission.AutoSize = true;
            this.lblPackageAgencyCommission.Location = new System.Drawing.Point(223, 183);
            this.lblPackageAgencyCommission.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPackageAgencyCommission.MaximumSize = new System.Drawing.Size(100, 0);
            this.lblPackageAgencyCommission.Name = "lblPackageAgencyCommission";
            this.lblPackageAgencyCommission.Size = new System.Drawing.Size(100, 42);
            this.lblPackageAgencyCommission.TabIndex = 21;
            this.lblPackageAgencyCommission.Text = "Agency Commission:";
            // 
            // btnPackageTabAddPackage
            // 
            this.btnPackageTabAddPackage.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPackageTabAddPackage.Location = new System.Drawing.Point(18, 240);
            this.btnPackageTabAddPackage.Name = "btnPackageTabAddPackage";
            this.btnPackageTabAddPackage.Size = new System.Drawing.Size(75, 35);
            this.btnPackageTabAddPackage.TabIndex = 5;
            this.btnPackageTabAddPackage.Text = "New";
            this.btnPackageTabAddPackage.UseVisualStyleBackColor = true;
            this.btnPackageTabAddPackage.Click += new System.EventHandler(this.btnPackageTabAddPackage_Click);
            // 
            // txtPackageTabPackageAgencyCommission
            // 
            this.txtPackageTabPackageAgencyCommission.Location = new System.Drawing.Point(331, 190);
            this.txtPackageTabPackageAgencyCommission.Margin = new System.Windows.Forms.Padding(4);
            this.txtPackageTabPackageAgencyCommission.Name = "txtPackageTabPackageAgencyCommission";
            this.txtPackageTabPackageAgencyCommission.ReadOnly = true;
            this.txtPackageTabPackageAgencyCommission.Size = new System.Drawing.Size(127, 29);
            this.txtPackageTabPackageAgencyCommission.TabIndex = 25;
            // 
            // btnPackageTabDeletePackage
            // 
            this.btnPackageTabDeletePackage.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPackageTabDeletePackage.Location = new System.Drawing.Point(383, 240);
            this.btnPackageTabDeletePackage.Name = "btnPackageTabDeletePackage";
            this.btnPackageTabDeletePackage.Size = new System.Drawing.Size(75, 35);
            this.btnPackageTabDeletePackage.TabIndex = 7;
            this.btnPackageTabDeletePackage.Text = "Delete";
            this.btnPackageTabDeletePackage.UseVisualStyleBackColor = true;
            this.btnPackageTabDeletePackage.Click += new System.EventHandler(this.btnPackageTabDeletePackage_Click);
            // 
            // btnPackageTabEditPackage
            // 
            this.btnPackageTabEditPackage.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPackageTabEditPackage.Location = new System.Drawing.Point(101, 240);
            this.btnPackageTabEditPackage.Name = "btnPackageTabEditPackage";
            this.btnPackageTabEditPackage.Size = new System.Drawing.Size(75, 35);
            this.btnPackageTabEditPackage.TabIndex = 6;
            this.btnPackageTabEditPackage.Text = "Edit";
            this.btnPackageTabEditPackage.UseVisualStyleBackColor = true;
            this.btnPackageTabEditPackage.Click += new System.EventHandler(this.btnPackageTabEditPackage_Click);
            // 
            // txtPackageTabPackageBasePrice
            // 
            this.txtPackageTabPackageBasePrice.Location = new System.Drawing.Point(331, 144);
            this.txtPackageTabPackageBasePrice.Margin = new System.Windows.Forms.Padding(4);
            this.txtPackageTabPackageBasePrice.Name = "txtPackageTabPackageBasePrice";
            this.txtPackageTabPackageBasePrice.ReadOnly = true;
            this.txtPackageTabPackageBasePrice.Size = new System.Drawing.Size(127, 29);
            this.txtPackageTabPackageBasePrice.TabIndex = 24;
            // 
            // lblPackagePrice
            // 
            this.lblPackagePrice.AutoSize = true;
            this.lblPackagePrice.Location = new System.Drawing.Point(240, 148);
            this.lblPackagePrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPackagePrice.Name = "lblPackagePrice";
            this.lblPackagePrice.Size = new System.Drawing.Size(83, 21);
            this.lblPackagePrice.TabIndex = 20;
            this.lblPackagePrice.Text = "Base Price:";
            // 
            // lblPackageEndDate
            // 
            this.lblPackageEndDate.AutoSize = true;
            this.lblPackageEndDate.Location = new System.Drawing.Point(33, 194);
            this.lblPackageEndDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPackageEndDate.Name = "lblPackageEndDate";
            this.lblPackageEndDate.Size = new System.Drawing.Size(75, 21);
            this.lblPackageEndDate.TabIndex = 18;
            this.lblPackageEndDate.Text = "End Date:";
            // 
            // lblPackageStartDate
            // 
            this.lblPackageStartDate.AutoSize = true;
            this.lblPackageStartDate.Location = new System.Drawing.Point(27, 148);
            this.lblPackageStartDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPackageStartDate.Name = "lblPackageStartDate";
            this.lblPackageStartDate.Size = new System.Drawing.Size(81, 21);
            this.lblPackageStartDate.TabIndex = 17;
            this.lblPackageStartDate.Text = "Start Date:";
            // 
            // lblPackageTabPackageName
            // 
            this.lblPackageTabPackageName.AutoSize = true;
            this.lblPackageTabPackageName.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPackageTabPackageName.Location = new System.Drawing.Point(152, 26);
            this.lblPackageTabPackageName.Name = "lblPackageTabPackageName";
            this.lblPackageTabPackageName.Size = new System.Drawing.Size(171, 32);
            this.lblPackageTabPackageName.TabIndex = 17;
            this.lblPackageTabPackageName.Text = "Package Name";
            this.lblPackageTabPackageName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPackageDescription
            // 
            this.lblPackageDescription.AutoSize = true;
            this.lblPackageDescription.Location = new System.Drawing.Point(16, 84);
            this.lblPackageDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPackageDescription.Name = "lblPackageDescription";
            this.lblPackageDescription.Size = new System.Drawing.Size(92, 21);
            this.lblPackageDescription.TabIndex = 19;
            this.lblPackageDescription.Text = "Description:";
            // 
            // txtPackageTabPackageDescription
            // 
            this.txtPackageTabPackageDescription.BackColor = System.Drawing.SystemColors.Control;
            this.txtPackageTabPackageDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPackageTabPackageDescription.Location = new System.Drawing.Point(116, 68);
            this.txtPackageTabPackageDescription.Margin = new System.Windows.Forms.Padding(4);
            this.txtPackageTabPackageDescription.MaxLength = 50;
            this.txtPackageTabPackageDescription.Multiline = true;
            this.txtPackageTabPackageDescription.Name = "txtPackageTabPackageDescription";
            this.txtPackageTabPackageDescription.ReadOnly = true;
            this.txtPackageTabPackageDescription.Size = new System.Drawing.Size(342, 59);
            this.txtPackageTabPackageDescription.TabIndex = 23;
            // 
            // lstPackageTabPackages
            // 
            this.lstPackageTabPackages.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstPackageTabPackages.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstPackageTabPackages.FormattingEnabled = true;
            this.lstPackageTabPackages.ItemHeight = 21;
            this.lstPackageTabPackages.Location = new System.Drawing.Point(16, 32);
            this.lstPackageTabPackages.Name = "lstPackageTabPackages";
            this.lstPackageTabPackages.Size = new System.Drawing.Size(290, 256);
            this.lstPackageTabPackages.TabIndex = 3;
            this.lstPackageTabPackages.SelectedIndexChanged += new System.EventHandler(this.lstPackageTabPackages_SelectedIndexChanged);
            // 
            // lblPackagesTabPackages
            // 
            this.lblPackagesTabPackages.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPackagesTabPackages.AutoSize = true;
            this.lblPackagesTabPackages.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPackagesTabPackages.Location = new System.Drawing.Point(16, 6);
            this.lblPackagesTabPackages.Name = "lblPackagesTabPackages";
            this.lblPackagesTabPackages.Size = new System.Drawing.Size(155, 25);
            this.lblPackagesTabPackages.TabIndex = 8;
            this.lblPackagesTabPackages.Text = "Select a Package:";
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
            this.tabPage2.Size = new System.Drawing.Size(1072, 628);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Products";
            // 
            // lblProductTabSupplierCount
            // 
            this.lblProductTabSupplierCount.AutoSize = true;
            this.lblProductTabSupplierCount.Location = new System.Drawing.Point(417, 244);
            this.lblProductTabSupplierCount.Name = "lblProductTabSupplierCount";
            this.lblProductTabSupplierCount.Size = new System.Drawing.Size(118, 21);
            this.lblProductTabSupplierCount.TabIndex = 13;
            this.lblProductTabSupplierCount.Text = "Total Suppliers: ";
            // 
            // lblProductTabProductId
            // 
            this.lblProductTabProductId.AutoSize = true;
            this.lblProductTabProductId.Location = new System.Drawing.Point(175, 244);
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
            this.txtProductTabTotalSuppliers.Location = new System.Drawing.Point(541, 240);
            this.txtProductTabTotalSuppliers.Name = "txtProductTabTotalSuppliers";
            this.txtProductTabTotalSuppliers.Size = new System.Drawing.Size(57, 29);
            this.txtProductTabTotalSuppliers.TabIndex = 9;
            // 
            // txtProductTabProductID
            // 
            this.txtProductTabProductID.BackColor = System.Drawing.SystemColors.Info;
            this.txtProductTabProductID.Enabled = false;
            this.txtProductTabProductID.Location = new System.Drawing.Point(267, 240);
            this.txtProductTabProductID.Name = "txtProductTabProductID";
            this.txtProductTabProductID.Size = new System.Drawing.Size(70, 29);
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
            this.tabSuppliers.Size = new System.Drawing.Size(1072, 628);
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
            this.lblSupplierTabProductId.Location = new System.Drawing.Point(425, 243);
            this.lblSupplierTabProductId.Name = "lblSupplierTabProductId";
            this.lblSupplierTabProductId.Size = new System.Drawing.Size(110, 21);
            this.lblSupplierTabProductId.TabIndex = 7;
            this.lblSupplierTabProductId.Text = "Total Products:";
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
            this.txtSupplierTabProductCount.BackColor = System.Drawing.SystemColors.Info;
            this.txtSupplierTabProductCount.Location = new System.Drawing.Point(541, 240);
            this.txtSupplierTabProductCount.Name = "txtSupplierTabProductCount";
            this.txtSupplierTabProductCount.ReadOnly = true;
            this.txtSupplierTabProductCount.Size = new System.Drawing.Size(57, 29);
            this.txtSupplierTabProductCount.TabIndex = 5;
            // 
            // txtSupplierTabSupplierId
            // 
            this.txtSupplierTabSupplierId.BackColor = System.Drawing.SystemColors.Info;
            this.txtSupplierTabSupplierId.Location = new System.Drawing.Point(267, 240);
            this.txtSupplierTabSupplierId.Name = "txtSupplierTabSupplierId";
            this.txtSupplierTabSupplierId.ReadOnly = true;
            this.txtSupplierTabSupplierId.Size = new System.Drawing.Size(70, 29);
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
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TravelExpertsGUI.Properties.Resources.clippy;
            this.pictureBox1.Location = new System.Drawing.Point(825, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(229, 287);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1082, 668);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmMain";
            this.Text = "Travel Experts Database Manager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvPackageTabProductsSupplier)).EndInit();
            this.gbPackageTabAddProductSupplier.ResumeLayout(false);
            this.gbPackageTabAddProductSupplier.PerformLayout();
            this.gbPackageTabSelectedPackage.ResumeLayout(false);
            this.gbPackageTabSelectedPackage.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabSuppliers.ResumeLayout(false);
            this.tabSuppliers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.GroupBox gbPackageTabAddProductSupplier;
        private System.Windows.Forms.RadioButton radPackageTabBySupplier;
        private System.Windows.Forms.RadioButton radPackageTabByProduct;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPackageTabAvailableProducts;
        private System.Windows.Forms.ListBox lstPackageTabAvailableSuppliers;
        private System.Windows.Forms.ListBox lstPackageTabAvailableProducts;
        private System.Windows.Forms.Button btnPackageTabAddProduct;
        private System.Windows.Forms.GroupBox gbPackageTabSelectedPackage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnPackageTabDeletePackage;
        private System.Windows.Forms.Button btnPackageTabEditPackage;
        private System.Windows.Forms.Button btnPackageTabRemoveProductSupplier;
        private System.Windows.Forms.ListBox lstPackageTabPackages;
        private System.Windows.Forms.Button btnPackageTabAddPackage;
        private System.Windows.Forms.Label lblPackagesTabPackages;
        private System.Windows.Forms.DataGridView gvPackageTabProductsSupplier;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblPackageAgencyCommission;
        private System.Windows.Forms.TextBox txtPackageTabPackageAgencyCommission;
        private System.Windows.Forms.TextBox txtPackageTabPackageBasePrice;
        private System.Windows.Forms.Label lblPackagePrice;
        private System.Windows.Forms.Label lblPackageEndDate;
        private System.Windows.Forms.Label lblPackageStartDate;
        private System.Windows.Forms.Label lblPackageTabPackageName;
        private System.Windows.Forms.Label lblPackageDescription;
        private System.Windows.Forms.TextBox txtPackageTabPackageDescription;
        private System.Windows.Forms.TextBox txtPackageTabPackageEndDate;
        private System.Windows.Forms.TextBox txtPackageTabPackageStartDate;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

