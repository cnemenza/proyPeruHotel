using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Web_WebRegistrarCliente : System.Web.UI.Page
{
    ProxyCliente.ServicioClienteClient objServicioCliente = new ProxyCliente.ServicioClienteClient();
    ProxyCliente.DataCliente objClienteBE = new ProxyCliente.DataCliente();

    ProxyUbigeo.ServicioUbigeoClient objServicioUbigeo = new ProxyUbigeo.ServicioUbigeoClient();
    ProxyUbigeo.dataUbigeo objUbigeoBE = new ProxyUbigeo.dataUbigeo();
    protected void Page_Load(object sender, EventArgs e)
    {
        ocultarDiv();
    }

    protected void btnRegistrar_Click(object sender, EventArgs e)
    {
        try
        {
            if (txtClave.Text.Equals(txtValidarClave.Text))
            {
                String ubigeo = ControlWeb1.TotalUbigeo.ToString();

                objClienteBE.ClieCodigo = txtCodigo.Text;
                objClienteBE.ClieNom = txtNombre.Text;
                objClienteBE.ClieApePater = txtApePater.Text;
                objClienteBE.ClieApeMater = txtApeMater.Text;
                objClienteBE.ClieDni = txtDni.Text;
                objClienteBE.ClieCorreo = txtCorreo.Text;
                objClienteBE.ClieTelefono = txtTelefono.Text;
                objClienteBE.ClieContra = txtClave.Text;
                objClienteBE.ClieSexo = cboSexo.SelectedValue.ToString();
                objClienteBE.IdUbigeo = objServicioUbigeo.GetIdUbigeo(ubigeo.Substring(0, 2), ubigeo.Substring(2, 2), ubigeo.Substring(4, 2));

                if (objServicioCliente.RegistrarCliente(objClienteBE))
                {
                    hdfAccion.Value = "M";
                    mdDetalle.Show();
                }
                else
                {
                    mostrarDiv();
                    throw new Exception("El usuario ya se encuentra registrado");
                }
            }
            else
            {
                mostrarDiv();
                txtRespuesta.Text = "Por favor, verfique las contraseñas";
            }


        }
        catch (Exception ex)
        {
            mostrarDiv();
            txtRespuesta.Text = ex.Message;
        }

    }
    private void mostrarDiv()
    {
        DivRespuesta.Attributes["class"] = "alert alert-danger";
    }

    private void ocultarDiv()
    {
        DivRespuesta.Attributes["class"] = "d-none";
    }

}