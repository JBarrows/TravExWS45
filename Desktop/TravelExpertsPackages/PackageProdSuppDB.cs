using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Team4_Workshop4;

namespace TravelExpertsPackages
{
    public static class PackageProdSuppDB
    {
        public static List<NamedProductSupplier> GetPackageProductSuppliersByPackage(int pkgID)
        {
            List<NamedProductSupplier> productSuppliers = new List<NamedProductSupplier>();
            SqlConnection conn = TravelExpertsDB.GetConnection();
            string sqlQuery = "SELECT  ps.ProductSupplierID as psID, p.ProductId as pID, ProdName, s.SupplierId as sID, SupName " +
                                "FROM Products p " +
                                "INNER JOIN Products_Suppliers ps ON p.ProductId = ps.ProductId " +
                                "INNER JOIN Suppliers s ON s.SupplierId = ps.SupplierId " +
                                "INNER JOIN Packages_Products_Suppliers pkgps ON pkgps.ProductSupplierId = ps.ProductSupplierId " +
                                "WHERE pkgps.PackageID = @PackageID "  +
                                "ORDER BY pkgps.ProductSupplierId";
            //string sqlQuery = "SELECT PackageID, ProductSupplierID FROM Packages_Products_Suppliers "+
            //                    "WHERE PackageID = @PackageID ORDER BY ProductSupplierID";
            SqlCommand cmd = new SqlCommand(sqlQuery, conn);
            cmd.Parameters.AddWithValue("@PackageID", pkgID);

            try
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    NamedProductSupplier prodSup = new NamedProductSupplier
                    {
                        ProductSupplierId = (int)reader["psID"],
                        ProductId = (int)reader["pID"],
                        ProductName = reader["ProdName"].ToString(),
                        SupplierId = (int)reader["sID"],
                        SupplierName = reader["SupName"].ToString()
                    };

                    productSuppliers.Add(prodSup);
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                conn.Close();
            }

            return productSuppliers;
        }

        public static List<NamedProductSupplier> GetPackageProductSuppliersByPackage(TravelPackage pkg)
        {
            return GetPackageProductSuppliersByPackage(pkg.ID);
        }
    }
}
