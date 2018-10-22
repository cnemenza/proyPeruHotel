using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data.Entity.Core;

namespace WCF_PeruHotel
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServicioCliente" en el código y en el archivo de configuración a la vez.
    public class ServicioCliente : IServicioCliente
    {
        Boolean blnexito;
        public bool InsertCliente(DataCliente objClienteBE)
        {
            PeruHotelEntities MiHotel = new PeruHotelEntities();
            try
            {
                CLIENTE objCliente = new CLIENTE();

                objCliente.id_cliente = String.Empty;
                objCliente.clie_nom = objClienteBE.ClieNom;
                objCliente.clie_apePater = objClienteBE.ClieApePater;
                objCliente.clie_apeMater = objClienteBE.ClieApeMater;
                objCliente.clie_correo = objClienteBE.ClieCorreo;
                objCliente.clie_tipoDocumento = objClienteBE.ClieTipoDocumento;
                objCliente.clie_documento = objClienteBE.ClieDocumento;
                objCliente.id_Pais = objClienteBE.IdPais;
                objCliente.clie_codigo = objClienteBE.ClieCodigo;
                objCliente.clie_contra = objClienteBE.ClieContra;
                objCliente.clie_sexo = objClienteBE.ClieSexo;
                objCliente.clie_estado = String.Empty;

                MiHotel.CLIENTE.Add(objCliente);
                MiHotel.SaveChanges();
                blnexito = true;
            }
            catch (Exception ex)
            {
                return blnexito;
            }
            return blnexito;
        }
        public Boolean DeleteCliente(string strCod)
        {
            try
            {
                PeruHotelEntities MiHotel = new PeruHotelEntities();
                MiHotel.usp_EliminarCliente(strCod);
                blnexito = true;

            }
            catch (EntityException ex)
            {
                return blnexito;
            }
            return blnexito;

        }
        public bool UpdateCliente(DataCliente objClienteBE)
        {
            try
            {
                PeruHotelEntities MiHotel = new PeruHotelEntities();
                MiHotel.usp_ActualizarCliente(
                    objClienteBE.IdCliente,objClienteBE.ClieNom,objClienteBE.ClieApePater,objClienteBE.ClieApeMater,objClienteBE.ClieCorreo,
                    objClienteBE.ClieTipoDocumento,objClienteBE.ClieDocumento,objClienteBE.IdPais,objClienteBE.ClieCodigo,objClienteBE.ClieContra,
                    objClienteBE.ClieSexo
                    );
                blnexito = true;

            }
            catch (EntityException ex)
            {
                return blnexito;
            }
            return blnexito;
        }

        public DataCliente GetCliente(string strCod)
        {
            PeruHotelEntities MiHotel = new PeruHotelEntities();
            DataCliente objClienteBE = new DataCliente();

            try
            {
                //Obtenemos con LINQ el registro a consultar
                 CLIENTE objCliente = (from obj in MiHotel.CLIENTE
                                         where obj.id_cliente == strCod
                                         select obj).FirstOrDefault();

                //Obtenemos los datos del vendedor
                objClienteBE.IdCliente = objCliente.id_cliente;
                objClienteBE.ClieNom = objCliente.clie_nom;
                objClienteBE.ClieApePater = objCliente.clie_apePater;
                objClienteBE.ClieApeMater = objCliente.clie_apeMater;
                objClienteBE.ClieCorreo = objCliente.clie_correo;
                objClienteBE.ClieTipoDocumento = objCliente.clie_tipoDocumento;
                objClienteBE.ClieDocumento = objCliente.clie_documento;
                objClienteBE.IdPais = objCliente.id_Pais;
                objClienteBE.ClieCodigo = objCliente.clie_codigo;
                objClienteBE.ClieContra = objCliente.clie_contra;
                objClienteBE.ClieSexo = objCliente.clie_sexo;
                objClienteBE.ClieEstado = objCliente.clie_estado;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return objClienteBE;
        }

        public List<DataCliente> GetAllCliente()
        {
            PeruHotelEntities MiHotel = new PeruHotelEntities();
            List<DataCliente> objListCliente = new List<DataCliente>();

            try
            {
                //Con LINQ obtenemos todos los vendedores y almacenamos en un objeto el resultado (query)
                var query = (from objCliente in MiHotel.CLIENTE
                             orderby objCliente.id_cliente
                             select objCliente);

                foreach (var resultado in query)
                {
                    DataCliente objClienteBE = new DataCliente();

                    objClienteBE.IdCliente = resultado.id_cliente;
                    objClienteBE.ClieNom = resultado.clie_nom;
                    objClienteBE.ClieApePater = resultado.clie_apePater;
                    objClienteBE.ClieApeMater = resultado.clie_apeMater;
                    objClienteBE.ClieCorreo = resultado.clie_correo;
                    objClienteBE.ClieTipoDocumento = resultado.clie_tipoDocumento;
                    objClienteBE.ClieDocumento = resultado.clie_documento;
                    objClienteBE.IdPais = resultado.id_Pais;
                    objClienteBE.ClieCodigo = resultado.clie_codigo;
                    objClienteBE.ClieContra = resultado.clie_contra;
                    objClienteBE.ClieSexo = resultado.clie_sexo;
                    objClienteBE.ClieEstado = resultado.clie_estado;


                    //Agregamos la instancia a la alista de Data Contractual a la lista de Vendedores
                    objListCliente.Add(objClienteBE);
                }

            }
            catch (EntityException ex)
            {

                throw new Exception(ex.Message);
            }
            return objListCliente;
        }


    }
}
