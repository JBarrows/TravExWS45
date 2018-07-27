using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelExpertsPackages;

namespace Team4_Workshop4
{
    public static class SupplierDB
    {
        //the method of getting all the suppliers data from the database
        public static List<Supplier> GetAllSuppliers()
        {
            List<Supplier> suppliers = new List<Supplier>();
            Supplier sup = null;
            SqlConnection con = TravelExpertsDB.GetConnection();
            string SelectSmt = "SELECT SupplierId, SupName " +
                                "FROM Suppliers " +
                                "ORDER BY SupName";
            SqlCommand cmd = new SqlCommand(SelectSmt, con);
            
            try
            {
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read()) //while there are suppliers
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

        //the method of getting the supplier by supplierId
        public static Supplier GetSupplier(int supplierId)
        {
            //List<Supplier> suppliers = new List<Supplier>();
            Supplier sup = null;
            SqlConnection con = TravelExpertsDB.GetConnection();
            string selectSmt = "SELECT SupplierId, SupName " +
                                "FROM Suppliers " +
                                "WHERE SupplierId = @SupplierId";
            SqlCommand cmd = new SqlCommand(selectSmt, con);
            cmd.Parameters.AddWithValue("@SupplierId", supplierId); // value comes from the method's argument
            try
            {
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read()) //found a supplier
                {
                    sup = new Supplier();
                    sup.SupplierId = (int)dr["SupplierId"];
                    sup.SupName = dr["SupName"].ToString();
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
            return sup;
        }

        //the method of getting new unique supplierId for adding new supplier
        public static int GetNewSupplierId(/*Supplier sup*/)
        {
            int supId = 0;
            SqlConnection con = TravelExpertsDB.GetConnection();
            string selectSmt = "SELECT TOP 1 SullierId " +
                                 "FROM Suppliers " +
                                 "ORDER BY SupplierId DESC";
            SqlCommand cmd = new SqlCommand(selectSmt, con);

            try
            {
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader(System.Data.CommandBehavior.SingleResult);
                if (dr.Read()) //found a supplierId
                {
                    supId = 1 + (int)dr["SupplierId"]; // add 1 to current largest supplierId
                    //sup.SupplierId = supId;
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
            return supId;

        }

        /// <summary>
        /// Adds a new supplier to the Suppliers table in Travel Experts database
        /// </summary>
        /// <param name="sup"> Supplier object that containg data for the new record</param>
        /// <returns>generated SupplierID</returns>
        public static int AddSupplier(Supplier sup)
        {
            SqlConnection con = TravelExpertsDB.GetConnection();            
            string insertSmt = "INSERT INTO Suppliers (Supplierid, SupName) " +
                                "VALUES(@SupplierId, @SupName)";
            SqlCommand cmd = new SqlCommand(insertSmt, con);
            cmd.Parameters.AddWithValue("@SupplierId", sup.SupplierId);
            cmd.Parameters.AddWithValue("@SupName", sup.SupName);
            try
            {
                con.Open();
                cmd.ExecuteNonQuery(); // run the insert command
                //get the generated ID - current identity value of Suppliers table
                string selectQuery = "SELECT INDENT_CURRENT('Suppliers') From Suppliers";
                SqlCommand selectCmd = new SqlCommand(selectQuery, con);
                int supplierId = Convert.ToInt32(selectCmd.ExecuteScalar());
                return supplierId;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
        }

        /// <summary>
        /// Delete a upplier from the Suppliers table in Travel Experts database
        /// </summary>
        /// <param name="sup"> Supplier object that containg data for the supplier </param>
        /// <returns>generated SupplierID</returns>
        public static bool DeleteSupplier(Supplier sup)
        {
            SqlConnection con = TravelExpertsDB.GetConnection();
            String deleteSmt = "DELETE FROM Suppliers " +
                                "WHERE SupplierId = @SupplierId " +
                                "And Name = @Name";
            SqlCommand cmd = new SqlCommand(deleteSmt, con);
            cmd.Parameters.AddWithValue("@SupplierId", sup.SupplierId);
            cmd.Parameters.AddWithValue("@SupName", sup.SupName);
            try
            {
                con.Open();
                int count = cmd.ExecuteNonQuery();
                if (count > 0) return true;
                else return false;
            }
            catch(SqlException ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
        }

        /// <summary>
        /// Updates existing supplier record
        /// </summary>
        /// <param name="oldSup">data before update</param>
        /// <param name="newSup">new data for the update</param>
        /// <returns>indicator of success</returns>
        public static bool UpdateSupplier(Supplier oldSup, Supplier newSup)
        {
            SqlConnection con = TravelExpertsDB.GetConnection();
            string UpdateSmt = "UPDATE Suppliers " +
                               "SET SupName = @NewSupName " +
                               "Where SupplierId = @OldSupplierId " +
                               "And SupName = @OldSupName";            
            SqlCommand cmd = new SqlCommand(UpdateSmt, con);
            cmd.Parameters.AddWithValue("@NewSupName", newSup.SupName);
            cmd.Parameters.AddWithValue("@OldSupplierId", oldSup.SupplierId);
            cmd.Parameters.AddWithValue("@OldSupName", oldSup.SupName);

            try
            {
                con.Open();
                int count = cmd.ExecuteNonQuery();
                if (count > 0) return true;
                else return false;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
        }
    }
}
