<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPagePrincipal.master" AutoEventWireup="true" CodeFile="WebLoginCliente.aspx.cs" Inherits="Web_InterfazPrincipal_WebLoginCliente" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="container mt-3">
        <div class="row justify-content-center">
            <h3>Inicio de Sesion</h3>
        </div>
    </div>
    <div class="mt-4" style="height: 250px;" >
        <div class="row justify-content-center ">
           <div class="form-group col-5">
             <label for="usuario">Codigo de Usuario</label>
                <asp:TextBox ID="txtUsuario" runat="server" class="form-control"></asp:TextBox>
            </div>
        </div>
        <div class="row justify-content-center">
            <div class="form-group col-5">
             <label for="usuario">Contraseña</label>
                <asp:TextBox ID="txtContrasenia" runat="server" class="form-control" type="password"></asp:TextBox>
            </div>
        </div>
        <div class="row justify-content-center">
            <asp:Button ID="Button1" runat="server" Text="Ingresar" class="btn btn-primary"/>
        </div>
        
    </div>

      <div class="row justify-content-md-center mb-3">
        <div class="col col-lg-2">
        
        </div>
        <div class="col-md-auto">
           <div class="row">
            <small class="mr-2">¿No estas registrado? </small> <a href="WebRegistroCliente.aspx">Registrate</a>
        </div>
        <div class="row">
            <small class="mr-2">¿Olvidaste tu contraseña? </small> <a href="#">Recuperar</a>
        </div>
            <div class="row">
                <asp:HyperLink ID="HyperLink1" runat="server" CssClass="mr-2 mt-3" NavigateUrl="~/Web/InterfazAdministrador/WebConsultarCliente.aspx">Ingresar como Administrador</asp:HyperLink>
        </div>
        </div>
        <div class="col col-lg-2">
      
        </div>
       </div>
 
</asp:Content>

