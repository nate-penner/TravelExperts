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

namespace TravelExpertsGUI
{
    public partial class frmAddModifySuppliers : Form
    {
        public Supplier CurrentSupplier;
        public bool IsAdd;

        public frmAddModifySuppliers()
        {
            InitializeComponent();

            if (IsAdd)
            {
                this.Text = "Add Supplier";
            }
            else
            {
                this.Text = "Modify Supplier";
                lstProducts.Hide();
            }

        }

        private void frmAddModifyProductsSuppliers_Load(object sender, EventArgs e)
        {

        }
    }
}
