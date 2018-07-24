using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team4_Workshop4
{
    class ProductSupplierDB
    {
        //the method of getting connection with the database
        public static SqlConnection GetConnection()
        {
            return new SqlConnection(@"Data Source = localhost\SQLEXPRESS; Initial Catalog = TravelExperts; Integrated Security = True");
        }

        //the method of getting all the suppliers data from the database
        public static List<ProductSupplier> GetProdudtSuppliers()
        {
            List<ProductSupplier> prodSups = new List<ProductSupplier>();
            ProductSupplier prodSup;
            SqlConnection con = GetConnection();
            string SelectSmt = "SELECT ProductSupplierId, ProductId, SupplierId" +
                                "FROM Products_Suppliers " +
                                "ORDER BY ProductSupplierId";
            SqlCommand selectCmd = new SqlCommand(SelectSmt, con);

            try
            {
                con.Open();
                SqlDataReader dr = selectCmd.ExecuteReader();
                while (dr.Read())
                {
                    prodSup = new ProductSupplier();
                    prodSup.ProductSupplierId = (int)dr["ProductSupplierId"];
                    prodSup.ProductId = (int)dr["ProductId"];
                    prodSup.SupplierId = (int)dr["SupplierId"];
                    

                    prodSups.Add(prodSup);
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
            return prodSups;
        }
    }
}
