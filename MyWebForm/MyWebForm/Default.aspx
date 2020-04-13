<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="MyWebForm._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div style="margin-bottom: 65px" >
        
    </div>

    <div class="row">
        <div class="col-md-4">
            <h2>The first operation - view cars</h2>
            <p>
                This page displays all the cars that are available.
            </p>
            <p>
                <a class="btn btn-default" runat="server" href="~/ViewCars">View Cars &raquo;</a>
            </p>
        </div>
        <div class="col-md-4">
            <h2>The second operation - add cars</h2>
            <p>
                Add new cars in database!
            </p>
            <p>
                <a class="btn btn-default" runat="server" href="~/AddCars">Add Car &raquo;</a>
            </p>
        </div>
        <div class="col-md-4">
            <h2>The third operation - delete cars</h2>
            <p>
                You can easily delete a car!
            </p>
            <p>
                <a class="btn btn-default" runat ="server" href ="~/DeleteCars">Delete cars &raquo;</a>
            </p>
        </div>
    </div>

</asp:Content>
