using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Web_InterfazAdministrador_WebConsultarReservas : System.Web.UI.Page
{
    ProxyReserva.ServicioReservaClient objServicioReserva = new ProxyReserva.ServicioReservaClient();
    ProxyCliente.ServicioClienteClient objServicioCliente = new ProxyCliente.ServicioClienteClient();

    ProxyReserva.dataReserva objReser = new ProxyReserva.dataReserva();

    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            if (!Page.IsPostBack)
            {

                //Cargamos el combo y ocultamos el div de respueta

                cboCliente.DataSource = objServicioCliente.ListarNombresCliente();            
                cboCliente.DataTextField = "ClieNom";
                cboCliente.DataValueField = "IdCliente";
                cboCliente.DataBind();
                ocultarDiv();
                formPrincipal.Attributes["style"] = "height : 350px";

            }
        }
        catch (Exception)
        {

            throw;
        }
    }

    protected void btnConsultar_Click(object sender, EventArgs e)
    {
        
        try
        {
            //Se obtiene los valores de strCod y el strEstado
            String strCod = cboCliente.SelectedValue.ToString();
            String strEstado = cboEstado.SelectedValue.ToString();

            formPrincipal.Attributes["style"] = "height : auto";
            //Se valida que no esten sin seleccionar
            if (strCod == "0" | strEstado == "0")
            {
                txtResultado.Text = "Debe Seleccionar parametros adecuados";
                ocultarTable();
                mostrarDiv();
            }
            else
            {
                ocultarDiv();
                mostrarTable();
                txtResultado.Text = string.Empty;

                //Se valida el estado de la reserva si es 1 : Activo - 2 : Concluido
                if (strEstado.Equals("1"))
                {
                    ocultarDiv();
                    mostrarTable();
                    grvDatos.DataSource = objServicioReserva.GetReservasActivasClientes(strCod);
                    grvDatos.DataBind();

                    //Si no tiene reservas se envia un msj
                    if (grvDatos.Rows.Count == 0)
                    {
                        mostrarDiv();
                        ocultarTable();
                        txtResultado.Text = "No se encuentran Reservas";
                    }
                }
                else if (strEstado.Equals("2"))
                {
                    ocultarDiv();
                    grvDatos.DataSource = objServicioReserva.GetReservasConcluidasClientes(strCod);
                    grvDatos.DataBind();

                    //Si no tiene reservas se envia un msj
                    if (grvDatos.Rows.Count == 0)
                    {
                        mostrarDiv();
                        ocultarTable();
                        txtResultado.Text = "No se encuentran Reservas";
                    }
                }
            }
            
           
        }
        catch (Exception ex)
        {
            mostrarDiv();
            txtResultado.Text = ex.Message;
        }
        
    }

    void mostrarDiv()
    {
        divRespuesta.Attributes["class"] = "alert alert-warning";
        divRespuesta.Attributes["style"] = "margin-bottom : 150px";
     
    }

    void ocultarDiv()
    {
        divRespuesta.Attributes["class"] = "hidden";
        divRespuesta.Attributes["style"] = "height: auto";
      
    }
    void mostrarTable()
    {
        grvDatos.CssClass = "table table-hover";
    }
    void ocultarTable()
    {
        grvDatos.CssClass = "d-none";
    }

    protected void cboEstado_SelectedIndexChanged(object sender, EventArgs e)
    {
    
    }
}