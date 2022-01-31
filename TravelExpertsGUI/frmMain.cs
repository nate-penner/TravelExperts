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
                txtSupplierTabSupplierId.Text = lstSupplierTabsupplier.SupplierId.ToString();
                txtSupplierTabProductCount.Text = product.Count().ToString();
                lstSupplierTabProducts.DataSource = product;
                lstSupplierTabProducts.DisplayMember = "ProdName";
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
            else
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
            } else
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
        /// Deletes the selected package from the database.
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
        /// Adds a product to the selected package.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPackageTabAddProduct_Click(object sender, EventArgs e)
        {
            //Get selected values
            Package selectedPackage = (Package)lstPackageTabPackages.SelectedValue;
            Product selectedProduct = PackageTabGetSelectedProduct();
            Supplier selectedSupplier = PackageTabGetSelectedSupplier();
            ProductsSupplier productsSupplier;

            if (selectedPackage != null && selectedProduct != null)
            {
                productsSupplier = ProductSupplierDB.GetProductsSupplier(selectedProduct, selectedSupplier);

                if (productsSupplier != null)
                {
                    PackageDB.AddProduct(selectedPackage, productsSupplier);

                    PackageTabRenderProducts();
                }
            }
        }

        // Author: Alex Cress
        /// <summary>
        /// Removes the selected Product from the selected Package.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPackageTabRemoveProduct_Click(object sender, EventArgs e)
        {
            //Get selected values
            Package selectedPackage = (Package)lstPackageTabPackages.SelectedValue;
            Product selectedProduct = PackageTabGetSelectedProduct();
            Supplier selectedSupplier = PackageTabGetSelectedSupplier();
            ProductsSupplier productsSupplier;

            if (selectedPackage != null && selectedProduct != null)
            {
                productsSupplier = ProductSupplierDB.GetProductsSupplier(selectedProduct, selectedSupplier);

                if (productsSupplier != null)
                {
                    PackageDB.RemoveProduct(selectedPackage, productsSupplier);

                    PackageTabRenderProducts();
                }
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
            PackageTabRenderProducts();
            PackageTabRenderSuppliers();
        }

        // Author: Alex Cress
        /// <summary>
        /// Ensures only one value is selected between its sister table lstPackageTabAvailableProducts and itself.
        /// Updates Suppliers based off of selected package.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lstPackageTabActiveProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Remove selection from sister table
            if (lstPackageTabActiveProducts.SelectedIndex != -1) //Avoid cancelling out
            {
                lstPackageTabAvailableProducts.SelectedIndex = -1;
            }

            PackageTabRenderSuppliers();
        }

        // Author: Alex Cress
        /// <summary>
        /// Ensures only one value is selected between its sister table lstPackageTabActiveProducts and itself.
        /// Updates Suppliers based off of selected package.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lstPackageTabAvailableProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Remove selection from sister table
            if (lstPackageTabAvailableProducts.SelectedIndex != -1) //Avoid cancelling out
            {
                lstPackageTabActiveProducts.SelectedIndex = -1;
            }

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

            //Render packages
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
            Package selectedPackage = PackageTabGetSelectedPackage();

            //Get products for selected Package
            List<Product> activeProducts = TravelExpertsDataAPI.ProductDB.GetProducts(selectedPackage);

            //Get products not in selected Package
            List<Product> availableProducts = TravelExpertsDataAPI.ProductDB.GetProductsExcluding(selectedPackage);

            //Render tables
            lstPackageTabActiveProducts.DataSource = activeProducts;
            lstPackageTabActiveProducts.DisplayMember = "ProdName";
            lstPackageTabActiveProducts.SelectedIndex = -1;

            lstPackageTabAvailableProducts.DataSource = availableProducts;
            lstPackageTabAvailableProducts.DisplayMember = "ProdName";
            lstPackageTabAvailableProducts.SelectedIndex = -1;
        }

        // Author: Alex Cress
        /// <summary>
        /// Renders Supplier tables using selected values from Product tables
        /// </summary>
        private void PackageTabRenderSuppliers()
        {
            //Get selected values from lists
            Package selectedPackage = PackageTabGetSelectedPackage();
            Product selectedProduct = PackageTabGetSelectedProduct();

            //Get Suppliers for Product
            List<Supplier> activeSuppliers = null;
            List<Supplier> availableSuppliers = null;

            if (selectedPackage != null && selectedProduct != null)
            {
                activeSuppliers = SupplierDB.GetSuppliersForPackageProduct(selectedPackage, selectedProduct);
                availableSuppliers = SupplierDB.GetSuppliersForPackageProductExcluding(selectedPackage, selectedProduct);
            }

            //Update supplier table
            lstPackageTabActiveSuppliers.DataSource = activeSuppliers;
            lstPackageTabActiveSuppliers.DisplayMember = "SupName";
            lstPackageTabActiveSuppliers.SelectedIndex = -1;

            lstPackageTabAvailableSuppliers.DataSource = availableSuppliers;
            lstPackageTabAvailableSuppliers.DisplayMember = "SupName";
            lstPackageTabAvailableSuppliers.SelectedIndex = -1;

        }

        //************************************************** Getters/Helpers *************************************************************

        // Author: Alex Cress
        /// <summary>
        /// Gets the selected Supplier from the Supplier tables.
        /// </summary>
        /// <returns>the selected Package, or null if none</returns>
        private Supplier PackageTabGetSelectedSupplier()
        {
            return lstPackageTabAvailableSuppliers.SelectedIndex != -1 ? (Supplier) lstPackageTabAvailableSuppliers.SelectedValue : (Supplier) lstPackageTabActiveSuppliers.SelectedValue;
        }

        // Author: Alex Cress
        /// <summary>
        /// Gets the selected Product from the Product tables.
        /// </summary>
        /// <returns>the selected Package, or null if none</returns>
        private Product PackageTabGetSelectedProduct()
        {
            return lstPackageTabAvailableProducts.SelectedIndex != -1 ? (Product)lstPackageTabAvailableProducts.SelectedValue : (Product)lstPackageTabActiveProducts.SelectedValue;
        }

        // Author: Alex Cress
        /// <summary>
        /// Gets the selected Package from the Package tables.
        /// </summary>
        /// <returns>the selected Package, or null if none</returns>
        private Package PackageTabGetSelectedPackage()
        {
            return (Package) lstPackageTabPackages.SelectedValue;
        }

        private void frmMain_FormClosing(Object sender, FormClosingEventArgs e)
        {
            EnterPage.Close();
        }
    }
}
