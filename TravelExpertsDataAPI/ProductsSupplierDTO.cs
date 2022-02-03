using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelExpertsData;

namespace TravelExpertsDataAPI
{
    public class ProductsSupplierDTO
    {
        public Product product;
        public string ProdName
        {
            get
            {
                return product.ProdName;
            }
        }
        public string SupName
        {
            get
            {
                return supplier.SupName;
            }
        }

        public Supplier supplier;
        public ProductsSupplier productsSupplier;


        public ProductsSupplierDTO(Product product, Supplier supplier, ProductsSupplier productsSupplier)
        {
            this.product = product;
            this.supplier = supplier;
            this.productsSupplier = productsSupplier;
        }

        
    }
}
