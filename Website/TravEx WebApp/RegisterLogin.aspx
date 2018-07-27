<%@ Page Title="Login/Register" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="RegisterLogin.aspx.cs" Inherits="TravEx_WebApp.WebForm4" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainPlaceHolder" runat="server">
        <div class="row m-5">
            <div class="card bg-warning col-lg-7 p-4">
                    <h1 class="row">Register</h1>
                <div class="card-body">
                    <div class="form-row">
                        <%-- First name --%>
                        <div class="col-md-6 form-group">
                            First Name
                            <asp:TextBox ID="txtFirstName" CssClass="form-control" runat="server" Width="100%"></asp:TextBox>
                        </div>
                        <%-- Last name --%>
                        <div class="col-md-6 form-group ">
                            Last Name
                            <asp:TextBox ID="txtLastName" CssClass="form-control" runat="server" Width="100%"></asp:TextBox>
                        </div>
                    </div>
                    <div class="form-row">
                        <div class="col form-group">
                            Street Address
                            <asp:TextBox ID="TextBox4" CssClass="form-control" runat="server" Width="100%"></asp:TextBox>
                        </div>
                    </div>
                    <div class="form-row">
                        <div class="col-8 col-md-5 form-group">
                            City
                            <asp:TextBox ID="TextBox5" CssClass="form-control" runat="server" Width="100%"></asp:TextBox>
                        </div>
                        <div class="col-4 col-md-2 form-group">
                            Prov
                            <asp:TextBox ID="TextBox7" CssClass="form-control" runat="server" Width="100%"></asp:TextBox>
                        </div>
                        <div class="col-md-5 form-group">
                            Postal
                            <asp:TextBox ID="TextBox6" CssClass="form-control" runat="server" Width="100%"></asp:TextBox>
                        </div>
                    </div>
                    <div class="form-row">
                        <div class="col-md-6 form-group">
                            Home Phone
                            <asp:TextBox ID="TextBox10" CssClass="form-control" runat="server" Width="100%"></asp:TextBox>
                        </div>
                        <div class="col-md-6 form-group ">
                            Business Phone
                            <asp:TextBox ID="TextBox11" CssClass="form-control" runat="server" Width="100%"></asp:TextBox>
                        </div>
                    </div>
                    <div class="form-row">
                        <div class="col form-group">
                            Email
                            <asp:TextBox ID="TextBox3" CssClass="form-control" runat="server" Width="100%"></asp:TextBox>
                        </div>
                    </div>
                    <div class="form-row">
                        <div class="col-md-6 form-group">
                            Password
                            <asp:TextBox ID="TextBox8" CssClass="form-control" runat="server" Width="100%"></asp:TextBox>
                        </div>
                        <div class="col-md-6 form-group ">
                            Confirm Password
                            <asp:TextBox ID="TextBox9" CssClass="form-control" runat="server" Width="100%"></asp:TextBox>
                        </div>
                    </div>
                </div>
            </div>
            <div class="col-lg"></div>

            <div class="card bg-info text-white col-lg-4 p-4">
                <h1 class="row">Login</h1>
                <div class="card-body">
                <%-- Email --%>
                <div class="form-row">
                    <div class="col form-group">
                        Email
                        <asp:TextBox ID="TextBox1" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>
                </div>
                <%--Password --%>
                <div class="form-row">
                    <div class="col form-group">
                        Password
                        <asp:TextBox ID="TextBox2" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>
                </div>
                </div>
            </div>
        </div>
</asp:Content>