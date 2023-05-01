using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelExpertsDatas
{
    /// <summary>
    /// Repository of methods to work with the Products table of the Travel Experts Database
    /// </summary>
    public class ProductManager
    {
        /// <summary>
        /// Get all products from the database
        /// </summary>
        /// <param name="db"></param>
        /// <returns>List of products from the database</returns>
        public static List<Product> GetAllProducts(TravelExpertsContext db)
        {
            List<Product> products = db.Products.ToList();
            return products;
        }

        /// <summary>
        /// Get all products from given supplier from the database
        /// </summary>
        /// <param name="db, supplier"></param>
        /// <returns>List of products from the database</returns>
        public static List<Product> GetProductsBySupplier(TravelExpertsContext db, Supplier supplier)
        {

            List<Product> products = db.Products.Where(p => p.ProductsSuppliers.Any(ps => ps.SupplierId == supplier.SupplierId)).ToList();
            return products;
        }
        /// <summary>
        /// Get product given product id
        /// </summary>
        /// <param name="db"></param>
        /// <param name="productId"></param>
        /// <returns>the product with that id</returns>
        public static Product GetProduct(TravelExpertsContext db, int productId)
        {
            Product product = db.Products.Find(productId);
            return product;
        }
        /// <summary>
        /// Add a product to the database
        /// </summary>
        /// <param name="db"></param>
        /// <param name="product"></param>
        /// <returns>updated database</returns>
        public static void AddProduct(TravelExpertsContext db, Product product)
        {
            db.Products.Add(product);
            db.SaveChanges();
        }
        /// <summary>
        /// Update a product in the database
        /// </summary>
        /// <param name="db"></param>
        /// <param name="oldProduct"></param>
        /// <param name="newProduct"></param>
        public static void UpdateProduct(TravelExpertsContext db, Product oldProduct, Product newProduct)
        {
            db.Entry(oldProduct).CurrentValues.SetValues(newProduct);
            db.SaveChanges();
        }

        /// <summary>
        /// Delete a product from the database
        /// </summary>
        /// <param name="db"></param>
        /// <param name="product"></param>
        public static void DeleteProduct(TravelExpertsContext db, Product product)
        {
            db.Products.Remove(product);
            db.SaveChanges();
        }
    }
}
