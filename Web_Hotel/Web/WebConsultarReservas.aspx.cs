using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Web_WebConsultarReservas : System.Web.UI.Page
{
    ProxyReserva.ServicioReservaClient objServicioReserva = new ProxyReserva.ServicioReservaClient();
    ProxyCliente.ServicioClienteClient objServicioCliente = new ProxyCliente.ServicioClienteClient();

    ProxyReserva.dataReserva objReser = new ProxyReserva.dataReserva();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            ocultarDiv();
            formPrincipal.Attributes["style"] = "height : 350px";
        }
        
    }

    protected void btnConsultar_Click(object sender, EventArgs e)
    {
        Panel1.CssClass = "Modal d-none";
        

        try
        {
            //Se obtiene los valores de strCod y el strEstado
            String strCod = txtDni.Text;
            DateTime fecIni = Convert.ToDateTime(txtFecIni.Text);
            DateTime fecFin = Convert.ToDateTime(txtFecFin.Text);

            formPrincipal.Attributes["style"] = "height : auto";
            //Se valida que no esten sin seleccionar
            if (strCod.Equals(String.Empty) | fecFin.Equals( String.Empty) | fecIni.Equals(String.Empty))
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

                grvDatos.DataSource = objServicioReserva.ListarReservas(strCod, fecIni, fecFin);
                grvDatos.DataBind();

                if (grvDatos.Rows.Count == 0)
                    {
                        mostrarDiv();
                        ocultarTable();
                        txtResultado.Text = "No se encuentran Reservas";
                    }
                
            }


        }
        catch (Exception ex)
        {
            formPrincipal.Attributes["style"] = "height : 100px";
            mostrarDiv();
            ocultarTable();
            txtResultado.Text = ex.Message;
        }
    }

    protected void grvDatos_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        try
        {
            int fila = Convert.ToInt16(e.CommandArgument);

            if (e.CommandName == "Detalles")
            {
                hdfAccion.Value = "M";
                String vcod = grvDatos.Rows[fila].Cells[0].Text;

                grvHabitaciones.DataSource = objServicioReserva.GetDetalleReservaHabitaciones(vcod);
                grvHabitaciones.DataBind();

                grvServicios.DataSource = objServicioReserva.GetDetalleReservaServicio(vcod);
                grvServicios.DataBind();

                if (grvServicios.Rows.Count == 0)
                {
                    txtResultadoServi.Text = "No se encuentran servicios consumidos";
                }
                else
                {
                    txtResultadoServi.Text = "";
                }

                Panel1.CssClass = "Modal";
                mdDetalle.Show();
            }

        }
        catch (Exception)
        {

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
}