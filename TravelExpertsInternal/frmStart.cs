namespace TravelExpertsInternal

    // author of this form : Hector Villouta
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }

        private void btnAddPackages_Click(object sender, EventArgs e)
        {
            frmPackages secondForm = new frmPackages();
            secondForm.Show();
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            frmProducts thirdForm = new frmProducts();
            thirdForm.Show();
        }


        private void btnSuppliers_Click(object sender, EventArgs e)
        {
            frmSupplier suppliersForm = new frmSupplier();
            suppliersForm.Show();
        }

        private void btnProductSuppliers_Click(object sender, EventArgs e)
        {
            frmProductSuppliers fourthForm = new frmProductSuppliers();
            fourthForm.Show();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            frmAddUpdateProduct addUpdateProductForm = new frmAddUpdateProduct();
            addUpdateProductForm.Show();
        }
    }
}