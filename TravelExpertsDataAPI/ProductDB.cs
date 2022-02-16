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
                    products = db.ProductsSuppliers.Where(ps => !db.ProductsSuppliersArchives.Select(psa => psa.ProductSupplierId).ToList().Contains(ps.ProductSupplierId))
                                                    .Join(
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
            catch (DbUpdateException ex)
            {
                Handles.HandleDbUpdateException(ex);
                return products;
            }
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
                    // Find the product to update based on the productId
                    Product dbProduct = db.Products.Find(product.ProductId);

                    // Set the data
                    dbProduct.ProdName = product.ProdName;

                    // Save the product
                    db.Products.Update(dbProduct);
                    db.SaveChanges();
                }
            } catch (Exception)
            {
                //Throw exception to caller, allow for more specific error handling
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

        // Author: Alex Cress
        /// <summary>
        /// Gets a list of products included in a Package.
        /// </summary>
        /// <param name="package">the Package context</param>
        /// <returns>A list of Products, or null if the are none</returns>
        public static List<Product> GetProducts(Package package)
        {
            List<Product> products = null;

            try
            {
                using (TravelExpertsContext db = new TravelExpertsContext())
                {
                    //Joins the Package and Product tables, selects all Products that refer to the given PackageId
                    products = db.Packages.Join(
                                                db.PackagesProductsSuppliers,
                                                p => p.PackageId,
                                                pps => pps.PackageId,
                                                (p, pps) => new { p, pps })
                                           .Join(
                                                db.ProductsSuppliers,
                                                pps1 => pps1.pps.ProductSupplierId,
                                                ps => ps.ProductSupplierId,
                                                (pps1, ps) => new { pps1, ps })
                                           .Join(
                                                db.Products,
                                                ps1 => ps1.ps.ProductId,
                                                pr => pr.ProductId,
                                                (ps1, pr) => new { ps1, pr })
                                           .Where(o => o.ps1.pps1.p.PackageId == package.PackageId)
                                           .Select(o => o.pr)
                                           .ToList();
                }
            }
            catch (DbUpdateException ex)
            {
                Handles.HandleDbUpdateException(ex);
            }
            catch (Exception ex)
            {
                Handles.LogToDebug(ex);
            }

            return products;
        }

        // Author: Alex Cress
        /// <summary>
        /// Gets a list of products NOT included in a vacation package.
        /// </summary>
        /// <param name="package">the Package context</param>
        /// <returns>A list of products, or null if there are none</returns>
        public static List<Product> GetProductsExcluding(Package package)
        {
            List<Product> products = null;

            try
            {
                using (TravelExpertsContext db = new TravelExpertsContext())
                {
                    //Selects all Products, joins the Package and Product tables in a subquery, selects all Products that refer to the given PackageId and excludes them from the result set
                    products = db.Products.Except(//Subquery
                                                db.Packages.Join( 
                                                    db.PackagesProductsSuppliers,
                                                    p => p.PackageId,
                                                    pps => pps.PackageId,
                                                    (p, pps) => new { p, pps })
                                               .Join(
                                                    db.ProductsSuppliers,
                                                    pps1 => pps1.pps.ProductSupplierId,
                                                    ps => ps.ProductSupplierId,
                                                    (pps1, ps) => new { pps1, ps })
                                               .Join(
                                                    db.Products,
                                                    ps1 => ps1.ps.ProductId,
                                                    pr => pr.ProductId,
                                                    (ps1, pr) => new { ps1, pr })
                                               .Where(o => o.ps1.pps1.p.PackageId == package.PackageId)
                                               .Select(o => o.pr))
                                           .ToList();
                }
            }
            catch (DbUpdateException ex)
            {
                Handles.HandleDbUpdateException(ex);
            }
            catch (Exception ex)
            {
                Handles.LogToDebug(ex);
            }

            return products;
        }

        // Author: Alex Cress
        /// <summary>
        /// Gets a list of products NOT associated with the given Supplier.
        /// </summary>
        /// <param name="package">the Supplier context</param>
        /// <returns>A list of products, or null if there are none</returns>
        public static List<Product> GetProductsExcluding(Supplier supplier)
        {
            List<Product> products = null;

            try
            {
                using (TravelExpertsContext db = new TravelExpertsContext())
                {
                    
                    products = db.Products.Except(db.ProductsSuppliers.Where(ps => !db.ProductsSuppliersArchives.Select(psa => psa.ProductSupplierId).ToList().Contains(ps.ProductSupplierId))
                                                    .Join(
                                                         db.Products,
                                                         p => p.ProductId,
                                                         ps => ps.ProductId,
                                                         (ps, p) => new { p, ps })
                                                    .Where(o => o.ps.SupplierId == supplier.SupplierId)
                                                    .Select(o => o.p))
                                          .ToList();
                }
            }
            catch (DbUpdateException ex)
            {
                Handles.HandleDbUpdateException(ex);
            }
            catch (Exception ex)
            {
                Handles.LogToDebug(ex);
            }

            return products;
        }

        public static List<Product> GetProductsForSupplierExcludingPackage(Package selectedPackage, Supplier selectedSupplier)
        {
            List<Product> products = null;

            try
            {
                using (TravelExpertsContext db = new TravelExpertsContext())
                {
                    //Selects all Products that have a relationship with the selectedSupplier.
                    //Removes any matching entries returned from the subquery.
                    products = db.Products.Join(db.ProductsSuppliers,
                                                  p => p.ProductId,
                                                  ps => ps.ProductId,
                                                  (p, ps) => new { p, ps })
                                            .Where(o => o.ps.SupplierId == selectedSupplier.SupplierId)
                                            .Select(k => k.p)
                                            .Except(//Subquery: Selects all Products that have a relationship with the selectedPackage.
                                                    db.Products.Join(db.ProductsSuppliers,
                                                                      p => p.ProductId,
                                                                      ps => ps.ProductId,
                                                                      (p, ps) => new { p, ps })
                                                                .Join(db.PackagesProductsSuppliers,
                                                                      ps1 => ps1.ps.ProductSupplierId,
                                                                      pps => pps.ProductSupplierId,
                                                                      (ps1, pps) => new { ps1, pps })
                                                                .Where(o => o.pps.PackageId == selectedPackage.PackageId)
                                                                .Select(o => o.ps1.p))
                                            .ToList();
                }
            }
            catch (DbUpdateException ex)
            {
                Handles.HandleDbUpdateException(ex);
            }
            catch (Exception ex)
            {
                Handles.LogToDebug(ex);
            }

            return products;
        }
    }
}
