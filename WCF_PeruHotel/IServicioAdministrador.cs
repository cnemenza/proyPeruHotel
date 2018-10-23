using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;


namespace WCF_PeruHotel
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IServicioAdministrador" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServicioAdministrador
    {
        [OperationContract]
        Boolean InsertAdministrador(DataAdministrador objAdministrador);
        [OperationContract]
        Boolean UpdateAdminitrador(DataAdministrador objAdministrador);

        [OperationContract]
        Boolean DeleteAdministrador(String strCod);

        [OperationContract]
        DataAdministrador GetAdministrador(String strCod);

        [OperationContract]
        List<DataAdministrador> GetAllAdministrador();
    }

    [DataContract]
    [Serializable]

    public class DataAdministrador
    {
        private String _idAdmi;
        private String _admiNom;
        private String _admiApePater;
        private String _admiApeMater;
        private String _admiCodigo;
        private String _admiContra;
        private String _admiDNI;
        private String _admiDireccion;
        private String _admiEstado;

        [DataMember]
        public string IdAdmi
        {
            get
            {
                return _idAdmi;
            }

            set
            {
                _idAdmi = value;
            }
        }

        [DataMember]
        public string AdmiNom
        {
            get
            {
                return _admiNom;
            }

            set
            {
                _admiNom = value;
            }
        }

        [DataMember]
        public string AdmiApePater
        {
            get
            {
                return _admiApePater;
            }

            set
            {
                _admiApePater = value;
            }
        }

        [DataMember]
        public string AdmiApeMater
        {
            get
            {
                return _admiApeMater;
            }

            set
            {
                _admiApeMater = value;
            }
        }

        [DataMember]
        public string AdmiCodigo
        {
            get
            {
                return _admiCodigo;
            }

            set
            {
                _admiCodigo = value;
            }
        }

        [DataMember]
        public string AdmiContra
        {
            get
            {
                return _admiContra;
            }

            set
            {
                _admiContra = value;
            }
        }

        [DataMember]
        public string AdmiDNI
        {
            get
            {
                return _admiDNI;
            }

            set
            {
                _admiDNI = value;
            }
        }

        [DataMember]
        public string AdmiDireccion
        {
            get
            {
                return _admiDireccion;
            }

            set
            {
                _admiDireccion = value;
            }
        }

        [DataMember]
        public string AdmiEstado
        {
            get
            {
                return _admiEstado;
            }

            set
            {
                _admiEstado = value;
            }
        }
    }
}
