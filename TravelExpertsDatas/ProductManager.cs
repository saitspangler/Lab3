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
            TravelExpertsContext context = new TravelExpertsContext();
            List<Product> products = context.Products.ToList();
            return products;
        }
        public static Product GetProduct(int productId)
        {
            TravelExpertsContext context = new TravelExpertsContext();
            Product product = context.Products.Find(productId);
            return product;
        }
        public static void AddProduct(Product product)
        {
            TravelExpertsContext context = new TravelExpertsContext();
            context.Products.Add(product);
            context.SaveChanges();
        }
        public static void UpdateProduct(Product oldProduct, Product newProduct)
        {
            TravelExpertsContext context = new TravelExpertsContext();
            context.Entry(oldProduct).CurrentValues.SetValues(newProduct);
            context.SaveChanges();
        }
        public static void DeleteProduct(Product product)
        {
            TravelExpertsContext context = new TravelExpertsContext();
            context.Products.Remove(product);
            context.SaveChanges();
        }
    }
}
