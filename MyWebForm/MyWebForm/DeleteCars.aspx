<%@ Page Title="In this page, you can delete one or some cars!" Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="DeleteCars.aspx.cs" Inherits="MyWebForm.WebForm1" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %></h2>
    <div>

        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:DatabaseAuto %>" 
            SelectCommand="SELECT [CarId], [Name], [Model], [Color] FROM [Car]" 
            DeleteCommand="DELETE FROM Car WHERE CarId= @CarId">
            <DeleteParameters>
                <asp:Parameter Name="CarId" />
            </DeleteParameters>
        </asp:SqlDataSource>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="CarId" DataSourceID="SqlDataSource1" Width="424px">
            <Columns>
                <asp:CommandField ShowDeleteButton="True" />
                <asp:BoundField DataField="CarId" HeaderText="CarId" ReadOnly="True" SortExpression="CarId" />
                <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
                <asp:BoundField DataField="Model" HeaderText="Model" SortExpression="Model" />
                <asp:BoundField DataField="Color" HeaderText="Color" SortExpression="Color" />
            </Columns>
        </asp:GridView>

    </div>
</asp:Content>