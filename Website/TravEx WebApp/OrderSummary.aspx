<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="OrderSummary.aspx.cs" Inherits="TravEx_WebApp.OrderSummary" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
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
    <link href="styles/bootstrap.min.css" rel="stylesheet" />
    <link href="styles/OrderSummary.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <h1 class="jumbotron text-center text-secondary">Booking Summary</h1>
            <h4 class="text-secondary">Congratulaltions ! Your booking is confirmed.</h4><br />
            <asp:DropDownList CssClass="form-control col-sm-3 bg-mute" ID="ddlBookingId" runat="server" AutoPostBack="True" DataSourceID="ObjectDataSource1" DataTextField="BookingId" DataValueField="BookingId">
            </asp:DropDownList>
            <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="GetBookings" TypeName="TravEx_WebApp.App_Code.BookingDB"></asp:ObjectDataSource>
            <asp:Button CssClass="btn" ID="btnPrint" runat="server" Text="Print" OnClinetClick="return window.print();" OnClick="btnPrint_Click"/>
        <br />
        <asp:GridView CssClass="table table-secondary" ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="ObjectDataSource2">
            <Columns>
                <asp:BoundField DataField="BookingId" HeaderText="BookingId" SortExpression="BookingId" />
                <asp:BoundField DataField="BookingDate" HeaderText="BookingDate" SortExpression="BookingDate" />
                <asp:BoundField DataField="BookingNo" HeaderText="BookingNo" SortExpression="BookingNo" />
                <asp:BoundField DataField="TravelerCount" HeaderText="TravelerCount" SortExpression="TravelerCount" />
                <asp:BoundField DataField="CustomerId" HeaderText="CustomerId" SortExpression="CustomerId" />
                <asp:BoundField DataField="TripTypeId" HeaderText="TripTypeId" SortExpression="TripTypeId" />
                <asp:BoundField DataField="PackageId" HeaderText="PackageId" SortExpression="PackageId" />
            </Columns>
        </asp:GridView>
        <asp:ObjectDataSource ID="ObjectDataSource2" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="GetBookingByBookingId" TypeName="TravEx_WebApp.App_Code.BookingDB">
            <SelectParameters>
                <asp:ControlParameter ControlID="ddlBookingId" Name="BookingId" PropertyName="SelectedValue" Type="Int32" />
            </SelectParameters>
        </asp:ObjectDataSource>
        <asp:GridView CssClass="table table-secondary" ID="GridView2" runat="server" AutoGenerateColumns="False" DataSourceID="ObjectDataSource3">
            <Columns>
                <asp:BoundField DataField="BookingDetailId" HeaderText="BookingDetailId" SortExpression="BookingDetailId" />
                <asp:BoundField DataField="ItineraryNo" HeaderText="ItineraryNo" SortExpression="ItineraryNo" />
                <asp:BoundField DataField="TripStart" HeaderText="TripStart" SortExpression="TripStart" />
                <asp:BoundField DataField="TripEnd" HeaderText="TripEnd" SortExpression="TripEnd" />
                <asp:BoundField DataField="Description" HeaderText="Description" SortExpression="Description" />
                <asp:BoundField DataField="Destination" HeaderText="Destination" SortExpression="Destination" />
                <asp:BoundField DataField="BasePrice" HeaderText="BasePrice" SortExpression="BasePrice" />
                <asp:BoundField DataField="AgencyCommission" HeaderText="AgencyCommission" SortExpression="AgencyCommission" />
                <asp:BoundField DataField="BookingId" HeaderText="BookingId" SortExpression="BookingId" />
                <asp:BoundField DataField="RegionId" HeaderText="RegionId" SortExpression="RegionId" />
                <asp:BoundField DataField="ClassId" HeaderText="ClassId" SortExpression="ClassId" />
                <asp:BoundField DataField="FeeId" HeaderText="FeeId" SortExpression="FeeId" />
                <asp:BoundField DataField="ProductSupplierId" HeaderText="ProductSupplierId" SortExpression="ProductSupplierId" />
            </Columns>
        </asp:GridView>
        <asp:ObjectDataSource ID="ObjectDataSource3" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="GetBookingDetailByBookingId" TypeName="TravEx_WebApp.App_Code.BookingDetailDB">
            <SelectParameters>
                <asp:ControlParameter ControlID="ddlBookingId" Name="BookingId" PropertyName="SelectedValue" Type="Int32" />
            </SelectParameters>
        </asp:ObjectDataSource>
        <asp:GridView CssClass="table table-secondary" ID="GridView3" runat="server" AutoGenerateColumns="False" DataSourceID="ObjectDataSource4">
            <Columns>
                <asp:BoundField DataField="CustomerId" HeaderText="CustomerId" SortExpression="CustomerId" />
                <asp:BoundField DataField="CustFirstName" HeaderText="CustFirstName" SortExpression="CustFirstName" />
                <asp:BoundField DataField="CustLastName" HeaderText="CustLastName" SortExpression="CustLastName" />
                <asp:BoundField DataField="CustAddress" HeaderText="CustAddress" SortExpression="CustAddress" />
                <asp:BoundField DataField="CustCity" HeaderText="CustCity" SortExpression="CustCity" />
                <asp:BoundField DataField="CustProv" HeaderText="CustProv" SortExpression="CustProv" />
                <asp:BoundField DataField="CustPostal" HeaderText="CustPostal" SortExpression="CustPostal" />
                <asp:BoundField DataField="CustCountry" HeaderText="CustCountry" SortExpression="CustCountry" />
                <asp:BoundField DataField="CustHomePhone" HeaderText="CustHomePhone" SortExpression="CustHomePhone" />
                <asp:BoundField DataField="CustBusPhone" HeaderText="CustBusPhone" SortExpression="CustBusPhone" />
                <asp:BoundField DataField="CustEmail" HeaderText="CustEmail" SortExpression="CustEmail" />
                <asp:BoundField DataField="AgentId" HeaderText="AgentId" SortExpression="AgentId" />
            </Columns>
        </asp:GridView>
        <asp:ObjectDataSource ID="ObjectDataSource4" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="GetCustomerByBookingId" TypeName="TravEx_WebApp.App_Code.CustomerDB">
            <SelectParameters>
                <asp:ControlParameter ControlID="ddlBookingId" Name="BookingId" PropertyName="SelectedValue" Type="Int32" />
            </SelectParameters>
        </asp:ObjectDataSource>
        <asp:GridView CssClass="table table-secondary" ID="GridView4" runat="server" AutoGenerateColumns="False" DataSourceID="ObjectDataSource5">
            <Columns>
                <asp:BoundField DataField="PackageId" HeaderText="PackageId" SortExpression="PackageId" />
                <asp:BoundField DataField="PkgName" HeaderText="PkgName" SortExpression="PkgName" />
                <asp:BoundField DataField="PkgStartDate" HeaderText="PkgStartDate" SortExpression="PkgStartDate" />
                <asp:BoundField DataField="PkgEndDate" HeaderText="PkgEndDate" SortExpression="PkgEndDate" />
                <asp:BoundField DataField="PkgDesc" HeaderText="PkgDesc" SortExpression="PkgDesc" />
                <asp:BoundField DataField="PkgBasePrice" HeaderText="PkgBasePrice" SortExpression="PkgBasePrice" />
                <asp:BoundField DataField="PkgAgencyCommission" HeaderText="PkgAgencyCommission" SortExpression="PkgAgencyCommission" />
            </Columns>
        </asp:GridView>
        <asp:ObjectDataSource ID="ObjectDataSource5" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="GetPackageByBookingId" TypeName="TravEx_WebApp.App_Code.PackageDB">
            <SelectParameters>
                <asp:ControlParameter ControlID="ddlBookingId" Name="BookingId" PropertyName="SelectedValue" Type="Int32" />
            </SelectParameters>
        </asp:ObjectDataSource>
        <asp:GridView CssClass="table table-secondary" ID="GridView5" runat="server" AutoGenerateColumns="False" DataSourceID="ObjectDataSource6">
            <Columns>
                <asp:BoundField DataField="BasePrice" HeaderText="BasePrice" SortExpression="BasePrice" />
                <asp:BoundField DataField="AgencyCommission" HeaderText="AgencyCommission" SortExpression="AgencyCommission" />
                <asp:BoundField DataField="PkgBasePrice" HeaderText="PkgBasePrice" SortExpression="PkgBasePrice" />
                <asp:BoundField DataField="PkgAgencyCommision" HeaderText="PkgAgencyCommision" SortExpression="PkgAgencyCommision" />
                <asp:BoundField DataField="FeeAmt" HeaderText="FeeAmt" SortExpression="FeeAmt" />
                <asp:BoundField DataField="TotalPrice" HeaderText="TotalPrice" SortExpression="TotalPrice" />
            </Columns>
        </asp:GridView>
        <asp:ObjectDataSource ID="ObjectDataSource6" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="GetOrderSummary" TypeName="TravEx_WebApp.App_Code.OrderSummaryDB">
            <SelectParameters>
                <asp:ControlParameter ControlID="ddlBookingId" Name="BookingId" PropertyName="SelectedValue" Type="Int32" />
            </SelectParameters>
        </asp:ObjectDataSource>
        </div>
    </form>
</body>
</html>
