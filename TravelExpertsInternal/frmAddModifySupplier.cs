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
    /*
    * The purpose of this application is to collect supplier contact infromation from the user 
    * The application will collect supplier contact name, company, address, phone, fax, URL, affiliation, User will be able to add, modify supplier contacts in the attached database.
    * Created on May 1, 2023
    * Author: Peter Thiel
    */
    public partial class frmAddModifySupplier : Form
    {
        // form level variables
        // public data for main form to set
        public bool isAdd; // true if Add false if Modify
        public SupplierContact? currentSupplier = null; // selected supplier when Modify or null when Add

        public frmAddModifySupplier()
        {
            InitializeComponent();
        }

        private void frmAddModifySupplier_Load(object sender, EventArgs e)
        {
            // differentiates between Add and Modify
            if (isAdd) // an add operation
            {
                this.Text = "Add Contact";
            }
            else // modify
            {
                this.Text = "Modify Contact";
                DisplaySupplier();

            }
        }

        private void DisplaySupplier()
        {
            if (currentSupplier != null)
            {
                txtSupplier.Text = currentSupplier.SupplierId.ToString();
                txtFName.Text = currentSupplier.SupConFirstName;
                txtLName.Text = currentSupplier.SupConLastName;
                txtCompany.Text = currentSupplier.SupConCompany;
                txtAddress.Text = currentSupplier.SupConAddress;
                txtCity.Text = currentSupplier.SupConCity;
                txtCountry.Text = currentSupplier.SupConCountry;
                txtPhone.Text = currentSupplier.SupConBusPhone;
                
            }
        }
    }
}
