using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_Hotel
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IServicioReserva" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServicioReserva
    {
        [OperationContract]

        List<dataReserva> ListarReservas(String strDNI,DateTime fecini, DateTime fecfin);

        [OperationContract]
        List<dataReserva> GetDetalleReservaHabitaciones(String strCod);
        [OperationContract]
        List<dataReserva> GetDetalleReservaServicio(String strCod);

    }
    [DataContract]
    [Serializable]
    public class dataReserva
    {
        private String _idReserva;
        private System.DateTime _reserFechaReser;
        private System.DateTime _reserFechaIngreso;
        private System.DateTime _reserFechaSalida;
        private String _idCliente;
        private String _nombre;
        private String _clieDni;
        private Single _cantHab;
        private Single _cantDias;
        private Single _monHab;
        private Single _monServicio;
        private Single _total;
        private String _estado;

        //detalle servicio
        private String _idServicio;
        private String _serviNom;
        private Single _serviPrecio;
        private Single _cantidadServicio;

        //detalle habitacion
        private String _idHabitacion;
        private String _tipoNombre;
        private Single _tipoPrecio;
        private String _habiNum;

        [DataMember]
        public string IdReserva
        {
            get
            {
                return _idReserva;
            }

            set
            {
                _idReserva = value;
            }
        }


        [DataMember]
        public string ClieDni
        {
            get
            {
                return _clieDni;
            }

            set
            {
                _clieDni = value;
            }
        }

        [DataMember]
        public DateTime ReserFechaReser
        {
            get
            {
                return _reserFechaReser;
            }

            set
            {
                _reserFechaReser = value;
            }
        }

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
        public string Nombre
        {
            get
            {
                return _nombre;
            }

            set
            {
                _nombre = value;
            }
        }

        [DataMember]
        public float CantHab
        {
            get
            {
                return _cantHab;
            }

            set
            {
                _cantHab = value;
            }
        }

        [DataMember]
        public float CantDias
        {
            get
            {
                return _cantDias;
            }

            set
            {
                _cantDias = value;
            }
        }

        [DataMember]
        public float MonHab
        {
            get
            {
                return _monHab;
            }

            set
            {
                _monHab = value;
            }
        }

        [DataMember]
        public float MonServicio
        {
            get
            {
                return _monServicio;
            }

            set
            {
                _monServicio = value;
            }
        }

        [DataMember]
        public float Total
        {
            get
            {
                return _total;
            }

            set
            {
                _total = value;
            }
        }

        [DataMember]
        public string Estado
        {
            get
            {
                return _estado;
            }

            set
            {
                _estado = value;
            }
        }
        [DataMember]
        public string IdServicio
        {
            get
            {
                return _idServicio;
            }

            set
            {
                _idServicio = value;
            }
        }
        [DataMember]
        public string ServiNom
        {
            get
            {
                return _serviNom;
            }

            set
            {
                _serviNom = value;
            }
        }
        [DataMember]
        public float ServiPrecio
        {
            get
            {
                return _serviPrecio;
            }

            set
            {
                _serviPrecio = value;
            }
        }
        [DataMember]
        public float CantidadServicio
        {
            get
            {
                return _cantidadServicio;
            }

            set
            {
                _cantidadServicio = value;
            }
        }
        [DataMember]
        public string IdHabitacion
        {
            get
            {
                return _idHabitacion;
            }

            set
            {
                _idHabitacion = value;
            }
        }
        [DataMember]
        public string TipoNombre
        {
            get
            {
                return _tipoNombre;
            }

            set
            {
                _tipoNombre = value;
            }
        }
        [DataMember]
        public float TipoPrecio
        {
            get
            {
                return _tipoPrecio;
            }

            set
            {
                _tipoPrecio = value;
            }
        }
        [DataMember]
        public string HabiNum
        {
            get
            {
                return _habiNum;
            }

            set
            {
                _habiNum = value;
            }
        }
    }
}

