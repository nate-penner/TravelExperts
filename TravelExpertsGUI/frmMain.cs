using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using TravelExpertsData;
using TravelExpertsDataAPI;

/* A GUI design to allow for easy database management and interaction
 * Form serves as home page for application, allowing user to cycle through various pages to view particular data
 * Authors: Nate Penner, Daniel Palmer, alex Cress
 * 2022-01-17
 */

namespace TravelExpertsGUI
{
    public partial class frmMain : Form
    {
        // productKeyMap maps the ListBox indices to the ProductId from the database
        Dictionary<int, int> productTabProductKeyMap = new Dictionary<int, int>();

        // A list of all products in the database
        List<Product> productTabProducts;

        public frmMain()
        {
            InitializeComponent();
        }
        private void frmMain_Load(object sender, EventArgs e)
        {   
            // The following code block was writen by Daniel Palmer
            // Sets up the supplier tab form controls
            List<Supplier> SupplierTabSuppliers = TravelExpertsDataAPI.SupplierDB.GetSuppliers();
            // Fills the supplier listbox with all suppliers
            lstSupplierTabSuppliers.DataSource = SupplierTabSuppliers;
            lstSupplierTabSuppliers.DisplayMember = "SupName";
            // End code block by Daniel Palmer

            // Product panel code
            int counter = 0;
            productTabProducts = ProductDB.GetProducts()
                .OrderBy(p => p.ProdName)
                .ToList();
            productTabProducts.ForEach( 
                p => {
                    lstProductTabProducts.Items.Add(p.ProdName);
                    productTabProductKeyMap.Add(counter, p.ProductId);
                    counter++;
                }
            );
        }
        // Populates the tab with details about selected supplier Author: Daniel Palmer
        private void lstSupplierTabSuppliers_SelectedIndexChanged(object sender, EventArgs e)
               {
            // Establishes the selected supplier and collects all products the supplier offers
            Supplier supplier = (Supplier)lstSupplierTabSuppliers.SelectedValue;
            List<Product> product = TravelExpertsDataAPI.ProductDB.GetProducts(supplier);

            // Displays all the supplier and product values to the form
            txtSupplierTabSupplierId.Text = supplier.SupplierId.ToString();
            txtSupplierTabProductCount.Text = product.Count().ToString();
            lstSupplierTabProducts.DataSource = product;
            lstSupplierTabProducts.DisplayMember = "ProdName";
        }

        private void lstProductTabProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the Product from the listbox selection
            int selected = lstProductTabProducts.SelectedIndex;
            txtProductTabProductID.Text = productTabProductKeyMap[selected].ToString();
            Product product = productTabProducts
                .Find(p => p.ProductId == productTabProductKeyMap[selected]);

            // Get the list of suppliers for the selected product
            List<Supplier> suppliers = SupplierDB
                .GetSuppliers(product)
                .OrderBy(s => s.SupName).ToList();

            // Clear the suppliers tab and load new data
            lstProductTabSuppliers.Items.Clear();
            suppliers.ForEach(s => lstProductTabSuppliers.Items.Add(s.SupName));

            // Show suppliers count
            txtProductTabTotalSuppliers.Text = suppliers.Count.ToString();
        }

    }
}
