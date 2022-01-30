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

        public static void AddProductSuppliers(Product product, List<Supplier> suppliers)
        {
            using (TravelExpertsContext db = new TravelExpertsContext())
            {
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

        public static List<Package> GetPackages(ProductsSupplier productsSupplier)
        {
            List<Package> packages = null;
            using (TravelExpertsContext db = new TravelExpertsContext())
            {
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

        public static ProductsSupplier GetProductSupplier(Product product, Supplier supplier)
        {
            ProductsSupplier ps = null;
            using (TravelExpertsContext db = new TravelExpertsContext())
            {
                try
                {
                    ps = db.ProductsSuppliers
                        .Where(ps => ps.ProductId == product.ProductId && ps.SupplierId == supplier.SupplierId)
                        .Single();
                }
                catch (Exception) { }
            }
            return ps;
        }

        public static bool IsArchived(ProductsSupplier productSupplier)
        {
            bool result;
            using (TravelExpertsContext db = new TravelExpertsContext())
            {
                try
                {
                    db.ProductsSuppliersArchives
                        .Where(psa => psa.ProductSupplierId == productSupplier.ProductSupplierId)
                        .Single();
                    result = true;
                } catch (Exception)
                {
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
        public static List<string> UpdateProductSuppliers(Product product, List<Supplier> suppliers)
        {
            List<string> packageNames = null;

            using (TravelExpertsContext db = new TravelExpertsContext())
            {
                // Get all the current suppliers for the product (from the database)
                List<int> savedSupplierIds = db.ProductsSuppliers
                    .Join(db.Suppliers,
                    ps => ps.SupplierId,
                    s => s.SupplierId,
                    (ps, s) => new { ps, s }
                    ).Where(o => o.ps.ProductId == product.ProductId)
                    .Select(o => o.s.SupplierId).ToList();

                // Get the ids of all the suppliers in the new list for this product
                List<int> supplierIds = suppliers.Select(s => s.SupplierId).ToList();

                // Remove any product supplier records in the database for suppliers that
                // are not in the passed supplier list
                savedSupplierIds.ForEach(s =>
                {
                    if (!supplierIds.Contains(s)) {
                        ProductsSupplier ps = db.ProductsSuppliers
                        .Where(ps => ps.SupplierId == s && ps.ProductId == product.ProductId)
                        .Single();

                        List<int> ppsIds = db.PackagesProductsSuppliers
                        .Where(pps => pps.ProductSupplierId == ps.ProductSupplierId)
                        .Select(pps => pps.ProductSupplierId).ToList();

                        if (ppsIds.Contains(ps.ProductSupplierId))
                        {
                            // A package is using this product supplier
                            // Don't remove it, add the packages using it
                            // to the packageNames list
                            if (packageNames == null)
                                packageNames = new List<string>();

                            db.Packages
                            .Join(db.PackagesProductsSuppliers,
                            p => p.PackageId,
                            pps => pps.PackageId,
                            (p, pps) => new { p.PkgName, pps.ProductSupplierId })
                            .Where(o => o.ProductSupplierId == ps.ProductSupplierId)
                            .Select(o => o.PkgName).ToList()
                            .ForEach(s => packageNames.Add(s));
                        } else
                        {
                            db.ProductsSuppliers.Remove(ps);
                        }
                    }
                });
                db.SaveChanges();

                // Add any product suppliers that are in the new list, but weren't in the database
                supplierIds.ForEach(s =>
                {
                    if (!savedSupplierIds.Contains(s))
                    {
                        ProductsSupplier ps = new ProductsSupplier();
                        ps.ProductId = product.ProductId;
                        ps.SupplierId = s;
                        db.ProductsSuppliers.Add(ps);
                    }
                });
                db.SaveChanges();
            }

            return packageNames;
        }

        /// <summary>
        /// Removes a product/supplier relationship
        /// </summary>
        /// <param name="supplier">The supplier being updated</param>
        /// <param name="product">The product being added</param>
        public static void RemoveProductSupplier(Product product, Supplier supplier)
        {
            // Remove this relationship from products_suppliers table
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
