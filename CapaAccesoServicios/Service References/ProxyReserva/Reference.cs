﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CapaAccesoServicios.ProxyReserva {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="dataReserva", Namespace="http://schemas.datacontract.org/2004/07/WCF_Hotel")]
    [System.SerializableAttribute()]
    public partial class dataReserva : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private float CantDiasField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private float CantHabField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private float CantidadServicioField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ClieDniField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EstadoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string HabiNumField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string IdClienteField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string IdHabitacionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string IdReservaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string IdServicioField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private float MonHabField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private float MonServicioField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NombreField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime ReserFechaIngresoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime ReserFechaReserField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime ReserFechaSalidaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ServiNomField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private float ServiPrecioField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TipoNombreField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private float TipoPrecioField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private float TotalField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public float CantDias {
            get {
                return this.CantDiasField;
            }
            set {
                if ((this.CantDiasField.Equals(value) != true)) {
                    this.CantDiasField = value;
                    this.RaisePropertyChanged("CantDias");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public float CantHab {
            get {
                return this.CantHabField;
            }
            set {
                if ((this.CantHabField.Equals(value) != true)) {
                    this.CantHabField = value;
                    this.RaisePropertyChanged("CantHab");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public float CantidadServicio {
            get {
                return this.CantidadServicioField;
            }
            set {
                if ((this.CantidadServicioField.Equals(value) != true)) {
                    this.CantidadServicioField = value;
                    this.RaisePropertyChanged("CantidadServicio");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ClieDni {
            get {
                return this.ClieDniField;
            }
            set {
                if ((object.ReferenceEquals(this.ClieDniField, value) != true)) {
                    this.ClieDniField = value;
                    this.RaisePropertyChanged("ClieDni");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Estado {
            get {
                return this.EstadoField;
            }
            set {
                if ((object.ReferenceEquals(this.EstadoField, value) != true)) {
                    this.EstadoField = value;
                    this.RaisePropertyChanged("Estado");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string HabiNum {
            get {
                return this.HabiNumField;
            }
            set {
                if ((object.ReferenceEquals(this.HabiNumField, value) != true)) {
                    this.HabiNumField = value;
                    this.RaisePropertyChanged("HabiNum");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string IdCliente {
            get {
                return this.IdClienteField;
            }
            set {
                if ((object.ReferenceEquals(this.IdClienteField, value) != true)) {
                    this.IdClienteField = value;
                    this.RaisePropertyChanged("IdCliente");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string IdHabitacion {
            get {
                return this.IdHabitacionField;
            }
            set {
                if ((object.ReferenceEquals(this.IdHabitacionField, value) != true)) {
                    this.IdHabitacionField = value;
                    this.RaisePropertyChanged("IdHabitacion");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string IdReserva {
            get {
                return this.IdReservaField;
            }
            set {
                if ((object.ReferenceEquals(this.IdReservaField, value) != true)) {
                    this.IdReservaField = value;
                    this.RaisePropertyChanged("IdReserva");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string IdServicio {
            get {
                return this.IdServicioField;
            }
            set {
                if ((object.ReferenceEquals(this.IdServicioField, value) != true)) {
                    this.IdServicioField = value;
                    this.RaisePropertyChanged("IdServicio");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public float MonHab {
            get {
                return this.MonHabField;
            }
            set {
                if ((this.MonHabField.Equals(value) != true)) {
                    this.MonHabField = value;
                    this.RaisePropertyChanged("MonHab");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public float MonServicio {
            get {
                return this.MonServicioField;
            }
            set {
                if ((this.MonServicioField.Equals(value) != true)) {
                    this.MonServicioField = value;
                    this.RaisePropertyChanged("MonServicio");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nombre {
            get {
                return this.NombreField;
            }
            set {
                if ((object.ReferenceEquals(this.NombreField, value) != true)) {
                    this.NombreField = value;
                    this.RaisePropertyChanged("Nombre");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime ReserFechaIngreso {
            get {
                return this.ReserFechaIngresoField;
            }
            set {
                if ((this.ReserFechaIngresoField.Equals(value) != true)) {
                    this.ReserFechaIngresoField = value;
                    this.RaisePropertyChanged("ReserFechaIngreso");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime ReserFechaReser {
            get {
                return this.ReserFechaReserField;
            }
            set {
                if ((this.ReserFechaReserField.Equals(value) != true)) {
                    this.ReserFechaReserField = value;
                    this.RaisePropertyChanged("ReserFechaReser");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime ReserFechaSalida {
            get {
                return this.ReserFechaSalidaField;
            }
            set {
                if ((this.ReserFechaSalidaField.Equals(value) != true)) {
                    this.ReserFechaSalidaField = value;
                    this.RaisePropertyChanged("ReserFechaSalida");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ServiNom {
            get {
                return this.ServiNomField;
            }
            set {
                if ((object.ReferenceEquals(this.ServiNomField, value) != true)) {
                    this.ServiNomField = value;
                    this.RaisePropertyChanged("ServiNom");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public float ServiPrecio {
            get {
                return this.ServiPrecioField;
            }
            set {
                if ((this.ServiPrecioField.Equals(value) != true)) {
                    this.ServiPrecioField = value;
                    this.RaisePropertyChanged("ServiPrecio");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string TipoNombre {
            get {
                return this.TipoNombreField;
            }
            set {
                if ((object.ReferenceEquals(this.TipoNombreField, value) != true)) {
                    this.TipoNombreField = value;
                    this.RaisePropertyChanged("TipoNombre");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public float TipoPrecio {
            get {
                return this.TipoPrecioField;
            }
            set {
                if ((this.TipoPrecioField.Equals(value) != true)) {
                    this.TipoPrecioField = value;
                    this.RaisePropertyChanged("TipoPrecio");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public float Total {
            get {
                return this.TotalField;
            }
            set {
                if ((this.TotalField.Equals(value) != true)) {
                    this.TotalField = value;
                    this.RaisePropertyChanged("Total");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ProxyReserva.IServicioReserva")]
    public interface IServicioReserva {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioReserva/ListarReservas", ReplyAction="http://tempuri.org/IServicioReserva/ListarReservasResponse")]
        System.Collections.Generic.List<CapaAccesoServicios.ProxyReserva.dataReserva> ListarReservas(string strDNI, System.DateTime fecini, System.DateTime fecfin);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioReserva/ListarReservas", ReplyAction="http://tempuri.org/IServicioReserva/ListarReservasResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<CapaAccesoServicios.ProxyReserva.dataReserva>> ListarReservasAsync(string strDNI, System.DateTime fecini, System.DateTime fecfin);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioReserva/GetDetalleReservaHabitaciones", ReplyAction="http://tempuri.org/IServicioReserva/GetDetalleReservaHabitacionesResponse")]
        System.Collections.Generic.List<CapaAccesoServicios.ProxyReserva.dataReserva> GetDetalleReservaHabitaciones(string strCod);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioReserva/GetDetalleReservaHabitaciones", ReplyAction="http://tempuri.org/IServicioReserva/GetDetalleReservaHabitacionesResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<CapaAccesoServicios.ProxyReserva.dataReserva>> GetDetalleReservaHabitacionesAsync(string strCod);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioReserva/GetDetalleReservaServicio", ReplyAction="http://tempuri.org/IServicioReserva/GetDetalleReservaServicioResponse")]
        System.Collections.Generic.List<CapaAccesoServicios.ProxyReserva.dataReserva> GetDetalleReservaServicio(string strCod);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioReserva/GetDetalleReservaServicio", ReplyAction="http://tempuri.org/IServicioReserva/GetDetalleReservaServicioResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<CapaAccesoServicios.ProxyReserva.dataReserva>> GetDetalleReservaServicioAsync(string strCod);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServicioReservaChannel : CapaAccesoServicios.ProxyReserva.IServicioReserva, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServicioReservaClient : System.ServiceModel.ClientBase<CapaAccesoServicios.ProxyReserva.IServicioReserva>, CapaAccesoServicios.ProxyReserva.IServicioReserva {
        
        public ServicioReservaClient() {
        }
        
        public ServicioReservaClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServicioReservaClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicioReservaClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicioReservaClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Collections.Generic.List<CapaAccesoServicios.ProxyReserva.dataReserva> ListarReservas(string strDNI, System.DateTime fecini, System.DateTime fecfin) {
            return base.Channel.ListarReservas(strDNI, fecini, fecfin);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<CapaAccesoServicios.ProxyReserva.dataReserva>> ListarReservasAsync(string strDNI, System.DateTime fecini, System.DateTime fecfin) {
            return base.Channel.ListarReservasAsync(strDNI, fecini, fecfin);
        }
        
        public System.Collections.Generic.List<CapaAccesoServicios.ProxyReserva.dataReserva> GetDetalleReservaHabitaciones(string strCod) {
            return base.Channel.GetDetalleReservaHabitaciones(strCod);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<CapaAccesoServicios.ProxyReserva.dataReserva>> GetDetalleReservaHabitacionesAsync(string strCod) {
            return base.Channel.GetDetalleReservaHabitacionesAsync(strCod);
        }
        
        public System.Collections.Generic.List<CapaAccesoServicios.ProxyReserva.dataReserva> GetDetalleReservaServicio(string strCod) {
            return base.Channel.GetDetalleReservaServicio(strCod);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<CapaAccesoServicios.ProxyReserva.dataReserva>> GetDetalleReservaServicioAsync(string strCod) {
            return base.Channel.GetDetalleReservaServicioAsync(strCod);
        }
    }
}