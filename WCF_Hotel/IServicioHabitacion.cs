using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_Hotel
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IServicioHabitacion" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServicioHabitacion
    {
        [OperationContract]

        List<dataHabitacion> ListarHabitacionesDisponibles(DateTime fecIngreso, DateTime fecSalida);

    }
    [DataContract]
    [Serializable]

    public class dataHabitacion
    {
        private String _idHabitacon;
        private String _habiNum;
        private String _habiPiso;
        private String _idTipoHabi;
        private String _idHotel;
        private String _tipoNombre;
        private String _tipoDescripcion;
        private Single _tipoPrecio;
        private String _tipoNumCamas;

        [DataMember]
        public string IdHabitacon
        {
            get
            {
                return _idHabitacon;
            }

            set
            {
                _idHabitacon = value;
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

        [DataMember]
        public string HabiPiso
        {
            get
            {
                return _habiPiso;
            }

            set
            {
                _habiPiso = value;
            }
        }

        [DataMember]
        public string IdTipoHabi
        {
            get
            {
                return _idTipoHabi;
            }

            set
            {
                _idTipoHabi = value;
            }
        }

        [DataMember]
        public string IdHotel
        {
            get
            {
                return _idHotel;
            }

            set
            {
                _idHotel = value;
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
        public string TipoDescripcion
        {
            get
            {
                return _tipoDescripcion;
            }

            set
            {
                _tipoDescripcion = value;
            }
        }

        [DataMember]
        public Single TipoPrecio
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
        public string TipoNumCamas
        {
            get
            {
                return _tipoNumCamas;
            }

            set
            {
                _tipoNumCamas = value;
            }
        }
    }
}

