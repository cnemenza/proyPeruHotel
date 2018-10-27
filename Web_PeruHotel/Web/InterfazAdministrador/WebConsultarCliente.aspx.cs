using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Web_InterfazAdministrador_WebConsultarCliente : System.Web.UI.Page
{
    ProxyCliente.ServicioClienteClient objServicioCliente =
                new ProxyCliente.ServicioClienteClient();
    ProxyCliente.DataCliente objClienteBE = new ProxyCliente.DataCliente();
    protected void Page_Load(object sender, EventArgs e)
    {
       
        if (!Page.IsPostBack)
        {
            cboCliente.DataSource = objServicioCliente.ListarNombresCliente();
            cboCliente.DataTextField = "IdCliente";
            cboCliente.DataValueField = "IdCliente";
            cboCliente.DataBind();
            divRespuesta.Attributes["class"] = "d-none";

        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        try
        {
            if (cboCliente.SelectedValue.ToString()!="0")
            {
                divCard.Attributes["style"] = "visibility : visible;";
                divRespuesta.Attributes["class"] = "d-none";
                String txtCodigo = cboCliente.SelectedValue.ToString();
                objClienteBE = objServicioCliente.GetCliente(txtCodigo);
                String ubigeo = objClienteBE.IdContinente + objClienteBE.IdPais + objClienteBE.IdCiudad;

                //lblMensaje.Text = String.Empty;
                lblNombre.Text = objClienteBE.ClieNom;
                lblApePaterno.Text = objClienteBE.ClieApePater;
                lblApeMater.Text = objClienteBE.ClieApeMater;
                lblCorreo.Text = objClienteBE.ClieCorreo;
                lblUbigeo.Text = ubigeo;
                lblContinente.Text = objClienteBE.NomContinente;
                lblPais.Text = objClienteBE.NomPais;
                lblCiudad.Text = objClienteBE.NomCiudad;

                if (objClienteBE.ClieSexo == "1")
                {
                    lblSexo.Text = "Masculino";
                }
                else
                {
                    lblSexo.Text = "Femenino";
                }
                lblDNI.Text = objClienteBE.ClieDocumento;

                Image1.ImageUrl = "imagenes/Clientes/" + objClienteBE.IdCliente + ".jpg";
            }
            else
            {
                divCard.Attributes["style"] = "visibility : hidden;";
                divRespuesta.Attributes["class"] = "alert alert-warning";
                txtMensaje.Text = "Debe seleccionar un cliente";
            }
            
        }
        catch (Exception ex)
        {
           
        }
    }
}