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
        * An API for accessing and updating Product-Supplier relationships
        * Design: Nate Penner
        * Implementation author(s): ... 
        * Creation Date: 2022-01-21
    */
    public static class ProductSupplierDB
    {
        /// <summary>
        /// Add a new product/supplier relationship
        /// </summary>
        /// <author>Daniel Palmer</author>
        /// <param name="supplier">The supplier</param>
        /// <param name="product">The product</param>
        public static void AddProductSupplier(Product product, Supplier supplier)
        {
            // Update the products_suppliers table with a new entry
            // Creates an instance of ProductsSupplier and assigns the Product and supplier Ids
            ProductsSupplier productSupplier = new ProductsSupplier();
            productSupplier.ProductId = product.ProductId;
            productSupplier.SupplierId = supplier.SupplierId;
            try
            {
                using (TravelExpertsContext db = new TravelExpertsContext())
                {
                    db.ProductsSuppliers.Add(productSupplier);
                    db.SaveChanges();
                }
            }
            catch (DbUpdateException ex)
            {
                Handles.HandleDbUpdateException(ex);
            }
        }

        /// <summary>
        /// Add a list of suppliers for a product to the database
        /// </summary>
        /// <author>Nate Penner</author>
        /// <param name="product">The product being modified</param>
        /// <param name="suppliers">The suppliers to add for this product</param>
        public static void AddProductSuppliers(Product product, List<Supplier> suppliers)
        {
            // Connect to the database
            using (TravelExpertsContext db = new TravelExpertsContext())
            {
                // Loop through the suppliers and add the product/supplier relationship
                // to the database and save changes
                suppliers.ForEach(s =>
                    {
                        ProductsSupplier ps = new ProductsSupplier();
                        ps.ProductId = product.ProductId;
                        ps.SupplierId = s.SupplierId;
                        db.ProductsSuppliers.Add(ps);
                    });
                db.SaveChanges();
            }
        }

        /// <summary>
        /// Gets a list of packages using a certain Product supplier
        /// </summary>
        /// <author>Nate Penner</author>
        /// <param name="productsSupplier">The product supplier to search for in the packages</param>
        /// <returns>A list of packages using this Product supplier</returns>
        public static List<Package> GetPackages(ProductsSupplier productsSupplier)
        {
            // The list of packages to return
            List<Package> packages = null;

            // Connect to the database
            using (TravelExpertsContext db = new TravelExpertsContext())
            {
                // check for packages using this Product supplier and add any results
                // to the packages list
                packages = db.Packages
                    .Join(db.PackagesProductsSuppliers,
                    p => p.PackageId,
                    pps => pps.PackageId,
                    (p, pps) => new { p, pps }
                    ).Where(o => o.pps.ProductSupplierId == productsSupplier.ProductSupplierId)
                    .Select(o => o.p).ToList();
            }
            return packages;
        }

        /// <summary>
        /// Gets a ProductsSupplier object from a passed Product and Supplier object
        /// </summary>
        /// <author>Nate Penner</author>
        /// <param name="product">The product</param>
        /// <param name="supplier">The supplier</param>
        /// <returns>ProductsSupplier object from the database</returns>
        public static ProductsSupplier GetProductSupplier(Product product, Supplier supplier)
        {
            // The Product supplier to return
            ProductsSupplier ps = null;
            using (TravelExpertsContext db = new TravelExpertsContext())
            {
                try
                {
                    ps = db.ProductsSuppliers
                        .Where(ps => ps.ProductId == product.ProductId && ps.SupplierId == supplier.SupplierId)
                        .Single();
                }
                catch {
                    // If there is no only a single ProductsSupplier returned, it will throw an
                    // error and we fall through to return null
                }
            }
            return ps;
        }

        /// <summary>
        /// Checks if a Product supplier is archived
        /// </summary>
        /// <author>Nate Penner</author>
        /// <param name="productSupplier">The Product supplier to check</param>
        /// <returns>true if archived, false if not archived</returns>
        public static bool IsArchived(ProductsSupplier productSupplier)
        {
            bool result;    // whether or not it's archived

            // Connect to database
            using (TravelExpertsContext db = new TravelExpertsContext())
            {
                try
                {
                    // Check for an archived Product supplier
                    db.ProductsSuppliersArchives
                        .Where(psa => psa.ProductSupplierId == productSupplier.ProductSupplierId)
                        .Single();
                    result = true;
                } catch (Exception)
                {
                    // if there is not a single result in the archive table matching the
                    // Product supplier, it will throw an error and we return false
                    result = false;
                }
            }
            return result;
        }

        /// <summary>
        /// Updates the relationship in the database between the product passed and the
        /// suppliers providing that product.
        /// </summary>
        /// <author>Nate Penner</author>
        /// <param name="product">The product to be updated</param>
        /// <param name="suppliers">The new supplier list</param>
        /// <returns>
        ///     A list of strings containing package names that caused any 
        ///     conflict with this update
        /// </returns>
        public static List<string> UpdateProductSuppliers(Product product, List<Supplier> suppliers)
        {
            // Conflicting package names
            List<string> packageNames = new List<string>();

            // A list of IDs of the suppliers from the new supplier list passed
            List<int> supplierIds = suppliers.Select(s => s.SupplierId).ToList();

            // A list of current suppliers for this product, retrieved from the database
            List<Supplier> savedSuppliers = SupplierDB.GetSuppliers(product).ToList();

            // The IDs of the saved suppliers
            List<int> savedSupplierIds = savedSuppliers.Select(s => s.SupplierId).ToList();

            // Archive any suppliers not in the new list
            savedSuppliers.ForEach(s =>
            {
                if (!supplierIds.Contains(s.SupplierId))
                {
                    // Try to archive this product supplier, getting any conflicting package names
                    // if not possible
                    List<Package> packages = ProductsSuppliersArchiveDB.ArchiveProductsSupplier(product, s);

                    if (packages != null && packages.Count > 0)
                        packages.ForEach(pkgName => packageNames.Add(pkgName.PkgName));
                }
            });

            // Add any suppliers not saved in the database
            suppliers.ForEach(s =>
            {
                // Get the ProductsSupplier for this supplier from the database
                ProductsSupplier ps = ProductSupplierDB.GetProductsSupplier(product, s);

                // If it's null, it wasn't in the databse
                if (ps == null)
                {
                    // Add it to the database
                    ProductSupplierDB.AddProductSupplier(product, s);
                } else
                {
                    // If it's archived, just unarchive it rather than creating a new ProductsSupplier
                    if (IsArchived(ps))
                    {
                        Unarchive(ps);
                    }
                }
            });

            return packageNames;
        }

        /// <summary>
        /// Removes a Product supplier from the archive table, making it active again
        /// </summary>
        /// <author>Nate Penner</author>
        /// <param name="ps">The Product supplier to reactivate</param>
        public static void Unarchive(ProductsSupplier ps)
        {
            try
            {
                // Connect to the databse
                using (TravelExpertsContext db = new TravelExpertsContext())
                {
                    // Get the ProductsSuppliersArchive object to delete
                    ProductsSuppliersArchive psa = db.ProductsSuppliersArchives.Find(ps.ProductSupplierId);

                    // Remove it and save
                    db.ProductsSuppliersArchives.Remove(psa);
                    db.SaveChanges();
                }
            } catch (DbUpdateException ex)
            {
                Handles.HandleDbUpdateException(ex);
            }
        }

        /// <summary>
        /// Removes a product/supplier relationship
        /// </summary>
        /// <param name="supplier">The supplier being updated</param>
        /// <param name="product">The product being added</param>
        public static void RemoveProductSupplier(Product product, Supplier supplier)
        {
            // Remove this relationship from products_suppliers table
            throw new NotImplementedException();
        }

        // Author: Alex Cress
        /// <summary>
        /// Gets the ProductsSupplier for a given Product + Supplier combination.
        /// </summary>
        /// <param name="product">the Product context</param>
        /// <param name="supplier">the Supplier context</param>
        /// <returns></returns>
        public static ProductsSupplier GetProductsSupplier(Product product, Supplier supplier)
        {
            ProductsSupplier productsSupplier = null;
            try
            {
                using (TravelExpertsContext db = new TravelExpertsContext())
                {
                    productsSupplier = db.ProductsSuppliers.Where(o => o.SupplierId == supplier.SupplierId
                                                                  && o.ProductId == product.ProductId)
                                                           .First();
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

            return productsSupplier;
        }
    }
}
