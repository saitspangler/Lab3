using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelExpertsDatas
{
    /*
    * The purpose of this application is to interface with the product supplier table in the connected database.
    * The application will control product id, supplier id, and will handled pulling data from, adding data to the database.
    * Created on Apr 28, 2023
    * Author: Peter Thiel
    */

    /// <summary>
    /// repepository of methods to work with the Products table of the travel experts database
    /// </summary>
    public class ProductSuppliersManager
    {
        public static List<ProductsSupplier> GetAllProductSuppliers()
        {
            List<ProductsSupplier> productSuppliers = new List<ProductsSupplier >(); // empty list of product suppliers
            using (TravelExpertsContext dB = new TravelExpertsContext()){
                productSuppliers = dB.ProductsSuppliers.ToList();
            }
            return productSuppliers;
        }
        /// <summary>
        /// get a product supplier by a given product supplier id
        /// </summary>
        /// <param name="prodSupplerId">given product supplier id</param>
        /// <returns>returns a product supplier by given product supplier id</returns>
        public static ProductsSupplier? GetProductSupplier(int prodSupplerId)
        {
            ProductsSupplier productsSupplier = null;
            using(TravelExpertsContext dB =new TravelExpertsContext())
            {
                productsSupplier = dB.ProductsSuppliers.Find(prodSupplerId);
            }
            return productsSupplier;
        }
        /// <summary>
        /// adds new product supplier to the database
        /// </summary>
        /// <param name="newProductsSupplier">new products supplier data to add</param>
        public static void AddProductSupplier(ProductsSupplier newProductsSupplier)
        {
            if(newProductsSupplier != null)
            {
                using (TravelExpertsContext dB = new TravelExpertsContext())
                {
                    dB.ProductsSuppliers.Add(newProductsSupplier);
                    dB.SaveChanges();
                }
            }
        }
        /// <summary>
        /// update existing product supplier with new data
        /// </summary>
        /// <param name="newProductsSupplierData">new product supplier data</param>
        public static void UpdateProductSupplier(ProductsSupplier newProductsSupplierData)
        {
            if (newProductsSupplierData != null)
            {
                using (TravelExpertsContext dB = new TravelExpertsContext())
                {
                    ProductsSupplier? productsSupplier = dB.ProductsSuppliers.Find(newProductsSupplierData.ProductId);
                    if(productsSupplier != null) // it exists
                    {
                        productsSupplier.ProductId = newProductsSupplierData.ProductId;
                        productsSupplier.SupplierId = newProductsSupplierData.SupplierId;
                        dB.SaveChanges();

                    }
                    dB.ProductsSuppliers.Add(newProductsSupplierData);
                    dB.SaveChanges();
                }
            }
        }

        // delete workflow is not required
    }
}
