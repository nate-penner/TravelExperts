using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TravelExpertsData;
using TravelExpertsDataAPI;

/* A form to Add/Modify the suppliers in the database, controls drawn to screen depend on mode loaded 
 * Authors: Daniel Palmer
 * 2022-01-17
 */

namespace TravelExpertsGUI
{
    public partial class frmAddModifySuppliers : Form
    {
        // Establish public variables to assigned and passed to form
        public Supplier CurrentSupplier;
        public bool IsAdd;
        public List<Product> AddedProducts = new List<Product>();
        // Select all product from database
        private List<Product> products = ProductDB.GetProducts();


        public frmAddModifySuppliers()
        {
            InitializeComponent();
        }

        // Sets up the form according to objects passed from the main form
        private void frmAddModifyProductsSuppliers_Load(object sender, EventArgs e)
        {
            if (IsAdd)
            {
                // Loads the Add mode
                this.Text = "Add Supplier";
                lblWarning.Hide();
                // Re-renders the lists
                RenderList();
            }
            else
            {
                // Loads the Modify Mode
                this.Text = "Modify Supplier";
                txtSupplierId.Text = CurrentSupplier.SupplierId.ToString();
                txtSupplierId.Enabled = false;
                txtSupplierName.Text = CurrentSupplier.SupName;

                //Hides all controls for adding products when the modify 
                lstProducts.Hide();
                lstAddedProducts.Hide();
                btnAddProduct.Hide();
                btnRemoveProduct.Hide();
            }

        }

        // Implements the Ok on click method, passes the Supplier data to main form
        // Author: Daniel Palmer 
        private void btnOk_Click(object sender, EventArgs e)
        {
            TextBox[] tbs = { txtSupplierId, txtSupplierName };
            if (Validator.IsPresent(tbs) &&
                Validator.IsInt(txtSupplierId) &&
                CheckSupplierId(Convert.ToInt32(txtSupplierId.Text)))
            {
                CurrentSupplier.SupName = txtSupplierName.Text;
                CurrentSupplier.SupplierId = Convert.ToInt32(txtSupplierId.Text);

                this.DialogResult = DialogResult.OK;
            }
        }

        // Implements the AddProduct on click method, adds the selected product to the AddedProduct list
        // Author: Daniel Palmer 
        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            if (lstProducts.SelectedValue != null)
            {
                AddedProducts.Add((Product)lstProducts.SelectedValue);
                products.Remove((Product)lstProducts.SelectedValue);
                // Re-renders the lists to add/remove items
                RenderList();
            }
        }
        // Implements the RemoveProduct on click method, removes the selected product from the AddedProduct list
        // Author: Daniel Palmer 
        private void btnRemoveProduct_Click(object sender, EventArgs e)
        {
            // Ensures there is a product selected
            if (lstAddedProducts.SelectedValue != null)
            {
                products.Add((Product)lstAddedProducts.SelectedValue);
                AddedProducts.Remove((Product)lstAddedProducts.SelectedValue);
                // Re-renders the lists to add/remove items
                RenderList();
            }
        }

        // Renders the product list and added product list
        // Author: Daniel Palmer
        private void RenderList()
        {
            lstProducts.DataSource = null;
            lstProducts.DataSource = products;
            lstProducts.DisplayMember = "ProdName";

            lstAddedProducts.DataSource = null;
            lstAddedProducts.DataSource = AddedProducts;
            lstAddedProducts.DisplayMember = "ProdName";
        }

        // Implements the Cancel on click method, closes the form and discards changes
        // Author: Daniel Palmer  
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
        
        // Checks the provide Supplier Id against all suppliers in the data base to ensure the Id is unique
        // Author: Daniel Palmer
        private bool CheckSupplierId(int code)
        {
            if (IsAdd)
            {
                try
                {
                    using (TravelExpertsContext db = new TravelExpertsContext())
                    {
                        // Creates a list of all product codes
                        var SupplierCodes = db.Suppliers.Select(s => s.SupplierId).ToList();
                        foreach (int SupplierCode in SupplierCodes)
                        {
                            // Compares the attempted product code with the values from the database
                            if (SupplierCode == code)
                            {
                                MessageBox.Show("Supplier Id must be unique!");
                                return false;
                            }
                        }
                        return true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                    return false;
                }
            }
            else
            {
                return true;
            }
        }
    }
}
