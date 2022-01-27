using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TravelExpertsData;

/*
 * A class for validation, provides methods for validating form controls
 * Author: Daniel Palmer
 * Date: 2022-01-21
*/
namespace TravelExpertsGUI
{
    public static class Validator
    {
        /// <summary>
        /// Checks if the textbox input is an empty string
        /// </summary>
        /// <param name="tb"></param>
        /// <returns>A boolean of whether the input is an empty string</returns>
        public static bool IsPresent(TextBox tb)
        {
            if (tb.Text == "")
            {
                MessageBox.Show($"{tb.Tag} is required");
                tb.Focus();
                return false;
            }
            return true;
        }

        /// <summary>
        /// Checks if the textbox input is an empty string
        /// </summary>
        /// <param name="cb"></param>
        /// <returns>A boolean of whether the input is an empty string</returns>
        public static bool IsPresent(ComboBox cb)
        {
            if (cb.Text == "")
            {
                MessageBox.Show($"{cb.Tag} is required");
                cb.Focus();
                return false;
            }
            return true;
        }

        // Overload of IsPresent taking an array of textboxes opposed to a single textbox
        public static bool IsPresent(TextBox[] tb)
        {
            //TextBox[] emptyFields = new TextBox[tb.Length];
            List<TextBox> emptyFields = new List<TextBox>();
            string message = "";
            int i = 0;
            foreach(TextBox tbox in tb)
            {
                if (tbox.Text == "")
                {
                    message += tbox.Tag + ", ";
                    emptyFields.Add(tbox);
                    i++;

                }
            }
            if (message != "")
            {
                message = message.Remove(message.Length -2);
                if (emptyFields.Count > 1)
                {
                    MessageBox.Show($"{message} fields are required");
                    emptyFields[0].Focus();
                    return false;
                }
                MessageBox.Show($"{message} field is required");
                emptyFields[0].Focus();
                return false;
            }
            return true;
        }
        /// <summary>
        /// Checks if textbox input is an number
        /// </summary>
        /// <param name="tb"></param>
        /// <returns>A boolean of whether the input is number of type decimal</returns>
        public static bool IsDecimal(TextBox tb)
        {
            try
            {
                Convert.ToDecimal(tb.Text);
                return true;
            }
            catch (FormatException)
            {
                MessageBox.Show($"{tb.Tag} must be a number");
                return false;
            }
        }

        /// <summary>
        /// Checks if textbox input is non-negative, calls IsDouble() method to verify input is a number of type decimal
        /// </summary>
        /// <param name="tb"></param>
        /// <returns>A boolean of whether the input is non-negative</returns>
        public static bool IsNonNegative(TextBox tb)
        {
            if (IsDecimal(tb))
            {
                decimal value = Convert.ToDecimal(tb.Text);
                if (value < 0)
                {
                    MessageBox.Show($"{tb.Tag} must be a positive number");
                    tb.Focus();
                    return false;
                }
                return true;
            }
            return false;

        }

        /// <summary>
        /// Checks if textbox input is an number
        /// </summary>
        /// <param name="tb"></param>
        /// <returns>A boolean of whether the input is number of type int</returns>
        public static bool IsInt(TextBox tb)
        {
            try
            {
                Convert.ToInt32(tb.Text);
                return true;
            }
            catch (FormatException)
            {
                MessageBox.Show($"{tb.Tag} must be a number");
                return false;
            }
        }

        /// <summary>
        /// Checks if textbox input is non-negative, calls IsInt() method to verify input is a number of type int
        /// </summary>
        /// <param name="tb"></param>
        /// <returns>A boolean of whether the input is non-negative</returns>
        public static bool IsNonNegativeInt(TextBox tb)
        {
            if (IsInt(tb))
            {
                decimal value = Convert.ToInt32(tb.Text);
                if (value < 0)
                {
                    MessageBox.Show($"{tb.Tag} must be a positive number");
                    tb.Focus();
                    return false;
                }
                return true;
            }
            return false;

        }

        /// <summary>
        /// Checks if textbox input is a valid date
        /// </summary>
        /// <param name="tb"></param>
        /// <returns>A Boolean of whether the date provided is valid</returns>
        public static bool IsDate(TextBox tb)
        {
            if (DateTime.TryParse(tb.Text, out DateTime DateValue))
            {
                return true;
            }
            else
            {
                MessageBox.Show($"{tb.Tag} Must be a valid date!");
                return false;
            }
        }

        /// <summary>
        /// validates if text box contains non-negative decimal value
        /// </summary>
        /// <param name="tb">text box to validate</param>
        /// <returns>true if valid and false if not</returns>
        public static bool IsNonNegativeDecimal(TextBox tb)
        {
            bool isValid = true;
            decimal result; // for TryParse
            if (!Decimal.TryParse(tb.Text, out result)) // TryParse returned false
            {
                isValid = false;
                MessageBox.Show(tb.Tag + " must be a number");
                tb.SelectAll(); // select all content for replacement
                tb.Focus();
            }
            else // it's decimal value, but could be negative
            {
                if (result < 0)
                {
                    isValid = false;
                    MessageBox.Show(tb.Tag + " must be positive or zero");
                    tb.SelectAll(); // select all content for replacement
                    tb.Focus();
                }
            }
            return isValid;
        }

        /// <summary>
        /// Contains all business logic for a Package
        /// </summary>
        /// <param name="package"></param>
        /// <returns></returns>
        public static bool IsValidPackage(Package package)
        {
            //TODO Check docs/implement all business-level requirements
            if(DateTime.Compare((DateTime) package.PkgStartDate, (DateTime) package.PkgEndDate) >= 0)//Start date is not before end date
            {
                MessageBox.Show("State date must be before end date!");
                return false;
            }
            return true;
        }
    }
}
