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

namespace TravelExpertsGUI
{
    /* A form to allow for easy management of products and suppliers, allowing the user to
     * add new products and modify existing products
     * Authors: Nate Penner
     * 2022-01-23
     */
    public partial class frmProducts : Form
    {
        public bool IsAdd = false;  // flag that determines what type of operation this is:
                                    // add or edit operation

        public Product SelectedProduct = null;              // The product being modified

        private List<Supplier> potentialSuppliers = null;   // A list of all suppliers from the
                                                            // database that DO NOT supply this
                                                            // product
        
        public List<Supplier> ProductSuppliers = null;      // A list of all suppliers from the
                                                            // database that DO supply this product
        
        // Constructor
        public frmProducts()
        {
            InitializeComponent();
        }

        // Form on load event handler
        private void frmProducts_Load(object sender, EventArgs e)
        {
            // Get archive productsupplierid

            using (TravelExpertsContext db = new TravelExpertsContext())
            {
                List<string> archived = db.ProductsSuppliersArchives
                    .Join(db.ProductsSuppliers,
                    psa => psa.ProductSupplierId,
                    ps => ps.ProductSupplierId,
                    (psa, ps) => ps
                    ).Select(o => o.SupplierId + ": " + o.ProductId).ToList();

                MessageBox.Show($"Archived relationships: {string.Join(", ", archived)}");
            }

            // Get all suppliers from the database
            potentialSuppliers = SupplierDB.GetSuppliers();

            if (IsAdd)
            {
                // Add a product
                this.Text = "Add Product";
                lstPotentialSuppliers.DataSource = potentialSuppliers;
                lstPotentialSuppliers.DisplayMember = "SupName";
            }
            else
            {
                // Modify a product

                // Update the window title and current suppliers label
                this.Text = $"Product > Edit > '{SelectedProduct.ProdName}'";
                lblCurrentSuppliers.Text = $"{SelectedProduct.ProdName} Suppliers:";

                // Get a list of all the suppliers for this product
                ProductSuppliers = SupplierDB.GetSuppliers(SelectedProduct)
                    .OrderBy(s => s.SupName).ToList();

                // Filter out the current suppliers from the list of all suppliers
                potentialSuppliers = potentialSuppliers
                    .OrderBy(s => s.SupName)
                    .Where(s => !ProductSuppliers.Select(ps => ps.SupName).ToList().Contains(s.SupName))
                    .ToList();

                // Display the current suppliers for this product
                lstCurrentSuppliers.DataSource = ProductSuppliers;
                lstCurrentSuppliers.DisplayMember = "SupName";

                // Display all the other suppliers in the database
                lstPotentialSuppliers.DataSource = potentialSuppliers;
                lstPotentialSuppliers.DisplayMember = "SupName";

                // Display the product name
                txtProductName.Text = SelectedProduct.ProdName;
            }
        }

        /// <summary>
        /// Get a new list of suppliers from the selections in the Listbox.
        /// It is necessary to compare supplierId because the objects may be
        /// from different contexts
        /// </summary>
        /// <param name="listbox">The listbox to get the selections from</param>
        /// <param name="suppliers">The supplier list from which to filter out the selections</param>
        /// <returns></returns>
        private List<Supplier> GetSelectedSuppliers(ListBox listbox, List<Supplier> suppliers)
        {
            // new list of the selected suppliers to return
            List<Supplier> selectedSuppliers = new List<Supplier>();

            // Loop through all the listbox selections
            foreach(int index in listbox.SelectedIndices)
            {
                // use the supplierId from the listbox items
                int supplierId = ((Supplier)listbox.Items[index]).SupplierId;

                // Grab the object from the passed suppliers based on the supplierId
                selectedSuppliers.Add(suppliers.Where(ps => ps.SupplierId == supplierId).Single());
            }
            return selectedSuppliers;
        }

        // Add suppliers button handler. This moves selections from the list on the
        // right to the list on the left
        private void btnAddSuppliers_Click(object sender, EventArgs e)
        {
            // Loop through all the selected suppliers and move them from
            // potentialSuppliers list to the productSuppliers list
            GetSelectedSuppliers(lstPotentialSuppliers, potentialSuppliers)
                .ForEach(s =>
                {
                    ProductSuppliers.Add(s);
                    potentialSuppliers.Remove(s);
                });

            UpdateListBoxes();
        }

        // Add suppliers button handler. This moves selections from the list on the
        // left to the list on the right
        private void btnRemoveSuppliers_Click(object sender, EventArgs e)
        {
            // Loop through all the selected suppliers and move them from
            // productSuppliers list to the potentialSuppliers list
            GetSelectedSuppliers(lstCurrentSuppliers, ProductSuppliers)
                .ForEach(s =>
                {
                    // Check if ProductsSupplier is in any Package
                    ProductsSupplier ps = ProductSupplierDB.GetProductSupplier(
                        SelectedProduct, s);

                    List<Package> packages = null;

                    if (ps != null)
                        packages = ProductSupplierDB.GetPackages(ps);

                    if (packages != null && packages.Count > 0)
                    {
                        string[] packageNames = packages.Select(p => p.PkgName).ToArray();
                        MessageBox.Show(
                            $"The supplier {s.SupName} for {SelectedProduct.ProdName} " +
                            " could not be deleted because it is being used by the following " +
                            $"packages:\n\t{string.Join("\n\t", packageNames)}\n" +
                            "Please remove this product supplier from all packages before " +
                            "deleting!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    } else
                    {
                        potentialSuppliers.Add(s);
                        ProductSuppliers.Remove(s);
                    }
                });

            UpdateListBoxes();
        }

        // Updates the listboxes with the latest supplier data
        private void UpdateListBoxes()
        {
            // Re-sort the list
            ProductSuppliers = ProductSuppliers
                .OrderBy(ps => ps.SupName).ToList();
            potentialSuppliers = potentialSuppliers
                .OrderBy(ps => ps.SupName).ToList();

            // Reload the data in the list controls
            lstPotentialSuppliers.DataSource = potentialSuppliers;
            lstCurrentSuppliers.DataSource = ProductSuppliers;
        }

        // Cancel this operation and close the form
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        // Save this data and close the form
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtProductName.Text != "")
            {
                SelectedProduct.ProdName = txtProductName.Text;
                this.DialogResult = DialogResult.OK;
            } else
            {
                MessageBox.Show("Please enter a product name!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtProductName.Focus();
            }
        }

        private void frmProducts_Click(object sender, EventArgs e)
        {
            foreach (int index in lstPotentialSuppliers.SelectedIndices)
            {
                Supplier s = (Supplier)lstPotentialSuppliers.Items[index];
                Product p = SelectedProduct;
                ProductsSupplier ps = ProductSupplierDB.GetProductSupplier(p, s);
                
                if (ps != null && ProductSupplierDB.IsArchived(ps))
                {
                    MessageBox.Show($"{p.ProdName} offered by {s.SupName} is archived!");
                }
            }
        }
    }
}
