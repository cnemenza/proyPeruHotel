using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_Hotel
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServicioCliente" en el código y en el archivo de configuración a la vez.
    public class ServicioCliente : IServicioCliente
    {
        public DataCliente GetCliente(string strDni)
        {
            PeruHotelEntities MiHotel = new PeruHotelEntities();
            DataCliente objClienteBE = new DataCliente();

            try
            {
                //Obtenemos con LINQ el registro a consultar
                vw_VistaCliente objCliente = (from obj in MiHotel.vw_VistaCliente
                                              where obj.clie_dni == strDni
                                              select obj).FirstOrDefault();

                //Obtenemos los datos del vendedor
                objClienteBE.IdCliente = objCliente.id_cliente;
                objClienteBE.ClieNom = objCliente.clie_nom;
                objClienteBE.ClieApePater = objCliente.clie_apePater;
                objClienteBE.ClieApeMater = objCliente.clie_apeMater;
                objClienteBE.ClieCorreo = objCliente.clie_correo;
                objClienteBE.ClieTelefono = objCliente.clie_telefono;
                objClienteBE.IdUbigeo = objCliente.id_Ubigeo;
                objClienteBE.ClieCodigo = objCliente.clie_codigo;
                objClienteBE.ClieContra = objCliente.clie_contra;
                objClienteBE.ClieSexo = (objCliente.clie_sexo.Equals("1")) ? "Masculino" : "Femenino";
                objClienteBE.ClieEstado = (objCliente.clie_estado.Equals("1")) ? "Activo" : "Inactivo";
                objClienteBE.IdUbigeo = objCliente.id_Continente + objCliente.id_Pais + objCliente.id_Ciudad;
                objClienteBE.NomContinente = objCliente.ubi_Continente;
                objClienteBE.NomPais = objCliente.ubi_Pais;
                objClienteBE.NomCiudad = objCliente.ubi_Ciudad;
                objClienteBE.ClieDni = objCliente.clie_dni;              
            }
            catch (Exception ex)
            {
                throw new Exception (ex.Message);
            }
            return objClienteBE;
        }

        public bool RegistrarCliente(DataCliente objClienteBE)
        {
            Boolean blnexito = false;
            PeruHotelEntities MiHotel = new PeruHotelEntities();
            try
            {
                CLIENTE objCliente = new CLIENTE();

                objCliente.id_cliente = String.Empty;
                objCliente.clie_nom = objClienteBE.ClieNom;
                objCliente.clie_apePater = objClienteBE.ClieApePater;
                objCliente.clie_apeMater = objClienteBE.ClieApeMater;
                objCliente.clie_correo = objClienteBE.ClieCorreo;
                objCliente.clie_dni = objClienteBE.ClieDni;
                objCliente.clie_telefono = objClienteBE.ClieTelefono;
                objCliente.id_Ubigeo = objClienteBE.IdUbigeo;
                objCliente.clie_codigo = objClienteBE.ClieCodigo;
                objCliente.clie_contra = objClienteBE.ClieContra;
                objCliente.clie_sexo = objClienteBE.ClieSexo;
                objCliente.clie_estado = String.Empty;

                MiHotel.CLIENTE.Add(objCliente);
                MiHotel.SaveChanges();
                blnexito = true;
            }
            catch (Exception)
            {
                return blnexito;
            }
            return blnexito;
        }
    }
}
