using System;
using System.Collections.Generic;
using System.Linq;

namespace TravelExpertsDatas
{
    /*
    * 
    * 
    * Addition: Added GetAllSupplierIDs method
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

        public static Supplier GetSupplier(int supplierID)
        {
            Supplier supplier = null;

            using (TravelExpertsContext dbContext = new TravelExpertsContext())
            {
                supplier = dbContext.Suppliers.SingleOrDefault(s => s.SupplierId == supplierID);
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
    }
}

