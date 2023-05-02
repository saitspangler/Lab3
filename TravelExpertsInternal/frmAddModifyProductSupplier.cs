using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using TravelExpertsDatas;

namespace TravelExpertsInternal
{
    public partial class frmAddModifyProductSupplier : Form
    {
        /*
        * The purpose of this application is to collect product supplier infromation from the user 
        * The application will manage product supplier information such as product id and supplier id, User will be able to add, modify product supplier combinations in the attached database.
        * Created on May 1, 2023
        * Author: Peter Thiel
        */

        // form level variables
        // public data for main form to set
        public bool isAdd; // true if Add false if Modify
        public ProductsSupplier? currentProductsSupplier = null; // selected supplier when Modify or null when Add

        public frmAddModifyProductSupplier()
        {
            InitializeComponent();

            //// populated data for combo boxes
            //List<Product> products = ProductManager.GetAllProducts();
            //List<Supplier> suppliers = SupplierManager.GetAllSuppliers();
            //// linking to combo boxes
            //cboProductID.DataSource = products;
            //cboProductID.DisplayMember = "ProductId";
            //cboProductID.ValueMember = "ProdName";
            //cboSupplierID.DataSource = suppliers;
            //cboSupplierID.DisplayMember = "SupplierId";
            //cboSupplierID.ValueMember = "SupName";

            // alternate method to populate combo boxes
            List<int> productIDs = ProductManager.GetAllProductIDs();
            cboProductID.DataSource = productIDs;
            List<int> supplierIDs = SupplierManager.GetAllSupplierIDs();
            cboSupplierID.DataSource = supplierIDs;
        }

        private void frmAddModifyProductSupplier_Load(object sender, EventArgs e)
        {
            // differentiates between Add and Modify
            if (isAdd) // an add operation
            {
                this.Text = "Add Products Supplier";
            }
            else // modify
            {
                this.Text = "Modify Products Supplier";
                DisplayProductsSupplier();

            }
        }
        // display product supplier info if modify
        private void DisplayProductsSupplier()
        {
            if (currentProductsSupplier != null)
            {
                txtProductsSupplierID.Text = currentProductsSupplier.ProductSupplierId.ToString();

                using (var context = new TravelExpertsContext())
                {
                    var productSupplier = context.ProductsSuppliers
                                                 .FirstOrDefault(ps => ps.ProductSupplierId == currentProductsSupplier.ProductSupplierId);

                    if (productSupplier != null)
                    {
                        // get the supplier name
                        var supplierName = context.Suppliers
                                                   .Where(s => s.SupplierId == productSupplier.SupplierId)
                                                   .Select(s => s.SupName)
                                                   .FirstOrDefault();

                        // set the supplier combobox
                        var supplierItem = new { SupplierId = productSupplier.SupplierId, SupName = supplierName };
                        cboSupplierID.DataSource = new List<object> { supplierItem };
                        cboSupplierID.DisplayMember = "SupName";
                        cboSupplierID.ValueMember = "SupplierId";

                        // get the product name
                        var productName = context.Products
                                                  .Where(p => p.ProductId == productSupplier.ProductId)
                                                  .Select(p => p.ProdName)
                                                  .FirstOrDefault();

                        // set the product combobox
                        var productItem = new { ProductId = productSupplier.ProductId, ProdName = productName };
                        cboProductID.DataSource = new List<object> { productItem };
                        cboProductID.DisplayMember = "ProdName";
                        cboProductID.ValueMember = "ProductId";
                    }
                }
            }
        }

        // when the accept button is clicked
        private void btnAccept_Click(object sender, EventArgs e)
        {
            bool valid = true;
            // if valid
            if (!isAdd) // if modify validate code
            {
                if (Validator.IsPresent(txtProductsSupplierID))
                {
                    if (isAdd) // need to create a new product object
                    {
                        currentProductsSupplier = new ProductsSupplier();
                    }

                    // check if unique
                    int id = Convert.ToInt32(txtProductsSupplierID);
                    List<int> ids = ProductSuppliersManager.GetAllProductsSupplierIDs();
                    foreach (int p in ids)
                    {
                        if (p == id)
                        {
                            MessageBox.Show($"Duplicate product code: {id}");
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

            if (valid)
            {
                if (isAdd) // need to create the object
                {
                    currentProductsSupplier = new ProductsSupplier();
                }
                // fill in data of product supplier object with new values
                currentProductsSupplier.ProductId = Convert.ToInt32(cboProductID);
                currentProductsSupplier.SupplierId = Convert.ToInt32(cboSupplierID);

                DialogResult = DialogResult.OK; 
            }
            
        }

        // no need to write code for Cancel button because it has been set as CancelButton on the form
    }
}

