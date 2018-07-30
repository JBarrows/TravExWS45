using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelExpertsPackages
{
    public class NamedProductSupplier : TravelExpertsPackages.ProductSupplier
    {
        public string ProductName { get; set; }
        public string SupplierName { get; set; }
    }
}
