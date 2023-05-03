using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
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
        public bool isAdd; // true if Add false if Modify
        public SupplierContact currentSupplier; // selected supplier when Modify or null when Add
        public Supplier sup;


        public frmAddModifySupplier()
        {
            InitializeComponent();
            //this.currentSupplier = currentSupplier;
        }

        // on form load
        private void frmAddModifySupplier_Load(object sender, EventArgs e)
        {
            // differentiates between Add and Modify
            if (isAdd) // an add operation
            {
                this.Text = "Add Contact";   
            }
            else // modify
            {
                this.Text = "Update Contact";
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
                txtProvince.Text = currentSupplier.SupConProv;
                txtFax.Text = currentSupplier.SupConFax;
                txtEmail.Text = currentSupplier.SupConEmail;
                txtURL.Text = currentSupplier.SupConUrl;
            }
        }

        // add supplier
        //private void addSupplier()
        //{
        //    //intialize controls on the form with default values
        //    //this.Text = "Add Supplier";
        //    txtSupplier.Text = " ";
        //    txtFName.Text = " ";
        //    txtLName.Text = " ";
        //    txtCompany.Text = " ";
        //    txtAddress.Text = " ";
        //    txtCity.Text = " ";
        //    txtCountry.Text = " ";
        //    txtPhone.Text = " ";
        //    txtProvince.Text = " ";
        //    txtPostalCode.Text = " ";
        //    txtFax.Text = " ";
        //    txtEmail.Text = " ";
        //    txtURL.Text = " ";

        //}

        // modify supplier
        //private void modifySupplier(int id)
        //{
        //    //load the data from the current supplier object
        //    //this.Text = "Modify Supplier";
        //    if (currentSupplier?.Supplier != null)
        //        txtSupplier.Text = currentSupplier.Supplier.SupName;
        //    txtFName.Text = currentSupplier.SupConFirstName;
        //    txtLName.Text = currentSupplier.SupConLastName;
        //    txtCompany.Text = currentSupplier.SupConCompany;
        //    txtAddress.Text = currentSupplier.SupConAddress;
        //    txtCity.Text = currentSupplier.SupConCity;
        //    txtCountry.Text = currentSupplier.SupConCountry;
        //    txtPhone.Text = currentSupplier.SupConBusPhone;
        //    txtProvince.Text = currentSupplier.SupConProv;
        //    txtPostalCode.Text = currentSupplier.SupConPostal;
        //    txtFax.Text = currentSupplier.SupConFax;
        //    txtEmail.Text = currentSupplier.SupConEmail;
        //    txtURL.Text = currentSupplier.SupConUrl;
        //}

        private void btnAccept_Click(object sender, EventArgs e)
        {

            using (TravelExpertsContext db = new TravelExpertsContext())
            {
                //validation for add and update
                if (Validator.IsPresent(txtSupplier) && Validator.IsPresent(txtFName) && Validator.IsPresent(txtLName) &&
                    Validator.IsPresent(txtCompany) && Validator.IsPresent(txtAddress) && Validator.IsPresent(txtCity) &&
                    Validator.IsPresent(txtProvince) && Validator.IsPresent(txtPostalCode)
                    //(Validator.IsPresent(txtPhone) | Validator.IsPresent(txtEmail))
                    )
                {
                    // checks if the supplier is null
                    if (currentSupplier == null)
                    {
                                                
                        if (isAdd)
                        {
                            currentSupplier = new SupplierContact();
                            
                            // Generate a new unique SupplierId value
                            int newSupplierId = db.Suppliers.Max(s => s.SupplierId) + 1;
                            // Create a new Supplier object
                            sup = new Supplier()
                            {
                                SupplierId = newSupplierId,
                                SupName = txtSupplier.Text
                            };

                            // Add the new Supplier object to the database
                            try
                            {
                                SupplierManager.AddSupplier(sup);
                            }
                            catch (DbUpdateException ex) // errors coming from SaveChanges
                            {
                                string errorMessage = "Error(s) while adding supplier:\n";
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
                                MessageBox.Show("Database connection lost while adding a supplier. Try again later");
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Error while adding a supplier:" + ex.Message, ex.GetType().ToString());
                            }
                        }
                        //txtSupplier.Text = sup.SupName;
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
                    DialogResult = DialogResult.OK;
                    //try
                    //{
                    //    // Save changes to the database
                    //    db.SaveChanges();
                    //}
                    //catch (Exception ex)
                    //{
                    //    // Handle any errors that may occur
                    //    MessageBox.Show(ex.InnerException?.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //}

                    // Generate a new unique SupplierContactId value
                    //int newSupplierContactId = db.SupplierContacts.Max(sc => sc.SupplierContactId) + 1;
                    //// Create a new SupplierContact object
                    //var supplierContact = new SupplierContact
                    //{
                    //    SupplierContactId = newSupplierContactId,
                    //    SupConFirstName = txtFName.Text,
                    //    SupConLastName = txtLName.Text,
                    //    SupConCompany = txtCompany.Text,
                    //    SupConAddress = txtAddress.Text,
                    //    SupConCity = txtCity.Text,
                    //    SupConProv = txtProvince.Text,
                    //    SupConPostal = txtPostalCode.Text,
                    //    SupConCountry = txtCountry.Text,
                    //    SupConBusPhone = txtPhone.Text,
                    //    SupConFax = txtFax.Text,
                    //    SupConEmail = txtEmail.Text,
                    //    SupConUrl = txtURL.Text,
                    //    SupplierId = supplier.SupplierId
                    //};

                    // Add the new SupplierContact objects to the database
                    //db.SupplierContacts.Add(supplierContact);

                    //try
                    //{
                    //    // Save changes to the database
                    //    db.SaveChanges();
                    //}
                    //catch (Exception ex)
                    //{
                    //    // Handle any errors that may occur
                    //    MessageBox.Show(ex.InnerException?.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //}
                    //}
                    //    else
                    //    {
                    //        // Retrieve existing supplier and suppliercontact records from the database
                    //        var supplier = db.Suppliers.Find(currentSupplier.SupplierId);
                    //        var supplierContact = db.SupplierContacts.Find(currentSupplier.SupplierContactId);

                    //        // Update properties of existing records
                    //        supplier.SupName = txtSupplier.Text;
                    //        supplierContact.SupConFirstName = txtFName.Text;
                    //        supplierContact.SupConLastName = txtLName.Text;
                    //        supplierContact.SupConCompany = txtCompany.Text;
                    //        supplierContact.SupConAddress = txtAddress.Text;
                    //        supplierContact.SupConCity = txtCity.Text;
                    //        supplierContact.SupConProv = txtProvince.Text;
                    //        supplierContact.SupConPostal = txtPostalCode.Text;
                    //        supplierContact.SupConCountry = txtCountry.Text;
                    //        supplierContact.SupConBusPhone = txtPhone.Text;
                    //        supplierContact.SupConFax = txtFax.Text;
                    //        supplierContact.SupConEmail = txtEmail.Text;
                    //        supplierContact.SupConUrl = txtURL.Text;

                    //        // Try to save changes to the database
                    //        try
                    //        {
                    //            // Save changes to the database
                    //            db.SaveChanges();
                    //        }
                    //        catch (Exception ex)
                    //        {
                    //            // Handle any errors that may occur
                    //            MessageBox.Show(ex.InnerException?.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //        }

                    //    }

                    //}
                    //this.Close(); 
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
