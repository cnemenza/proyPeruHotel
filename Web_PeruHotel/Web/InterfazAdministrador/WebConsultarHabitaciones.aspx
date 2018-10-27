<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageAdministrador.master" AutoEventWireup="true" CodeFile="WebConsultarHabitaciones.aspx.cs" Inherits="Web_InterfazAdministrador_WebConsultarHabitaciones" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h2 class="mt-4 mb-2">Habitaciones Disponibles</h2>
   <p>
   <div class="form-group row" id="formPrincipal" runat="server">
        <label for="IdTipo" class="col-sm-3 col-form-label ml-3">Seleccione Tipo De Habitacion</label>
    <div class="col-sm-5">
         <asp:DropDownList ID="cboTipoHabi" runat="server" AutoPostBack="True" CssClass="form-control" OnSelectedIndexChanged="cboTipoHabi_SelectedIndexChanged" AppendDataBoundItems="true" >
             <asp:ListItem Value="0">&lt;Seleccione un tipo de habitacion&gt;</asp:ListItem>
         </asp:DropDownList>
    </div>
    </div>
   </p>

    <div class="row mb-4">
        <div class="col-md-7">
            <div class="alert alert-warning" role="alert" id="divRespuesta" runat="server">
              <asp:Label ID="txtCantidad" runat="server"></asp:Label>
            </div>
            <asp:GridView ID="grvDatos" CssClass="table table-hover" runat="server" AutoGenerateColumns="False">
                <Columns>
                    <asp:BoundField DataField="IdHabitacon" HeaderText="ID " />
                    <asp:BoundField DataField="HabiNum" HeaderText="Numero Hab." />
                    <asp:BoundField DataField="HabiPiso" HeaderText="Num. Piso" />
                </Columns>
                <HeaderStyle CssClass="thead-dark" />
            </asp:GridView>
        </div>
        <div class="col-md-5  mb-5">
            <div class="card" id="divCard" runat="server">
              <div class="card-body">
                <h5 class="card-title">Detalles</h5>
                <h6 class="card-subtitle mb-2 text-muted ml-2">
                    <asp:Label ID="Label1" runat="server" Text="Descripcion"></asp:Label></h6>
                <p class="card-text ml-2">
                    <asp:Label ID="txtDescripcion" runat="server" Text="Seleccione un tipo de habitacion"></asp:Label></p>
                <h6 class="card-subtitle mb-2 text-muted ml-2">
                    <asp:Label ID="Label2" runat="server" Text="Numero de Camas"></asp:Label></h6>
                <p class="card-text ml-2">
                    <asp:Label ID="txtNumCamas" runat="server" Text="Seleccione un tipo de habitacion"></asp:Label></p>
                <h6 class="card-subtitle mb-2 text-muted ml-2">
                    <asp:Label ID="Label3" runat="server" Text="Precio"></asp:Label></h6>
                  <p class="card-text ml-2">
                      <div class="alert alert-success" role="alert">
                          <asp:Label ID="txtPrecio" runat="server" Text="Seleccione un tipo de habitacion" CssClass="font-weight-bold"></asp:Label>
                      </div>
                  </p>
              </div>
            </div>
        </div>
    </div>
</asp:Content>

