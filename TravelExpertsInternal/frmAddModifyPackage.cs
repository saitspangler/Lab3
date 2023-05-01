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
using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace TravelExpertsInternal
{
    public partial class frmAddModifyPackage : Form
    {
        public Package Package { get; set; }
        public bool AddPackage { get; set; }

        public frmAddModifyPackage()
        {
            InitializeComponent();
        }

        private void frmAddModifyPackage_Load(object sender, EventArgs e)
        {
            if (AddPackage)
            {
                this.Text = "Add Package";
                txtPackageID.ReadOnly = false;  // allow entry of new product code
            }
            else
            {
                this.Text = "Modify Package";
                txtPackageID.ReadOnly = true;   // can't change existing product code
                this.DisplayPackage();
            }
        }

        private void DisplayPackage()
        {
            txtPackageID.Text = Package.PackageId.ToString();
            txtPkgName.Text = Package.PkgName;
            txtPkgDesc.Text = Package.PkgDesc;
            txtPkgStartDate.Text = Package.PkgStartDate.ToString();
            txtPkgEndDate.Text = Package.PkgEndDate.ToString();
            txtPkgBasePrice.Text = Package.PkgBasePrice.ToString("N2");
            txtAgencyCommission.Text = Package.PkgAgencyCommission.ToString();
        }
    }
}
