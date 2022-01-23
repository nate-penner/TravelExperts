using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using TravelExpertsData;
using TravelExpertsDataAPI;

namespace TravelExpertsGUI
{
    public partial class frmMain : Form
    {
        // productKeyMap maps the ListBox indices to the ProductId from the database
        Dictionary<int, int> productTabProductKeyMap = new Dictionary<int, int>();

        // A list of all products in the database
        List<Product> productTabProducts;

        // WOO new repo on branch!
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
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
