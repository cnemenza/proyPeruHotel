using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Web_InterfazAdministrador_WebReservasTotales : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        txtFecFin.Enabled = false;
        txtFecIni.Enabled = false;
    }

    protected void cboEstado_SelectedIndexChanged(object sender, EventArgs e)
    {
        String variable = cboEstado.SelectedValue.ToString();
        if(variable == "1")
        {
            txtFecFin.Enabled = true;
            txtFecIni.Enabled = true;
        }
       
    }
}