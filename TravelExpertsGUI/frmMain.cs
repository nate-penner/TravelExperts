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
        Dictionary<int, int> productKeyMap = new Dictionary<int, int>();

        // A list of all products in the database
        List<Product> products;

        // WOO new repo on branch!
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            // Product panel code
            int counter = 0;
            products = ProductDB.GetProducts()
                .OrderBy(p => p.ProdName)
                .ToList();
            products.ForEach( 
                p => {
                    lstProductTabProducts.Items.Add(p.ProdName);
                    productKeyMap.Add(counter, p.ProductId);
                    counter++;
                }
            );
        }

        private void lstProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selected = lstProductTabProducts.SelectedIndex;
            lstProductTabSuppliers.Items.Clear();
            txtProductTabProductID.Text = productKeyMap[selected].ToString();
            Product product = products
                .Find(p => p.ProductId == productKeyMap[selected]);

            List<Supplier> suppliers = ProductDB
                .GetSuppliers(product)
                .OrderBy(s => s.SupName).ToList();

            suppliers.ForEach(s => lstProductTabSuppliers.Items.Add(s.SupName));
            txtProductTabTotalSuppliers.Text = suppliers.Count.ToString();
        }
    }
}
