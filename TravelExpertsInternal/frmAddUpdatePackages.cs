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
    public partial class frmAddUpdatePackages : Form
    {
        private Package package;
        public frmAddUpdatePackages(Package package = null)
        {
            InitializeComponent();
            this.package = package;
            if (package == null)
            {
                addPackage();
            }
            else { modifyPackage(package.PackageId); }
        }

        private void frmAddUpdatePackages_Load(object sender, EventArgs e)
        {

        }

        private void addPackage()
        {

        }

        private void modifyPackage(int id)
        {

        }

        private void btnSavePackage_Click(object sender, EventArgs e)
        {
            PackagesManager.AddPackage(package);
        }
    }
}
