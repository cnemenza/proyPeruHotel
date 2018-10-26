using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Web_InterfazAdministrador_WebConsultarCliente : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        try
        {

            ProxyCliente.ServicioClienteClient objServicioCliente =
                new ProxyCliente.ServicioClienteClient();
            ProxyCliente.DataCliente objClienteBE = new ProxyCliente.DataCliente();

            divContenedor.Attributes["class"] = "container";
            objClienteBE = objServicioCliente.GetCliente(txtCodigo.Text);

            lblMensaje.Text = String.Empty;
            lblNombre.Text = objClienteBE.ClieNom;
            lblApePaterno.Text = objClienteBE.ClieApePater;
            lblApeMater.Text = objClienteBE.ClieApeMater;
            lblCorreo.Text = objClienteBE.ClieCorreo;
            if (objClienteBE.ClieSexo == "1")
            {
                lblSexo.Text = "Masculino";
            }
            else
            {
                lblSexo.Text = "Femenino";
            }
            lblDocumento.Text = objClienteBE.ClieDocumento;

            Image1.ImageUrl = "imagenes/Clientes/" + objClienteBE.IdCliente + ".jpg";
        }
        catch (Exception ex)
        {
            lblMensaje.Text = ex.Message;
        }
    }
}