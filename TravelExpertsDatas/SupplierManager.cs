using System;
using System.Collections.Generic;
using System.Linq;

namespace TravelExpertsDatas
{
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
    }
}

