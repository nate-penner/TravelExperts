using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TravelExpertsData;
using TravelExpertsDataAPI;

namespace TravelExpertsGUI
{
    public partial class frmAddModifySuppliers : Form
    {
        public Supplier CurrentSupplier;
        public bool IsAdd;
        public List<Product> AddedProducts = new List<Product>();

        private List<Product> products = ProductDB.GetProducts();


        public frmAddModifySuppliers()
        {
            InitializeComponent();
        }

        private void frmAddModifyProductsSuppliers_Load(object sender, EventArgs e)
        {
            if (IsAdd)
            {
                this.Text = "Add Supplier";
                RenderList();
            }
            else
            {
                this.Text = "Modify Supplier";
                lstProducts.Hide();
            }

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            CurrentSupplier.SupName = txtSupplierName.Text;
            CurrentSupplier.SupplierId = Convert.ToInt32(txtSupplierId.Text);

            this.DialogResult = DialogResult.OK;
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            if (lstProducts.SelectedValue != null)
            {
                AddedProducts.Add((Product)lstProducts.SelectedValue);
                products.Remove((Product)lstProducts.SelectedValue);
                RenderList();
            }
        }
        private void btnRemoveProduct_Click(object sender, EventArgs e)
        {
            if (lstAddedProducts.SelectedValue != null)
            {
                products.Add((Product)lstAddedProducts.SelectedValue);
                AddedProducts.Remove((Product)lstAddedProducts.SelectedValue);
                RenderList();
            }
        }

        private void RenderList()
        {
            lstProducts.DataSource = null;
            lstProducts.DataSource = products;
            lstProducts.DisplayMember = "ProdName";

            lstAddedProducts.DataSource = null;
            lstAddedProducts.DataSource = AddedProducts;
            lstAddedProducts.DisplayMember = "ProdName";
        }
    }
}
