using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaAccesoServicios
{
    public class ServicioUbigeo
    {
        ProxyUbigeo.ServicioUbigeoClient objServicioUbigeo = new ProxyUbigeo.ServicioUbigeoClient();

        public List<ProxyUbigeo.dataUbigeo> GetAllContinentes()
        {
            return objServicioUbigeo.GetAllContinentes();
        }
        public List<ProxyUbigeo.dataUbigeo> GetAllPaises(String codContinente)
        {
            return objServicioUbigeo.GetAllPaises(codContinente);
        }
        public List<ProxyUbigeo.dataUbigeo> GetAllCiudades(String codContinente, String codPais)
        {
            return objServicioUbigeo.GetAllCiudades(codContinente,codPais);
        }
        public String GetIdUbigeo(String codContinente, String codPais, String codCiudad)
        {
            return objServicioUbigeo.GetIdUbigeo(codContinente, codPais, codCiudad);
        }
    }
}
