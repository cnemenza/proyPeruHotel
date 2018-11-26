using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaAccesoServicios
{
    public class ServicioHabitacion
    {
        ProxyHabitacion.ServicioHabitacionClient objServicoHabitacion = new ProxyHabitacion.ServicioHabitacionClient();

        public List<ProxyHabitacion.dataHabitacion> ListarHabitacionesDisponibles(DateTime fecIngreso, DateTime fecSalida)
        {
            return objServicoHabitacion.ListarHabitacionesDisponibles(fecIngreso, fecSalida);
        }
    }
}
