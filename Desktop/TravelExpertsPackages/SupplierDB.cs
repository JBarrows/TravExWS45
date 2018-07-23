using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team4_Workshop4
{
    public static class SupplierDB
    {
        //the method of getting connection with the database
        public static SqlConnection GetConnection()
        {
            return new SqlConnection(@"Data Source = ICTVMOO - 3HACPF6\SQLEXPRESS; Initial Catalog = TravelExperts; Integrated Security = True");
        }

        //the method of getting all the suppliers data from the database
        public static List<Supplier> GetSuppliers()
        {
            List<Supplier> suppliers = new List<Supplier>();
            Supplier sup;
            SqlConnection con = GetConnection();
            string SelectSmt = "SELECT SupplierId, SupName " +
                                "FROM Suppliers " +
                                "ORDER BY SupName";
            SqlCommand selectCmd = new SqlCommand(SelectSmt, con);

            try
            {
                con.Open();
                SqlDataReader dr = selectCmd.ExecuteReader();
                while (dr.Read())
                {
                    sup = new Supplier();
                    sup.SupplierId = (int)dr["SupplierId"];
                    sup.SupName = dr["SupName"].ToString();

                    suppliers.Add(sup);
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
            return suppliers;
        }
    }
}
