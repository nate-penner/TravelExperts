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
