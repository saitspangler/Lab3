using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelExpertsDatas
{

    /*
    * 
    * 
    * Addition: Added GetAllProductIDs and ProductId methods
    * Added on May 1, 2023
    * By: Peter Thiel
    */
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
        /// <summary>
        /// get a list of all product ids
        /// </summary>
        /// <returns>returns a list of all product ids</returns>
        public static List<int> GetAllProductIDs()
        {
            List<int> ids = new List<int>();
            using (TravelExpertsContext dB = new TravelExpertsContext())
            {
                ids = dB.Products.Select(p => p.ProductId).ToList();
            }
            return ids;
        }
        
    }

}
