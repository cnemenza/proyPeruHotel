using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class Web_WebConsultarCliente : System.Web.UI.Page
{
    ProxyCliente.ServicioClienteClient objServicioCliente =
               new ProxyCliente.ServicioClienteClient();
    ProxyCliente.DataCliente objClienteBE = new ProxyCliente.DataCliente();
    protected void Page_Load(object sender, EventArgs e)
    {
        divRespuesta.Attributes["class"] = "d-none";
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        try
        {
            if (txtDni.Text != String.Empty)
            {
                divCard.Attributes["style"] = "visibility : visible;";
                divRespuesta.Attributes["class"] = "d-none";
                String txtCodigo = txtDni.Text.ToString();
                objClienteBE = objServicioCliente.GetCliente(txtCodigo);

                //lblMensaje.Text = String.Empty;
                lblNombre.Text = objClienteBE.ClieNom;
                lblApePaterno.Text = objClienteBE.ClieApePater;
                lblApeMater.Text = objClienteBE.ClieApeMater;
                lblCorreo.Text = objClienteBE.ClieCorreo;
                lblUbigeo.Text = objClienteBE.IdUbigeo;
                lblContinente.Text = objClienteBE.NomContinente;
                lblPais.Text = objClienteBE.NomPais;
                lblCiudad.Text = objClienteBE.NomCiudad;
                lblSexo.Text = objClienteBE.ClieSexo;
                lblTelefono.Text = objClienteBE.ClieTelefono;
                lbldni.Text = objClienteBE.ClieDni;
                Image1.ImageUrl = "imagenes/Clientes/" + objClienteBE.IdCliente + ".jpg";
                
            }
            else
            {
                divCard.Attributes["style"] = "visibility : hidden;";
                divRespuesta.Attributes["class"] = "alert alert-warning";
                txtMensaje.Text = "Debe Ingresar el dni de un cliente";
            }

        }
        catch (Exception ex)
        {
            divCard.Attributes["style"] = "visibility : hidden;";
            divRespuesta.Attributes["class"] = "alert alert-warning";
            txtMensaje.Text = "No se encuentra el cliente";
        }
    }
}