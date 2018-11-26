using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CapaAccesoServicios
{
    public class ServicioCliente
    {
        ProxyCliente.ServicioClienteClient objServicioCliente = new ProxyCliente.ServicioClienteClient();

        public ProxyCliente.DataCliente GetCliente(String strDni)
        {
            return objServicioCliente.GetCliente(strDni);
        }

        public Boolean RegistrarCliente(ProxyCliente.DataCliente objCliente)
        {
            return objServicioCliente.RegistrarCliente(objCliente);
        }
    }
}
