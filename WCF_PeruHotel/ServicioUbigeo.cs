using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_PeruHotel
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServicioUbigeo" en el código y en el archivo de configuración a la vez.
    public class ServicioUbigeo : IServicioUbigeo
    {

        public List<dataUbigeo> GetAllContinentes()
        {
            PeruHotelEntities MiHotel = new PeruHotelEntities();
            List<dataUbigeo> objListaUbigeo = new List<dataUbigeo>();

            try
            {
                //haciendo la consulta con LINQ, sin usar el SP

                var query = MiHotel.usp_ListarContinente();

                foreach (var resultado in query)
                {
                    dataUbigeo objUbiBE = new dataUbigeo();
                    objUbiBE.IdContinente = resultado.id_Continente;
                    objUbiBE.UbiContinente = resultado.ubi_Continente;

                    //Agregamos la instancia a la alista de Data Contractual a la lista de Vendedores
                    objListaUbigeo.Add(objUbiBE);
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            return objListaUbigeo;
        }

        public List<dataUbigeo> GetAllPaises(String codContinente)
        {
            PeruHotelEntities MiHotel = new PeruHotelEntities();
            List<dataUbigeo> objListaUbigeo = new List<dataUbigeo>();

            try
            {
                //haciendo la consulta con LINQ, sin usar el SP

                var query = MiHotel.usp_ListarPais(codContinente);

                foreach (var resultado in query)
                {
                    dataUbigeo objUbiBE = new dataUbigeo();
                    objUbiBE.IdPais = resultado.id_pais;
                    objUbiBE.UbiPais = resultado.ubi_pais;

                    //Agregamos la instancia a la alista de Data Contractual a la lista de Vendedores
                    objListaUbigeo.Add(objUbiBE);
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            return objListaUbigeo;
        }

        public List<dataUbigeo> GetAllCiudades(String codContinente, String codPais)
        {
            PeruHotelEntities MiHotel = new PeruHotelEntities();
            List<dataUbigeo> objListaUbigeo = new List<dataUbigeo>();

            try
            {
                //haciendo la consulta con LINQ, sin usar el SP

                var query = MiHotel.usp_ListarCiudad(codContinente,codPais);

                foreach (var resultado in query)
                {
                    dataUbigeo objUbiBE = new dataUbigeo();
                    objUbiBE.IdCiudad = resultado.id_ciudad;
                    objUbiBE.UbiCiudad = resultado.ubi_ciudad;

                    //Agregamos la instancia a la alista de Data Contractual a la lista de Vendedores
                    objListaUbigeo.Add(objUbiBE);
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            return objListaUbigeo;
        }

        public String GetIdUbigeo(String codContinente, String codPais, String codCiudad)
        {

            PeruHotelEntities MiHotel = new PeruHotelEntities();
            try
            {

                String idUbigeo = String.Empty;
                var query = (from ubi in MiHotel.UBIGEO
                             where ubi.id_Continente == codContinente &&
                                   ubi.id_Pais == codPais &&
                                   ubi.id_Ciudad == codCiudad
                             select
                                 ubi.id_Ubigeo
                             );

                foreach(var i in query)
                {
                    idUbigeo = Convert.ToString(i);
                }
                return idUbigeo;
            }
            catch (Exception)
            {

                throw;
            }
            
        }
    }
}
