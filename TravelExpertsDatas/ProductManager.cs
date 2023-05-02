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
        //public static void UpdateProduct(Product oldProduct, Product newProduct)
        //{
        //    TravelExpertsContext context = new TravelExpertsContext();
        //    context.Entry(oldProduct).CurrentValues.SetValues(newProduct);
        //    context.SaveChanges();
        //}

        /// <summary>
        ///  update existing product with new data 
        /// </summary>
        /// <param name="newProdData">new product data</param>
        public static void UpdateProduct(Product newProdData)
        {
            if (newProdData != null)
            {
                using (TravelExpertsContext db = new TravelExpertsContext())
                {
                    // find the product to update in this context
                    Product prod = db.Products.Find(newProdData.ProductId);
                    if (prod != null) // it still exists
                    {
                        // code does not  change
                        prod.ProdName = newProdData.ProdName;
                        prod.ProductsSuppliers = newProdData.ProductsSuppliers;
                        db.SaveChanges();
                    }
                }
            }
        }

        /// <summary>
        /// find product by primary key value
        /// </summary>
        /// <param name="productCode">code of the product to find</param>
        /// <returns>found product or null</returns>
        //public static Product FindProduct(string productCode)
        //{
        //    Product product = null;
        //    using (TravelExpertsContext db = new TravelExpertsContext())
        //    {
        //        product = db.Products.Find(productCode);
        //    }
        //    return product;
        //}

        public static Product FindProduct(string productCode)
        {
            int productId = Convert.ToInt32(productCode);
            using (TravelExpertsContext context = new TravelExpertsContext())
            {
                return context.Products.Find(productId);
            }
        }

        public static void DeleteProduct(Product product)
        {
            TravelExpertsContext context = new TravelExpertsContext();
            context.Products.Remove(product);
            context.SaveChanges();
        }
    }
}
