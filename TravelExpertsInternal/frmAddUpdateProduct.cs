using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TravelExpertsDatas;

namespace TravelExpertsInternal
{
    /*All the below was done by Allen F. Horton.
     * Form allows you to add or update selected product.
     * Addition: added field validation for add/update workflows
     * Added on May 3, 2023
     * By: Peter Thiel

     */

    public partial class frmAddUpdateProduct : Form
    {
        // public because main form needs to set it
        public Product currentProduct;
        public bool isAdd;

        public frmAddUpdateProduct()
        {
            InitializeComponent();
        }

        private void frmAddUpdateProduct_Load(object sender, EventArgs e)
        {
            if (isAdd) // it is Add
            {
                this.Text = "Add Product";
                lblAddUpdateProduct.Text = this.Text;
            }
            else //it is Modify
            {
                this.Text = "Modify Product";
                lblAddUpdateProduct.Text = this.Text;
                DisplayProduct();

            }
        }

        private void DisplayProduct()
        {

            if (currentProduct != null)
            {
                txtProdName.Text = currentProduct.ProdName;

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            // for add and modify
            if (Validator.IsPresent(txtProdName))
            {
                if (isAdd) // validate code

                {
                    currentProduct = new Product();
                }
                // put data in
                currentProduct.ProdName = txtProdName.Text;

                DialogResult = DialogResult.OK;

            }
        }
    }
}

