<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Reporte.aspx.cs" Inherits="Laboratorio8.Reporte1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:GridView ID="GridView1" runat="server" class ="table">
    </asp:GridView>
    <br />
    <br />
    <asp:Button ID="ButtonReporte" runat="server" Text="Ver Reporte" class="btn btn-primary btn-lg" OnClick="ButtonReporte_Click" />
    <asp:Button ID="Button1" runat="server" Text="Ordenar" class="btn btn-primary btn-lg" OnClick="Button1_Click"/>
</asp:Content>
