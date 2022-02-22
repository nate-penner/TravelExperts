using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelExpertsData;

namespace TravelExpertsDataAPI
{
    /// <summary>
    /// A data transfer object which holds Product, Supplier, and ProductsSupplier object reference for a Package.
    /// </summary>
    public class ProductsSupplierDTO
    {
        /// <summary>
        /// The Product reference for this DTO.
        /// </summary>
        public Product product;

        /// <summary>
        /// The Supplier reference for this DTO.
        /// </summary>
        public Supplier supplier;

        /// <summary>
        /// The ProductsSupplier reference for the DTO.
        /// </summary>
        public ProductsSupplier productsSupplier;

        /// <summary>
        /// Property to get the ProductName
        /// </summary>
        public string ProdName
        {
            get
            {
                return product.ProdName;
            }
        }
        /// <summary>
        /// Property to get the SupplierName
        /// </summary>
        public string SupName
        {
            get
            {
                return supplier.SupName;
            }
        }

        /// <summary>
        /// Initializes a new instance of this class.
        /// </summary>
        /// <param name="product">the Product the set</param>
        /// <param name="supplier">the Supplier to set</param>
        /// <param name="productsSupplier">the ProductsSupplier to set</param>
        public ProductsSupplierDTO(Product product, Supplier supplier, ProductsSupplier productsSupplier)
        {
            this.product = product;
            this.supplier = supplier;
            this.productsSupplier = productsSupplier;
        }

        
    }
}
