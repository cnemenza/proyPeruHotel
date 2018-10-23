using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class Web_InterfazAdministrador_WebConsultarHabitaciones : System.Web.UI.Page
{
    ProxyHabitacion.ServicioHabitacionClient objServicioHabitacion = new ProxyHabitacion.ServicioHabitacionClient();
    ProxyHabitacion.dataHabitacion objHabi = new ProxyHabitacion.dataHabitacion();
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            if (!Page.IsPostBack)
            {

                //Cargamos el combo

                cboTipoHabi.DataSource = objServicioHabitacion.ListarTipoHabitacion();

                cboTipoHabi.DataTextField = "TipoNombre";
                cboTipoHabi.DataValueField = "IdTipoHabi";
                cboTipoHabi.DataBind();

                //Se ocultan los div
                divRespuesta.Attributes["class"] = "hidden";
                divCard.Attributes["class"] = "d-none";
                formPrincipal.Attributes["style"] = "height: 340px;";
            }
        }
        catch (Exception)
        {

            throw;
        }

    }

    protected void cboTipoHabi_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
                //Cargamos el grid
                String strCod = cboTipoHabi.SelectedValue.ToString();
                grvDatos.DataSource = objServicioHabitacion.ListarHabitacionDisponiblePorTipo(strCod);
                grvDatos.DataBind();
                txtCantidad.Text = "Se encuentran disponibles " + Convert.ToString(grvDatos.Rows.Count) + " habitaciones";

                //Cargamos los detalles
                objHabi = objServicioHabitacion.GetDetalleTipoHabitacion(strCod);
                txtDescripcion.Text = objHabi.TipoDescripcion;
                txtNumCamas.Text = objHabi.TipoNumCamas;
                txtPrecio.Text = "S/. " + Convert.ToString(objHabi.TipoPrecio);

                //Se muestran los div
                divRespuesta.Attributes["class"] = "alert alert-warning";
                divCard.Attributes["class"] = "card";
                formPrincipal.Attributes["style"] = "height: auto";


        }
        catch (Exception ex)
        {
            txtCantidad.Text = ex.Message;
            divCard.Attributes["class"] = "d-none mb-5";
        }
    }
}