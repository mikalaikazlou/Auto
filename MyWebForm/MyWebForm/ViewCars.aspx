<%@ Page Title="List of Cars" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ViewCars.aspx.cs" Inherits="MyWebForm.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <h3>&nbsp;This page displays all the cars that are available.</h3>
    <p>&nbsp;</p>

    <div >
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1" Width="425px" Height="156px" BorderStyle="Ridge">
            <Columns>
                <asp:BoundField DataField="CarId" HeaderText="CarId" SortExpression="CarId" />
                <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
                <asp:BoundField DataField="Model" HeaderText="Model" SortExpression="Model" />
                <asp:BoundField DataField="Color" HeaderText="Color" SortExpression="Color" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:DatabaseAuto %>" SelectCommand="SELECT * FROM [Car]"></asp:SqlDataSource>
    </div>
</asp:Content>
