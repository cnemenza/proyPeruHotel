using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_PeruHotel
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IServicioCliente" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServicioCliente
    {
        [OperationContract]
        Boolean InsertCliente(DataCliente objAdministrador);
        [OperationContract]
        Boolean UpdateCliente(DataCliente objAdministrador);

        [OperationContract]
        Boolean DeleteCliente(String strCod);

        [OperationContract]
        DataCliente GetCliente(String strCod);

        [OperationContract]
        List<DataCliente> GetAllCliente();

        [OperationContract]
        List<DataCliente> ListarNombresCliente();


    }
    [DataContract]
    [Serializable]

    public class DataCliente
    {
        private String _idCliente;
        private String _clieNom;
        private String _clieApePater;
        private String _clieApeMater;
        private String _clieCorreo;
        private String _clieTelefono;
        private String _idUbigeo;
        private String _clieCodigo;
        private String _clieContra;
        private String _clieSexo;
        private String _clieEstado;
        private String _idContinente;
        private String _idPais;
        private String _idCiudad;
        private String _nomContinente;
        private String _nomPais;
        private String _nomCiudad;

    
        [DataMember]
        public String IdCliente
        {
            get { return this._idCliente; }
            set { this._idCliente = value; }
        }
        [DataMember]
        public String ClieNom
        {
            get { return this._clieNom; }
            set { this._clieNom = value; }
        }
        [DataMember]
        public String ClieApePater
        {
            get { return this._clieApePater; }
            set { this._clieApePater = value; }
        }
        [DataMember]
        public String ClieApeMater
        {
            get { return this._clieApeMater; }
            set { this._clieApeMater = value; }
        }
        [DataMember]
        public String ClieCorreo
        {
            get { return this._clieCorreo; }
            set { this._clieCorreo = value; }
        }

        [DataMember]
        public String ClieTelefono
        {
            get { return this._clieTelefono; }
            set { this._clieTelefono = value; }
        }
        [DataMember]
        public String IdUbigeo
        {
            get { return this._idUbigeo; }
            set { this._idUbigeo = value; }
        }
        [DataMember]
        public String ClieCodigo
        {
            get { return this._clieCodigo; }
            set { this._clieCodigo = value; }
        }
        [DataMember]
        public String ClieContra
        {
            get { return this._clieContra; }
            set { this._clieContra = value; }
        }
        [DataMember]
        public String ClieSexo
        {
            get { return this._clieSexo; }
            set { this._clieSexo = value; }
        }
        [DataMember]
        public String ClieEstado
        {
            get { return this._clieEstado; }
            set { this._clieEstado = value; }
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
        public string NomContinente
        {
            get
            {
                return _nomContinente;
            }

            set
            {
                _nomContinente = value;
            }
        }
        [DataMember]
        public string NomPais
        {
            get
            {
                return _nomPais;
            }

            set
            {
                _nomPais = value;
            }
        }
        [DataMember]
        public string NomCiudad
        {
            get
            {
                return _nomCiudad;
            }

            set
            {
                _nomCiudad = value;
            }
        }
    }
}
