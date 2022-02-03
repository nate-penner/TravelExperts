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
        /// Removes the ProductsSupplier from the given Package
        /// </summary>
        /// <param name="package">the Package context</param>
        /// <param name="productsSupplier">the Product to be removed</param>
        public static void RemoveProductsSupplier(Package package, ProductsSupplier productsSupplier)
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

        public static List<ProductsSupplierDTO> GetProductsSupplierDTOs(Package package)
        {
            List<ProductsSupplierDTO> DTOs = new List<ProductsSupplierDTO>();


            //select s.SupplierId, SupName, p.ProductId, ProdName, ps.ProductSupplierId
            //from Suppliers s
            //join Products_Suppliers ps
            //ON s.SupplierId = ps.SupplierId
            //join Products p
            //ON p.ProductId = ps.ProductId
            //join Packages_Products_Suppliers pps
            //ON pps.ProductSupplierId = ps.ProductSupplierId
            //where PackageId = 1

            using (TravelExpertsContext db = new TravelExpertsContext())
            {
                try
                {
                    var result = db.Suppliers.Join(db.ProductsSuppliers,
                                                s => s.SupplierId,
                                                ps => ps.SupplierId,
                                                (s, ps) => new { s, ps })
                                          .Join(db.Products,
                                                ps1 => ps1.ps.ProductId,
                                                p => p.ProductId,
                                                (ps1, p) => new { ps1, p })
                                          .Join(db.PackagesProductsSuppliers,
                                                ps2 => ps2.ps1.ps.ProductSupplierId,
                                                pps => pps.ProductSupplierId,
                                                (ps2, pps) => new { ps2, pps })
                                          .Where(pps2 => pps2.pps.PackageId == package.PackageId)
                                          .Select(o => new
                                          {
                                              ProductId = o.ps2.p.ProductId,
                                              ProdName = o.ps2.p.ProdName,
                                              SupplierId = o.ps2.ps1.s.SupplierId,
                                              SupName = o.ps2.ps1.s.SupName,
                                              ProductSupplierId = o.pps.ProductSupplierId
                                          });


                    foreach (var ele in result)
                    {
                        Product p = new Product();
                        p.ProductId = ele.ProductId;
                        p.ProdName = ele.ProdName;

                        Supplier s = new Supplier();
                        s.SupplierId = ele.SupplierId;
                        s.SupName = ele.SupName;

                        ProductsSupplier ps = new ProductsSupplier();
                        ps.ProductSupplierId = ele.ProductSupplierId;

                        ProductsSupplierDTO dto = new ProductsSupplierDTO(p, s, ps);
                        DTOs.Add(dto);
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
            }

            

            return DTOs;
        }
    }
}
