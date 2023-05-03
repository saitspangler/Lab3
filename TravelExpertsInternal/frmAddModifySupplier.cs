using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Packaging;
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
        private SupplierContact currentSupplier; // selected supplier when Modify or null when Add

        public frmAddModifySupplier(SupplierContact currentSupplier = null)
        {
            InitializeComponent();
            this.currentSupplier = currentSupplier;
            LoadAffiliations();
        }

        private void frmAddModifySupplier_Load(object sender, EventArgs e)
        {
            if (currentSupplier != null && currentSupplier.SupplierId > 0)
            {
                modifySupplier((int)currentSupplier.SupplierId);
            }
            else { addSupplier(); }
        }

        // add supplier
        private void addSupplier()
        {
            //intialize controls on the form with default values
            this.Text = "Add Supplier";
            txtSupplier.Text = " ";
            txtFName.Text = " ";
            txtLName.Text = " ";
            txtCompany.Text = " ";
            txtAddress.Text = " ";
            txtCity.Text = " ";
            txtCountry.Text = " ";
            txtPhone.Text = " ";
            txtProvince.Text = " ";
            txtPostalCode.Text = " ";
            txtFax.Text = " ";
            txtEmail.Text = " ";
            txtURL.Text = " ";
            cboAffiliation.Text = " ";

        }

        // modify supplier
        private void modifySupplier(int id)
        {
            //load the data from the current supplier object
            this.Text = "Modify Supplier";
            if (currentSupplier?.Supplier != null)
                txtSupplier.Text = currentSupplier.Supplier.SupName;
            txtFName.Text = currentSupplier.SupConFirstName;
            txtLName.Text = currentSupplier.SupConLastName;
            txtCompany.Text = currentSupplier.SupConCompany;
            txtAddress.Text = currentSupplier.SupConAddress;
            txtCity.Text = currentSupplier.SupConCity;
            txtCountry.Text = currentSupplier.SupConCountry;
            txtPhone.Text = currentSupplier.SupConBusPhone;
            txtProvince.Text = currentSupplier.SupConProv;
            txtPostalCode.Text = currentSupplier.SupConPostal;
            txtFax.Text = currentSupplier.SupConFax;
            txtEmail.Text = currentSupplier.SupConEmail;
            txtURL.Text = currentSupplier.SupConUrl;
            cboAffiliation.Text = currentSupplier.AffiliationId?.ToString() ?? "";
        }

        private void LoadAffiliations()
        {
            cboAffiliation.Items.Clear();
            var affiliations = SupplierManager.GetAllAffiliations();
            foreach (Affiliation a in affiliations)
            {
                cboAffiliation.Items.Add(a.AffilitationId);
            }

        }
        private void btnAccept_Click(object sender, EventArgs e)
        {
            using (TravelExpertsContext dbContext = new TravelExpertsContext())
            {
                var supplier = new Supplier
                {
                    SupName = txtSupplier.Text
                };
                var supplierContact = new SupplierContact
                {
                    SupConFirstName = txtFName.Text,
                    SupConLastName = txtLName.Text,
                    SupConCompany = txtCompany.Text,
                    SupConAddress = txtAddress.Text,
                    SupConCity = txtCity.Text,
                    SupConProv = txtProvince.Text,
                    SupConPostal = txtPostalCode.Text,
                    SupConCountry = txtCountry.Text,
                    SupConBusPhone = txtPhone.Text,
                    SupConFax = txtFax.Text,
                    SupConEmail = txtEmail.Text,
                    SupConUrl = txtURL.Text,
                    AffiliationId = cboAffiliation.Text,
                    Supplier = supplier
                };
                dbContext.SupplierContacts.Add(supplierContact);
                dbContext.SaveChanges();
                DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
