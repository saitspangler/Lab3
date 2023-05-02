using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Windows.Forms;
using TravelExpertsDatas;

namespace TravelExpertsInternal
{
    public partial class frmSupplier : Form
    {
        // private variables / constants
        private DataGridView dgvSuppliers;
        private const int MODIFY_INDEX = 2;
        private SupplierContact? currentSupplier;

        public frmSupplier()
        {
            InitializeComponent();

        }

        private void frmSupplier_Load(object? sender, EventArgs e)
        {
            DisplaySuppliers();
        }

        //method populates the DataGridView control with data from the Suppliers
        //table in the database. It first clears any existing rows and
        //columns, then creates columns for SupplierId, Supplier Name,
        //and Modify button

        private void DisplaySuppliers()
        {
            dgvSuppliers.Rows.Clear();
            List<Supplier> suppliers = SupplierManager.GetAllSuppliers();
            dgvSuppliers.Columns.Clear();
            dgvSuppliers.Columns.Add("SupplierId", "Supplier ID");
            dgvSuppliers.Columns.Add("SupName", "Supplier Name");
            // Add modify column
            var modifyColumn = new DataGridViewButtonColumn()
            {
                UseColumnTextForButtonValue = true,
                Text = "Modify",
                HeaderText = ""
            };
            dgvSuppliers.Columns.Add(modifyColumn);
            dgvSuppliers.Columns[0].Width = 100;
            dgvSuppliers.Columns[1].Width = 200;
            foreach (Supplier supplier in suppliers)
            {
                dgvSuppliers.Rows.Add(supplier.SupplierId, supplier.SupName);
            }
        }

        private void ModifySupplier(SupplierContact currentSupplier)
        {

            // create another form to AddModifySupplier
            frmAddModifySupplier secondForm = new frmAddModifySupplier();
            secondForm.isAdd = false;
            secondForm.currentSupplier = currentSupplier;
            DialogResult = secondForm.ShowDialog();

            if (DialogResult == DialogResult.OK) // proceed with modify
            {
                currentSupplier = secondForm.currentSupplier; // new data values
                try
                {
                    if (currentSupplier != null)
                    {
                        SupplierManager.UpdateSupplier(currentSupplier);
                        DisplaySuppliers(); // refresh grid 
                    }
                }
                catch (DbUpdateException ex) // errors coming from SaveChanges
                {
                    string errorMessage = "Error(s) while modifying product supplier:\n";
                    var sqlException = (SqlException)ex.InnerException;
                    foreach (SqlError error in sqlException.Errors)
                    {
                        errorMessage += "ERROR CODE:  " + error.Number +
                                        " " + error.Message + "\n";
                    }
                    MessageBox.Show(errorMessage);
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Database connection lost while modifying a product supplier. Try again later");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error while modifying a product supplier:" + ex.Message, ex.GetType().ToString());
                }
            }
        }

        private void dgvSuppliers_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == MODIFY_INDEX)
            {
                int supplierID = Convert.ToInt32(dgvSuppliers.Rows[e.RowIndex].Cells[0].Value);

                try
                {
                    currentSupplier = SupplierManager.GetSupplier(supplierID);

                    if (currentSupplier != null)
                    {
                        if (e.ColumnIndex == MODIFY_INDEX) // modify
                        {
                            ModifySupplier(currentSupplier);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error while modifying a supplier: " + ex.Message, ex.GetType().ToString());
                }
            }
        }
    }
}
