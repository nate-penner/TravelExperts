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
            // Add the package to the db
        }

        /// <summary>
        /// Updates an existing package
        /// </summary>
        /// <param name="package">The updated package data</param>
        public static void UpdatePackage(Package package)
        {
            // Update the package in the db
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
