
<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageAdministrador.master" AutoEventWireup="true" CodeFile="WebConsultarCliente.aspx.cs" Inherits="Web_InterfazAdministrador_WebConsultarCliente" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">


    <style type="text/css">
        .auto-style1 {
            width: 892px;
        }
        .auto-style2 {
            width: 180px;
        }
        .auto-style3 {
            width: 197px;
        }
        .auto-style4 {
            width: 101px;
        }
        .auto-style5 {
            width: 180px;
            height: 22px;
        }
        .auto-style6 {
            width: 197px;
            height: 22px;
        }
        .auto-style7 {
            height: 22px;
            width: 101px;
        }
        .auto-style8 {
            width: 180px;
            height: 26px;
        }
        .auto-style9 {
            width: 197px;
            height: 26px;
        }
        .auto-style10 {
            width: 101px;
            height: 26px;
        }
    </style>


</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class"container">
        <h1 class="mt-2 mb-2">
            Consulta de Clientes
        </h1>

    </div>
    <div class ="container">
        <table class="auto-style1">
            <tr>
        <td class="auto-style2"><strong>Codigo Cliente:</strong></td>
        <td class="auto-style3">
            <asp:TextBox ID="txtCodigo" runat="server"></asp:TextBox>
        </td>
        <td class="auto-style4">
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Consultar" CssClass="btn-warning" />
        </td>
    </tr>
        </table>
    </div>

    <div class="container d-none m-2" id="divContenedor" runat="server">
    <table class="auto-style1">
        <br />
    
    <tr>
        <td class="auto-style8"><strong>Nombres:</strong></td>
        <td class="auto-style9">
            <asp:Label ID="lblNombre" runat="server"></asp:Label>
        </td>
        <td class="auto-style10"></td>
    </tr>
    <tr>
        <td class="auto-style2"><strong>Apellido Paterno:</strong></td>
        <td class="auto-style3">
            <asp:Label ID="lblApePaterno" runat="server"></asp:Label>
        </td>
        <td class="auto-style4">&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style8"><strong>Apellido Materno:</strong></td>
        <td class="auto-style9">
            <asp:Label ID="lblApeMater" runat="server"></asp:Label>
        </td>
        <td class="auto-style10"></td>
    </tr>
    <tr>
        <td class="auto-style2"><strong>Correo:</strong></td>
        <td class="auto-style3">
            <asp:Label ID="lblCorreo" runat="server"></asp:Label>
        </td>
        <td class="auto-style4">&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style5"><strong>Sexo:</strong></td>
        <td class="auto-style6">
            <asp:Label ID="lblSexo" runat="server"></asp:Label>
        </td>
        <td class="auto-style7"></td>
    </tr>    
     <tr>
        <td class="auto-style5"><strong>DNI:</strong></td>
        <td class="auto-style6">
            <asp:Label ID="lblDocumento" runat="server"></asp:Label>
        </td>
        <td class="auto-style7"></td>
    </tr>
        <tr>
        <td class="auto-style5"><strong>Foto:</strong></td>
        <td class="auto-style6">
            <asp:Image ID="Image1" runat="server"></asp:Image>
        </td>
        <td class="auto-style7"></td>
    </tr>
        <tr>
        <td class="auto-style2">
            <asp:Label ID="lblMensaje" runat="server" style="color: #FF0000"></asp:Label>
        </td>
       
    </tr>    
</table>
        </div>
</asp:Content>