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
    /*All the below was done by Allen F. Horton.
     * Form allows you to select a product to add or update.
     */
    public partial class frmProducts : Form
    {
        private Product currentProduct;
        private const int MODIFY_INDEX = 2;
        public frmProducts()
        {
            InitializeComponent();
        }


        private void frmProducts_Load(object sender, EventArgs e)
        {
            DisplayProducts();
        }

        private void DisplayProducts()
        {
            dgvProducts.Rows.Clear();
            List<Product> products = ProductManager.GetAllProducts();
            //dgvProducts.DataSource = products;
            dgvProducts.Columns.Clear();
            dgvProducts.Columns.Add("ProductId", "Product ID");
            dgvProducts.Columns.Add("ProdName", "Product Name");
            dgvProducts.Columns[0].Width = 100;
            dgvProducts.Columns[1].Width = 200;
            var modifyColumn = new DataGridViewButtonColumn()
            {
                UseColumnTextForButtonValue = true,
                HeaderText = "",
                Text = "Modify"
            };
            dgvProducts.Columns.Add(modifyColumn);

            foreach (Product product in products)
            {
                dgvProducts.Rows.Add(product.ProductId, product.ProdName);
            }
        }

        private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string productCode = dgvProducts.
                Rows[e.RowIndex].Cells[0].Value.ToString().Trim();
            try
            {
                currentProduct = ProductManager.FindProduct(productCode);
                if (currentProduct != null)
                {
                    if (e.ColumnIndex == MODIFY_INDEX)// Modify
                    {
                        ModifyProduct();
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while finding a product: " +
                    ex.Message, ex.GetType().ToString());
            }
        }



        private void ModifyProduct()
        {
            frmAddUpdateProduct secondForm = new frmAddUpdateProduct();
            secondForm.isAdd = false; // it is modify
            secondForm.currentProduct = currentProduct;
            DialogResult result = secondForm.ShowDialog();
            if (result == DialogResult.OK) // proceed with modify
            {
                currentProduct = secondForm.currentProduct; // new data values
                try
                {
                    ProductManager.UpdateProduct(currentProduct);
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddUpdateProduct secondForm = new frmAddUpdateProduct();
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
                        ProductManager.AddProduct(currentProduct);
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

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

