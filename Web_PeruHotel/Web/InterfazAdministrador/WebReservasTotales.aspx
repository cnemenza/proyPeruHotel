<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageAdministrador.master" AutoEventWireup="true" CodeFile="WebReservasTotales.aspx.cs" Inherits="Web_InterfazAdministrador_WebReservasTotales" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
          <h2 class="mt-4 mb-2">Reservas</h2>
   <p>

   <div class="form-group row" id="formPrincipal" runat="server">
        <label for="IdTipo" class="col-sm-2 col-form-label ml-3">Estado de las Facturas</label>
    <div class="col-sm-5">
         <asp:DropDownList ID="cboEstado" runat="server" CssClass="form-control" AppendDataBoundItems="true" AutoPostBack="True" OnSelectedIndexChanged="cboEstado_SelectedIndexChanged" >
             <asp:ListItem Value="0">&lt;Seleccione un estado&gt;</asp:ListItem>
             <asp:ListItem Value="1">A la fecha</asp:ListItem>
             <asp:ListItem Value="2">Concluidas</asp:ListItem>
         </asp:DropDownList>
    </div>
    <div class="col-sm-2">
        <asp:Button ID="btnConsultar" CssClass="btn btn-warning" runat="server" Text="Consultar" />
    </div>
    </div>
       <div class="row">
           <label for="IdTipo" class="col-sm-2 col-form-label ml-3">Primera Fecha</label>
    <div class="col-sm-3">
        <asp:TextBox ID="txtFecIni" runat="server" CssClass="form-control"></asp:TextBox>
    </div>
           <label for="IdTipo" class="col-sm-2 col-form-label ml-3">Segunda Fecha</label>
    <div class="col-sm-3">
          <asp:TextBox ID="txtFecFin" runat="server"  CssClass="form-control"></asp:TextBox>
    </div>
       </div>
       <p></p>
        <div class="alert alert-warning" role="alert" id="divRespuesta" runat="server">
               <asp:Label ID="txtResultado" runat="server"></asp:Label>
        </div>
     
   </p>
    <div class="row">
        <div class="col">
            <asp:GridView ID="grvDatos" CssClass="table-sm table-hover" runat="server" AutoGenerateColumns="False">
                <HeaderStyle CssClass="thead-dark" />
            </asp:GridView>
        </div>

    </div>
</asp:Content>

