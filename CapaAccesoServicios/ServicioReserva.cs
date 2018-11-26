using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaAccesoServicios
{
    public class ServicioReserva
    {
        ProxyReserva.ServicioReservaClient objServicioReserva = new ProxyReserva.ServicioReservaClient();

        public List<ProxyReserva.dataReserva> ListarReservas(String strDNI, DateTime fecini, DateTime fecfin)
        {
            return objServicioReserva.ListarReservas(strDNI, fecini, fecfin);
        }
        
        public List<ProxyReserva.dataReserva> GetDetalleReservaHabitaciones(String strCod)
        {
            return objServicioReserva.GetDetalleReservaHabitaciones(strCod);
        }

        public List<ProxyReserva.dataReserva> GetDetalleReservaServicio(String strCod)
        {
            return objServicioReserva.GetDetalleReservaServicio(strCod);
        }
    }
}
