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

        public frmAddUpdatePackages(Package package = null)
        {

            InitializeComponent();
            this.package = package;
            if (package == null)
            {
                addPackage();
            }
            else { modifyPackage(package.PackageId); }
            LoadSuppliers();
        }
        private void LoadSuppliers()
        {
            cbSuppliers.Items.Clear();
            // Get all suppliers from the database
            using (var context = new TravelExpertsContext())
            {
                var suppliers = (from s in context.Suppliers
                                 select s).ToList();
                foreach (Supplier supplier in suppliers)
                {
                    cbSuppliers.Items.Add(supplier.SupName);
                }
            }
        }

        private void frmAddUpdatePackages_Load(object sender, EventArgs e)
        {

        }

        private void addPackage()
        {

        }

        private void modifyPackage(int id)
        {
            dgvPackageProductList.Columns.Clear();

            // create a new instance of the TravelExpertsContext class
            TravelExpertsContext db = new TravelExpertsContext();

            // define the LINQ query
            var query = from pa in db.Packages
                        join pps in db.PackagesProductsSuppliers on pa.PackageId equals pps.PackageId
                        join ps in db.ProductsSuppliers on pps.ProductSupplierId equals ps.ProductSupplierId
                        join p in db.Products on ps.ProductId equals p.ProductId
                        where pa.PackageId == id
                        select p;

            // execute the LINQ query and retrieve the results
            List<Product> products = query.ToList();
            dgvPackageProductList.DataSource = products;
            dgvPackageProductList.Columns[0].Visible = false;
            dgvPackageProductList.Columns[1].HeaderText = "Product";
            dgvPackageProductList.Columns[1].Width = 200;
        }

        private void btnSavePackage_Click(object sender, EventArgs e)
        {
            PackagesManager.AddPackage(package);
        }

        private void cbSuppliers_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Clear the DataGridView
            dgvAddProductsList.Rows.Clear();
            dgvAddProductsList.Columns.Clear();
            DataGridViewTextBoxColumn productNameColumn = new DataGridViewTextBoxColumn();
            productNameColumn.HeaderText = "Product Name";
            productNameColumn.Name = "ProductName";
            dgvAddProductsList.Columns.Add(productNameColumn);


            // Get the selected supplier name
            string selectedSupplierName = cbSuppliers.SelectedItem.ToString();

            // Get the selected supplier object
            Supplier selectedSupplier = null;
            using (var context = new TravelExpertsContext())
            {
                selectedSupplier = context.Suppliers.Include(s => s.ProductsSuppliers).ThenInclude(ps => ps.Product).FirstOrDefault(s => s.SupName == selectedSupplierName);
            }

            // Add the products from the selected supplier to the DataGridView
            if (selectedSupplier != null)
            {
                foreach (ProductsSupplier ps in selectedSupplier.ProductsSuppliers)
                {
                    dgvAddProductsList.Rows.Add(ps.Product.ProdName);
                }
            }
        }

        private void dgvAddProductsList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
