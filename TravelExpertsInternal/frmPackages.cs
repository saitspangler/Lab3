using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.Metrics;
using System.Threading.Channels;
using TravelExpertsDatas;

namespace TravelExpertsInternal
{
    /*
    * Addition: changed Add/Modify Package workflow
    * Added on May 3, 2023
    * By: Peter Thiel
    */

    public partial class frmPackages : Form
    {

        private Package currentPackage;

        public frmPackages()
        {
            InitializeComponent();
        }

        private void frmPackages_Load(object sender, EventArgs e)
        {
            DisplayPackages();
        }

        private void DisplayPackages()
        {
            dgvPackages.Columns.Clear(); // reset columns
            List<Package> packages = PackagesManager.GetAllPackages();
            dgvPackages.DataSource = packages;
            var modifyColumn = new DataGridViewButtonColumn
            {
                Name = "Modify",
                Text = "Modify",
                UseColumnTextForButtonValue = true,
                Width = 100
            };

            dgvPackages.Columns[0].Visible = false;
            dgvPackages.Columns[1].HeaderText = "Name";
            dgvPackages.Columns[1].Width = 150;
            dgvPackages.Columns[2].HeaderText = "Start Date";
            dgvPackages.Columns[2].DefaultCellStyle.Format = "d";
            dgvPackages.Columns[2].Width = 100;
            dgvPackages.Columns[3].HeaderText = "End Date";
            dgvPackages.Columns[3].DefaultCellStyle.Format = "d";
            dgvPackages.Columns[3].Width = 100;
            dgvPackages.Columns[4].HeaderText = "Description";
            dgvPackages.Columns[4].Width = 300;
            dgvPackages.Columns[5].HeaderText = "Base Price";
            dgvPackages.Columns[5].DefaultCellStyle.Format = "c";
            dgvPackages.Columns[5].Width = 150;
            dgvPackages.Columns[6].HeaderText = "Agency Commission";
            dgvPackages.Columns[6].DefaultCellStyle.Format = "c";
            dgvPackages.Columns[6].Width = 150;
            dgvPackages.Columns[7].Visible = false;
            dgvPackages.Columns[8].Visible = false;
            dgvPackages.Columns.Add(modifyColumn);

        }

        private void dgvPackages_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvPackages.Columns["Modify"].Index)
            {
                // Get the selected package
                //var package = (Package)dgvPackages.Rows[e.RowIndex].DataBoundItem;

                //var form = new frmAddUpdatePackages(package);
                //form.FormClosed += Form_FormClosed;
                //form.Show();

                if (dgvPackages.Rows[e.RowIndex].Cells[0].Value != null)
                {
                    int packageId;
                    
                        packageId = Convert.ToInt32(dgvPackages.Rows[e.RowIndex].Cells[0].Value);
                        try
                        {
                            currentPackage = PackagesManager.GetPackageById(packageId);
                            if (currentPackage != null)
                            {
                                UpdatePackage();
                            }
                        }
                        catch (DbUpdateException ex) // errors coming from SaveChanges
                        {
                            string errorMessage = "Error(s) while modifying package:\n";
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
                            MessageBox.Show("Database connection lost while modifying a package. Try again later");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error while modifying a package:" + ex.Message, ex.GetType().ToString());
                        }
                }
            }
        }
        // modify current pacakge
        private void UpdatePackage()
        {
            frmAddUpdatePackages newForm = new frmAddUpdatePackages();
            newForm.isAdd = false; // is modify
            newForm.package = currentPackage;
            DialogResult = newForm.ShowDialog();
            if (DialogResult == DialogResult.OK) // proceed with modify
            {
                currentPackage = newForm.package; // new data values
                try
                {
                    // save changes to the database
                    PackagesManager.UpdatePackage(currentPackage.PackageId, currentPackage);
                    DisplayPackages(); // refresh grid
                }
                catch (DbUpdateException ex) // errors coming from SaveChanges
                {
                    string errorMessage = "Error(s) while modifying package:\n";
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
                    MessageBox.Show("Database connection lost while modifying a package. Try again later");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error while modifying a package:" + ex.Message, ex.GetType().ToString());
                }
            }
        }

        private void btnAddPackage_Click(object sender, EventArgs e)
        {
            frmAddUpdatePackages newForm = new frmAddUpdatePackages();
            newForm.isAdd = true;
            newForm.package = null;
            DialogResult = newForm.ShowDialog();
            if (DialogResult == DialogResult.OK) // proceed with add
            {
                currentPackage = newForm.package;
                if(currentPackage != null)
                {
                    try
                    {
                        // Save changes to the database
                        PackagesManager.AddPackage(currentPackage);
                        DisplayPackages(); // refresh the grid
                    }
                    catch (DbUpdateException ex) // errors coming from SaveChanges
                    {
                        string errorMessage = "Error(s) while adding package:\n";
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
                        MessageBox.Show("Database connection lost while adding a package. Try again later");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error while adding a package:" + ex.Message, ex.GetType().ToString());
                    }
                }
            }
            //newForm.FormClosed += Form_FormClosed;
            //newForm.Show();
        }

        private void Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            DisplayPackages();
        }

        private void btnBackHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}