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
    public partial class frmPackageMaintenance : Form
    {
        public frmPackageMaintenance()
        {
            InitializeComponent();
        }

        private TravelExpertsContext context = new TravelExpertsContext();
        private Package selectedPackage;
        private Product selectedProduct;
        private Supplier selectedSupplier;


        private void DisplayProducts()
        {
            dgvDisplay.Columns.Clear();
            var products = context.Products
                .OrderBy(p => p.ProductId)
                .Select(p => new { p.ProductId, p.ProdName })
                .ToList();

            dgvDisplay.DataSource = products;

            // add column for modify button
            var modifyColumn = new DataGridViewButtonColumn()
            {
                UseColumnTextForButtonValue = true,
                HeaderText = "",
                Text = "Modify"
            };
            dgvDisplay.Columns.Add(modifyColumn);

            // format the column header
            dgvDisplay.EnableHeadersVisualStyles = false;
            dgvDisplay.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9, FontStyle.Bold);
            dgvDisplay.ColumnHeadersDefaultCellStyle.BackColor = Color.Goldenrod;
            dgvDisplay.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            // format the odd numbered rows
            dgvDisplay.AlternatingRowsDefaultCellStyle.BackColor = Color.PaleGoldenrod;

            // format the first column
            dgvDisplay.Columns[0].HeaderText = "Product ID";
            dgvDisplay.Columns[0].Width = 110;

            // format the second column
            dgvDisplay.Columns[1].HeaderText = "Product";
            dgvDisplay.Columns[1].Width = 310;

            // format the third column
            dgvDisplay.Columns[2].HeaderText = "";
            dgvDisplay.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvDisplay.Columns[2].Width = 100;

        }


        private void DisplayPackages()
        {
            dgvDisplay.Columns.Clear();
            var products = context.Packages
                .OrderBy(p => p.PackageId)
                .Select(p => new { p.PkgName, p.PkgDesc, p.PkgStartDate, p.PkgEndDate, p.PkgBasePrice, p.PkgAgencyCommission })
                .ToList();

            dgvDisplay.DataSource = products;

            // add column for modify button
            var modifyColumn = new DataGridViewButtonColumn()
            {
                UseColumnTextForButtonValue = true,
                HeaderText = "",
                Text = "Modify"
            };
            dgvDisplay.Columns.Add(modifyColumn);


            // format the column header
            dgvDisplay.EnableHeadersVisualStyles = false;
            dgvDisplay.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9, FontStyle.Bold);
            dgvDisplay.ColumnHeadersDefaultCellStyle.BackColor = Color.Goldenrod;
            dgvDisplay.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            // format the odd numbered rows
            dgvDisplay.AlternatingRowsDefaultCellStyle.BackColor = Color.PaleGoldenrod;

            //// format the first column
            //dgvDisplay.Columns[0].HeaderText = "Product Code";
            //dgvDisplay.Columns[0].Width = 110;

            //// format the second column
            //dgvDisplay.Columns[1].Width = 310;

            //// format the third column
            //dgvDisplay.Columns[2].HeaderText = "Unit Price";
            //dgvDisplay.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            //dgvDisplay.Columns[2].Width = 90;
            //dgvDisplay.Columns[2].DefaultCellStyle.Format = "c";
            //dgvDisplay.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }


        private void DisplaySuppliers()
        {
            dgvDisplay.Columns.Clear();
            var products = context.Suppliers
                .OrderBy(s => s.SupplierId)
                .Select(s => new { s.SupplierId, s.SupName })
                .ToList();

            dgvDisplay.DataSource = products;

            // add column for modify button
            var modifyColumn = new DataGridViewButtonColumn()
            {
                UseColumnTextForButtonValue = true,
                HeaderText = "",
                Text = "Modify"
            };
            dgvDisplay.Columns.Add(modifyColumn);


            // format the column header
            dgvDisplay.EnableHeadersVisualStyles = false;
            dgvDisplay.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9, FontStyle.Bold);
            dgvDisplay.ColumnHeadersDefaultCellStyle.BackColor = Color.Goldenrod;
            dgvDisplay.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            // format the odd numbered rows
            dgvDisplay.AlternatingRowsDefaultCellStyle.BackColor = Color.PaleGoldenrod;

            //// format the first column
            //dgvDisplay.Columns[0].HeaderText = "Product Code";
            //dgvDisplay.Columns[0].Width = 110;

            //// format the second column
            //dgvDisplay.Columns[1].Width = 310;

            //// format the third column
            //dgvDisplay.Columns[2].HeaderText = "Unit Price";
            //dgvDisplay.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            //dgvDisplay.Columns[2].Width = 90;
            //dgvDisplay.Columns[2].DefaultCellStyle.Format = "c";
            //dgvDisplay.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }

        private void rdoPackages_CheckedChanged(object sender, EventArgs e)
        {
            //rdoPackages.Checked = true;
            Packages_Checked();
        }

        private void Packages_Checked()
        {
            btnAddPackage.Visible = true;
            btnAddProduct.Visible = false;
            btnAddSupplier.Visible = false;

            DisplayPackages();
        }

        private void rdoProducts_CheckedChanged(object sender, EventArgs e)
        {

            btnAddPackage.Visible = false;
            btnAddProduct.Visible = true;
            btnAddSupplier.Visible = false;

            DisplayProducts();
        }

        private void rdoSuppliers_CheckedChanged(object sender, EventArgs e)
        {
            btnAddPackage.Visible = false;
            btnAddProduct.Visible = false;
            btnAddSupplier.Visible = true;

            DisplaySuppliers();
        }

        private void frmPackageMaintenance_Load(object sender, EventArgs e)
        {
            Packages_Checked();
        }

        private void ModifyProduct()
        {
            var addModifyProductForm = new frmAddModifyProduct()
            {
                AddProduct = false,
                Product = selectedProduct
            };
            DialogResult result = addModifyProductForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                try
                {
                    selectedProduct = addModifyProductForm.Product;
                    context.SaveChanges();
                    DisplayProducts();
                }
                catch (DbUpdateConcurrencyException ex)
                {
                    HandleConcurrencyError(ex);
                }
                catch (DbUpdateException ex)
                {
                    HandleDatabaseError(ex);
                }
                catch (Exception ex)
                {
                    HandleGeneralError(ex);
                }
            }
        }

        private void ModifyPackage()
        {
            var addModifyPackageForm = new frmAddModifyPackage()
            {
                AddPackage = false,
                Package = selectedPackage
            };
            DialogResult result = addModifyPackageForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                try
                {
                    selectedPackage = addModifyPackageForm.Package;
                    context.SaveChanges();
                    DisplayPackages();
                }
                catch (DbUpdateConcurrencyException ex)
                {
                    HandleConcurrencyError(ex);
                }
                catch (DbUpdateException ex)
                {
                    HandleDatabaseError(ex);
                }
                catch (Exception ex)
                {
                    HandleGeneralError(ex);
                }
            }
        }

        private void ModifySupplier()
        {
            var addModifySupplierForm = new frmAddModifySupplier()
            {
                AddSupplier = false,
                Supplier = selectedSupplier
            };
            DialogResult result = addModifySupplierForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                try
                {
                    selectedSupplier = addModifySupplierForm.Supplier;
                    context.SaveChanges();
                    DisplaySuppliers();
                }
                catch (DbUpdateConcurrencyException ex)
                {
                    HandleConcurrencyError(ex);
                }
                catch (DbUpdateException ex)
                {
                    HandleDatabaseError(ex);
                }
                catch (Exception ex)
                {
                    HandleGeneralError(ex);
                }
            }
        }

        private void HandleConcurrencyError(DbUpdateConcurrencyException ex)
        {
            ex.Entries.Single().Reload();

            var state = context.Entry(selectedProduct).State;
            if (state == EntityState.Detached)
            {
                MessageBox.Show("Another user has deleted that product.",
                    "Concurrency Error");
            }
            else
            {
                string message = "Another user has updated that product.\n" +
                    "The current database values will be displayed.";
                MessageBox.Show(message, "Concurrency Error");
            }
            this.DisplayProducts();
        }

        private void HandleDatabaseError(DbUpdateException ex)
        {
            string errorMessage = "";
            var sqlException = (SqlException)ex.InnerException;
            foreach (SqlError error in sqlException.Errors)
            {
                errorMessage += "ERROR CODE:  " + error.Number + " " +
                                error.Message + "\n";
            }
            MessageBox.Show(errorMessage);
        }

        private void HandleGeneralError(Exception ex)
        {
            MessageBox.Show(ex.Message, ex.GetType().ToString());
        }

        private void dgvDisplay_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (rdoPackages.Checked == true)
            {
                const int ModifyIndex = 7;

                if (e.ColumnIndex == ModifyIndex)
                {
                    string packageId = dgvDisplay.Rows[e.RowIndex].Cells[0].Value.ToString().Trim();
                    selectedPackage = context.Packages.Find(packageId);
                    ModifyPackage();

                }


            }

            if (rdoProducts.Checked == true)
            {
                const int ModifyIndex = 3;

                if (e.ColumnIndex == ModifyIndex)
                {
                    string productId = dgvDisplay.Rows[e.RowIndex].Cells[0].Value.ToString().Trim();
                    selectedProduct = context.Products.Find(productId);
                }

                if (e.ColumnIndex == ModifyIndex)
                {
                    ModifyProduct();
                }
            }

            if (rdoSuppliers.Checked == true)
            {
                const int ModifyIndex = 3;

                if (e.ColumnIndex == ModifyIndex)
                {
                    string supplierId = dgvDisplay.Rows[e.RowIndex].Cells[0].Value.ToString().Trim();
                    selectedSupplier = context.Suppliers.Find(supplierId);
                }

                if (e.ColumnIndex == ModifyIndex)
                {
                    ModifySupplier();
                }
            }
        }

        private void btnAddPackage_Click(object sender, EventArgs e)
        {
            var addModifyPackageForm = new frmAddModifyPackage()
            {
                AddPackage = true
            };
            DialogResult result = addModifyPackageForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                try
                {
                    selectedPackage = addModifyPackageForm.Package;
                    context.Packages.Add(selectedPackage);
                    context.SaveChanges();
                    DisplayPackages();
                }
                catch (DbUpdateException ex)
                {
                    HandleDatabaseError(ex);
                }
                catch (Exception ex)
                {
                    HandleGeneralError(ex);
                }
            }
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            var addModifyProductForm = new frmAddModifyProduct()
            {
                AddProduct = true
            };
            DialogResult result = addModifyProductForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                try
                {
                    selectedProduct = addModifyProductForm.Product;
                    context.Products.Add(selectedProduct);
                    context.SaveChanges();
                    DisplayProducts();
                }
                catch (DbUpdateException ex)
                {
                    HandleDatabaseError(ex);
                }
                catch (Exception ex)
                {
                    HandleGeneralError(ex);
                }
            }
        }

        private void btnAddSupplier_Click(object sender, EventArgs e)
        {
            var addModifySupplierForm = new frmAddModifySupplier()
            {
                AddSupplier = true
            };
            DialogResult result = addModifySupplierForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                try
                {
                    selectedSupplier = addModifySupplierForm.Supplier;
                    context.Suppliers.Add(selectedSupplier);
                    context.SaveChanges();
                    DisplaySuppliers();
                }
                catch (DbUpdateException ex)
                {
                    HandleDatabaseError(ex);
                }
                catch (Exception ex)
                {
                    HandleGeneralError(ex);
                }
            }
        }
    }
}
