using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaAccesoServicios
{
    public class ServicioRegistroReserva
    {
        ProxyRegistroReserva.ServicioRegistroReservaClient objServicioRegistro = new ProxyRegistroReserva.ServicioRegistroReservaClient();
        
        public Boolean RegistroReserva(ProxyRegistroReserva.DataRegistro data)
        {
            return objServicioRegistro.RegistroReserva(data);
        }
    }
}
