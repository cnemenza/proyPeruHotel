using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Controles_web_WebControl_Ubigeo : System.Web.UI.UserControl
{
    ProxyUbigeo.ServicioUbigeoClient objServicioUbigeo = new ProxyUbigeo.ServicioUbigeoClient();
    ProxyUbigeo.dataUbigeo objUbi = new ProxyUbigeo.dataUbigeo();
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            if (!Page.IsPostBack)
            {
                Enlazar("94", "02", "01");
                MostrarUbigeo();
            }
        }
        catch (Exception)
        {

            throw;
        }
        
    }

    protected void cboContinente_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            EnlazarPais(cboContinente.SelectedValue.ToString(), "02");
            EnlazarCiudad(cboContinente.SelectedValue.ToString(), cboPais.SelectedValue.ToString(),"01");
            MostrarUbigeo();
            
        }
        catch (Exception ex)
        {

            txtUbigeo.Text = ex.Message;
        }
    }

    protected void cboPais_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            EnlazarCiudad(cboContinente.SelectedValue.ToString(), cboPais.SelectedValue.ToString(), "01");
            MostrarUbigeo();
        }
        catch (Exception)
        {

            throw;
        }
    }

    protected void cboCiudad_SelectedIndexChanged(object sender, EventArgs e)
    {
        MostrarUbigeo();
    }
    public void MostrarUbigeo()
    {
        txtUbigeo.Text = cboContinente.SelectedValue + cboPais.SelectedValue + cboCiudad.SelectedValue;
    }
    public void Enlazar(String strIdContinente, String strIdPais, String strIdCiudad)
    {
        EnlazarContinente(strIdContinente);
        EnlazarPais(strIdContinente, strIdPais);
        EnlazarCiudad(strIdContinente, strIdPais, strIdCiudad);
    }

    public void EnlazarContinente(String strIdContinente)
    {
        cboContinente.DataSource = objServicioUbigeo.GetAllContinentes();
        cboContinente.DataValueField = "IdContinente";
        cboContinente.DataTextField = "UbiContinente";
        cboContinente.DataBind();
        cboContinente.SelectedValue = strIdContinente;

    }

    public void EnlazarPais(String StrIdContinente, String StrIdPais)
    {
        cboPais.DataSource = objServicioUbigeo.GetAllPaises(StrIdContinente);
        cboPais.DataValueField = "IdPais";
        cboPais.DataTextField = "UbiPais";
        cboPais.DataBind();
        cboPais.SelectedValue = StrIdPais;

    }

    public void EnlazarCiudad(String StrIdContinente, String StrIdPais, String StrIdCiudad)
    {
        cboCiudad.DataSource = objServicioUbigeo.GetAllCiudades(StrIdContinente, StrIdPais);
        cboCiudad.DataValueField = "IdCiudad";
        cboCiudad.DataTextField = "UbiCiudad";
        cboCiudad.DataBind();
        cboCiudad.SelectedValue = StrIdCiudad;

    }
}