<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="WebRegistrarCliente.aspx.cs" Inherits="Web_WebRegistrarCliente" EnableEventValidation="false"%>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<%@ Register Src="~/Controles_web/WebControl_Ubigeo.ascx" TagPrefix="uc1" TagName="WebControl_Ubigeo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<h2 class="mt-4 mb-4">Registro de Clientes</h2>
        

         <div class="alert alert-danger" role="alert" runat="server" id="DivRespuesta">
         <asp:Label ID="txtRespuesta" runat="server" Text=""></asp:Label>
        </div>   
    <form>
        <div class="row">
            <div class="col-md-6">
                <div class="form-group">
                <label for="exampleInputEmail1">Nombre de ingreso</label>
                    <table class="w-25">
                        <tr>
                            <td>
                     <asp:TextBox ID="txtCodigo" runat="server" CssClass="form-control" Width="400px"></asp:TextBox>               
                            </td>
                            <td>               
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtCodigo" ErrorMessage="*" ForeColor="Red" ValidationGroup="G1" Font-Bold="True" Font-Size="Large"></asp:RequiredFieldValidator>
                            </td>
                        </tr>
                    </table>
                </div>
                <div class="form-group">
                <label for="exampleInputEmail1">Nombres</label>
                      <table class="w-25">
                        <tr>
                            <td>
                     <asp:TextBox ID="txtNombre" runat="server" CssClass="form-control" Width="400px"></asp:TextBox>              
                            </td>
                            <td>               
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtNombre" ErrorMessage="*" ForeColor="Red" ValidationGroup="G1" Font-Bold="True" Font-Size="Large"></asp:RequiredFieldValidator>
                            </td>
                        </tr>
                    </table>
                </div>
                <div class="form-group">
                <label for="exampleInputEmail1">Apellido Paterno</label>
                     <table class="w-25">
                        <tr>
                            <td>
                     <asp:TextBox ID="txtApePater" runat="server" CssClass="form-control" Width="400px"></asp:TextBox>          
                            </td>
                            <td>               
                     <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtApePater" ErrorMessage="*" ForeColor="Red" ValidationGroup="G1" Font-Bold="True" Font-Size="Large"></asp:RequiredFieldValidator>
                            </td>
                        </tr>
                    </table>
                </div>
                <div class="form-group">
                <label for="exampleInputEmail1">Apellido Materno</label>
                     <table class="w-25">
                        <tr>
                            <td>
                     <asp:TextBox ID="txtApeMater" runat="server" CssClass="form-control" Width="400px"></asp:TextBox>        
                            </td>
                            <td>               
                     <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtApeMater" ErrorMessage="*" ForeColor="Red" ValidationGroup="G1" Font-Bold="True" Font-Size="Large"></asp:RequiredFieldValidator>
                            </td>
                        </tr>
                    </table>
                </div>
                 <div class="form-group">
                <label for="exampleInputEmail1">DNI</label>
                     <table class="w-25">
                        <tr>
                            <td>
                     <asp:TextBox ID="txtDni" runat="server" CssClass="form-control" Width="400px"></asp:TextBox>        
                            </td>
                            <td>               
                     <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="txtDni" ErrorMessage="*" ForeColor="Red" ValidationGroup="G1" Font-Bold="True" Font-Size="Large"></asp:RequiredFieldValidator>
                            </td>
                        </tr>
                    </table>
                </div>
                <div class="form-group">
                <label for="exampleInputEmail1">Correo Electronico</label>
                    <table class="w-25">
                        <tr>
                            <td>
                     <asp:TextBox ID="txtCorreo" runat="server" CssClass="form-control" Width="400px" TextMode="Email"></asp:TextBox>    
                            </td>
                            <td>               
                      <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtCorreo" ErrorMessage="*" ForeColor="Red" ValidationGroup="G1" Font-Bold="True" Font-Size="Large"></asp:RequiredFieldValidator>
                            </td>
                        </tr>
                    </table>
                   
                </div>
                <div class="form-group">
                <label for="exampleInputEmail1">Telefono</label>            
                    <table class="w-25">
                        <tr>
                            <td>
                     <asp:TextBox ID="txtTelefono" runat="server" CssClass="form-control" Width="400px" TextMode="Number"></asp:TextBox>
                            </td>
                            <td>               
                       <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="txtTelefono" ErrorMessage="*" ForeColor="Red" ValidationGroup="G1" Font-Bold="True" Font-Size="Large"></asp:RequiredFieldValidator>
                            </td>
                        </tr>
                    </table>                 
                </div>
            </div>
            <div class="col-md-6">   
                <uc1:WebControl_Ubigeo runat="server" ID="ControlWeb1" />
                <div class="form-group">
                    <div class="form-group">
                <label for="exampleInputEmail1">Sexo</label>
                <asp:DropDownList ID="cboSexo" runat="server" CssClass="form-control" Width="400px">
                    <asp:ListItem Value="1">Masculino</asp:ListItem>
                    <asp:ListItem Value="2">Femenino</asp:ListItem>
                </asp:DropDownList>
                </div>
                <label for="exampleInputEmail1">Contraseña</label>
                    <table class="w-25">
                        <tr>
                            <td>
                     <asp:TextBox ID="txtClave" runat="server" CssClass="form-control" Width="400px" TextMode="Password"></asp:TextBox>
                            </td>
                            <td>               
                       <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="txtClave" ErrorMessage="*" ForeColor="Red" ValidationGroup="G1" Font-Bold="True" Font-Size="Large"></asp:RequiredFieldValidator>
                            </td>
                        </tr>
                    </table>      
                </div>
                <div class="form-group">
                <label for="exampleInputEmail1">Valida contraseña</label>
                <asp:TextBox ID="txtValidarClave" runat="server" CssClass="form-control" Width="400px" TextMode="Password"></asp:TextBox>
                </div>
                
            </div>
        </div>    
         <div class="row mb-5">
        <div class="col">
            
        <asp:Button ID="btnRegistrar" CssClass="btn btn-warning" runat="server" CausesValidation="true" ValidationGroup="G1" Text="Registrar" Width="130px" Height="40px" OnClick="btnRegistrar_Click"/>
            </div>
        </div>  
    
    </form>
<asp:LinkButton ID="btnPopup" runat="server" CssClass="d-none">asasd</asp:LinkButton>
    <cc1:ModalPopupExtender ID="mdDetalle" runat="server" TargetControlID="btnPopup" PopupControlID="Panel1"></cc1:ModalPopupExtender>
    <asp:Panel ID="Panel1" runat="server" CssClass="Modal">
        <!-- Modal -->

            <div class ="CajaModal">
                <div class="row">
                    <div class="col m-auto">
                            <asp:HiddenField ID="hdfAccion" runat="server" />
                            <h1 class="ml-4 mt-4">PeruHotel</h1>   
                        <hr />                            
                    </div>
                </div>
                <div class="col">
                    <div class="alert alert-warning pt-5 pb-5" role="alert">
                      <h3>Cliente registrado con exito! <span class="badge badge-secondary"></span></h3>
                    </div>
                </div>
 
                  <hr />
                   
                <div class="row mb-5">
                    
                    <div class="col-10">
                        
                    </div>
               
                    <div class="col-2">
                        <a class="btn btn-dark" href="WebConsultarCliente.aspx">Cerrar</a>     
                    </div>

                </div>
            </div>
                   
    </asp:Panel>

    <style type="text/css">
    .Modal{
        background-color : #171616ab;
        color : black;
        height : 100%;
        width : 100%;
    }
    .CajaModal{
           position: fixed;
            right: 0;
            left: 0;
            margin: 150px;
            width:800px;
            margin-left : 400px;
            border-radius: 18px;
            background-color : white;
    }
    </style>

</asp:Content>



