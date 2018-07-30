using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TravEx_WebApp.App_Code;

namespace TravEx_WebApp
{
    public partial class SignUp : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                DebugFillForm();
        }

        private void DebugFillForm()
        {
            txtFirstName.Text = "Joel";
            txtLastName.Text = "Barr";
            txtAddress.Text = "4519 Vegas rd NW";
            txtCity.Text = "Calgary";
            txtPostal.Text = "a4a4a4";
            txtHomePhone.Text = "403-593-5520";
            txtWorkPhone.Text = "4035935520";
            txtEmail.Text = "Joelbarr1220@gmail.com";
            txtPassword1.Text = "password";
            txtPassword2.Text = "password";

        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer()
            {
                CustFirstName = txtFirstName.Text,
                CustLastName = txtLastName.Text,
                CustAddress = txtAddress.Text,
                CustCity = txtCity.Text,
                CustPostal = txtPostal.Text,
                CustProv = drpProvince.Text,
                CustCountry = "Canada",
                CustHomePhone = txtHomePhone.Text,
                CustBusPhone = txtWorkPhone.Text,
                CustEmail = txtEmail.Text
            };

            /*int customerID = */CustomerDB.InsertCustomer(customer);

            //Create Login
            /*
             * CustomerLogin login = new Login() {
             *      CustomerID = customerID,
             *      Password = txtPassword1.Text
             * };
             * */
             
            // Log in

        }

    }
}