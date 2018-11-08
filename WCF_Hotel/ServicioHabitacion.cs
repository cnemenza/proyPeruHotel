using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_Hotel
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServicioHabitacion" en el código y en el archivo de configuración a la vez.
    public class ServicioHabitacion : IServicioHabitacion
    {

        public List<dataHabitacion> ListarHabitacionDisponibles()
        {
            PeruHotelEntities MiHotel = new PeruHotelEntities();
            List<dataHabitacion> objListaHabitacion = new List<dataHabitacion>();

            try
            {
                var query = (from objHabi in MiHotel.vw_VistaHabitacion
                             where objHabi.Estado == "Disponible"
                             orderby objHabi.id_habitacion
                             select objHabi);

                foreach (var resultado in query)
                {
                    dataHabitacion objHabitacionBE = new dataHabitacion();

                    objHabitacionBE.IdHabitacon = resultado.id_habitacion;
                    objHabitacionBE.HabiNum = resultado.habi_num;
                    objHabitacionBE.HabiPiso = resultado.habi_piso;
                    objHabitacionBE.IdTipoHabi = resultado.id_tipo_habi;
                    objHabitacionBE.IdHotel = resultado.id_hotel;
                    objHabitacionBE.TipoNombre = resultado.tipo_nombre;
                    objHabitacionBE.TipoDescripcion = resultado.tipo_descripcion;
                    objHabitacionBE.TipoPrecio = Convert.ToSingle(resultado.tipo_precio);
                    objHabitacionBE.TipoNumCamas = resultado.tipo_num_camas;
                    objHabitacionBE.HabiEstado = resultado.Estado;

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
    }
}
