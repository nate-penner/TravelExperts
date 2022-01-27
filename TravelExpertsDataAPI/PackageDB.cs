using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
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
            catch(Exception)
            {
                //Throw exception to caller, allow for more specific error handling
                throw;
            }

        }

        /// <summary>
        /// Updates an existing package
        /// </summary>
        /// <param name="package">The updated package data</param>
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
                catch (Exception)
                {
                    //Throw exception to caller, allow for more specific error handling
                    throw;
                }
            }
        }

        /// <summary>
        /// Removes an existing package
        /// </summary>
        /// <param name="package">The package to be removed</param>
        public static void RemovePackage(Package package)
        {
            throw new NotImplementedException();
        }
    }
}
