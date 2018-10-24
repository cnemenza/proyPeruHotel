<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageAdministrador.master" AutoEventWireup="true" CodeFile="WebConsultarReservas.aspx.cs" Inherits="Web_InterfazAdministrador_WebConsultarReservas" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
      <h2 class="mt-4 mb-2">Reservas</h2>
   <p>
   <div class="form-group row" id="Div1" runat="server">
        <label for="IdTipo" class="col-sm-3 col-form-label ml-3">Seleccione Nombre del Cliente</label>
    <div class="col-sm-5">
         <asp:DropDownList ID="cboCliente" runat="server" CssClass="form-control" AppendDataBoundItems="true" >
             <asp:ListItem Value="0">&lt;Seleccione un cliente&gt;</asp:ListItem>
         </asp:DropDownList>
    </div>
    </div>
   </p>
    <p>
   <div class="form-group row" id="formPrincipal" runat="server">
        <label for="IdTipo" class="col-sm-3 col-form-label ml-3">Estado de las Facturas</label>
    <div class="col-sm-5">
         <asp:DropDownList ID="cboEstado" runat="server" CssClass="form-control" AppendDataBoundItems="true" >
             <asp:ListItem Value="0">&lt;Seleccione un estado&gt;</asp:ListItem>
             <asp:ListItem Value="1">Activo</asp:ListItem>
             <asp:ListItem Value="2">Concluido</asp:ListItem>
         </asp:DropDownList>
    </div>
    <div class="col-sm-2">
        <asp:Button ID="btnConsultar" CssClass="btn btn-warning" runat="server" Text="Consultar" OnClick="btnConsultar_Click" />
    </div>
    </div>
        <div class="alert alert-warning" role="alert" id="divRespuesta" runat="server">
               <asp:Label ID="txtResultado" runat="server"></asp:Label>
        </div>
     
   </p>

    <div class="row">
        <div class="col">
            <asp:GridView ID="grvDatos" CssClass="table table-hover" runat="server" AutoGenerateColumns="False">
                <Columns>
                    <asp:BoundField DataField="IdReserva" HeaderText="ID" />
                    <asp:BoundField DataField="ReserFechaReser" DataFormatString="{0:d}" HeaderText="Fecha de Reserva" />
                    <asp:BoundField DataField="ReserFechaIngreso" DataFormatString="{0:d}" HeaderText="Fecha de Ingreso" />
                    <asp:BoundField DataField="ReserFechaSalida" DataFormatString="{0:d}" HeaderText="Fecha Salida" />
                    <asp:BoundField DataField="CantHab" HeaderText="Cant. Hab. " />
                    <asp:BoundField DataField="CantDias" HeaderText="Cant. Dias" />
                    <asp:BoundField DataField="Total" DataFormatString="{0:n}" HeaderText="Total (S./ )" />
                </Columns>
                <HeaderStyle CssClass="thead-dark" />
            </asp:GridView>
        </div>

    </div>

   
</asp:Content>

