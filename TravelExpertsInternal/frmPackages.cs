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
    public partial class frmPackages : Form
    {
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
            dgvPackages.Columns[7].HeaderText = "Bookings";
            dgvPackages.Columns[7].Width = 100;
            dgvPackages.Columns[8].Visible = false;
            dgvPackages.Columns.Add(modifyColumn);

        }

        private void dgvPackages_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvPackages.Columns["Modify"].Index)
            {
                // Get the selected package
                var package = (Package)dgvPackages.Rows[e.RowIndex].DataBoundItem;

                var form = new frmAddUpdatePackages(package);
                form.Show();
            }
        }

        private void btnAddPackage_Click(object sender, EventArgs e)
        {
            var newPackage = new Package();
            frmAddUpdatePackages newForm = new frmAddUpdatePackages(newPackage);
            newForm.Show();
        }
    }
}