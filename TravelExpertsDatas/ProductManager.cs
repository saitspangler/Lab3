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
        public static List<Product> GetAllProducts()
        {
            TravelExpertsContext db = new TravelExpertsContext();
            List<Product> products = db.Products.ToList();
            return products;
        }
        public static Product GetProductById(int productId)
        {
            TravelExpertsContext db = new TravelExpertsContext();
            Product product = db.Products.Find(productId);
            return product;
        }
        public static void AddProduct(TravelExpertsContext db, Product product)
        {
            db.Products.Add(product);
            db.SaveChanges();
        }
        public static void UpdateProduct(TravelExpertsContext db, Product oldProduct, Product newProduct)
        {
            db.Entry(oldProduct).CurrentValues.SetValues(newProduct);
            db.SaveChanges();
        }
        public static void DeleteProduct(TravelExpertsContext db, Product product)
        {
            TravelExpertsContext context = new TravelExpertsContext();
            context.Products.Remove(product);
            context.SaveChanges();
        }
    }
}
