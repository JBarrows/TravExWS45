using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelExpertsPackages
{
    public static class PackageProdSuppDB
    {
        public static List<Team4_Workshop4.ProductSupplier> GetProductSuppliersByPackage(int pkgID)
        {
            List<Team4_Workshop4.ProductSupplier> productSuppliers = new List<Team4_Workshop4.ProductSupplier>();

            return productSuppliers;
        }

        public static List<Team4_Workshop4.ProductSupplier> GetProductSuppliersByPackage(TravelPackage pkg)
        {
            return GetProductSuppliersByPackage(pkg.ID);
        }
    }
}
