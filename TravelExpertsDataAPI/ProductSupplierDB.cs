using System;
using System.Collections.Generic;
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
        /// <param name="supplier">The supplier</param>
        /// <param name="product">The product</param>
        public static void AddProductSupplier(Product product, Supplier supplier)
        {
            // Update the products_suppliers table with a new entry
        }

        public static void UpdateProductSuppliers(Product product, List<Supplier> suppliers)
        {
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
                        db.ProductsSuppliers.Remove(ps);
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
    }
}
