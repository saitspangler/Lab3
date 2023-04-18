using TechSupportData;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace ProductMaintenanceGUI
/*
* Product Maintenance Application
* 
* Author: Peter Spangler
* 
* 
* Date: April 2023
*/
{
    public partial class frmProductsMaintenace : Form
    {

        string productCode;

        private Product currentProduct;

        public frmProductsMaintenace()
        {
            InitializeComponent();
        }

        private void frmProductsMaintenace_Load(object sender, EventArgs e)
        {
            DisplayProducts();
        }

        private void DisplayProducts()
        {
            dgvProducts.Columns.Clear();// reset columns
            List<ProductDTO> products = ProductDB.GetProducts();
            dgvProducts.DataSource = products;
            dgvProducts.Columns[0].HeaderText = "Product Code";
            dgvProducts.Columns[0].Width = 150;
            dgvProducts.Columns[1].HeaderText = "Name";
            dgvProducts.Columns[1].Width = 450;
            dgvProducts.Columns[2].HeaderText = "Version";
            dgvProducts.Columns[2].Width = 200;
            dgvProducts.Columns[3].HeaderText = "Release Date";
            dgvProducts.Columns[3].DefaultCellStyle.Format = "d";
            dgvProducts.Columns[3].Width = 250;
        }

        // add a new product
        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddModifyProduct secondForm = new frmAddModifyProduct();
            secondForm.isAdd = true;
            secondForm.currentProduct = null;
            DialogResult result = secondForm.ShowDialog();
            if (result == DialogResult.OK) // proceed with add
            {
                currentProduct = secondForm.currentProduct;
                if (currentProduct != null)
                {
                    try
                    {
                        ProductDB.AddProduct(currentProduct);
                        DisplayProducts(); // refresh grid
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
                        MessageBox.Show("Database connection lost while adding a product. Try again later");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error while adding a product: " +
                            ex.Message, ex.GetType().ToString());
                    }
                }
            }
        }

        // user clicked on a cell within the grid view
        private void dgvProducts_CellClick(object sender,
            DataGridViewCellEventArgs e)
        {
            // e.ColumnIndex is the column where the click happened
            // e.RowIndex is the row where the click happened
            // return Product Code value
            try
            {
                productCode = dgvProducts.Rows[e.RowIndex].Cells[0].Value.ToString();
                currentProduct = ProductDB.FindProduct(productCode);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while getting product: " +
                    ex.Message, ex.GetType().ToString());
            }
        }

        // modify current product
        private void ModifyProduct(string productCode)
        {
            frmAddModifyProduct secondForm = new frmAddModifyProduct();
            secondForm.isAdd = false; // it is modify
            secondForm.currentProduct = (Product)currentProduct;
            DialogResult result = secondForm.ShowDialog();
            if (result == DialogResult.OK) // proceed with modify
            {
                currentProduct = secondForm.currentProduct; // new data values
                try
                {
                    ProductDB.UpdateProduct((Product)currentProduct);
                    DisplayProducts(); // refresh grid
                }
                catch (DbUpdateException ex) // errors coming from SaveChanges
                {
                    string errorMessage = "Error(s) while modifying product:\n";
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
                    MessageBox.Show("Database connection lost while modifying a product." +
                        " Try again later");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error while modifying a product: " +
                        ex.Message, ex.GetType().ToString());
                }
            }
        }

        // delete current product
        private void RemoveProduct(string productCode)
        {
            if (productCode != null)
            {
                DialogResult result = MessageBox.Show(
                $"Do you want to delete the following product?\n" +
                $"Product Code: {productCode}\n" + $"This action cannot be undone.",
                    "Confirm delete", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                if (result == DialogResult.Yes)// user confirmed
                {
                    try
                    {
                        ProductDB.DeleteProduct(productCode);
                        DisplayProducts(); // refresh grid
                    }
                    catch (DbUpdateException ex) // errors coming from SaveChanges
                    {
                        string errorMessage = "Error(s) while deleting product:\n";
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
                        MessageBox.Show("Database connection lost while deleting a product." +
                            " Try again later");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error while deleting a product: " +
                            ex.Message, ex.GetType().ToString());
                    }
                }
            }
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            if (Validator.IsRowSelected(dgvProducts))
            {
                ModifyProduct(productCode);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (Validator.IsRowSelected(dgvProducts))
            {
                RemoveProduct(productCode);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}