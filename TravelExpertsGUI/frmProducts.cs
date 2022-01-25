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
    public partial class frmProducts : Form
    {
        public bool IsAdd = false;
        public Product SelectedProduct = null;
        private List<Supplier> potentialSuppliers = null;
        public List<Supplier> ProductSuppliers = null;
        public frmProducts()
        {
            InitializeComponent();
        }

        private void frmProducts_Load(object sender, EventArgs e)
        {
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
                this.Text = $"Product > Edit > '{SelectedProduct.ProdName}'";
                lblCurrentSuppliers.Text = $"{SelectedProduct.ProdName} Suppliers:";

                // Get a list of suppliers for this product
                ProductSuppliers = SupplierDB.GetSuppliers(SelectedProduct)
                    .OrderBy(s => s.SupName).ToList();

                // Get a list of all suppliers, filtering out the ones that already
                // provide the product
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

        private List<Supplier> GetSelectedSuppliers(ListBox listbox, List<Supplier> suppliers)
        {
            List<Supplier> selectedSuppliers = new List<Supplier>();

            foreach(int index in listbox.SelectedIndices)
            {
                int supplierId = ((Supplier)listbox.Items[index]).SupplierId;
                selectedSuppliers.Add(suppliers.Where(ps => ps.SupplierId == supplierId).Single());
            }
            return selectedSuppliers;
        }

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

        private void btnRemoveSuppliers_Click(object sender, EventArgs e)
        {
            // Loop through all the selected suppliers and move them from
            // potentialSuppliers list to the productSuppliers list
            GetSelectedSuppliers(lstCurrentSuppliers, ProductSuppliers)
                .ForEach(s =>
                {
                    potentialSuppliers.Add(s);
                    ProductSuppliers.Remove(s);
                });

            UpdateListBoxes();
        }

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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
