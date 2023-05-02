using Microsoft.EntityFrameworkCore;
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
    public partial class frmAddUpdatePackages : Form
    {
        private Package package;

        private int selectedProductId;

        private string selectedProductName;

        public frmAddUpdatePackages(Package package = null)
        {
            InitializeComponent();
            this.package = package;
            LoadSuppliers();
        }
        private void LoadSuppliers()
        {
            cbSuppliers.Items.Clear();
            // Get all suppliers from the database
            var suppliers = SupplierManager.GetAllSuppliers();
            foreach (Supplier supplier in suppliers)
            {
                cbSuppliers.Items.Add(supplier.SupName);
            }
        }

        private void frmAddUpdatePackages_Load(object sender, EventArgs e)
        {
            if (package != null && package.PackageId > 0)
            {
                modifyPackage(package.PackageId);
            }
            else { addPackage(); }
        }

        private void addPackage()
        {
            // Initialize the controls on the form with default values for a new package
            txtPackageName.Text = "";
            txtPackageDescription.Text = "";
            dtpStartDate.Value = DateTime.Now;
            dtpEndDate.Value = DateTime.Now;
            txtPackagePrice.Text = "0.00";
            txtPackageAgencyCommission.Text = "0.00";
        }

        private void modifyPackage(int id)
        {

            // create a new instance of the TravelExpertsContext class
            TravelExpertsContext db = new TravelExpertsContext();
            // Retrieve the Package object from the database and include its associated products
            package = db.Packages
                .Include(p => p.PackagesProductsSuppliers)
                .ThenInclude(pps => pps.ProductSupplier)
                .ThenInclude(ps => ps.Product)
                .FirstOrDefault(p => p.PackageId == id);

            // Load the data from the Package object into the controls on the form
            txtPackageName.Text = package.PkgName;
            txtPackageDescription.Text = package.PkgDesc;
            dtpStartDate.Value = package.PkgStartDate.GetValueOrDefault();
            dtpEndDate.Value = package.PkgEndDate.GetValueOrDefault();
            txtPackagePrice.Text = package.PkgBasePrice.ToString("F2");
            txtPackageAgencyCommission.Text = package.PkgAgencyCommission.
                GetValueOrDefault().ToString("F2");

            // Clear the ListBox and add the product names to it
            lbPackageProductList.Items.Clear();
            foreach (var pps in package.PackagesProductsSuppliers)
            {
                lbPackageProductList.Items.Add(pps.ProductSupplier.Product.ProdName);
            }

        }

        private void btnSavePackage_Click(object sender, EventArgs e)
        {
            // Create a new instance of the TravelExpertsContext class
            using (var db = new TravelExpertsContext())
            {
                // Check if the package object is null
                if (package == null)
                {
                    // Create a new Package object
                    package = new Package();
                }

                // Update the Package object with the data from the controls on the form
                package.PkgName = txtPackageName.Text;
                if (txtPackageDescription.Text.Length > 50)
                {
                    MessageBox.Show("The package description cannot exceed 50 characters. Your input has been truncated.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPackageDescription.Text = txtPackageDescription.Text.Substring(0, 50);
                }
                package.PkgDesc = txtPackageDescription.Text; package.PkgStartDate = dtpStartDate.Value;
                package.PkgEndDate = dtpEndDate.Value;
                package.PkgBasePrice = decimal.Parse(txtPackagePrice.Text);
                package.PkgAgencyCommission = decimal.Parse(txtPackageAgencyCommission.Text);

                // Check if the Package object has a valid PackageId
                if (package.PackageId > 0)
                {
                    // Update the existing Package object in the database
                    db.Entry(package).State = EntityState.Modified;
                }
                else
                {
                    // Add the new Package object to the database
                    db.Packages.Add(package);
                }

                try
                {
                    // Save changes to the database
                    db.SaveChanges();
                }
                catch (DbUpdateException ex)
                {
                    // Display the message from the inner exception
                    MessageBox.Show(ex.InnerException.Message);
                }
                // Get the selected products from the ListBox
                var selectedProducts = lbPackageProductList.Items.Cast<string>().ToList();

                // Remove any existing associations between this package and products that are not selected
                var existingAssociations = db.PackagesProductsSuppliers.Where
                    (pps => pps.PackageId == package.PackageId).ToList();
                foreach (var association in existingAssociations)
                {
                    var product = db.ProductsSuppliers.Where(ps => ps.ProductSupplierId == 
                    association.ProductSupplierId).Select(ps => ps.Product).FirstOrDefault();
                    if (!selectedProducts.Contains(product.ProdName))
                    {
                        db.PackagesProductsSuppliers.Remove(association);
                    }
                }

                // Add new associations between this package and the selected products
                foreach (var productName in selectedProducts)
                {
                    var product = db.Products.FirstOrDefault(p => p.ProdName == productName);
                    if (product != null)
                    {
                        var productSupplierId = db.ProductsSuppliers.Where(ps => ps.ProductId 
                        == product.ProductId).Select(ps => ps.ProductSupplierId).FirstOrDefault();
                        if (!existingAssociations.Any(pps => pps.ProductSupplierId == productSupplierId))
                        {
                            var newAssociation = new PackagesProductsSupplier { PackageId = package.PackageId,
                                ProductSupplierId = productSupplierId };
                            db.PackagesProductsSuppliers.Add(newAssociation);
                        }
                    }
                }

                // Save changes to the database
                db.SaveChanges();
            }
            this.Close();
        }

        private void cbSuppliers_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Clear the ListBox
            lbAddProductList.Items.Clear();

            // Get the selected supplier name
            string selectedSupplierName = cbSuppliers.SelectedItem.ToString();

            // Get the selected supplier object
            Supplier selectedSupplier = null;
            using (var context = new TravelExpertsContext())
            {
                selectedSupplier = context.Suppliers.Include(s => s.ProductsSuppliers).
                    ThenInclude(ps => ps.Product).FirstOrDefault(s => s.SupName == selectedSupplierName);
            }

            // Add the products from the selected supplier to the ListBox
            if (selectedSupplier != null)
            {
                foreach (ProductsSupplier ps in selectedSupplier.ProductsSuppliers)
                {
                    lbAddProductList.Items.Add(ps.Product);
                }
            }
        }

        private void btnAddToPackage_Click(object sender, EventArgs e)
        {
            // Check if a product is selected
            if (string.IsNullOrEmpty(selectedProductName))
            {
                // Display an error message
                MessageBox.Show("Please select a product to add.");
            }
            else if (lbPackageProductList.Items.Contains(selectedProductName))
            {
                // Display an error message
                MessageBox.Show("This product is already in the package.");
            }
            else
            {
                // Create a new Product object with the information of the selected product
                var product = new Product { ProductId = selectedProductId, ProdName = selectedProductName };

                // Add the product name to the ListBox
                lbPackageProductList.Items.Add(product.ProdName);
            }
        }

        private void lbAddProductList_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the selected item in the ListBox
            var selectedItem = (Product)lbAddProductList.SelectedItem;

            // Get the ProductId of the selected item and store it in the selectedProductId variable
            selectedProductId = selectedItem.ProductId;
            selectedProductName = selectedItem.ProdName;
        }

        private void btnCancelAdd_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRemoveFromPackage_Click(object sender, EventArgs e)
        {
            // Check if an item is selected in the ListBox
            if (lbPackageProductList.SelectedItem != null)
            {
                // Remove the selected item from the ListBox
                lbPackageProductList.Items.Remove(lbPackageProductList.SelectedItem);
            }
        }
    }
}
