<%@ Control Language="C#" AutoEventWireup="true" CodeFile="WebControl_Ubigeo.ascx.cs" Inherits="Controles_web_WebControl_Ubigeo" %>
    <div>
        <asp:Label ID="txtUbigeo" runat="server" Text="Label"></asp:Label>
    </div>
    <div class="form-group">
        <label for="exampleInputEmail1">Seleccione Continente</label>
        <asp:DropDownList ID="cboContinente" runat="server" CssClass="form-control" AutoPostBack="True" OnSelectedIndexChanged="cboContinente_SelectedIndexChanged">
            <asp:ListItem Value="0">&lt;Seleccione un continente&gt;</asp:ListItem>
        </asp:DropDownList>
    </div>
    <div class="form-group">
        <label for="exampleInputEmail1">Seleccione Pais</label>
        <asp:DropDownList ID="cboPais" runat="server" CssClass="form-control" AutoPostBack="True" OnSelectedIndexChanged="cboPais_SelectedIndexChanged">
            <asp:ListItem Value="0">&lt;Seleccione un pais&gt;</asp:ListItem>
        </asp:DropDownList>
    </div>
    
    <div class="form-group">
        <label for="exampleInputEmail1">Seleccione Ciudad</label>
        <asp:DropDownList ID="cboCiudad" runat="server" CssClass="form-control" AutoPostBack="True" OnSelectedIndexChanged="cboCiudad_SelectedIndexChanged">
            <asp:ListItem Value="0">&lt;Seleccione una ciudad&gt;</asp:ListItem>
        </asp:DropDownList>
    </div>

