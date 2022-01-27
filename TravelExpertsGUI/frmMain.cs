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
        Supplier supplier;
        public frmMain()
        {
            InitializeComponent();
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            SupplierTabRenderList();

            // Product panel code
            // Author: Nate Penner
            loadProductsTab();

            //Load package panel
            PackageTabRenderPackageList();
        }


        // Loads a list of products from the databaes into the Products tab
        // Author: Nate Penner
        private void loadProductsTab()
        {
            lstProductTabProducts.DataSource = ProductDB.GetProducts()
                .OrderBy(p => p.ProdName).ToList();
            lstProductTabProducts.DisplayMember = "ProdName";
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

        /// <summary>
        /// Loads the package list with all packages
        /// Author: Alex Cress
        /// </summary>
        private void PackageTabRenderPackageList()
        {
            //Get ADO table
            List<Package> packages = TravelExpertsDataAPI.PackageDB.GetPackages();
            //Render table
            lstPackageTabPackages.DataSource = packages;
            lstPackageTabPackages.DisplayMember = "PkgName";
        }

        // Populates the tab with details about selected supplier
        // Author: Daniel Palmer
        private void lstSupplierTabSuppliers_SelectedIndexChanged(object sender, EventArgs e)
               {
            // Makes sure there is an index selected in list
            if (lstSupplierTabSuppliers.SelectedValue != null)
            {
                // Establishes the selected supplier and collects all products the supplier offers
                supplier = (Supplier)lstSupplierTabSuppliers.SelectedValue;

                List<Product> product = TravelExpertsDataAPI.ProductDB.GetProducts(supplier);

                // Displays all the supplier and product values to the form
                txtSupplierTabSupplierId.Text = supplier.SupplierId.ToString();
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
            frmProducts productsForm = new frmProducts();
            productsForm.IsAdd = true;

            DialogResult result = productsForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                ProductDB.AddProduct(productsForm.SelectedProduct);
            } else
            {
                // Show an error message
            }
        }

        // Handles the Edit product button in the Products tab
        // Author: Nate Penner
        private void btnProductTabEditProduct_Click(object sender, EventArgs e)
        {
            frmProducts productsForm = new frmProducts();
            productsForm.IsAdd = false;
            productsForm.SelectedProduct = productTabGetProductSelection();

            DialogResult result = productsForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                ProductSupplierDB.UpdateProductSuppliers(
                    productsForm.SelectedProduct, productsForm.ProductSuppliers
                    );
                productTabLoadSuppliers(productsForm.SelectedProduct);
            } else
            {
                // Show an error

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

            if(result == DialogResult.OK)
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

        /// <summary>
        /// Opens a form to accept user input for a new Package. If valid, the new Package will be saved to the database.
        /// Author: Alex Cress
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
                catch(Exception ex)
                {
                    MessageBox.Show($"Error while adding new Package to the database: {ex.Message}", "Database Error");
                }
                
                //Refresh table
                PackageTabRenderPackageList();
            }
        }

        /// <summary>
        /// Opens a form to accept user input for modifying an existing Package. If valid, the modifications will be saved to the database.
        /// Author: Alex Cress
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
            Package selectedPackage = (Package) lstPackageTabPackages.SelectedItem;

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
            }
        }

        private void btnPackageTabDeletePackage_Click(object sender, EventArgs e)
        {
            //Check if a row is selected (should always be selected by default)           
            if (lstPackageTabPackages.SelectedItem == null)
            {
                MessageBox.Show("Please select a Package from the list to modify.");
                return;
            }

            //Get the selected Package from the table
            Package selectedPackage = (Package) lstPackageTabPackages.SelectedItem; 

            //Confirm that the user wants to delete
            DialogResult answer = MessageBox.Show($"Do you want to delete {selectedPackage.PkgName}?",
                "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            //Delete the Product
            if (answer == DialogResult.Yes)
            {
                using (TravelExpertsContext db = new TravelExpertsContext())
                {
                    try
                    {
                        //Get ADO reference
                        selectedPackage = db.Packages.Find(selectedPackage.PackageId);
                        //Delete from database
                        db.Packages.Remove(selectedPackage);
                        db.SaveChanges();
                        //Refresh table
                        PackageTabRenderPackageList();
                    }
                    //TODO Alex- more specific error handling
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error while deleting Package {selectedPackage.PkgName}: " + ex.Message, ex.GetType().ToString());
                    }
                }
            }
        }
    }
}
