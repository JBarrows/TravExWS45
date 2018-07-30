using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TravEx_WebApp.App_Code
{
    public class OrderSummary
    {
        public OrderSummary() { }
        public decimal BasePrice { get; set; }
        public decimal AgencyCommission { get; set; }
        public decimal PkgBasePrice { get; set; }
        public decimal PkgAgencyCommision { get; set; }
        public decimal FeeAmt { get; set; }
        public decimal TotalPrice { get; set; }

    }
}