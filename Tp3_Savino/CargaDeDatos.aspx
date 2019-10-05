<%@ Page Title="Carga de Datos" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CargaDeDatos.aspx.cs" Inherits="Tp3_Savino.CargaDeDatos" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Kerusorteo - Carga De Datos</h1>
        <p class="lead">El voucher ingresado es correcto, necesitariamos tu DNI para empezar a cagar tus datos</p>
        <p>
            <asp:TextBox runat="server" class="form-control ds-input" ID="dniText" placeholder="Ingrese DNI..." aria-label="Ingrese DNI..." autocomplete="off" data-docs-version="4.3" spellcheck="false" role="combobox" dir="auto" Style="position: relative; max-width: 1000px; width: 200px; vertical-align: top;"></asp:TextBox>
        </p>
        <p>
            <asp:LinkButton ID="LinkButton2" class="btn btn-primary btn-lg" runat="server" Text=" Siguiente paso &raquo;" OnClick="btnContinuar_Click" />

        </p>
    </div>
</asp:Content>
