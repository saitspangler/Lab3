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

            dgvPackages.Columns[0].HeaderText = "Package ID";
            dgvPackages.Columns[0].Width = 150;
            dgvPackages.Columns[1].HeaderText = "Name";
            dgvPackages.Columns[1].Width = 450;
            dgvPackages.Columns[2].HeaderText = "Start Date";
            dgvPackages.Columns[2].Width = 200;
            dgvPackages.Columns[3].HeaderText = "End Date";
            dgvPackages.Columns[3].DefaultCellStyle.Format = "d";
            dgvPackages.Columns[3].Width = 250;
        }
    }
}