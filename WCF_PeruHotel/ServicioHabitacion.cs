using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data.Entity.Core;

namespace WCF_PeruHotel
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServicioHabitacion" en el código y en el archivo de configuración a la vez.
    public class ServicioHabitacion : IServicioHabitacion
    {
        public List<dataHabitacion> ListarTipoHabitacion()
        {
            PeruHotelEntities MiHotel = new PeruHotelEntities();
            List<dataHabitacion> objListaHabitacion = new List<dataHabitacion>();

            try
            {
                var query = MiHotel.usp_ListarTipoHabitacion();

                foreach (var resultado in query)
                {
                    dataHabitacion objHabitacionBE = new dataHabitacion();

                    objHabitacionBE.IdTipoHabi = resultado.id_tipo_habi;
                    objHabitacionBE.TipoNombre = resultado.tipo_nombre;
                    objHabitacionBE.TipoDescripcion = resultado.tipo_descripcion;
                    objHabitacionBE.TipoPrecio = Convert.ToSingle(resultado.tipo_precio);
                    objHabitacionBE.TipoNumCamas = resultado.tipo_num_camas;

                    //Agregamos la instancia a la alista de Data Contractual a la lista de Vendedores
                    objListaHabitacion.Add(objHabitacionBE);
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            return objListaHabitacion;
        }

        public List<dataHabitacion> ListarHabitacionDisponiblePorTipo(String strIdTipo)
        {
            PeruHotelEntities MiHotel = new PeruHotelEntities();
            List<dataHabitacion> objListaHabitacion = new List<dataHabitacion>();

            try
            {
                var query = MiHotel.usp_HabitacionDisponiblePorTipo(strIdTipo);

                foreach (var resultado in query)
                {
                    dataHabitacion objHabitacionBE = new dataHabitacion();

                    objHabitacionBE.IdHabitacon = resultado.id_habitacion;
                    objHabitacionBE.HabiNum = resultado.habi_num;
                    objHabitacionBE.HabiPiso = resultado.habi_piso;
                    
                    //Agregamos la instancia a la alista de Data Contractual a la lista de Vendedores
                    objListaHabitacion.Add(objHabitacionBE);
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            return objListaHabitacion;
        }

        public dataHabitacion GetDetalleTipoHabitacion(String strIdTipo)
        {
            PeruHotelEntities MiHotel = new PeruHotelEntities();
            dataHabitacion objHabitacionBE = new dataHabitacion();

            try
            {
                //Obtenemos con LINQ el registro a consultar
                TIPO_HABITACION objHabitacion = (from objHabi in MiHotel.TIPO_HABITACION
                                           where objHabi.id_tipo_habi == strIdTipo
                                            select objHabi).FirstOrDefault();

                //Obtenemos los datos del vendedor
                objHabitacionBE.IdTipoHabi = objHabitacion.id_tipo_habi;
                objHabitacionBE.TipoDescripcion = objHabitacion.tipo_descripcion;
                objHabitacionBE.TipoNombre = objHabitacion.tipo_nombre;
                objHabitacionBE.TipoNumCamas = objHabitacion.tipo_num_camas;
                objHabitacionBE.TipoPrecio = Convert.ToSingle(objHabitacion.tipo_precio);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            return objHabitacionBE;
        }

    }
}
