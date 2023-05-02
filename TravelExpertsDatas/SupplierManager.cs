using System;
using System.Collections.Generic;
using System.Linq;

namespace TravelExpertsDatas
{
    /*
    * 
    * 
    * Addition: Added GetAllSupplierIDs, UpdateSupplier methods
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
    }
}

