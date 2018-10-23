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
        private String _clieTipoDocumento;
        private String _clieDocumento;
        private String _idPais;
        private String _clieCodigo;
        private String _clieContra;
        private String _clieSexo;
        private String _clieEstado;

    
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
        public String ClieTipoDocumento
        {
            get { return this._clieTipoDocumento; }
            set { this._clieTipoDocumento = value; }
        }
        [DataMember]
        public String ClieDocumento
        {
            get { return this._clieDocumento; }
            set { this._clieDocumento = value; }
        }
        [DataMember]
        public String IdPais
        {
            get { return this._idPais; }
            set { this._idPais = value; }
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
     
    }
}
