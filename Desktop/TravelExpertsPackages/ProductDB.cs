using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelExpertsPackages
{
    public static class ProductDB
    {
        public static SqlConnection GetConnection()
        {

            //string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\northwnd.mdf;Integrated Security=True;Connect Timeout=30";
            string connectionString = @"Data Source=localhost\sqlexpress;Initial Catalog=TravelExperts;Integrated Security=True";
            SqlConnection con = new SqlConnection(connectionString);
            return con;
        }

        public static List<Product> GetProducts()
        {
            List<Product> products = new List<Product>();
            Product product;
            SqlConnection con = TravelExpertsDB.GetConnection();
            string selectStatement = "SELECT ProductId, ProdName " +
                                     "FROM Products ORDER BY ProductId";

            SqlCommand selectCmd = new SqlCommand(selectStatement, con);

            try
            {
                con.Open();
                SqlDataReader dr = selectCmd.ExecuteReader();
                while (dr.Read())
                {
                    product = new Product();
                    product.ProductId = (int)dr["ProductId"];
                    product.ProdName = dr["ProdName"].ToString();
   
                    products.Add(product);
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }

            return products;
        }
    }
}
