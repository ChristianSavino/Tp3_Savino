<%@ Page Title="Carga de Datos" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CargaDeDatos2.aspx.cs" Inherits="Tp3_Savino.CargaDeDatos2" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Kerusorteo - Carga De Datos</h1>
        <p class="lead">Complete los datos</p>
        <p class="lead">Voucher</p>
        <p>
            <asp:TextBox runat="server" class="form-control ds-input" ID="voucherText" placeholder="" aria-label="" Enabled="false" autocomplete="off" data-docs-version="4.3" spellcheck="false" role="combobox" dir="auto" Style="position: relative; max-width: 1000px; width: 350px; vertical-align: top;"></asp:TextBox>
        </p>
        <p class="lead">DNI</p>
        <p>
            <asp:TextBox runat="server" class="form-control ds-input" ID="dniText" placeholder="" aria-label="" Enabled="false" autocomplete="off" data-docs-version="4.3" spellcheck="false" role="combobox" dir="auto" Style="position: relative; max-width: 1000px; width: 300px; vertical-align: top;"></asp:TextBox>
        </p>
        <p class="lead">Nombre</p>
        <p>
            <asp:TextBox runat="server" class="form-control ds-input" ID="nombreText" placeholder="Ingrese Nombre..." MaxLength="50" aria-label="Ingrese Nombre..." autocomplete="off" data-docs-version="4.3" spellcheck="false" role="combobox" dir="auto" Style="position: relative; max-width: 1000px; width: 300px; vertical-align: top;"></asp:TextBox>
        </p>
        <p class="lead">Apellido</p>
        <p>
            <asp:TextBox runat="server" class="form-control ds-input" ID="apellidoText" placeholder="Ingrese Apellido..." MaxLength="50" autocomplete="off" data-docs-version="4.3" spellcheck="false" role="combobox" dir="auto" Style="position: relative; max-width: 1000px; width: 500px; vertical-align: top;"></asp:TextBox>
        </p>
        <p class="lead">E-Mail</p>
        <p>
            <asp:TextBox runat="server" class="form-control ds-input" ID="emailText" placeholder="Ingrese Email..." MaxLength="100" autocomplete="off" data-docs-version="4.3" spellcheck="false" role="combobox" dir="auto" Style="position: relative; max-width: 1000px; width: 500px; vertical-align: top;"></asp:TextBox>
        </p>
        <p class="lead">Direccion</p>
        <p>
            <asp:TextBox runat="server" class="form-control ds-input" ID="direccionText" placeholder="Ingrese Direccion..." MaxLength="50" autocomplete="off" data-docs-version="4.3" spellcheck="false" role="combobox" dir="auto" Style="position: relative; max-width: 1000px; width: 500px; vertical-align: top;"></asp:TextBox>
        </p>
        <p class="lead">Ciudad</p>
        <p>
            <asp:TextBox runat="server" class="form-control ds-input" ID="ciudadText" placeholder="Ingrese Ciudad..." MaxLength="50" autocomplete="off" data-docs-version="4.3" spellcheck="false" role="combobox" dir="auto" Style="position: relative; max-width: 1000px; width: 500px; vertical-align: top;"></asp:TextBox>
        </p>
        <p class="lead">Codigo Postal</p>
        <p>
            <asp:TextBox runat="server" class="form-control ds-input" ID="codigoPostalText" placeholder="CP..." MaxLength="8" autocomplete="off" data-docs-version="4.3" spellcheck="false" role="combobox" dir="auto" Style="position: relative; max-width: 1000px; width: 500px; vertical-align: top;"></asp:TextBox>
        </p>
        <p>
            <asp:LinkButton ID="LinkButton3" class="btn btn-primary btn-lg" runat="server" Text=" Siguiente paso &raquo;" OnClick="btnContinuar_Click" /></p>
    </div>
</asp:Content>
