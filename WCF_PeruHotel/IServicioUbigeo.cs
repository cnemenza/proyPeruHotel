using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_PeruHotel
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IServicioUbigeo" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServicioUbigeo
    {
        [OperationContract]
        List<dataUbigeo> GetAllContinentes();
        [OperationContract]
        List<dataUbigeo> GetAllPaises(String codContinente);
        [OperationContract]
        List<dataUbigeo> GetAllCiudades(String codContinente, String codPais);
        [OperationContract]
        String GetIdUbigeo(String codContinente, String codPais, String codCiudad);
    }

    [DataContract]
    [Serializable]
    public class dataUbigeo
    {
        private String _idUbigeo;
        private String _idContinente;
        private String _idPais;
        private String _idCiudad;
        private String _ubiContinente;
        private String _ubiPais;
        private String _ubiCiudad;

        [DataMember]
        public string IdUbigeo
        {
            get
            {
                return _idUbigeo;
            }

            set
            {
                _idUbigeo = value;
            }
        }
        [DataMember]

        public string IdContinente
        {
            get
            {
                return _idContinente;
            }

            set
            {
                _idContinente = value;
            }
        }

        [DataMember]
        public string IdPais
        {
            get
            {
                return _idPais;
            }

            set
            {
                _idPais = value;
            }
        }

        [DataMember]
        public string IdCiudad
        {
            get
            {
                return _idCiudad;
            }

            set
            {
                _idCiudad = value;
            }
        }

        [DataMember]
        public string UbiContinente
        {
            get
            {
                return _ubiContinente;
            }

            set
            {
                _ubiContinente = value;
            }
        }

        [DataMember]
        public string UbiPais
        {
            get
            {
                return _ubiPais;
            }

            set
            {
                _ubiPais = value;
            }
        }

        [DataMember]
        public string UbiCiudad
        {
            get
            {
                return _ubiCiudad;
            }

            set
            {
                _ubiCiudad = value;
            }
        }
    }
}
