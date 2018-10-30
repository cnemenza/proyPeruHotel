<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPagePrincipal.master" AutoEventWireup="true" CodeFile="WebRegistroCliente.aspx.cs" Inherits="Web_InterfazPrincipal_WebRegistroCliente"  EnableEventValidation="false" %>

<%@ Register Src="~/Controles_web/WebControl_Ubigeo.ascx" TagPrefix="uc1" TagName="WebControl_Ubigeo" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <form>
        <div class="form-group">
            <label for="exampleInputEmail1">Email address</label>
            <input type="email" class="form-control" id="exampleInputEmail1" aria-describedby="emailHelp" placeholder="Enter email">
            <small id="emailHelp" class="form-text text-muted">We'll never share your email with anyone else.</small>
          </div>
        <uc1:WebControl_Ubigeo runat="server" ID="WebControl_Ubigeo" />
    </form>
</asp:Content>

