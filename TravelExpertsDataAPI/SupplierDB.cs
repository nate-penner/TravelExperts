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
            List<Supplier> suppliers = null;

            using (TravelExpertsContext db = new TravelExpertsContext())
            {
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
                db.Suppliers.Add(supplier);
                db.SaveChanges();
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
                Supplier dbSupplier = db.Suppliers.Find(supplier.SupplierId);
                dbSupplier.SupName = supplier.SupName;
                db.SaveChanges();
            }
        }
    }
}
