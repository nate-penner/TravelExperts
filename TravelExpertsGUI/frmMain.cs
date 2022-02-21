using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using TravelExpertsData;
using TravelExpertsDataAPI;

/* A GUI design to allow for easy database management and interaction
 * Form serves as home page for application, allowing user to cycle through various pages to view particular data
 * Authors: Nate Penner, Daniel Palmer, Alex Cress
 * 2022-01-17
 */

namespace TravelExpertsGUI
{
    public partial class frmMain : Form
    {
        private Supplier lstSupplierTabsupplier;

        // Accepts the enterPage to let program close
        public frmEnterPage EnterPage = null;

        public frmMain()
        {
            InitializeComponent();
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            SupplierTabRenderList();

            // Load the products tab
            loadProductsTab();

            //Load package panel
            InitializePackageTab();
        }

        // Loads a list of products from the database into the Products tab
        // Author: Nate Penner
        private void loadProductsTab()
        {
            lstProductTabProducts.DataSource = ProductDB.GetProducts()
                .OrderBy(p => p.ProdName).ToList();
            lstProductTabProducts.DisplayMember = "ProdName";
        }

        // Loads a list of products from the database into the Products tab
        // and selects the Product passed to the method
        // Author: Nate Penner
        private void loadProductsTab(Product selected)
        {
            // Get the products from the db
            List<Product> products = ProductDB.GetProducts()
                .OrderBy(p => p.ProdName).ToList();

            // Load them into the list and select the correct one
            lstProductTabProducts.DataSource = products;
            lstProductTabProducts.SelectedItem = products.Where(p => p.ProductId == selected.ProductId)
                .Single();
        }

        // Renders the product list on the SupplierTab
        // Author: Daniel Palmer
        private void SupplierTabRenderList()
        {
            // Sets up the supplier tab form controls
            List<Supplier> SupplierTabSuppliers = TravelExpertsDataAPI.SupplierDB.GetSuppliers();
            // Fills the supplier listbox with all suppliers, clearing it before loading
            lstSupplierTabSuppliers.DataSource = null;
            lstSupplierTabSuppliers.DataSource = SupplierTabSuppliers;
            lstSupplierTabSuppliers.DisplayMember = "SupName";
        }

        private void SupplierTabRenderProductsList(List<Product> product)
        {
            txtSupplierTabSupplierId.Text = lstSupplierTabsupplier.SupplierId.ToString();
            txtSupplierTabProductCount.Text = product.Count().ToString();
            lstSupplierTabProducts.DataSource = product;
            lstSupplierTabProducts.DisplayMember = "ProdName";
        }

        // Populates the tab with details about selected supplier
        // Author: Daniel Palmer
        private void lstSupplierTabSuppliers_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Makes sure there is an index selected in list
            if (lstSupplierTabSuppliers.SelectedValue != null)
            {
                // Establishes the selected supplier and collects all products the supplier offers
                lstSupplierTabsupplier = (Supplier)lstSupplierTabSuppliers.SelectedValue;

                List<Product> product = TravelExpertsDataAPI.ProductDB.GetProducts(lstSupplierTabsupplier);

                // Displays all the supplier and product values to the form
                SupplierTabRenderProductsList(product);
            }


        }

        // Handles the event when changing the product list selection
        // Author: Nate Penner
        private void lstProductTabProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the Product from the listbox selection
            Product product = productTabGetProductSelection();

            // Show the product ID
            txtProductTabProductID.Text = product.ProductId.ToString();

            // Load the supplier for this product
            productTabLoadSuppliers(product);
        }

        // Handles the Add product button click in the Products tab
        // Author: Nate Penner
        private void btnProductTabAddProduct_Click(object sender, EventArgs e)
        {
            // Create a new form to enter data
            frmProducts productsForm = new frmProducts();
            productsForm.IsAdd = true;

            // Open as modal form, add operation
            DialogResult result = productsForm.ShowDialog();

            // If it returned ok
            if (result == DialogResult.OK)
            {
                // Add the product to the database
                ProductDB.AddProduct(productsForm.SelectedProduct);

                // Add any suppliers chosen for this product to the database
                ProductSupplierDB.AddProductSuppliers(
                    productsForm.SelectedProduct, productsForm.ProductSuppliers
                    );

                // Reload the products tab product list, selecting the new product
                loadProductsTab(productsForm.SelectedProduct);
                
                // Reload the products tab supplier list for the new product
                productTabLoadSuppliers(productsForm.SelectedProduct);
            }
            else if (result != DialogResult.Cancel)
            {
                // Show an error message
                MessageBox.Show("Unable to add the product!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Handles the Edit product button in the Products tab
        // Author: Nate Penner
        private void btnProductTabEditProduct_Click(object sender, EventArgs e)
        {
            // Show a new form to modify the product data
            frmProducts productsForm = new frmProducts();
            productsForm.IsAdd = false;

            // Get the product selected from the list
            productsForm.SelectedProduct = productTabGetProductSelection();

            // Open as modal form, for modify/edit operation
            DialogResult result = productsForm.ShowDialog();

            // If everything is OK
            if (result == DialogResult.OK)
            {
                // Update the suppliers for the product, retrieving any package names
                // conflicting with any Product suppliers
                List<String> packageNames = ProductSupplierDB.UpdateProductSuppliers(
                    productsForm.SelectedProduct, productsForm.ProductSuppliers
                    );

                // Update the product (name)
                ProductDB.UpdateProduct(productsForm.SelectedProduct);

                // Show an error message if there managed to be any conflicts.
                // This should never run because it is checked in the form!
                if (packageNames != null && packageNames.Count > 0)
                {

                    MessageBox.Show("The following packages blocked some deletions: " +
                        $"{string.Join(", ", packageNames.ToArray())}");
                }

                // Reload the product tab suppliers list with the updated
                // suppliers for the selected product
                productTabLoadSuppliers(productsForm.SelectedProduct);


                // Update the product tab product list with the new product
                // name and select it in the list
                int selectedIndex = lstProductTabProducts.SelectedIndex;
                loadProductsTab();
                lstProductTabProducts.SelectedIndex = selectedIndex;
                // Updates the Product list in the supplier tab. Fixes edge case where supplier products do not update
                // when the selected supplier is removed as a supplier of a product
                List<Product> SupplierTabproducts = TravelExpertsDataAPI.ProductDB.GetProducts(lstSupplierTabsupplier);
                SupplierTabRenderProductsList(SupplierTabproducts);
            } else if (result != DialogResult.Cancel)
            {
                // Show an error message
                MessageBox.Show("Unable to edit the product or suppliers!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Get the selected Product from the products list in the Product tab
        // Author: Nate Penner
        private Product productTabGetProductSelection()
        {
            return (Product)lstProductTabProducts.SelectedItem;
        }

        // Loads a list suppliers for the Product in the product tab
        // Author: Nate Penner
        private void productTabLoadSuppliers(Product product)
        {
            // Get the list of suppliers for the selected product
            List<Supplier> suppliers = SupplierDB
                .GetSuppliers(product)
                .OrderBy(s => s.SupName).ToList();

            // Display the supplier data in the list
            lstProductTabSuppliers.DataSource = suppliers;
            lstProductTabSuppliers.DisplayMember = "SupName";

            // Show suppliers count
            txtProductTabTotalSuppliers.Text = suppliers.Count.ToString();
        }

        // Implements the SupplierTabAdd on click method, opens the add/modify form in add mode
        // Author: Daniel Palmer
        private void btnSupplierTabAdd_Click(object sender, EventArgs e)
        {
            frmAddModifySuppliers AddForm = new frmAddModifySuppliers();
            AddForm.IsAdd = true;
            AddForm.CurrentSupplier = new Supplier();

            DialogResult result = AddForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                // Grabs the Supplier and product created by the form
                Supplier CurrentSupplier = AddForm.CurrentSupplier;
                List<Product> AddedProducts = AddForm.AddedProducts;
                SupplierDB.AddSupplier(CurrentSupplier);

                // Loop over all products in the generated product list, and add them with the supplier to the ProductsSupplier Table
                foreach (Product prod in AddedProducts)
                {
                    ProductSupplierDB.AddProductSupplier(prod, CurrentSupplier);
                }
                //Re-renders the list
                SupplierTabRenderList();
            }
        }

        // Implements the SupplierTabModify on click method, opens the add/modify form in modify mode
        // Author: Daniel Palmer
        private void btnSupplierTabModify_Click(object sender, EventArgs e)
        {
            frmAddModifySuppliers ModifyForm = new frmAddModifySuppliers();
            ModifyForm.IsAdd = false;
            ModifyForm.CurrentSupplier = (Supplier)lstSupplierTabSuppliers.SelectedValue;

            DialogResult result = ModifyForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                // Grabs all changes to the supplier data and updates the table
                Supplier CurrentSupplier = ModifyForm.CurrentSupplier;
                SupplierDB.UpdateSupplier(CurrentSupplier);
            }
            //Re-renders the list
            SupplierTabRenderList();
        }

        private void InitializePackageTab()
        {
            PackageTabRenderPackages();
            PackageTabRenderProducts();
            PackageTabRenderSuppliers();
            PackageTabRenderProductSuppliers();
        }

        //////////////////////////////////////////////// Package Tab Code \\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\

        //************************************************** Button Handlers ******************************************************

        // Author: Alex Cress
        /// <summary>
        /// Opens a form to accept user input for a new Package. If valid, the new Package will be saved to the database.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPackageTabAddPackage_Click(object sender, EventArgs e)
        {
            //Get input from user
            frmAddModifyPackage inputForm = new frmAddModifyPackage(FORM_ACTION.CREATE);
            DialogResult result = inputForm.ShowDialog();

            //All input is valid and the user wishes to add a new product
            if (result == DialogResult.OK)
            {
                //Update DB
                try
                {
                    PackageDB.AddPackage(inputForm.package);
                }
                //TODO Alex- more specific error handling
                catch (Exception ex)
                {
                    MessageBox.Show($"Error while adding new Package to the database: {ex.Message}", "Database Error");
                }

                //Refresh table
                PackageTabRenderPackages();
            }
        }

        // Author: Alex Cress
        /// <summary>
        /// Opens a form to accept user input for modifying an existing Package. If valid, the modifications will be saved to the database.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPackageTabEditPackage_Click(object sender, EventArgs e)
        {
            //Check if a row is selected (should always be selected by default)           
            if (lstPackageTabPackages.SelectedItem == null)
            {
                MessageBox.Show("Please select a Package from the list to modify.");
                return;
            }

            //Get the selected Package from the table
            Package selectedPackage = (Package)lstPackageTabPackages.SelectedItem;

            //Populate/show form
            frmAddModifyPackage inputForm = new frmAddModifyPackage(FORM_ACTION.UPDATE);
            inputForm.package = selectedPackage;
            DialogResult result = inputForm.ShowDialog();

            //If all input is valid and the user wishes to save their changes
            if (result == DialogResult.OK)
            {
                try
                {
                    PackageDB.UpdatePackage(inputForm.package);
                }
                //TODO Alex- more specific error handling
                catch (Exception ex)
                {
                    MessageBox.Show($"Error while modifying PackageId {inputForm.package.PackageId}: {ex.Message}", "Database Error");
                }

                PackageTabRenderPackages(lstPackageTabPackages.SelectedIndex);
            }
        }

        // Author: Alex Cress
        /// <summary>
        /// Deletes the selected Package from the database.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPackageTabDeletePackage_Click(object sender, EventArgs e)
        {
            //Check if a row is selected (should always be selected by default)           
            if (lstPackageTabPackages.SelectedItem == null)
            {
                MessageBox.Show("Please select a Package from the list to delete.");
                return;
            }

            //Get the selected Package from the table
            Package selectedPackage = PackageTabGetSelectedPackage();

            //Confirm that the user wants to delete
            DialogResult answer = MessageBox.Show($"Do you want to delete {selectedPackage.PkgName}?",
                "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (answer == DialogResult.Yes)
            {
                PackageDB.RemovePackage(selectedPackage);

                PackageTabRenderPackages();
            }
        }

        // Author: Alex Cress
        /// <summary>
        /// Adds a ProductSupplier to the selected Package.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPackageTabAddProductSupplier_Click(object sender, EventArgs e)
        {
            //Get selected values
            Package selectedPackage = PackageTabGetSelectedPackage();
            Product selectedProduct = PackageTabGetSelectedProduct();
            Supplier selectedSupplier = PackageTabGetSelectedSupplier();
            ProductsSupplier productsSupplier;

            if (selectedPackage != null && selectedProduct != null)
            {
                productsSupplier = ProductSupplierDB.GetProductsSupplier(selectedProduct, selectedSupplier);

                if (productsSupplier != null)
                {
                    PackageDB.AddProduct(selectedPackage, productsSupplier);

                    PackageTabRenderSuppliers();
                    PackageTabRenderProductSuppliers();
                }
            }
        }

        // Author: Alex Cress
        /// <summary>
        /// Removes the selected ProductSupplier from the selected Package.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPackageTabRemoveProductSupplier_Click(object sender, EventArgs e)
        {
            //Get selected values
            Package selectedPackage = PackageTabGetSelectedPackage();
            ProductsSupplier selectedProductsSupplier = PackageTabGetSelectedProductsSupplier().productsSupplier;

            if (selectedProductsSupplier != null)
            {
                PackageDB.RemoveProductsSupplier(selectedPackage, selectedProductsSupplier);

                PackageTabRenderProductSuppliers();
                PackageTabRenderSuppliers();

            }
        }

        //************************************************** Misc. Event Listeners ******************************************************

        // Author: Alex Cress
        /// <summary>
        /// Renders Product lists when Package selection changes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lstPackageTabPackages_SelectedIndexChanged(object sender, EventArgs e)
        {
            PackageTabRenderPackageDetails();
            PackageTabRenderProducts();
            PackageTabRenderProductSuppliers();
        }

        // Author: Alex Cress
        /// <summary>
        /// Ensures only one value is selected between its sister table lstPackageTabActiveProducts and itself.
        /// Updates Suppliers based off of selected package.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lstPackageTabProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (radPackageTabByProduct.Checked)
            {
                PackageTabRenderSuppliers();
            }
            else if (radPackageTabBySupplier.Checked)
            {
                //Do nothing
            }
            else
            {
                throw new NotImplementedException();
            }

        }

        private void lstPackageTabSuppliers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (radPackageTabByProduct.Checked)
            {
                //Do nothing
            }
            else if (radPackageTabBySupplier.Checked)
            {
                PackageTabRenderProducts();
            }
            else
            {
                throw new NotImplementedException();
            }
        }

        private void radGrpPackageTabAddProductsSupplier_CheckChanged(object sender, EventArgs e)
        {
            PackageTabRenderProducts();
            PackageTabRenderSuppliers();
        }

        //************************************************** Renderers *************************************************************

        // Author: Alex Cress
        /// <summary>
        /// Refreshes the Packages table Data Source.
        /// </summary>
        private void PackageTabRenderPackages()
        {
            //Get all packages
            List<Package> packages = PackageDB.GetPackages();

            //Render packages ListBox
            lstPackageTabPackages.DataSource = packages;
            lstPackageTabPackages.DisplayMember = "PkgName";

        }

        // Author: Alex Cress
        /// <summary>
        /// Refreshes the Packages table Data Source and retains selected index in the list.
        /// </summary>
        /// <param name="index">the table index you want to be selected after refreshing</param>
        private void PackageTabRenderPackages(int index)
        {
            PackageTabRenderPackages();
            lstPackageTabPackages.SelectedIndex = index;
        }

        // Author: Alex Cress
        /// <summary>
        /// Refreshes the Products table Data Source.
        /// </summary>
        private void PackageTabRenderProducts()
        {
            List<Product> availableProducts = null;

            if (radPackageTabByProduct.Checked)
            {
                //Get all products
                availableProducts = ProductDB.GetProducts();
            }
            else if (radPackageTabBySupplier.Checked)
            {
                Supplier selectedSupplier = PackageTabGetSelectedSupplier();
                Package selectedPackage = PackageTabGetSelectedPackage();

                //Get Products for selected Supplier excluding those already in the selected Package
                if (selectedSupplier != null)
                {
                    availableProducts = ProductDB.GetProductsForSupplierExcludingPackage(selectedPackage, selectedSupplier);
                }
            }
            else
            {
                throw new NotImplementedException();
            }


            lstPackageTabAvailableProducts.DataSource = availableProducts;
            lstPackageTabAvailableProducts.DisplayMember = "ProdName";
            lstPackageTabAvailableProducts.SelectedIndex = -1;
        }

        // Author: Alex Cress
        /// <summary>
        /// Renders Supplier table using selected values from Product tables
        /// </summary>
        private void PackageTabRenderSuppliers()
        {
            List<Supplier> availableSuppliers = null;

            if (radPackageTabByProduct.Checked)
            {
                //Get selected values from lists
                Package selectedPackage = PackageTabGetSelectedPackage();
                Product selectedProduct = PackageTabGetSelectedProduct();

                //Get Suppliers for selected Product excluding those already in the selected Package               
                if (selectedPackage != null && selectedProduct != null)
                {
                    availableSuppliers = SupplierDB.GetSuppliersForProductExcludingPackage(selectedPackage, selectedProduct);
                }
            }
            else if (radPackageTabBySupplier.Checked)
            {
                //Get all Suppliers
                availableSuppliers = SupplierDB.GetSuppliers();
            }
            else
            {
                //Someone added a radio button to this groupbox
                throw new NotImplementedException();
            }

            //Render ListBox
            lstPackageTabAvailableSuppliers.DataSource = availableSuppliers;
            lstPackageTabAvailableSuppliers.DisplayMember = "SupName";
        }

        private void PackageTabRenderProductSuppliers()
        {
            //Get ProductSuppliers for selected package
            Package selectedPackage = PackageTabGetSelectedPackage();
            List<ProductsSupplierDTO> DTOs = PackageDB.GetProductsSupplierDTOs(selectedPackage);

            //Render ProductSuppliers
            gvPackageTabProductsSupplier.DataSource = DTOs;
            gvPackageTabProductsSupplier.Columns["SupName"].Width = 250;
            gvPackageTabProductsSupplier.Columns["ProdName"].Width = 150;
        }

        private void PackageTabRenderPackageDetails()
        {
            Package selectedPackage = (Package)lstPackageTabPackages.SelectedValue;

            //Populate fields
            lblPackageTabPackageName.Text = selectedPackage.PkgName;
            txtPackageTabPackageDescription.Text = selectedPackage.PkgDesc;
            txtPackageTabPackageStartDate.Text = ((DateTime)selectedPackage.PkgStartDate).ToShortDateString();
            txtPackageTabPackageEndDate.Text = ((DateTime)selectedPackage.PkgEndDate).ToShortDateString();
            txtPackageTabPackageBasePrice.Text = selectedPackage.PkgBasePrice.ToString("c");
            txtPackageTabPackageAgencyCommission.Text = ((Decimal)selectedPackage.PkgAgencyCommission).ToString("c");
        }

        //************************************************** Getters/Helpers *************************************************************

        // Author: Alex Cress
        /// <summary>
        /// Gets the selected Supplier from the Supplier ListBox.
        /// </summary>
        /// <returns>the selected Package, or null if none</returns>
        private Supplier PackageTabGetSelectedSupplier()
        {
            return (Supplier) lstPackageTabAvailableSuppliers.SelectedValue;
        }

        // Author: Alex Cress
        /// <summary>
        /// Gets the selected Product from the Product ListBox.
        /// </summary>
        /// <returns>the selected Package, or null if none</returns>
        private Product PackageTabGetSelectedProduct()
        {
            return (Product)lstPackageTabAvailableProducts.SelectedValue;
        }

        // Author: Alex Cress
        /// <summary>
        /// Gets the selected Package from the Package ListBox.
        /// </summary>
        /// <returns>the selected Package, or null if none</returns>
        private Package PackageTabGetSelectedPackage()
        {
            return (Package) lstPackageTabPackages.SelectedValue;
        }

        // Author: Alex Cress
        /// <summary>
        /// Gets the selected ProductsSupplierDTO from the ProductsSupplier ListBox.
        /// </summary>
        /// <returns>the selected ProductsSupplierDTO, or null if none selected</returns>
        private ProductsSupplierDTO PackageTabGetSelectedProductsSupplier()
        {
            return (ProductsSupplierDTO) gvPackageTabProductsSupplier.CurrentRow.DataBoundItem;
        }

        private void frmMain_FormClosing(Object sender, FormClosingEventArgs e)
        {
            EnterPage.Close();
        }


    }
}
