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
    public static class CustomerDB
    {
        [DataObjectMethod(DataObjectMethodType.Select)]
        public static List<Customer> GetAllCustomers()
        {
            List<Customer> customers = new List<Customer>(); // make an empty list
            Customer cust;
            // create connection
            SqlConnection connection = TravelExpertsDB.GetConnection();

            // create select command
            string selectString = "SELECT * FROM Customers " +
                                  "ORDER BY CustomerId";
            SqlCommand selectCommand = new SqlCommand(selectString, connection);
            try
            {

                connection.Open();

                SqlDataReader reader = selectCommand.ExecuteReader();
                while (reader.Read())
                {
                    cust = new Customer();
                    cust.CustomerId = (int)reader["CustomerId"];
                    cust.CustFirstName = reader["CustFirstName"].ToString();
                    cust.CustLastName = reader["CustLastName"].ToString();
                    cust.CustAddress = reader["CustAddress"].ToString();
                    cust.CustCity = reader["CustCity"].ToString();
                    cust.CustProv = reader["CustProv"].ToString();
                    cust.CustPostal = reader["CustPostal"].ToString();
                    cust.CustCountry = reader["CustCountry"].ToString();
                    cust.CustHomePhone = reader["CustHomePhone"].ToString();
                    cust.CustBusPhone = reader["CustBusPhone"].ToString();
                    cust.CustEmail = reader["CustEmail"].ToString();
                    cust.AgentId = (int)reader["AgentId"];
                    customers.Add(cust);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                throw ex; // throw it to the form to handle
            }
            finally
            {
                connection.Close();
            }
            return customers;
        }






        // retrieves customer with given ID
        [DataObjectMethod(DataObjectMethodType.Select)]
        public static Customer GetCustomerByCustomerId(int CustomerId)
        {
            Customer cust = null; // found customer
            // define connection
            SqlConnection connection = TravelExpertsDB.GetConnection();

            // define the select query command
            string selectQuery = "select * " +
                                 "from Customers " +
                                 "where CustomerId = @CustomerId";
            SqlCommand selectCommand = new SqlCommand(selectQuery, connection);
            selectCommand.Parameters.AddWithValue("@CustomerId", CustomerId);
            try
            {
                // open the connection
                connection.Open();

                // execute the query
                SqlDataReader reader = selectCommand.ExecuteReader(CommandBehavior.SingleRow);

                // process the result if any
                if (reader.Read()) // if there is customer
                {
                    cust = new Customer();
                    cust.CustomerId = (int)reader["CustomerId"];
                    cust.CustFirstName = reader["CustFirstName"].ToString();
                    cust.CustLastName = reader["CustLastName"].ToString();
                    cust.CustAddress = reader["CustAddress"].ToString();
                    cust.CustCity = reader["CustCity"].ToString();
                    cust.CustProv = reader["CustProv"].ToString();
                    cust.CustPostal = reader["CustPostal"].ToString();
                    cust.CustCountry = reader["CustCountry"].ToString();
                    cust.CustHomePhone = reader["CustHomePhone"].ToString();
                    cust.CustBusPhone = reader["CustBusPhone"].ToString();
                    cust.CustEmail = reader["CustEmail"].ToString();
                    cust.AgentId = (int)reader["AgentId"];
                }
            }
            catch (Exception ex)
            {
                throw ex; // let the form handle it
            }
            finally
            {
                connection.Close(); // close connecto no matter what
            }

            return cust;
        }

        // retrieves CustomerId with given BookingId
        [DataObjectMethod(DataObjectMethodType.Select)]
        public static int GetCustomerIdByBookingId(int BookingId)
        {
            int customerId = 0;

            SqlConnection connection = TravelExpertsDB.GetConnection();

            // define the select query command
            string selectQuery = "SELECT CustomerId " +
                                 "FROM Bookings " +
                                 "WHERE BookingId = @BookingId";

            //$sql_pkg_id = "SELECT PackageId FROM bookings where bookings.bookingId = '$bookingId';";
            SqlCommand selectCommand = new SqlCommand(selectQuery, connection);
            selectCommand.Parameters.AddWithValue("@BookingId", BookingId);
            try
            {
                // open the connection
                connection.Open();

                // execute the query
                SqlDataReader reader = selectCommand.ExecuteReader(CommandBehavior.SingleRow);

                // process the result if any
                if (reader.Read()) // if there is booking
                {
                    //booking = new Booking();
                    //booking.PackageId = (int)reader["PackageId"];
                    customerId = (int)reader["CustomerId"];
                }
            }
            catch (Exception ex)
            {
                throw ex; // let the form handle it
            }
            finally
            {
                connection.Close(); // close connection no matter what
            }

            return customerId;
        }

        // retrieves customer with given ID
        [DataObjectMethod(DataObjectMethodType.Select)]
        public static Customer GetCustomerByBookingId(int BookingId)
        {         
            return GetCustomerByCustomerId(GetCustomerIdByBookingId(BookingId));
        }

    }
}