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
        // display supplier info if modify
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

        private void btnAccept_Click(object sender, EventArgs e)
        {
            bool valid = true;
            // if valid
            if (isAdd) // validate code
            {
                if (Validator.IsPresent(txtSupplier))
                {
                    if (isAdd) // need to create a new product object
                    {
                        currentSupplier = new SupplierContact();
                    }

                    // check if unique
                    int id = Convert.ToInt32(txtSupplier);
                    List<int> ids = SupplierManager.GetAllSupplierIDs();
                    foreach (int p in ids)
                    {
                        if (p == id)
                        {
                            MessageBox.Show($"Duplicate product code: {id}");
                            valid = false; // found duplicate
                        }
                    }
                }
                else // empty string
                {
                    valid = false;
                }
            }
            // for both Add and Modify

            if (valid && currentSupplier != null)
            {
                if (isAdd) // need to create the object
                {
                    currentSupplier = new SupplierContact();
                }
                // fill in data of product supplier object with new values
                currentSupplier.SupplierId = Convert.ToInt32(txtSupplier);
                currentSupplier.SupConFirstName = txtFName.ToString();
                currentSupplier.SupConLastName = txtLName.ToString();
                currentSupplier.SupConCompany = txtCompany.ToString();
                currentSupplier.SupConAddress = txtAddress.ToString();
                currentSupplier.SupConCity = txtCity.ToString();
                currentSupplier.SupConProv = txtProvince.ToString();
                currentSupplier.SupConPostal = txtPostalCode.ToString();
                currentSupplier.SupConCountry = txtCountry.ToString();
                currentSupplier.SupConBusPhone = txtPhone.ToString();
                currentSupplier.SupConFax = txtFax.ToString();
                currentSupplier.SupConEmail = txtEmail.ToString();
                currentSupplier.SupConUrl = txtURL.ToString();
                currentSupplier.AffiliationId = cboAffiliation.ToString();

                DialogResult = DialogResult.OK;
            }
        }
    }
}
