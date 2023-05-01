using System;
using System.Windows.Forms;
using TravelExpertsDatas;

namespace TravelExpertsInternal
{
    public partial class frmSupplier : Form
    {
        private DataGridView dgvSuppliers;
        private const int MODIFY_INDEX = 2;

        public frmSupplier()
        {
            InitializeComponent();

            dgvSuppliers = new DataGridView
            {
                Dock = DockStyle.Fill,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            };
            this.Controls.Add(dgvSuppliers);

            this.Load += frmSupplier_Load;
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

        private void ModifySupplier(Supplier currentSupplier)
        {

            throw new NotImplementedException();
        }

        private void dgvSupplier_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == MODIFY_INDEX)
            {
                int supplierID = Convert.ToInt32(dgvSuppliers.Rows[e.RowIndex].Cells[0].Value);

                try
                {
                    Supplier currentSupplier = SupplierManager.GetSupplier(supplierID);

                    if (currentSupplier != null)
                    {
                        ModifySupplier(currentSupplier);
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
