using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelExpertsDatas
{
    public class SupplierManager
    {
        public static List<string> GetSupplierNames()
        {
            List<string> supNames = new List<string>(); // empty list
            using (TravelExpertsContext db = new TravelExpertsContext())
            {
                supNames = db.Suppliers.
                    Select(s => s.SupName).ToList();
            }
            return supNames;
        }

        public static List<Supplier> GetSuppliers()
        {
            List<Supplier> suppliers = new List<Supplier>();
            using (TravelExpertsContext db = new TravelExpertsContext())
            {
                suppliers = db.Suppliers.ToList();
            }
            return suppliers;
        }

        public static List<int> GetSupplierIds()
        {
            List<int> supIds = new List<int>(); // empty list
            using (TravelExpertsContext db = new TravelExpertsContext())
            {
                supIds = db.Suppliers.
                    Select(s => s.SupplierId).ToList();
            }
            return supIds;
        }
    }
}
