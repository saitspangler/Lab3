using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelExpertsDatas
{        
    /// <summary>
    /// Repository of methods to work with the Supplier table of the Travel Experts Database
    /// </summary>
    /// 
    public class SupplierManager
    {
        /// <summary>
        /// List of all suppliers in the database
        /// </summary>
        /// <param name="db"></param>
        /// <returns></returns>
        public static List<Supplier> GetAllSuppliers(TravelExpertsContext db)
        {
            List<Supplier> suppliers = db.Suppliers.ToList();
            return suppliers;
        }
        /// <summary>
        /// Get all suppliers from given product from the database
        /// </summary>
        /// <param name="db"></param>
        /// <param name="product"></param>
        /// <returns>List of suppliers from the database</returns>
        public static List<Supplier> GetSuppliersByProduct(TravelExpertsContext db, Product product)
        {
            List<Supplier> suppliers = db.Suppliers.Where(s => s.ProductsSuppliers.Any(ps => ps.ProductId == product.ProductId)).ToList();
            return suppliers;
        }
        /// <summary>
        /// Get supplier given supplier id
        /// </summary>
        /// <param name="db"></param>
        /// <param name="supplierId"></param>
        /// <returns>the supplier with that id</returns>
        public static Supplier GetSupplier(TravelExpertsContext db, int supplierId)
        {
            Supplier supplier = db.Suppliers.Find(supplierId);
            return supplier;
        }
        /// <summary>
        /// Add a supplier to the database
        /// </summary>
        /// <param name="db"></param>
        /// <param name="supplier"></param>
        /// <returns>updated database</returns>
        public static void AddSupplier(TravelExpertsContext db, Supplier supplier)
        {
            db.Suppliers.Add(supplier);
            db.SaveChanges();
        }
        /// <summary>
        /// Update a supplier in the database
        /// </summary>
        /// <param name="db"></param>
        /// <param name="oldSupplier"></param>
        /// <param name="newSupplier"></param>
        public static void UpdateSupplier(TravelExpertsContext db, Supplier oldSupplier, Supplier newSupplier)
        {
            db.Entry(oldSupplier).CurrentValues.SetValues(newSupplier);
            db.SaveChanges();
        }
        /// <summary>
        /// Delete a supplier from the database
        /// </summary>
        /// <param name="db"></param>
        /// <param name="supplier"></param>
        public static void DeleteSupplier(TravelExpertsContext db, Supplier supplier)
        {
            db.Suppliers.Remove(supplier);
            db.SaveChanges();
        }

    }
}
