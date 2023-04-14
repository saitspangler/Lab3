using TechSupportData;

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
            if (currentProduct != null)
            {
                txtProductCode.Text = currentProduct.ProductCode;
                txtName.Text = currentProduct.Name;
                txtVersion.Text = currentProduct.Version.ToString();// no formatting!!
                txtReleaseDate.Text = currentProduct.ReleaseDate.ToString();
            }
        }

        // save changes
        private void btnSave_Click(object sender, EventArgs e)
        {
            bool valid = true;
            if (isAdd) // validate code
            {
                if (Validator.IsPresent(txtProductCode))
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
                Validator.IsPresent(txtVersion) &&
                Validator.IsPresent(txtReleaseDate)
              ) // valid data
            {
                if (isAdd) // need to create the object
                {
                    currentProduct = new Product();
                }
                // put data in
                currentProduct.ProductCode = txtProductCode.Text;
                currentProduct.Name = txtName.Text;
                currentProduct.Version = Convert.ToDecimal(txtVersion.Text);
                //get releasedate date from the form
                currentProduct.ReleaseDate = Convert.ToDateTime(txtReleaseDate.Text);

                DialogResult = DialogResult.OK;
            }
        }

    }
}
