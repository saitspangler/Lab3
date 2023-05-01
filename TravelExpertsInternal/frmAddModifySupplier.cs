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
    public partial class frmAddModifySupplier : Form
    {
        public Supplier Supplier { get; set; }
        public bool AddSupplier { get; set; }
        public frmAddModifySupplier()
        {
            InitializeComponent();
        }

        private void frmAddModifySupplier_Load(object sender, EventArgs e)
        {
            if (AddSupplier)
            {
                this.Text = "Add Supplier";
                txtSupplierId.ReadOnly = false;  // allow entry of new product code
            }
            else
            {
                this.Text = "Modify Supplier";
                txtSupplierId.ReadOnly = true;   // can't change existing product code
                this.DisplaySupplier();
            }
        }

        private void DisplaySupplier()
        {
            txtSupplierId.Text = Supplier.SupplierId.ToString();
            txtSupName.Text = Supplier.SupName;
        }
    }
}
