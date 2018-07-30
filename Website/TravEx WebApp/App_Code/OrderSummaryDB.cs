using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace TravEx_WebApp.App_Code
{
    [DataObject(true)]
    public static class OrderSummaryDB
    {
        const decimal TAX = 0.05m;
        // retrieves customer with given ID
        [DataObjectMethod(DataObjectMethodType.Select)]
        public static OrderSummary GetOrderSummary(int BookingId)
        {           
            OrderSummary orderSummary = new OrderSummary();

            orderSummary.BasePrice = BookingDetailDB.GetBookingDetailByBookingId(BookingId).BasePrice;
            orderSummary.AgencyCommission = BookingDetailDB.GetBookingDetailByBookingId(BookingId).AgencyCommission;
            orderSummary.PkgBasePrice = PackageDB.GetPackageByBookingId(BookingId).PkgBasePrice;
            orderSummary.PkgAgencyCommision = PackageDB.GetPackageByBookingId(BookingId).PkgAgencyCommission;
            orderSummary.FeeAmt = FeeDB.GetFeeByBookingId(BookingId).FeeAmt;

            orderSummary.TotalPrice = (orderSummary.BasePrice + orderSummary.AgencyCommission +
                                      orderSummary.PkgBasePrice + orderSummary.PkgAgencyCommision +
                                      orderSummary.FeeAmt) * (1 + TAX);
            return orderSummary;
        }
    }
}