using TechSupportData;

namespace ProductMaintenanceGUI
{
    /*
    * Product Maintenance Application
    * 
    * Author: Peter Spangler
    * 
    * 
    * Date: April 2023
    */
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

        /// <summary>
        /// display current product
        /// </summary>
        private void DisplayProduct()
        {
            if (currentProduct != null)
            {
                txtProductCode.Text = currentProduct.ProductCode.ToUpper();
                txtName.Text = currentProduct.Name;
                txtVersion.Text = currentProduct.Version.ToString();// no formatting!!
                txtReleaseDate.Text = currentProduct.ReleaseDate.ToString("MM/dd/yyyy"); //format date to fit validator and nudge user towards accepted format
            }
        }

        /// <summary>
        /// save changes from either adding or modifying a product
        /// </summary>
        private void btnSave_Click(object sender, EventArgs e)
        {
            bool valid = true;
            if (isAdd) // validate code
            {
                if (Validator.IsPresent(txtProductCode) && Validator.IsValidLength(txtProductCode, 10))
                {
                    // check if unique
                    string code = txtProductCode.Text;
                    List<string> codes = ProductDB.GetProductCodes();
                    foreach (string c in codes)
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
            if (valid &&
                Validator.IsPresent(txtName) &&
                Validator.IsValidLength(txtName, 50) &&
                Validator.IsPresent(txtVersion) &&
                Validator.IsNonNegativeDecimal(txtVersion) &&
                Validator.IsDecimalInRange(txtVersion, 0, 9) &&
                Validator.IsPresent(txtReleaseDate) &&
                Validator.IsValidDate(txtReleaseDate)
              ) // valid data
            {
                if (isAdd) // need to create the object
                {
                    currentProduct = new Product();
                }
                // put data in
                currentProduct.ProductCode = txtProductCode.Text.ToUpper();
                currentProduct.Name = txtName.Text;
                currentProduct.Version = Convert.ToDecimal(txtVersion.Text);
                currentProduct.ReleaseDate = Convert.ToDateTime(txtReleaseDate.Text);

                DialogResult = DialogResult.OK;
            }
        }

    }
}
