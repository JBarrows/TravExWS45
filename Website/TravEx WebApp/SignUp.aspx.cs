using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TravEx_WebApp.App_Code;

/***********************************
 * This page written by Joel Barr
 ***********************************/
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

            int? customerID = CustomerDB.InsertCustomer(customer);

            if (customerID == null)
            {
                throw new Exception("Cannot retrieve new customer ID");
            }

            //Create Login
            CustomerLogin login = new CustomerLogin()
            {
                CustomerId = customerID.Value,
                Password = txtPassword1.Text
            };

            CustomerDB.InsertLogin(login);

            // Log in
            Login(customerID.Value);
        }

        private void Login(int customerID)
        {
            Session["CustomerId"] = customerID;
            Server.Transfer("MyAccount.aspx", true);
        }

        protected void loginEmailvalidator_ServerValidate(object source, ServerValidateEventArgs args)
        {
            args.IsValid = false;
            
            int? customerId = GetLoginID();

            if (customerId != null && CustomerDB.LoginExists(customerId.Value))
                args.IsValid = true;
        }

        private int? GetLoginID()
        {
            if (txtLoginEmail.Text == String.Empty) return null;

            Customer customer = CustomerDB.GetCustomerByEmail(txtLoginEmail.Text);
            if (customer == null) return null;

            int customerId = customer.CustomerId;
            return customerId;
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            int? customerID = GetLoginID();
            if (customerID == null || !CustomerDB.CheckPassword(customerID.Value, txtLoginPassword.Text)) return;

            Login(customerID.Value);
        }

        protected void loginPasswordValidator_ServerValidate(object source, ServerValidateEventArgs args)
        {
            args.IsValid = false;
            string pwInput;

            if (txtLoginPassword.Text == String.Empty)
                return;
            else
                pwInput = txtLoginPassword.Text;

            int? customerID = GetLoginID();
            
            if (customerID != null && CustomerDB.CheckPassword(customerID.Value, pwInput))
                args.IsValid = true;
        }
    }
}