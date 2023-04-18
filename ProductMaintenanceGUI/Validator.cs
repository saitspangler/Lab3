using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductMaintenanceGUI
{
    /// <summary>
    /// a repository of validation methods
    /// </summary>
    public static class Validator
    {
        /// <summary>
        /// checks if text box has text in it
        /// </summary>
        /// <param name="textBox">text box to check (Tag property is set)</param>
        /// <returns>true if valid and false if not</returns>
        public static bool IsPresent(TextBox textBox)
        {
            bool isValid = true;
            if(textBox.Text == "") // bad
            {
                MessageBox.Show(textBox.Tag + " is required");
                textBox.Focus();
                isValid = false;
            }
            return isValid;
        }

        /// <summary>
        /// checks if text box has the accepted number of charactersin it
        /// </summary>
        /// <param name="textBox"></param>
        /// <param name="maxLength"></param>
        /// <returns>true if valid and false if not</returns>
        public static bool IsValidLength(TextBox textBox, int maxLength)
        {
            bool isValid = true;
            if (textBox.Text.Length > maxLength)
            {
                MessageBox.Show(textBox.Tag + $" must be {maxLength} characters or less");
                textBox.Focus();
                isValid = false;
            }
            return isValid;
        }


        /// <summary>
        /// checks if combo box has value selected
        /// </summary>
        /// <param name="comboBox">combo box to check (Tag property is set)</param>
        /// <returns>true if valid and false if not</returns>
        public static bool IsSelected(ComboBox comboBox)
        {
            bool isValid = true;
            if (comboBox.SelectedIndex == -1) // bad
            {
                MessageBox.Show(comboBox.Tag + " must be selected");
                comboBox.Focus();
                isValid = false;
            }
            return isValid;
        }

        /// <summary>
        /// Checks if a DataGridView has a row selected.
        /// </summary>
        /// <param name="dataGridView">DataGridView to check (Tag property is set)</param>
        /// <returns>true if valid and false if not</returns>
        public static bool IsRowSelected(DataGridView dataGridView)
        {
            bool isValid = true;
            if (dataGridView.SelectedRows.Count == 0) // no row selected
            {
                MessageBox.Show("Please select a row by clicking the arrow in the far left column to modify or delete a product.");
                dataGridView.Focus();
                isValid = false;
            }
            return isValid;
        }

        /// <summary>
        /// checks if text box contains a non-negative int value
        /// </summary>
        /// <param name="textBox">text box to check (Tag property is set)</param>
        /// <returns>true if valid and false if not</returns>
        public static bool IsNonNegativeInt(TextBox textBox)
        {
            bool isValid = true;
            int result;
            if(!Int32.TryParse(textBox.Text, out result)) // not an int
            {
                MessageBox.Show(textBox.Tag + " has to be a whole number");
                textBox.SelectAll(); // select all text in the box for replacement
                textBox.Focus();
                isValid = false;
            }
            else if(result < 0) // it is an int but negative
            {
                MessageBox.Show(textBox.Tag + " has to be positive or zero");
                textBox.SelectAll(); // select all text in the box for replacement
                textBox.Focus();
                isValid = false;
            }
            return isValid;
        }

        /// <summary>
        /// checks if text box contains an int value within given range
        /// </summary>
        /// <param name="textBox">text box to check (Tag property is set)</param>
        /// <param name="minVal">minimum value for the range</param>
        /// <param name="maxVal">maximum value for the range</param>
        /// <returns>true if valid and fals if not</returns>
        public static bool IsIntInRange(TextBox textBox, int minVal, int maxVal)
        {
            bool isValid = true;
            int result;
            if (!Int32.TryParse(textBox.Text, out result)) // not an int
            {
                MessageBox.Show(textBox.Tag + " has to be a whole number");
                textBox.SelectAll(); // select all text in the box for replacement
                textBox.Focus();
                isValid = false;
            }
            else if (result < minVal || result > maxVal) // it is an int but out of range
            {
                MessageBox.Show(textBox.Tag + " has to be between " + minVal +
                                              " and " + maxVal);
                textBox.SelectAll(); // select all text in the box for replacement
                textBox.Focus();
                isValid = false;
            }
            return isValid;
        }

        /// <summary>
        /// checks if text box contains a non-negative double value
        /// </summary>
        /// <param name="textBox">text box to check (Tag property is set)</param>
        /// <returns>true if valid and false if not</returns>
        public static bool IsNonNegativeDouble(TextBox textBox)
        {
            bool isValid = true;
            double result;
            if (!Double.TryParse(textBox.Text, out result)) // not a double
            {
                MessageBox.Show(textBox.Tag + " has to be a number");
                textBox.SelectAll(); // select all text in the box for replacement
                textBox.Focus();
                isValid = false;
            }
            else if (result < 0) // it is a double but negative
            {
                MessageBox.Show(textBox.Tag + " has to be positive or zero");
                textBox.SelectAll(); // select all text in the box for replacement
                textBox.Focus();
                isValid = false;
            }
            return isValid;
        }

        /// <summary>
        /// checks if text box contains a non-negative decimal value
        /// </summary>
        /// <param name="textBox">text box to check (Tag property is set)</param>
        /// <returns>true if valid and false if not</returns>
        public static bool IsNonNegativeDecimal(TextBox textBox)
        {
            bool isValid = true;
            decimal result;
            if (!Decimal.TryParse(textBox.Text, out result)) // not a decimal
            {
                MessageBox.Show(textBox.Tag + " has to be a number");
                textBox.SelectAll(); // select all text in the box for replacement
                textBox.Focus();
                isValid = false;
            }
            else if (result < 0) // it is a decimal but negative
            {
                MessageBox.Show(textBox.Tag + " has to be positive or zero");
                textBox.SelectAll(); // select all text in the box for replacement
                textBox.Focus();
                isValid = false;
            }
            return isValid;
        }

        /// <summary>
        /// checks if text box contains a decimal value within given range
        /// </summary>
        /// <param name="textBox">text box to check (Tag property is set)</param>
        /// <param name="minVal">minimum value for the range</param>
        /// <param name="maxVal">maximum value for the range</param>
        /// <returns>true if valid and false if not</returns>
        public static bool IsDecimalInRange(TextBox textBox, 
                                            decimal minVal, decimal maxVal)
        {
            bool isValid = true;
            decimal result;
            if (!Decimal.TryParse(textBox.Text, out result)) // not a decimal
            {
                MessageBox.Show(textBox.Tag + " has to be a number");
                textBox.SelectAll(); // select all text in the box for replacement
                textBox.Focus();
                isValid = false;
            }
            else if (result < minVal || result > maxVal) // it is a decimal but outside the range
            {
                MessageBox.Show(textBox.Tag + " has to be between " + minVal + 
                                              " and " + maxVal);
                textBox.SelectAll(); // select all text in the box for replacement
                textBox.Focus();
                isValid = false;
            }
            return isValid;
        }

        /// <summary>
        /// checks if text box contains a valid date within a range of 20 years ago and 20 years in the future
        /// </summary>
        /// <param name="textBox">text box to check (Tag property is set)</param>
        /// <returns>true if valid and false if not</returns>
        public static bool IsValidDate(TextBox textBox)
        {
            bool isValid = true;
            DateTime result;
            if (!DateTime.TryParse(textBox.Text, out result))
            {
                MessageBox.Show(textBox.Tag + " has to be a valid date in the format mm/dd/yyyy");
                textBox.SelectAll();
                textBox.Focus();
                isValid = false;
            }
            else if (result.ToString("MM/dd/yyyy") != textBox.Text)
            {
                MessageBox.Show(textBox.Tag + " has to be in the format mm/dd/yyyy");
                textBox.SelectAll();
                textBox.Focus();
                isValid = false;
            }
            else
            {
                DateTime minDate = DateTime.Now.AddYears(-20);
                DateTime maxDate = DateTime.Now.AddYears(20);
                if (result < minDate || result > maxDate)
                {
                    MessageBox.Show(textBox.Tag + " has to be a date within the range of " +
                                    minDate.ToString("MM/dd/yyyy") + " and " + maxDate.ToString("MM/dd/yyyy"));
                    textBox.SelectAll(); // select all text in the box for replacement
                    textBox.Focus();
                    isValid = false;
                }
            }
            return isValid;
        }
    }
}
