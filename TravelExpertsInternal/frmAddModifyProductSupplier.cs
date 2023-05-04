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

        /* Provided code for 'DisplayProductsSupplier()' so that comboboxes show ProdNames and SupNames 
         * instead of ProductIds and SupplierIds.
         * Changed frmAddModifyProductSupplier design.
         * Took away modify capability.
         *Author: Allen F. Horton
         */

        // form level variables
        // public data for main form to set
      
        public ProductsSupplier? currentProductsSupplier = null; // selected supplier when Modify or null when Add

        public frmAddModifyProductSupplier()
        {
            InitializeComponent();

            

            // alternate method to populate combo boxes
            List<int> productIDs = ProductManager.GetAllProductIDs();
            cboProductID.DataSource = productIDs;
            List<int> supplierIDs = SupplierManager.GetAllSupplierIDs();
            cboSupplierID.DataSource = supplierIDs;
        }

        private void frmAddModifyProductSupplier_Load(object sender, EventArgs e)
        {
           
            
                this.Text = "Add Products Supplier";
                DisplayProductsSupplier();
            
            
        }
        // display product supplier info if modify or add 
        private void DisplayProductsSupplier()
        {
            
                using (var context = new TravelExpertsContext())
                {
                    var suppliers = context.Suppliers.Select(s => new { s.SupplierId, s.SupName }).ToList();
                    cboSupplierID.DataSource = suppliers;
                    cboSupplierID.DisplayMember = "SupName";
                    cboSupplierID.ValueMember = "SupplierId";

                    var products = context.Products.Select(p => new { p.ProductId, p.ProdName }).ToList();
                    cboProductID.DataSource = products;
                    cboProductID.DisplayMember = "ProdName";
                    cboProductID.ValueMember = "ProductId";
                }
           

        }

        // when the accept button is clicked
        private void btnAccept_Click(object sender, EventArgs e)
        {
            bool valid = true;

            // for both Add and Modify

            if (valid)
            {
                
                currentProductsSupplier = new ProductsSupplier();
                
                // fill in data of product supplier object with new values
                currentProductsSupplier.ProductId = (int)cboProductID.SelectedValue;
                currentProductsSupplier.SupplierId = (int)cboSupplierID.SelectedValue;



                DialogResult = DialogResult.OK;
            }

        }

        // no need to write code for Cancel button because it has been set as CancelButton on the form
    }
}

