using CustomerData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductMaintenanceGUI
{
    public partial class frmAddModifyProduct : Form
    {
        // public because main form needs to set it
        public Product currentProduct;
        public bool isAdd;
        public frmAddModifyProduct()
        {
            InitializeComponent();
        }

        private void frmAddModifyProduct_Load(object sender, EventArgs e)
        {
            if (isAdd) // it is Add
            {
                this.Text = "Add Product";
                txtProductCode.Enabled = true;
            }
            else //it is Modify
            {
                this.Text = "Modify Product";
                DisplayProduct();
                txtProductCode.Enabled = false;
            }
        }

        // display current product
        private void DisplayProduct()
        {
            if(currentProduct != null)
            {
                txtProductCode.Text = currentProduct.ProductCode;
                txtDescription.Text = currentProduct.Description;
                txtUnitPrice.Text = currentProduct.UnitPrice.ToString();// no formatting!!
                txtQuantity.Text = currentProduct.OnHandQuantity.ToString();
            }
        }

        // save changes
        private void btnSave_Click(object sender, EventArgs e)
        {
            bool valid = true;         
            if(isAdd) // validate code
            {
                if (Validator.IsPresent(txtProductCode))
                {
                    // check if unique
                    string code = txtProductCode.Text;
                    List<string> codes = ProductDB.GetProductCodes();
                    foreach(string c in codes)
                    {
                        if (c.Trim() == code.Trim())
                        {
                            MessageBox.Show($"Duplicate product code: {code}");
                            valid = false; // found duplicate
                        }
                    }
                }
                else // empty string
                {
                    valid = false;
                }
            }
            // for both Add and Modify
            if( valid &&
                Validator.IsPresent(txtDescription) &&
                Validator.IsPresent(txtUnitPrice) &&
                Validator.IsNonNegativeDecimal(txtUnitPrice) &&
                Validator.IsPresent(txtQuantity) &&
                Validator.IsNonNegativeInt(txtQuantity)
              ) // valid data
            {
                if(isAdd) // need to create the object
                {
                    currentProduct = new Product();
                }
                // put data in
                currentProduct.ProductCode = txtProductCode.Text;
                currentProduct.Description = txtDescription.Text;
                currentProduct.UnitPrice = Convert.ToDecimal(txtUnitPrice.Text);
                currentProduct.OnHandQuantity = Convert.ToInt32(txtQuantity.Text);
                
                DialogResult = DialogResult.OK;
            }
        }

    }
}
