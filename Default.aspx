<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Laboratorio8._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Inscripción Ciudadanos</h1>
        <p class="lead">
            <asp:DropDownList ID="DropDownListCiudadano" runat="server">
            </asp:DropDownList>
        </p>
        <p class="lead">
            <asp:TextBox ID="TextBoxPartido" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="ButtonInscribir" runat="server" Text="Inscribir Ciudadano" class="btn btn-primary btn-md" OnClick="ButtonInscribir_Click" />
        </p>
    </div>

    </asp:Content>
