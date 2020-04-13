<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddCars.aspx.cs" Inherits="MyWebForm.WebForm2" %>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <asp:DetailsView ID="DetailsView1" runat="server" AutoGenerateRows="False" DataKeyNames="CarId" DataSourceID="SqlDataSource1" EnableViewState="False" Height="106px" Width="392px">
        <Fields>
            <asp:BoundField DataField="CarId" HeaderText="CarId" ReadOnly="false" SortExpression="CarId" />
            <asp:BoundField DataField="Name" HeaderText="Name" ReadOnly="false"  SortExpression="Name" />
            <asp:BoundField DataField="Model" HeaderText="Model" ReadOnly="false" SortExpression="Model" />
            <asp:BoundField DataField="Color" HeaderText="Color" ReadOnly="false" SortExpression="Color" />
            <asp:CommandField ShowInsertButton="True" />
        </Fields>
        </asp:DetailsView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:DatabaseAuto %>" 
            
            InsertCommand="INSERT INTO [Car] ([CarId],[Name], [Model], [Color]) VALUES (@CarId, @Name, @Model, @Color)" 
            SelectCommand="SELECT [CarId], [Name], [Model], [Color] FROM [Car]" 
            UpdateCommand="UPDATE [Car] SET [Name] = @Name, [Model] = @Model, [Color] = @Color WHERE [CarId] = @CarId">
            
            <InsertParameters>
                <asp:Parameter Name="CarId" Type="Int32" />
                <asp:Parameter Name="Name" Type="String" />
                <asp:Parameter Name="Model" Type="String" />
                <asp:Parameter Name="Color" Type="String" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="CarId" Type="Int32" />
                <asp:Parameter Name="Model" Type="String" />
                <asp:Parameter Name="Color" Type="String" />
                <asp:Parameter Name="Name" Type="String" />
            </UpdateParameters>
        </asp:SqlDataSource>
</div>
    </asp:Content>