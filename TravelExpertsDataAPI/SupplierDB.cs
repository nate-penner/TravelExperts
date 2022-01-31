using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelExpertsData;

namespace TravelExpertsDataAPI
{
    /*
        * An API for accessing and updating Supplier data
        * Design: Nate Penner
        * Implementation author(s): ... 
        * Creation Date: 2022-01-21
    */
    public static class SupplierDB
    {
        /// <summary>
        /// Get a list of all suppliers
        /// </summary>
        /// <author>Daniel Palmer</author>
        /// <returns>A list of all suppliers</returns>
        public static List<Supplier> GetSuppliers()
        {
            List<Supplier> suppliers = null;

            // Get suppliers from db
            using (TravelExpertsContext db = new TravelExpertsContext())
            {
                try
                {
                    suppliers = db.Suppliers.OrderBy(o => o.SupName).ToList();
                }
                catch (DbUpdateException ex)
                {
                    Handles.HandleDbUpdateException(ex);
                }
                catch (Exception ex)
                {
                }
            }

            return suppliers;
        }
        
        /// <summary>
        /// Get a list of suppliers for the product
        /// </summary>
        /// <author>Nate Penner</author>
        /// <param name="product">The product to lookup</param>
        /// <returns>A list of suppliers providing this product</returns>
        public static List<Supplier> GetSuppliers(Product product)
        {
            // The suppliers for the product
            List<Supplier> suppliers = null;

            // Read from DB
            using (TravelExpertsContext db = new TravelExpertsContext())
            {
                // Get all suppliers for this product
                suppliers = db.ProductsSuppliers
                    .Join(
                        db.Suppliers,
                        ps => ps.SupplierId,
                        s => s.SupplierId,
                        (ps, s) => new { ps, s }
                    )
                    .Where(o => o.ps.ProductId == product.ProductId)
                    .Select(o => o.s)
                    .ToList();

                // Get the ProductsSupplier object
                List<ProductsSupplier> productsSuppliers = db.ProductsSuppliers
                    .Where(ps => ps.ProductId == product.ProductId).ToList();

                // filter out archived ProductsSuppliers
                db.ProductsSuppliersArchives.ToList().ForEach(psa =>
                {
                    productsSuppliers = productsSuppliers
                        .Where(ps => ps.ProductSupplierId != psa.ProductSupplierId).ToList();
                });

                // Refill the suppliers list
                suppliers = productsSuppliers.Select(ps => ps.Supplier).ToList();
            }

            return suppliers;
        }

        /// <summary>
        /// Adds a new supplier to the database
        /// </summary>
        /// <author>Daniel Palmer</author>
        /// <param name="supplier">The supplier to be added</param>
        public static void AddSupplier(Supplier supplier)
        {
            using (TravelExpertsContext db = new TravelExpertsContext())
            {
                try
                {

                    db.Suppliers.Add(supplier);
                    db.SaveChanges();

                }
                catch (DbUpdateConcurrencyException ex) // concurrency error
                {
                    Handles.HandleConcurrencyError(ex, db, supplier);
                }
                catch (DbUpdateException ex)
                {
                    Handles.HandleDbUpdateException(ex);
                }
            }

        }

        /// <summary>
        /// Update an existing supplier
        /// </summary>
        /// <param name="supplier">The updated supplier data</param>
        public static void UpdateSupplier(Supplier supplier)
        {

            using (TravelExpertsContext db = new TravelExpertsContext())
            {
                try
                {
                    Supplier dbSupplier = db.Suppliers.Find(supplier.SupplierId);
                    dbSupplier.SupName = supplier.SupName;
                    db.SaveChanges();
                }
                catch (DbUpdateConcurrencyException ex) // concurrency error
                {
                    Handles.HandleConcurrencyError(ex, db, supplier);
                }
                catch (DbUpdateException ex)
                {
                    Handles.HandleDbUpdateException(ex);
                }

            }
        }

        // Author: Alex Cress
        /// <summary>
        /// Gets the Suppliers for a given Package + Product combination.
        /// </summary>
        /// <param name="package">the Package context</param>
        /// <param name="product">the Product context</param>
        /// <returns>the Suppliers for the given parameters, or null if there are none</returns>
        public static List<Supplier> GetSuppliersForPackageProduct(Package package, Product product)
        {
            List<Supplier> suppliers = null;
            try
            {
                using (TravelExpertsContext db = new TravelExpertsContext())
                {
                    //Joins Suppliers, ProductSuppliers, and PackagesProductSuppliers, then filters based on the Package and Product IDs
                    suppliers = db.Suppliers.Join(
                                                  db.ProductsSuppliers,
                                                  s => s.SupplierId,
                                                  ps => ps.SupplierId,
                                                  (s, ps) => new { s, ps })
                                            .Join(
                                                  db.PackagesProductsSuppliers,
                                                  pps => pps.ps.ProductSupplierId,
                                                  ps1 => ps1.ProductSupplierId,
                                                  (pps, ps1) => new { pps, ps1 })
                                            .Where(o => o.ps1.PackageId == package.PackageId && o.pps.ps.ProductId == product.ProductId)
                                            .Select(l => l.pps.s)
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

            return suppliers;
        }
        // Author: Alex Cress
        /// <summary>
        /// Gets the Suppliers for a given Product which are NOT included in a Package.
        /// </summary>
        /// <param name="package">the Package context</param>
        /// <param name="product">the Product context</param>
        /// <returns>the Suppliers for the given parameters, or null if there are none</returns>
        public static List<Supplier> GetSuppliersForPackageProductExcluding(Package package, Product product)
        {
            List<Supplier> suppliers = null;
            try
            {
                using (TravelExpertsContext db = new TravelExpertsContext())
                {
                    //Joins Suppliers and ProductsSuppliers, filters it on ProductId, removes any entries that exist in the subquery
                    suppliers = db.Suppliers.Join(
                                                  db.ProductsSuppliers,
                                                  s => s.SupplierId,
                                                  ps => ps.SupplierId,
                                                  (s, ps) => new { s, ps })
                                            .Where(o => o.ps.ProductId == product.ProductId)
                                            .Select(k => k.s)
                                            .Except(//Subquery joins Suppliers, ProductsSuppliers, and PackagesProductSuppliers, and filters it on PackageId.
                                                    //The subquery returns the Suppliers for the given Package + Product combination.
                                                    db.Suppliers.Join(
                                                                      db.ProductsSuppliers,
                                                                      s => s.SupplierId,
                                                                      ps => ps.SupplierId,
                                                                      (s, ps) => new { s, ps })
                                                                .Join(
                                                                      db.PackagesProductsSuppliers,
                                                                      ps1 => ps1.ps.ProductSupplierId,
                                                                      pps => pps.ProductSupplierId,
                                                                      (ps1, pps) => new { ps1, pps })
                                                                .Where(o => o.pps.PackageId == package.PackageId)
                                                                .Select(o => o.ps1.s))
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

            return suppliers;
        }
    }
}
