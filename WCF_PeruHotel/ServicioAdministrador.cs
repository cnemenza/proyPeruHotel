using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data.Entity.Core;

namespace WCF_PeruHotel
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServicioAdministrador" en el código y en el archivo de configuración a la vez.
    public class ServicioAdministrador : IServicioAdministrador
    {
        Boolean blnexito;
        public bool InsertAdministrador(DataAdministrador objAdmiBE)
        {
            PeruHotelEntities MiHotel = new PeruHotelEntities();
            try
            {
                ADMINISTRADOR objAdmi = new ADMINISTRADOR();

                objAdmi.id_admi = String.Empty;
                objAdmi.admi_nom = objAdmiBE.AdmiNom;
                objAdmi.admi_apePater = objAdmiBE.AdmiApePater;
                objAdmi.admi_apeMater = objAdmiBE.AdmiApeMater;
                objAdmi.admi_codigo = objAdmiBE.AdmiCodigo;
                objAdmi.admi_contra = objAdmiBE.AdmiContra;
                objAdmi.admi_dni = objAdmiBE.AdmiDNI;
                objAdmi.admi_direccion = objAdmiBE.AdmiDireccion;
                objAdmi.admi_estado = String.Empty;

                MiHotel.ADMINISTRADOR.Add(objAdmi);
                MiHotel.SaveChanges();
                blnexito = true;
            }
            catch (Exception)
            {
                return blnexito;
            }
            return blnexito;
        }
        public Boolean DeleteAdministrador(string strCod)
        {
            try
            {
                PeruHotelEntities MiHotel = new PeruHotelEntities();
                MiHotel.usp_EliminarAdministrador(strCod);
                blnexito = true;

            } catch(EntityException)
            {
                return blnexito;
            }
            return blnexito;
            
        }
        public bool UpdateAdminitrador(DataAdministrador objAdmiBE)
        {
            try
            {
                PeruHotelEntities MiHotel = new PeruHotelEntities();
                MiHotel.usp_ActualizarAdministrador(
                    objAdmiBE.IdAdmi, objAdmiBE.AdmiNom, objAdmiBE.AdmiApePater, objAdmiBE.AdmiApeMater, objAdmiBE.AdmiCodigo,
                    objAdmiBE.AdmiContra, objAdmiBE.AdmiDNI, objAdmiBE.AdmiDireccion
                    );
                blnexito = true;

            }
            catch (EntityException)
            {
                return blnexito;
            }
            return blnexito;
        }

        public DataAdministrador GetAdministrador(string strCod)
        {
            PeruHotelEntities MiHotel = new PeruHotelEntities();
            DataAdministrador objAdmiBE = new DataAdministrador();

            try
            {
                //Obtenemos con LINQ el registro a consultar
                ADMINISTRADOR objAdmi = (from obj in MiHotel.ADMINISTRADOR
                                                  where obj.id_admi == strCod
                                                  select obj).FirstOrDefault();

                //Obtenemos los datos del vendedor
                objAdmiBE.IdAdmi = objAdmi.id_admi;
                objAdmiBE.AdmiNom = objAdmi.admi_nom;
                objAdmiBE.AdmiApePater = objAdmi.admi_apePater;
                objAdmiBE.AdmiApeMater = objAdmi.admi_apeMater;
                objAdmiBE.AdmiCodigo = objAdmi.admi_codigo;
                objAdmiBE.AdmiContra = objAdmi.admi_contra;
                objAdmiBE.AdmiDNI = objAdmi.admi_dni;
                objAdmiBE.AdmiDireccion = objAdmi.admi_direccion;
                objAdmiBE.AdmiEstado = objAdmi.admi_estado;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return objAdmiBE;
        }

        public List<DataAdministrador> GetAllAdministrador()
        {
            PeruHotelEntities MiHotel = new PeruHotelEntities();
            List<DataAdministrador> objListaAdmi = new List<DataAdministrador>();

            try
            {
                //Con LINQ obtenemos todos los vendedores y almacenamos en un objeto el resultado (query)
                var query = (from objAdmistrador in MiHotel.ADMINISTRADOR
                             orderby objAdmistrador.id_admi
                             select objAdmistrador);

                foreach (var resultado in query)
                {
                    DataAdministrador objAdmiBE = new DataAdministrador();

                    objAdmiBE.IdAdmi = resultado.id_admi;
                    objAdmiBE.AdmiNom = resultado.admi_nom;
                    objAdmiBE.AdmiApePater = resultado.admi_apePater;
                    objAdmiBE.AdmiApeMater = resultado.admi_apeMater;
                    objAdmiBE.AdmiCodigo = resultado.admi_codigo;
                    objAdmiBE.AdmiContra = resultado.admi_contra;
                    objAdmiBE.AdmiDNI = resultado.admi_dni;
                    objAdmiBE.AdmiDireccion = resultado.admi_direccion;
                    objAdmiBE.AdmiEstado = resultado.admi_estado;
                  

                    //Agregamos la instancia a la alista de Data Contractual a la lista de Vendedores
                    objListaAdmi.Add(objAdmiBE);
                }

            }
            catch (EntityException ex)
            {

                throw new Exception(ex.Message);
            }
            return objListaAdmi;
        }

       
    }
}
