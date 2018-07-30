using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelExpertsPackages;

namespace TravelExpertsPackages
{
    public static class SupplierDB
    {
        //the method of getting all the suppliers data from the database
        public static List<Supplier> GetSuppliers()
        {
            List<Supplier> suppliers = new List<Supplier>();
            Supplier sup;
            SqlConnection con = TravelExpertsDB.GetConnection();
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
