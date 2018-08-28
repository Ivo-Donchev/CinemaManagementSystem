<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CitiesList.aspx.cs" Inherits="CinemaManagementSystem.CitiesList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:GridView runat="server" ID="citiesList" ItemType="CinemaManagementSystem.Models.City" DataKeyNames="Id" SelectMethod="citiesList_GetData" AutoGenerateColumns="false">
        <Columns>
            <asp:DynamicField DataField="Id" />
            <asp:DynamicField DataField="Name" />
        </Columns>
    </asp:GridView>
</asp:Content>
