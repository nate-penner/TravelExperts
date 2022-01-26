using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelExpertsData;
using Microsoft.EntityFrameworkCore;

namespace TravelExpertsDataAPI
{
    /*
        * An API for accessing and updating Product data
        * Design: Nate Penner
        * Implementation author(s): ... 
        * Creation Date: 2022-01-21
    */

    public static class ProductDB
    {
        /// <summary>
        /// Get a list of all products from database
        /// </summary>
        /// <author>Nate Penner</author>
        /// <returns>A list of products</returns>
        public static List<Product> GetProducts()
        {
            List<Product> products = null;

            // Get the product list from database
            using (TravelExpertsContext db = new TravelExpertsContext())
            {
                products = db.Products.ToList();
            }

            return products;
        }

        /// <summary>
        /// Gets a list of all products for the specified supplier
        /// </summary>
        /// <param name="supplier">The supplier</param>
        /// <author>Daniel Palmer</author>
        /// <returns>All products provided by the supplier</returns>
        public static List<Product> GetProducts(Supplier supplier)
        {
            List<Product> products = null;
            try
            {
                using (TravelExpertsContext db = new TravelExpertsContext())
                {
                    products = db.ProductsSuppliers.Join(
                                                         db.Products,
                                                         p => p.ProductId,
                                                         ps => ps.ProductId,
                                                         (ps, p) => new { p, ps })
                                                    .Where(o => o.ps.SupplierId == supplier.SupplierId)
                                                    .Select(o => o.p)
                                                    .ToList();
                }

                return products;
            }
            catch (NullReferenceException ex)
            {
                return products;
            }
        }

        /// <summary>
        /// Gets a list of products included in a vacation package
        /// </summary>
        /// <param name="package">The vacation package to find products for</param>
        /// <returns>A list of products</returns>
        public static List<Product> GetProducts(Package package)
        {
            List<Product> products = null;

            return products;
        }

        /// <summary>
        /// Add a new product to the database
        /// </summary>
        /// <author>Nate Penner</author>
        /// <param name="product">The product data to add</param>
        public static void AddProduct(Product product)
        {
            // Add the product to the db
            using (TravelExpertsContext db = new TravelExpertsContext())
            {
                db.Products.Add(product);
                db.SaveChanges();
            }
        }

        /// <summary>
        /// A product to be updated in the database
        /// </summary>
        /// <author>Nate Penner</author>
        /// <param name="product">The product to be updated</param>
        public static void UpdateProduct(Product product)
        {
            // Update the product in the db
            try
            {
                using(TravelExpertsContext db = new TravelExpertsContext())
                {
                    Product dbProduct = db.Products.Find(product.ProductId);
                    dbProduct.ProdName = product.ProdName;
                    db.Products.Update(dbProduct);
                    db.SaveChanges();
                }
            } catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Remove a product from the database
        /// </summary>
        /// <param name="product">The product to be removed</param>
        public static void RemoveProduct(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
