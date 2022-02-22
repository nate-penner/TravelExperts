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

/* A subform that allows modification of Packages.
 * Authors: Alex Cress
 * 2022-01-28
 */

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
                //Populate all fields with Package information
                txtName.Text = package.PkgName;
                txtDescription.Text = package.PkgDesc;
                txtBasePrice.Text = package.PkgBasePrice.ToString("c");
                txtAgencyCommission.Text = ((Decimal)package.PkgAgencyCommission).ToString("c");
                dtpStartDate.Value = (DateTime) package.PkgStartDate;
                dtpEndDate.Value = (DateTime)package.PkgEndDate;
                //Enable everything... no customization at this point
            }
        }

        /// <summary>
        /// Validates the form and sets DialogResult.OK if valid.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAccept_Click(object sender, EventArgs e)
        {
            string basePrice = RemoveCurrencyFormat(txtBasePrice.Text);
            string agencyCommisson = RemoveCurrencyFormat(txtAgencyCommission.Text);

            //Basic form validation
            if (Validator.IsPresent(txtName) &&
                Validator.IsPresent(txtDescription) &&
                Validator.IsNonNegativeDecimal(txtBasePrice) &&
                Validator.IsNonNegativeDecimal(txtAgencyCommission))         
            {
                //Populate a new Package
                Package newPackage = new Package();
                newPackage.PackageId = package.PackageId;
                newPackage.PkgName = txtName.Text;
                newPackage.PkgDesc = txtDescription.Text;
                newPackage.PkgStartDate = dtpStartDate.Value;
                newPackage.PkgEndDate = dtpEndDate.Value;
                newPackage.PkgBasePrice = Decimal.Parse(basePrice);
                newPackage.PkgAgencyCommission = Decimal.Parse(agencyCommisson);

                //Check business logic
                if (Validator.IsValidPackage(newPackage))
                {
                    //If all input if valid, simply return to main form and allow it to do what it wants with the Package
                    package = newPackage;
                    this.DialogResult = DialogResult.OK;
                }
            }

        }

        // Author: Alex Cress
        /// <summary>
        /// Removes '$' ',' and any whitespaces. Not compatable with any other currencies and/or foreign currency formats.
        /// </summary>
        /// <param name="s">the string to be formatted</param>
        /// <returns>a string with all currency formatting removed</returns>
        private string RemoveCurrencyFormat(string s)
        {
            return s.Replace("$", "").Replace(",", "").Trim();
        }

        // Author: Alex Cress
        /// <summary>
        /// Cancels any changes and closes the form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
