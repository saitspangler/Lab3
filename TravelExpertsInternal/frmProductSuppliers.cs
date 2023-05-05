using Microsoft.Data.SqlClient;
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
    /*
    * The purpose of this application is to let the user maintain product suppliers. Main Form displays data of all product suppliers and allows the user to select one.
    * The application will display product supplier id, product id, supplier id. User will be able to add, modify product suppliers in the attached database.
    * Created on Apr 28, 2023
    * Author: Peter Thiel
    */

    /* 1. Fixed 'Back' button.
     * 2. Made 'DisplayProductsSupplier()' so that it shows ProdName for ProductId and SupName SupplierId in dgv.
     * 3. Got rid of modify functionality.
     * Author: Allen F. Horton*/
    public partial class frmProductSuppliers : Form
    {


        // private variables
        private ProductsSupplier? currentProductSupplier;
        public frmProductSuppliers()
        {
            InitializeComponent();
        }
        // on form load
        private void frmProductSuppliers_Load(object sender, EventArgs e)
        {
            DisplayProductsSupplier();
        }

        //Display ProductsSuppliers in dgv
        // Author: Allen F. Horton
        private void DisplayProductsSupplier()
        {
            dgvProductSuppliers.Rows.Clear();
            List<ProductsSupplier> productSupplier = ProductSuppliersManager.GetAllProductSuppliers();
            dgvProductSuppliers.Columns.Clear();
            // do some formatting
            dgvProductSuppliers.Columns.Add("ProductSupplierId", "Product Supplier ID");
            dgvProductSuppliers.Columns.Add("Product", "Product");
            dgvProductSuppliers.Columns.Add("Supplier", "Supplier");
            // add modify column

            dgvProductSuppliers.Columns[0].Width = 100;
            dgvProductSuppliers.Columns[1].Width = 200;
            // join with Product and Supplier tables and select ProdName and SupName instead of IDs
            var query = from ps in productSupplier
                        join p in ProductManager.GetAllProducts() on ps.ProductId equals p.ProductId
                        join s in SupplierManager.GetAllSuppliers() on ps.SupplierId equals s.SupplierId
                        select new
                        {
                            ps.ProductSupplierId,
                            ProdName = p.ProdName,
                            SupName = s.SupName
                        };
            foreach (var result in query)
            {
                dgvProductSuppliers.Rows.Add(result.ProductSupplierId, result.ProdName, result.SupName);
            }
        }






        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddModifyProductSupplier secondForm = new frmAddModifyProductSupplier(); // makes an object of the second form

            secondForm.currentProductsSupplier = null;
            DialogResult = secondForm.ShowDialog();
            secondForm.Focus();
            if (DialogResult == DialogResult.OK) // proceed with add
            {
                currentProductSupplier = secondForm.currentProductsSupplier;
                if (currentProductSupplier != null)
                {
                    try
                    {
                        ProductSuppliersManager.AddProductSupplier(currentProductSupplier);
                        DisplayProductsSupplier(); // refresh grid
                    }
                    catch (DbUpdateException ex) // errors coming from SaveChanges
                    {
                        string errorMessage = "Error(s) while adding product:\n";
                        var sqlException = (SqlException)ex.InnerException;
                        foreach (SqlError error in sqlException.Errors)
                        {
                            errorMessage += "ERROR CODE:  " + error.Number +
                                            " " + error.Message + "\n";
                        }
                        MessageBox.Show(errorMessage);
                    }
                    catch (SqlException)
                    {
                        MessageBox.Show("Database connection lost while adding a customer. Try again later");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error while adding a product: " +
                            ex.Message, ex.GetType().ToString());
                    }
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
