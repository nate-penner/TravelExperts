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
        * An API for accessing and updating Vacation package data
        * Design: Nate Penner
        * Implementation author(s): ... 
        * Creation Date: 2022-01-21
    */
    public static class PackageDB
    {
        /// <summary>
        /// Gets all rows from the Package table.
        /// </summary>
        /// <returns>a list of all Packages</returns>
        public static List<Package> GetPackages()
        {
            List<Package> packages = null;
            using (TravelExpertsContext db = new TravelExpertsContext())
            {
                try
                {
                    packages = db.Packages.ToList();
                }
                catch (DbUpdateException ex)
                {
                    Handles.HandleDbUpdateException(ex);
                }
                catch (Exception ex)
                {
                    Handles.LogToDebug(ex);
                }
            }

                return packages;
        }

        /// <summary>
        /// Adds a new vacation package
        /// </summary>
        /// <param name="package">The package data to add</param>
        public static void AddPackage(Package package)
        {
            try
            {
                using (TravelExpertsContext db = new TravelExpertsContext())
                {
                    db.Packages.Add(package);
                    db.SaveChanges();
                }                          
            }
            catch(DbUpdateException ex)
            {
                Handles.HandleDbUpdateException(ex);
            }
            catch(Exception ex)
            {
                Handles.LogToDebug(ex);
            }

        }

        // Author: Alex Cress
        /// <summary>
        /// Updates an existing package.
        /// </summary>
        /// <param name="package">The package data to update</param>
        public static void UpdatePackage(Package newPackage)
        {
            using (TravelExpertsContext db = new TravelExpertsContext())
            {
                try
                {
                    //Get ADO reference
                    Package oldPackage = db.Packages.Find(newPackage.PackageId);

                    //Update object properties
                    oldPackage.PkgName = newPackage.PkgName;
                    oldPackage.PkgDesc = newPackage.PkgDesc;
                    oldPackage.PkgStartDate = newPackage.PkgStartDate;
                    oldPackage.PkgEndDate = newPackage.PkgEndDate;
                    oldPackage.PkgBasePrice = newPackage.PkgBasePrice;
                    oldPackage.PkgAgencyCommission = newPackage.PkgAgencyCommission;

                    db.SaveChanges();
                }
                catch (DbUpdateException ex)
                {
                    Handles.HandleDbUpdateException(ex);
                }
                catch (Exception ex)
                {
                    Handles.LogToDebug(ex);
                }
            }
        }
        // Author: Alex Cress
        /// <summary>
        /// Removes an existing package.
        /// </summary>
        /// <param name="package">The package to be removed</param>
        public static void RemovePackage(Package package)
        {
            using (TravelExpertsContext db = new TravelExpertsContext())
            {
                try
                {
                    //Get ADO references
                    package = db.Packages.Find(package.PackageId);
                    List<PackagesProductsSupplier> pps = db.PackagesProductsSuppliers
                                                            .Where(o => o.PackageId == package.PackageId)
                                                            .ToList();
                    //Delete FK constraits
                    foreach (PackagesProductsSupplier ele in pps)
                    {
                        db.PackagesProductsSuppliers.Remove(ele);
                    }

                    //Delete Package
                    db.Packages.Remove(package);
                    db.SaveChanges();
                }
                catch (DbUpdateException ex)
                {
                    Handles.HandleDbUpdateException(ex);
                }
                catch (Exception ex)
                {
                    Handles.LogToDebug(ex);
                }
            }
        }

        // Author: Alex Cress
        /// <summary>
        /// Removes the Product from the given Package
        /// </summary>
        /// <param name="package">the Package context</param>
        /// <param name="productsSupplier">the Product to be removed</param>
        public static void RemoveProduct(Package package, ProductsSupplier productsSupplier)
        {
            using (TravelExpertsContext db = new TravelExpertsContext())
            {
                try
                {
                    //Get ADO reference
                    PackagesProductsSupplier pps = db.PackagesProductsSuppliers
                                                        .Where(o => o.PackageId == package.PackageId
                                                            && o.ProductSupplierId == productsSupplier.ProductSupplierId)
                                                        .First();

                    //Delete from database
                    db.PackagesProductsSuppliers.Remove(pps);
                    db.SaveChanges();

                }
                catch (DbUpdateException ex)
                {
                    Handles.HandleDbUpdateException(ex);
                }
                catch (Exception ex)
                {
                    Handles.LogToDebug(ex);
                }
            }
        }

        // Author: Alex Cress
        /// <summary>
        /// Adds a Product to the given Package.
        /// </summary>
        /// <param name="package">the Package context</param>
        /// <param name="productsSupplier">the Product to be added</param>
        public static void AddProduct(Package package, ProductsSupplier productsSupplier)
        {
            using (TravelExpertsContext db = new TravelExpertsContext())
            {
                try
                {
                    PackagesProductsSupplier pps = new PackagesProductsSupplier();
                    pps.PackageId = package.PackageId;
                    pps.ProductSupplierId = productsSupplier.ProductSupplierId;

                    db.PackagesProductsSuppliers.Add(pps);
                    db.SaveChanges();

                }
                catch (DbUpdateException ex)
                {
                    Handles.HandleDbUpdateException(ex);
                }
                catch (Exception ex)
                {
                    Handles.LogToDebug(ex);
                }
            }
        }
    }
}
