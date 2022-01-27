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
    /// <summary>
    /// Enum flag used to indicate the purpose of the input form. 
    /// Certain fields and/or actions will be disabled depending on the flag.
    /// </summary>
    public enum FORM_ACTION
    {
        CREATE,
        UPDATE
    }

    public partial class frmAddModifyPackage : Form
    {
        /// <summary>
        /// Stores the intended action of the form.
        /// </summary>
        public FORM_ACTION action;

        /// <summary>
        /// The package that was given to the form and/or modified within.
        /// </summary>
        public Package package = new Package();

        /// <summary>
        /// Creates a new Windows Form object that accepts user input for Packages. 
        /// </summary>
        /// <param name="action">The desired action of the form</param>
        public frmAddModifyPackage(FORM_ACTION action)
        {
            InitializeComponent();
            this.action = action;
        }

        /// <summary>
        /// Sets the look/feel and permitted functionality of the form based on the set FORM_ACTION.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmAddModifyPackage_Load(object sender, EventArgs e)
        {
            if(action == FORM_ACTION.CREATE)
            {
                //Enable everything... no customization at this point
            }
            else if(action == FORM_ACTION.UPDATE)
            {
                //Populate all fields
                txtName.Text = package.PkgName;
                txtDescription.Text = package.PkgDesc;
                txtBasePrice.Text = package.PkgBasePrice.ToString("c");
                txtAgencyCommission.Text = ((Decimal)package.PkgAgencyCommission).ToString("c");
                dtpStartDate.Value = (DateTime) package.PkgStartDate;
                dtpEndDate.Value = (DateTime)package.PkgEndDate;              
            }
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            //Basic form validation
            if (Validator.IsPresent(txtName) &&
                Validator.IsPresent(txtDescription) &&
                Validator.IsNonNegativeDecimal(txtBasePrice) &&
                Validator.IsNonNegativeDecimal(txtAgencyCommission))         
            {
                //Populate a new Package
                Package newPackage = new Package();
                newPackage.PkgName = txtName.Text;
                newPackage.PkgDesc = txtDescription.Text;
                newPackage.PkgStartDate = dtpStartDate.Value;
                newPackage.PkgEndDate = dtpEndDate.Value;
                newPackage.PkgBasePrice = Decimal.Parse(txtBasePrice.Text);
                newPackage.PkgAgencyCommission = Decimal.Parse(txtAgencyCommission.Text);

                //Check business logic
                if (Validator.IsValidPackage(newPackage))
                {
                    //If all input if valid, simply return to main form and allow it to do what it wants with the Package
                    package = newPackage;
                    this.DialogResult = DialogResult.OK;
                }
            }

        }

    }
}
