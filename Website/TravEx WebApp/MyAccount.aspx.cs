using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TravEx_WebApp.App_Code;

/*
 * Purpose: ASP.NET Workshop 5
 * Author: Lindsay
 * Date:July, 2018 
 */

namespace TravEx_WebApp
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        Customer cust;

        //fills the customer information when form loading
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["CustomerId"] == null)
                Server.Transfer("SignUp.aspx", true);
            if (!IsPostBack)
            {
                try
                {
                    //cust = CustomerDB.GetCustomerByCustomerId(143);
                    cust = CustomerDB.GetCustomerByCustomerId((int)Session["CustomerId"]);
                    fillCustomer(cust);
                }
                catch (Exception ex)
                {
                    lblUpdatError.Text = ex.Message;
                }
            }

        }

        private void fillCustomer(Customer cust)
        {
            txtFirstName.Text = cust.CustFirstName;
            txtLastName.Text = cust.CustLastName;
            txtAddress.Text = cust.CustAddress;
            txtCity.Text = cust.CustCity;
            ddlProv.Text = cust.CustProv;
            txtPostal.Text = cust.CustPostal;
            txtHomePhone.Text = cust.CustHomePhone;
            txtBusPhone.Text = cust.CustBusPhone;
            txtEmail.Text = cust.CustEmail;
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            Customer newCust = new Customer();
            newCust.CustFirstName = txtFirstName.Text;
            newCust.CustLastName = txtLastName.Text ;
            newCust.CustAddress = txtAddress.Text;
            newCust.CustCity = txtCity.Text;
            newCust.CustProv = ddlProv.SelectedValue;
            newCust.CustPostal = txtPostal.Text;
            newCust.CustHomePhone = txtHomePhone.Text;
            newCust.CustBusPhone = txtBusPhone.Text;
            newCust.CustEmail = txtEmail.Text;
            try
            {
                if (CustomerDB.UpdateCustomerByCustomerId((int)Session["CustomerId"], newCust))
                    lblUpdatError.Text = "Your information updated.";
            }
            catch (Exception ex)
            {
                lblUpdatError.Text = ex.Message;
            }
        }

        
        protected void btnCancle_Click(object sender, EventArgs e)
        {
            fillCustomer(cust);
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            txtOldPassword.Text = "";
            txtNewPassword.Text = "";
            txtConfirmPwd.Text = "";
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            CustomerLogin reset = new CustomerLogin();

            string oldPwd = txtOldPassword.Text;
            string newPwd = txtNewPassword.Text;
            string confirmPwd = txtConfirmPwd.Text;

            if (!CustomerDB.CheckPassword(cust.CustomerId, oldPwd))
                lblResetError.Text = "Invalid current password. Please try again.";
            else // do reset
            {
                reset.CustomerId = cust.CustomerId;
                reset.Password = newPwd;
                try
                {
                    if (CustomerDB.ResetCustomerPassword(reset))
                    {
                        lblResetError.Text = "Reset successfully.";
                    }                    
                }
                catch (Exception ex)
                {
                    lblResetError.Text = ex.Message;
                }
            }
        }
    }
}