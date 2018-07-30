<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegisterLogin.aspx.cs" Inherits="WebApplication1.RegisterLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login</title>
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.1.2/css/bootstrap.min.css" integrity="sha384-Smlep5jCw/wG7hdkwQ/Z5nLIefveQRIY9nfy6xoR1uRYBtpZgI6339F5dgvm/e9B" crossorigin="anonymous" />
</head>
<body>
    <form id="frmRegister" runat="server" class="container-fluid">
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
                <%-- Password --%>
                <div class="form-row">
                    <div class="col form-group">
                        Password
                        <asp:TextBox ID="TextBox2" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>
                </div>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
