using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelExpertsData;

namespace TravelExpertsDataAPI
{
    class ProductsSuppliersArchiveDB
    {
        public static List<Package> ArchiveProductsSupplier(Product product, Supplier supplier)
        {
            List<Package> packagesUsing = null;
            ProductsSupplier ps = ProductSupplierDB.GetProductsSupplier(product, supplier);

            packagesUsing = ProductSupplierDB.GetPackages(ps);

            if (packagesUsing != null && packagesUsing.Count > 0)
                return packagesUsing;

            // If it gets here, there were no packages using this
            using (TravelExpertsContext db = new TravelExpertsContext())
            {
                List<ProductsSuppliersArchive> psaList = db.ProductsSuppliersArchives
                    .Where(psa => psa.ProductSupplierId == ps.ProductSupplierId).ToList();

                // It's not already archived
                if (psaList.Count < 1)
                {
                    // Archive it
                    ProductsSuppliersArchive psa = new ProductsSuppliersArchive();
                    psa.ProductSupplierId = ps.ProductSupplierId;
                    db.ProductsSuppliersArchives.Add(psa);
                    db.SaveChanges();
                }
            }

            return packagesUsing;
        }
    }
}
