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
    /*
     * Validation added by Peter Spangler
     */
    public partial class frmAddModifySupplier : Form
    {
        // form level variables
        // public data for main form to set
        private SupplierContact currentSupplier; // selected supplier when Modify or null when Add
        private Supplier supplier;


        public frmAddModifySupplier(SupplierContact currentSupplier = null)
        {
            InitializeComponent();
            this.currentSupplier = currentSupplier;
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
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            using (TravelExpertsContext db = new TravelExpertsContext())
            {
                {
                    // Validate input fields
                    if (Validator.IsPresent(txtSupplier) && Validator.IsPresent(txtFName) && Validator.IsPresent(txtLName) &&
                        Validator.IsPresent(txtCompany) && Validator.IsPresent(txtAddress) && Validator.IsPresent(txtCity) &&
                        Validator.IsPresent(txtProvince) && Validator.IsPresent(txtPostalCode))
                    {
                        if (currentSupplier == null)
                        {

                            // Generate a new unique SupplierId value
                            int newSupplierId = db.Suppliers.Max(s => s.SupplierId) + 1;
                            // Create a new Supplier object
                            var supplier = new Supplier
                            {
                                SupplierId = newSupplierId,
                                SupName = txtSupplier.Text
                            };

                            // Add the new Supplier object to the database
                            db.Suppliers.Add(supplier);

                            try
                            {
                                // Save changes to the database
                                db.SaveChanges();
                                DialogResult = DialogResult.OK;
                                this.Close();
                            }
                            catch (Exception ex)
                            {
                                // Handle any errors that may occur
                                MessageBox.Show(ex.InnerException?.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }

                            // Generate a new unique SupplierContactId value
                            int newSupplierContactId = db.SupplierContacts.Max(sc => sc.SupplierContactId) + 1;
                            // Create a new SupplierContact object
                            var supplierContact = new SupplierContact
                            {
                                SupplierContactId = newSupplierContactId,
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
                                SupplierId = supplier.SupplierId
                            };

                            // Add the new SupplierContact objects to the database
                            db.SupplierContacts.Add(supplierContact);

                            try
                            {
                                // Save changes to the database
                                db.SaveChanges();
                            }
                            catch (Exception ex)
                            {
                                // Handle any errors that may occur
                                MessageBox.Show(ex.InnerException?.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            DialogResult = DialogResult.OK;
                            this.Close();

                        }
                        else
                        {
                            // Retrieve existing supplier and suppliercontact records from the database
                            var supplier = db.Suppliers.Find(currentSupplier.SupplierId);
                            var supplierContact = db.SupplierContacts.Find(currentSupplier.SupplierContactId);

                            // Update properties of existing records
                            supplier.SupName = txtSupplier.Text;
                            supplierContact.SupConFirstName = txtFName.Text;
                            supplierContact.SupConLastName = txtLName.Text;
                            supplierContact.SupConCompany = txtCompany.Text;
                            supplierContact.SupConAddress = txtAddress.Text;
                            supplierContact.SupConCity = txtCity.Text;
                            supplierContact.SupConProv = txtProvince.Text;
                            supplierContact.SupConPostal = txtPostalCode.Text;
                            supplierContact.SupConCountry = txtCountry.Text;
                            supplierContact.SupConBusPhone = txtPhone.Text;
                            supplierContact.SupConFax = txtFax.Text;
                            supplierContact.SupConEmail = txtEmail.Text;
                            supplierContact.SupConUrl = txtURL.Text;

                            // Try to save changes to the database
                            try
                            {
                                // Save changes to the database
                                db.SaveChanges();
                                DialogResult = DialogResult.OK;
                                this.Close();
                            }
                            catch (Exception ex)
                            {
                                // Handle any errors that may occur
                                MessageBox.Show(ex.InnerException?.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}