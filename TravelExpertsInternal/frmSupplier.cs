using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Windows.Forms;
using TravelExpertsDatas;

namespace TravelExpertsInternal
{
    /*
    * Addition: changed Add/Modify Package workflow
    * Added on May 3, 2023
    * By: Peter Thiel
    */
    public partial class frmSupplier : Form
    {
        // private variables / constants
        private DataGridView dgvSuppliers;
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
            dgvSuppliers.Columns.Clear();
            List<Supplier> suppliers = SupplierManager.GetAllSuppliers();
            dgvSuppliers.DataSource = suppliers;
            // Add modify column
            var modifyColumn = new DataGridViewButtonColumn
            {
                Name = "Modify",
                Text = "Modify",
                UseColumnTextForButtonValue = true,
                Width = 100
            };
            dgvSuppliers.Columns[0].Visible = false;
            dgvSuppliers.Columns[1].Width = 250;
            dgvSuppliers.Columns[2].Visible = false;
            dgvSuppliers.Columns[3].Visible = false;
            dgvSuppliers.Columns.Add(modifyColumn);

        }

        private void dgvSuppliers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvSuppliers.Columns["Modify"].Index)
            {
                // Get the selected package
                //var supplier = (Supplier)dgvSuppliers.Rows[e.RowIndex].DataBoundItem;
                //var supContactId = SupplierManager.GetSupplierContactBySupplierId(supplier.SupplierId);
                //var form = new frmAddModifySupplier(supContactId);
                //form.FormClosed += Form_FormClosed;
                //form.Show();
                if (dgvSuppliers.Rows[e.RowIndex].Cells[0].Value != null)
                {
                    int suppliersId;

                    suppliersId = Convert.ToInt32(dgvSuppliers.Rows[e.RowIndex].Cells[0].Value);
                    try
                    {
                        currentSupplier = SupplierManager.GetSupplierContactBySupplierId(suppliersId);
                        if (currentSupplier != null)
                        {
                            UpdateSupplier();
                        }
                    }
                    catch (DbUpdateException ex) // errors coming from SaveChanges
                    {
                        string errorMessage = "Error(s) while adding supplier:\n";
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
                        MessageBox.Show("Database connection lost while adding a supplier. Try again later");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error while adding a supplier:" + ex.Message, ex.GetType().ToString());
                    }
                }
            }
        
        }

        private void UpdateSupplier()
        {
            frmAddModifySupplier newForm = new frmAddModifySupplier();
            newForm.isAdd = false; // is update
            newForm.currentSupplier = currentSupplier;
            DialogResult = newForm.ShowDialog();
            if (DialogResult == DialogResult.OK) // proceed with update
            {
                currentSupplier = newForm.currentSupplier; // new data values
                try
                {
                    // Save changes to the database
                    SupplierManager.AddSupplierContact(currentSupplier);
                    DisplaySuppliers(); // refresh the grid
                }
                catch (DbUpdateException ex) // errors coming from SaveChanges
                {
                    string errorMessage = "Error(s) while updating supplier:\n";
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
                    MessageBox.Show("Database connection lost while updating a supplier. Try again later");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error while updating a supplier:" + ex.Message, ex.GetType().ToString());
                }
                
            }
        }

        private void btnExitSupplierPage_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddSupplier_Click(object sender, EventArgs e)
        {
            frmAddModifySupplier newForm = new frmAddModifySupplier();
            newForm.isAdd = true;
            newForm.currentSupplier = null;
            DialogResult = newForm.ShowDialog();
            if (DialogResult == DialogResult.OK) // proceed with add
            {
                currentSupplier = newForm.currentSupplier;
                if (currentSupplier != null)
                {
                    try
                    {
                        // Save changes to the database
                        SupplierManager.AddSupplierContact(currentSupplier);
                        DisplaySuppliers(); // refresh the grid
                    }
                    catch (DbUpdateException ex) // errors coming from SaveChanges
                    {
                        string errorMessage = "Error(s) while adding supplier:\n";
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
                        MessageBox.Show("Database connection lost while adding a supplier. Try again later");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error while adding a supplier:" + ex.Message, ex.GetType().ToString());
                    }
                }
            }
            //newForm.FormClosed += Form_FormClosed;
            //newForm.Show();
        }


        private void Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            DisplaySuppliers();
        }
    }
}
