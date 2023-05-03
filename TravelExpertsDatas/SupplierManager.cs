using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
namespace TravelExpertsDatas
{
    /*
    * 
    * 
    * Addition: Added GetAllSupplierIDs, UpdateSupplier, AddSupplier methods
    * Added on May 1, 2023
    * By: Peter Thiel
    */
    public class SupplierManager
    {
        

        public static List<Supplier> GetAllSuppliers()
        {
            List<Supplier> suppliers = new List<Supplier>();

            using (TravelExpertsContext dbContext = new TravelExpertsContext())
            {
                suppliers = dbContext.Suppliers.ToList();
            }

            return suppliers;
        }

        public static SupplierContact GetSupplier(int supplierID)
        {
            SupplierContact supplier = null;

            using (TravelExpertsContext dbContext = new TravelExpertsContext())
            {
                supplier = dbContext.SupplierContacts.Find(supplierID);
            }

            return supplier;
        }
        /// <summary>
        /// get a list of supplier ids
        /// </summary>
        /// <returns>returns a list of supplier ids</returns>
        public static List<int> GetAllSupplierIDs()
        {
            List<int> ids = new List<int>();
            using (TravelExpertsContext dB = new TravelExpertsContext())
            {
                ids = dB.Suppliers.Select(s => s.SupplierId).ToList();
            }
            return ids;
        }

        public static void UpdateSupplier(SupplierContact newSupplierData)
        {
            
            if (newSupplierData != null)
            {
                using (TravelExpertsContext dB = new TravelExpertsContext())
                {
                    SupplierContact supplier = dB.SupplierContacts.Find(newSupplierData.SupplierId);
                    if(supplier != null) // supplier exists
                    {
                        supplier.SupConFirstName = newSupplierData.SupConFirstName;
                        supplier.SupConLastName = newSupplierData.SupConLastName;
                        supplier.SupConCompany = newSupplierData.SupConCompany;
                        supplier.SupConAddress = newSupplierData.SupConAddress;
                        supplier.SupConCity = newSupplierData.SupConCity;
                        supplier.SupConProv = newSupplierData.SupConProv;
                        supplier.SupConPostal = newSupplierData.SupConPostal;
                        supplier.SupConCountry = newSupplierData.SupConCountry;
                        supplier.SupConBusPhone = newSupplierData.SupConBusPhone;
                        supplier.SupConFax = newSupplierData.SupConFax;
                        supplier.SupConEmail = newSupplierData.SupConEmail;
                        supplier.SupConUrl = newSupplierData.SupConUrl;
                        supplier.AffiliationId = newSupplierData.AffiliationId;
                        dB.SaveChanges();
                    }
                }
                
            }
        }
        /// <summary>
        /// adds a new supplier contact to the database
        /// </summary>
        /// <param name="newContact">new supplier contact data</param>
        public static void AddSupplierContact(SupplierContact newContact)
        {
            if (newContact != null)
            {
                using (TravelExpertsContext dB =  new TravelExpertsContext())
                {
                    dB.SupplierContacts.Add(newContact);
                    dB.SaveChanges();
                }
            }
        }
        /// <summary>
        /// add a new contact to the database
        /// </summary>
        /// <param name="newSupplier">new supplier data to add</param>
        public static void AddSupplier(Supplier newSupplier)
        {
            if (newSupplier != null)
            {
                using (TravelExpertsContext dB = new TravelExpertsContext())
                {
                    dB.Suppliers.Add(newSupplier);
                    dB.SaveChanges();
                }
            }
        }

        /// <summary>
        /// Get a specific supplier contact by supplier id
        /// </summary>
        /// <param name="supplierId"></param>
        /// <returns>the desired supplier contact</returns>
        public static SupplierContact GetSupplierContactBySupplierId(int supplierId)
        {
            using (TravelExpertsContext dbContext = new TravelExpertsContext())
            {
                SupplierContact supplierContact = dbContext.SupplierContacts
                    .Include(sc => sc.Supplier) // Include the Supplier navigation property
                    .FirstOrDefault(sc => sc.SupplierId == supplierId);
                return supplierContact;
            }
        }
        /// <summary>
        /// get a list of Affiliations
        /// </summary>
        /// <returns>return list of affiliations</returns>
        public static List<Affiliation> GetAllAffiliations()
        {
            List<Affiliation> affiliations = new List<Affiliation>();
            using (TravelExpertsContext dbContext = new TravelExpertsContext())
            {
                affiliations = dbContext.Affiliations.ToList();
            }
            return affiliations;
        }
    }
}