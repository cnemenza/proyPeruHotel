using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_Hotel
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IServicioRegistroReserva" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServicioRegistroReserva
    {
        [OperationContract]
        Boolean RegistroReserva(DataRegistro data);
    }
    [DataContract]
    [Serializable]

    public class DataRegistro
    {
        private System.DateTime _reserFechaIngreso;
        private System.DateTime _reserFechaSalida;
        private String _idCliente;
        private String _idHabi1;
        private String _idHabi2;
        private String _idHabi3;

        [DataMember]
        public DateTime ReserFechaIngreso
        {
            get
            {
                return _reserFechaIngreso;
            }

            set
            {
                _reserFechaIngreso = value;
            }
        }
        [DataMember]

        public DateTime ReserFechaSalida
        {
            get
            {
                return _reserFechaSalida;
            }

            set
            {
                _reserFechaSalida = value;
            }
        }

        [DataMember]
        public string IdCliente
        {
            get
            {
                return _idCliente;
            }

            set
            {
                _idCliente = value;
            }
        }

        [DataMember]
        public string IdHabi1
        {
            get
            {
                return _idHabi1;
            }

            set
            {
                _idHabi1 = value;
            }
        }

        [DataMember]
        public string IdHabi2
        {
            get
            {
                return _idHabi2;
            }

            set
            {
                _idHabi2 = value;
            }
        }

        [DataMember]
        public string IdHabi3
        {
            get
            {
                return _idHabi3;
            }

            set
            {
                _idHabi3 = value;
            }
        }
    }
    
}
