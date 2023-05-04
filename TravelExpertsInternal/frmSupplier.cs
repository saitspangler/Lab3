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
                var supplier = (Supplier)dgvSuppliers.Rows[e.RowIndex].DataBoundItem;
                var supContactId = SupplierManager.GetSupplierContactBySupplierId(supplier.SupplierId);
                var form = new frmAddModifySupplier(supContactId);
                form.FormClosed += Form_FormClosed;
                form.Show();
            }
        }
        private void btnExitSupplierPage_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddSupplier_Click(object sender, EventArgs e)
        {
            frmAddModifySupplier newForm = new frmAddModifySupplier();
            newForm.FormClosed += Form_FormClosed;
            newForm.Show();
        }


        private void Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            DisplaySuppliers();
        }


    }
}