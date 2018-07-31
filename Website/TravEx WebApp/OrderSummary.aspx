<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="OrderSummary.aspx.cs" Inherits="TravEx_WebApp.OrderSummary" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
            <script>
            //print() is for the print button
            function window.print() {
                var prtContent = document.getElementById("div2");
                var WinPrint = window.open('', '', 'left=0,top=0,width=800,height=900,toolbar=0,scrollbars=0,status=0');
                WinPrint.document.write(prtContent.innerHTML);
                WinPrint.document.close();
                WinPrint.focus();
                WinPrint.print();
                WinPrint.close();
            }
        </script>
    <title>Order Summary</title>
    <link href="styles/OrderSummary.css" rel="stylesheet" />
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainPlaceHolder" runat="server">

        <h1 class="jumbotron text-center text-secondary">Booking Summary</h1>
        <h4 class="text-secondary">Here are the list of your bookings.<asp:Button CssClass="btn" ID="btnPrint" runat="server" Text="Print" OnClinetClick="return window.print();" OnClick="btnPrint_Click"/></h4>
        <asp:DropDownList CssClass="form-control col-sm-3 bg-mute" D="ddlCustomerId" runat="server" AutoPostBack="True" DataSourceID="ObjectDataSource7" DataTextField="CustomerId" DataValueField="CustomerId" ID="ddlCustomerId" >
        </asp:DropDownList>
        <asp:ObjectDataSource ID="ObjectDataSource7" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="GetAllCustomers" TypeName="TravEx_WebApp.App_Code.CustomerDB"></asp:ObjectDataSource>
        <asp:GridView CssClass="table table-striped" ID="GridView6" runat="server" AutoGenerateColumns="False" DataSourceID="ObjectDataSource8">
            <Columns>
                <asp:BoundField DataField="BookingId" HeaderText="BookingId" SortExpression="BookingId" />
                <asp:BoundField DataField="BookingDate" HeaderText="BookingDate" SortExpression="BookingDate" DataFormatString="{0:D}" />
                <asp:BoundField DataField="BookingNo" HeaderText="BookingNo" SortExpression="BookingNo" />
            </Columns>
        </asp:GridView>
        <asp:ObjectDataSource ID="ObjectDataSource8" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="GetBookingsByCustomerId" TypeName="TravEx_WebApp.App_Code.BookingDB">
            <SelectParameters>
                <asp:ControlParameter ControlID="ddlCustomerId" Name="CustomerId" PropertyName="SelectedValue" Type="Int32" />
            </SelectParameters>
        </asp:ObjectDataSource>
            <br />
            <br />
        <asp:DropDownList CssClass="form-control col-sm-3 bg-mute" ID="ddlBookingId" runat="server" AutoPostBack="True" DataSourceID="ObjectDataSource1" DataTextField="BookingId" DataValueField="BookingId">
        </asp:DropDownList>
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="GetBookingsByCustomerId" TypeName="TravEx_WebApp.App_Code.BookingDB">
            <SelectParameters>
                <asp:ControlParameter ControlID="ddlCustomerId" Name="CustomerId" PropertyName="SelectedValue" Type="Int32" />
            </SelectParameters>
        </asp:ObjectDataSource>
        <asp:GridView CssClass="table table-striped" ID="GridView7" runat="server" AutoGenerateColumns="False" DataSourceID="ObjectDataSource2">
            <Columns>
                <asp:BoundField DataField="BookingDetailId" HeaderText="BookingDetailId" SortExpression="BookingDetailId" />
                <asp:BoundField DataField="TripStart" HeaderText="TripStart" SortExpression="TripStart" DataFormatString="{0:D}" />
                <asp:BoundField DataField="TripEnd" HeaderText="TripEnd" SortExpression="TripEnd" DataFormatString="{0:D}" />
                <asp:BoundField DataField="Description" HeaderText="Description" SortExpression="Description" />
                <asp:BoundField DataField="Destination" HeaderText="Destination" SortExpression="Destination" />
                <asp:BoundField DataField="ProdName" HeaderText="ProdName" SortExpression="ProdName" />
                <asp:BoundField DataField="SupName" HeaderText="SupName" SortExpression="SupName" />
                <asp:BoundField DataField="BasePrice" HeaderText="BasePrice" SortExpression="BasePrice" />
                <asp:BoundField DataField="FeeAmt" HeaderText="FeeAmt" SortExpression="FeeAmt" />
                <asp:BoundField DataField="TaxAmt" HeaderText="TaxAmt" SortExpression="TaxAmt" />
                <asp:BoundField DataField="TotalPrice" HeaderText="TotalPrice" SortExpression="TotalPrice" />
            </Columns>
        </asp:GridView>
        <asp:ObjectDataSource ID="ObjectDataSource2" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="GetOrderSummaryByBookingId" TypeName="TravEx_WebApp.App_Code.OrderSummaryDB">
            <SelectParameters>
                <asp:ControlParameter ControlID="ddlBookingId" Name="BookingId" PropertyName="SelectedValue" Type="Int32" />
            </SelectParameters>
        </asp:ObjectDataSource>
        <br />

</asp:Content>






    
       

 
     
   

