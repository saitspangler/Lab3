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
    public partial class frmProductSuppliers : Form
    {
        // constants
        private const int MODIFY_INDEX = 3;

        // private variables
        private ProductsSupplier? currentProductSupplier;
        public frmProductSuppliers()
        {
            InitializeComponent();
        }
        // on form load
        private void frmProductSuppliers_Load(object sender, EventArgs e)
        {
            DisplayProductSuppliers();
        }
        // displays the product supplier form
        private void DisplayProductSuppliers()
        {
            dgvProductSuppliers.Rows.Clear();
            List<ProductsSupplier> productSupplier = ProductSuppliersManager.GetAllProductSuppliers();
            dgvProductSuppliers.Columns.Clear();
            // do some formatting
            dgvProductSuppliers.Columns.Add("ProductSupplierId", "Product Supplier ID");
            dgvProductSuppliers.Columns.Add("ProductId", "Product ID");
            dgvProductSuppliers.Columns.Add("Supplier", "Sup");
            // add modify column
            var modifyColumn = new DataGridViewButtonColumn()
            {
                UseColumnTextForButtonValue = true,
                Text = "Modify",
                HeaderText = ""
            };
            dgvProductSuppliers.Columns.Add(modifyColumn);
            dgvProductSuppliers.Columns[0].Width = 100;
            dgvProductSuppliers.Columns[1].Width = 200;
            foreach (ProductsSupplier ps in productSupplier)
            {
                dgvProductSuppliers.Rows.Add(ps.ProductSupplierId, ps.ProductId, ps.SupplierId);
                
            }
        }
        // controls when user clicks on the data grid view (only modify cell is interactive)
        private void dgvProductSuppliers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == MODIFY_INDEX)
            {
                int productSupplierID = Convert.ToInt32(dgvProductSuppliers.Rows[e.RowIndex].Cells[0].Value);

                try
                {
                    currentProductSupplier = ProductSuppliersManager.GetProductSupplier(productSupplierID);
                    if (currentProductSupplier != null)
                    {
                        if(e.ColumnIndex == MODIFY_INDEX) // modify
                        {
                            ModifyProductSupplier();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error while adding a product:" + ex.Message, ex.GetType().ToString());
                }
            }
        }
        // modify the current product supplier
        private void ModifyProductSupplier()
        {
            // create another form to AddModifyProductSupplier
            throw new NotImplementedException();
        }
    }
}
