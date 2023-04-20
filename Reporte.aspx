<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Reporte.aspx.cs" Inherits="Laboratorio8.Reporte1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:GridView ID="GridView1" runat="server" class ="table">
    </asp:GridView>
    <h2>Total Inscritos:</h2>
    <h2><asp:Label ID="LabelTotal" runat="server"></asp:Label></h2>
    <br />
    <br />
    <asp:Button ID="ButtonReporte" runat="server" Text="Ver Reporte" class="btn btn-primary btn-lg" OnClick="ButtonReporte_Click" />
    <asp:Button ID="Button1" runat="server" Text="Ordenar" class="btn btn-success btn-lg" OnClick="Button1_Click"/>
    <asp:Button ID="ButtonTotal" runat="server" class="btn btn-danger btn-lg" Text="Total" OnClick="ButtonTotal_Click" />
</asp:Content>
