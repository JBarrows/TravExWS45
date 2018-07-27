using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelExpertsPackages
{
    public static class SuppliedProdDB
    {
        //getting all the products supplieried by the supplier
        public static List<NamedProductSupplier> GetProductsBySupplier(int supplierId)
        {
            List<NamedProductSupplier> SuppliedProds = new List<NamedProductSupplier>();
            NamedProductSupplier suppliedProd;
            SqlConnection con = TravelExpertsDB.GetConnection();
            string SelectSmt = "SELECT SupplierId, p.ProductId, p.ProdName " +
                                "FROM Products_Suppliers ps JOIN Products p " +
                                "ON ps.ProductId = p.ProductId " +
                                "WHERE SupplierId = @SupplierId " +
                                "ORDER BY p.ProductId";
            SqlCommand selectCmd = new SqlCommand(SelectSmt, con);
            selectCmd.Parameters.AddWithValue("@SupplierId", supplierId);

            try
            {
                con.Open();
                SqlDataReader dr = selectCmd.ExecuteReader();
                while (dr.Read())
                {
                    suppliedProd = new NamedProductSupplier();
                    suppliedProd.SupplierId = (int)dr["SupplierId"];
                    suppliedProd.ProductId = (int)dr["ProductId"];
                    suppliedProd.ProductName = dr["prodName"].ToString();
                    SuppliedProds.Add(suppliedProd);
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
            return SuppliedProds;
        }
        

    }

}
