<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MyAccount.aspx.cs" Inherits="TravEx_WebApp.WebForm3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainPlaceHolder" runat="server">

        <div class="row m-5">
            <div class="card bg-secondary text-white col-lg-7 p-4">
                    <h2 class="row">Personal Information</h2>
                <div class="card-body">
                    <div class="form-row">
                        <div class="col-md-6 form-group">
                            First Name
                            <asp:TextBox ID="txtFirstName" CssClass="form-control" runat="server" Width="100%"></asp:TextBox>
                        </div>
                        <div class="col-md-6 form-group ">
                            Last Name
                            <asp:TextBox ID="txtLastName" CssClass="form-control" runat="server" Width="100%"></asp:TextBox>
                        </div>
                    </div>
                    <div class="form-row">
                        <div class="col form-group">
                            Street Address
                            <asp:TextBox ID="txtStreetAddr" CssClass="form-control" runat="server" Width="100%"></asp:TextBox>
                        </div>
                    </div>
                    <div class="form-row">
                        <div class="col-8 col-md-5 form-group">
                            City
                            <asp:TextBox ID="txtCity" CssClass="form-control" runat="server" Width="100%"></asp:TextBox>
                        </div>
                        <div class="col-4 col-md-2 form-group">
                            Prov
                            <asp:TextBox ID="txtProv" CssClass="form-control" runat="server" Width="100%"></asp:TextBox>
                        </div>
                        <div class="col-md-5 form-group">
                            Postal Code
                            <asp:TextBox ID="txtPostal" CssClass="form-control" runat="server" Width="100%"></asp:TextBox>
                        </div>
                    </div>
                    <div class="form-row">
                        <div class="col-md-6 form-group">
                            Home Phone
                            <asp:TextBox ID="txtHomePhone" CssClass="form-control" runat="server" Width="100%"></asp:TextBox>
                        </div>
                        <div class="col-md-6 form-group ">
                            Business Phone
                            <asp:TextBox ID="txtBusPhone" CssClass="form-control" runat="server" Width="100%"></asp:TextBox>
                        </div>
                    </div>
                    <div class="form-row">
                        <div class="col form-group">
                            Email
                            <asp:TextBox ID="txtEmail" CssClass="form-control" runat="server" Width="100%"></asp:TextBox>
                        </div>
                    </div>
                    <br/>
                    <div class="form-row">
                        <div class="col-md-6">
                            <asp:Button ID="btnUpdate" runat="server" CssClass="btn btn-warning mb-2" Text="Update" Width="100%" />
                        </div>
                        <div class="col-md-6">
                            <asp:Button ID="btnCancle" runat="server" CssClass="btn btn-warning" Text="Cancle" CausesValidation="False" Width="100%" />
                        </div>
                    </div>
                </div>
            </div>
            <div class="col-lg"></div>

            <div class="card bg-info text-white col-lg-4 p-4">
                <h2 class="row">Reset Password</h2>
                <div class="card-body">
                    <div class="form-row">
                        <div class="col form-group">
                            Current Password
                            <asp:TextBox ID="txtOldPassword" CssClass="form-control" runat="server"></asp:TextBox>
                        </div>
                    </div>
                    <div class="form-row">
                        <div class="col form-group">
                            New Password
                            <asp:TextBox ID="txtNewPassword" CssClass="form-control" runat="server"></asp:TextBox>
                        </div>
                    </div>
                    <div class="form-row">
                        <div class="col form-group">
                            Confirm Password
                            <asp:TextBox ID="txtConfirmPwd" CssClass="form-control" runat="server"></asp:TextBox>
                        </div>
                    </div>
                    <br/>
                    <div class="form-row">
                        <div class="col-md-6">
                            <asp:Button ID="btnSubmit" runat="server" CssClass="btn btn-warning mb-2" Text="Submit" Width="100%" />
                        </div>
                        <div class="col-md-6">
                            <asp:Button ID="btnClear" runat="server" CssClass="btn btn-warning" Text="Clear" CausesValidation="False" Width="100%" />
                        </div>
                    </div>
                </div>
            </div>
        </div>
</asp:Content>
