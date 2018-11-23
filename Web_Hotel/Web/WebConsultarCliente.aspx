<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="WebConsultarCliente.aspx.cs" Inherits="Web_WebConsultarCliente" EnableEventValidation="true" %>
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

    <div class ="container mb-3">
        <div class="row">
            <label for="IdTipo" class="col-sm-3 col-form-label ml-3">Ingrese Documento</label>
            <div class="col-sm-5">
                <asp:TextBox ID="txtDni" CssClass="form-control" runat="server"></asp:TextBox>
            </div>
            <div class="col-sm-2">
                 <asp:Button ID="Button2" runat="server" OnClick="Button1_Click" Text="Consultar" CssClass=" btn btn-warning" />
            </div>
        </div>
        
    </div>
    
    <div class="container mt-5">
            <div class="col">
                 <div class="alert alert-warning" role="alert" id="divRespuesta" runat="server">
                    <asp:Label ID="txtMensaje" runat="server"></asp:Label>
            </div>
            </div>
        </div>

       <div class="col-md-12 ">
            <div class="card" id="divCard" runat="server" style="visibility: hidden;">
              <div class="card-body">
                  <div class="row">
                      <div class="col-md-6">
                           <h5 class="card-title">Detalles del Cliente</h5>
                            <h6 class="card-subtitle mb-2 text-muted ml-2">
                                <asp:Label ID="Label1" runat="server" Text="Nombre"></asp:Label></h6>
                            <p class="card-text ml-2">
                                <asp:Label ID="lblNombre" runat="server" Text="Seleccione un tipo de habitacion"></asp:Label></p>
                          <h6 class="card-subtitle mb-2 text-muted ml-2">
                                <asp:Label ID="Label2" runat="server" Text="Apellido Paterno"></asp:Label></h6>
                            <p class="card-text ml-2">
                                <asp:Label ID="lblApePaterno" runat="server" Text="Seleccione un tipo de habitacion"></asp:Label></p>
                          <h6 class="card-subtitle mb-2 text-muted ml-2">
                                <asp:Label ID="Label5" runat="server" Text="Apellido Materno"></asp:Label></h6>
                            <p class="card-text ml-2">
                                <asp:Label ID="lblApeMater" runat="server" Text="Seleccione un tipo de habitacion"></asp:Label></p>
                          <h6 class="card-subtitle mb-2 text-muted ml-2">
                                <asp:Label ID="Label7" runat="server" Text="Correo"></asp:Label></h6>
                            <p class="card-text ml-2">
                                <asp:Label ID="lblCorreo" runat="server" Text="Seleccione un tipo de habitacion"></asp:Label></p>
                          <h6 class="card-subtitle mb-2 text-muted ml-2">
                                <asp:Label ID="Label9" runat="server" Text="Sexo"></asp:Label></h6>
                            <p class="card-text ml-2">
                                <asp:Label ID="lblSexo" runat="server" Text="Seleccione un tipo de habitacion"></asp:Label></p>
                          <h6 class="card-subtitle mb-2 text-muted ml-2">
                                <asp:Label ID="Label11" runat="server" Text="Telefono"></asp:Label></h6>
                            <p class="card-text ml-2">
                                <asp:Label ID="lblTelefono" runat="server" Text="Seleccione un tipo de "></asp:Label></p>
                          <h6 class="card-subtitle mb-2 text-muted ml-2">
                                <asp:Label ID="Label4" runat="server" Text="Documento"></asp:Label></h6>
                            <p class="card-text ml-2">
                                <asp:Label ID="lbldni" runat="server" Text="Seleccione un tipo de "></asp:Label></p>
                         
                                
                   

                            
                              
                      </div>
                      <div class="col-md-6 ">
                           <h6 class="card-subtitle mb-2 text-muted ml-2">
                          <asp:Label ID="Label13" runat="server" Text="Ubigeo"></asp:Label></h6>
                            <p class="card-text ml-2">
                                <asp:Label ID="lblUbigeo" runat="server" Text="Seleccione un tipo de habitacion"></asp:Label></p>
                                 <h6 class="card-subtitle mb-2 text-muted ml-2">
                                <asp:Label ID="Label15" runat="server" Text="Continente"></asp:Label></h6>
                            <p class="card-text ml-2">
                                <asp:Label ID="lblContinente" runat="server" Text="Seleccione un tipo de habitacion"></asp:Label></p>
                          <h6 class="card-subtitle mb-2 text-muted ml-2">
                                <asp:Label ID="Label17" runat="server" Text="Pais"></asp:Label></h6>
                            <p class="card-text ml-2">
                                <asp:Label ID="lblPais" runat="server" Text="Seleccione un tipo de habitacion"></asp:Label></p>
                          <h6 class="card-subtitle mb-2 text-muted ml-2">
                                <asp:Label ID="Label19" runat="server" Text="Ciudad"></asp:Label></h6>
                            <p class="card-text ml-2">
                                <asp:Label ID="lblCiudad" runat="server" Text="Seleccione un tipo de habitacion"></asp:Label></p>
                              <h6 class="card-subtitle mb-2 text-muted ml-2">
                                <asp:Label ID="Label3" runat="server" Text="Foto"></asp:Label></h6>
                              <p class="card-text ml-2">
                                  <div class="alert alert-success w-50" role="alert">
                                      <asp:Image ID="Image1" runat="server" CssClass="ml-5"></asp:Image>
                                  </div>
                              </p>
                      </div>
                  </div>
               
              </div>
            </div>
        </div>      
</asp:Content>

