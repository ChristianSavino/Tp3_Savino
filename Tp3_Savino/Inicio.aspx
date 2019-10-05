<%@ Page Title="Congratulations" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Inicio.aspx.cs" Inherits="Tp3_Savino.Inicio" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Kerusorteo - Inicio</h1>
        <p class="lead">Si deseas participar del sorteo, ingresa el numero de voucher obtenido por realizar una compra en nuestra pagina</p>
        <p>
            <asp:TextBox runat="server" class="form-control ds-input" ID="voucherText" placeholder="Ingrese voucher..." aria-label="Ingrese Voucher..." autocomplete="off" data-docs-version="4.3" spellcheck="false" role="combobox" dir="auto" Style="position: relative; max-width: 1000px; width: 350px; vertical-align: top;"></asp:TextBox>
        </p>
        <p>
            <asp:LinkButton ID="LinkButton1" class="btn btn-primary btn-lg" runat="server" Text=" Siguiente paso &raquo;" OnClick="btnContinuar_Click" /></p>
    </div>

</asp:Content>
