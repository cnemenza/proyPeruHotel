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
        public DataCliente GetCliente(string strCod)
        {
            PeruHotelEntities MiHotel = new PeruHotelEntities();
            DataCliente objClienteBE = new DataCliente();

            try
            {
                //Obtenemos con LINQ el registro a consultar
                vw_VistaCliente objCliente = (from obj in MiHotel.vw_VistaCliente
                                              where obj.id_cliente == strCod
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
                objClienteBE.ClieSexo = objCliente.clie_sexo;
                objClienteBE.ClieEstado = objCliente.clie_estado;
                objClienteBE.IdUbigeo = objCliente.id_Continente + objCliente.id_Pais + objCliente.id_Ciudad;
                objClienteBE.NomContinente = objCliente.ubi_Continente;
                objClienteBE.NomPais = objCliente.ubi_Pais;
                objClienteBE.NomCiudad = objCliente.ubi_Ciudad;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return objClienteBE;
        }
    }
}
