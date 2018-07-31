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
        int customerId = 104;
        //fills the customer information when form loading
        protected void Page_Load(object sender, EventArgs e)
        {
            Customer cust = new Customer();            
            if (!IsPostBack)
            {
                try
                {
                    cust = CustomerDB.GetCustomerByCustomerId(customerId);
                }
                catch (Exception ex)
                {
                    lblMessage.Text = ex.Message;
                }
            }

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
            Customer cust = new Customer();
            cust.CustFirstName = txtFirstName.Text;
            cust.CustLastName = txtLastName.Text ;
            cust.CustAddress = txtAddress.Text;
            cust.CustCity = txtCity.Text;
            cust.CustProv = ddlProv.SelectedValue;
            cust.CustPostal = txtPostal.Text;
            cust.CustHomePhone = txtHomePhone.Text;
            cust.CustBusPhone = txtBusPhone.Text;
            cust.CustEmail = txtEmail.Text;
            try
            {

                CustomerDB.UpdateCustomerByCustomerId(customerId, cust);
            }
            catch (Exception ex)
            {
                lblMessage.Text = ex.Message;
                hnjkmfkdmfk
            }
        }
    }
}