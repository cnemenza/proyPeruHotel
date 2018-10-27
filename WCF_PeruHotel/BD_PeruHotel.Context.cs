﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WCF_PeruHotel
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class PeruHotelEntities : DbContext
    {
        public PeruHotelEntities()
            : base("name=PeruHotelEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ADMINISTRADOR> ADMINISTRADOR { get; set; }
        public virtual DbSet<CLIENTE> CLIENTE { get; set; }
        public virtual DbSet<HABITACION> HABITACION { get; set; }
        public virtual DbSet<HOTEL> HOTEL { get; set; }
        public virtual DbSet<PROMOCION> PROMOCION { get; set; }
        public virtual DbSet<RESERVA> RESERVA { get; set; }
        public virtual DbSet<SERVICIO> SERVICIO { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<TIPO_HABITACION> TIPO_HABITACION { get; set; }
        public virtual DbSet<vw_VistaDetalleReserva> vw_VistaDetalleReserva { get; set; }
        public virtual DbSet<vw_VistaReserva> vw_VistaReserva { get; set; }
        public virtual DbSet<UBIGEO> UBIGEO { get; set; }
        public virtual DbSet<vw_VistaReservaHabitaciones> vw_VistaReservaHabitaciones { get; set; }
        public virtual DbSet<vw_VistaReservaServicios> vw_VistaReservaServicios { get; set; }
        public virtual DbSet<vw_VistaDetalleServicio> vw_VistaDetalleServicio { get; set; }
        public virtual DbSet<vw_VistaCliente> vw_VistaCliente { get; set; }
    
        public virtual int usp_ActualizarAdministrador(string id_admi, string admi_nom, string admi_apePater, string admi_apeMater, string admi_codigo, string admi_contra, string admi_dni, string admi_direccion)
        {
            var id_admiParameter = id_admi != null ?
                new ObjectParameter("id_admi", id_admi) :
                new ObjectParameter("id_admi", typeof(string));
    
            var admi_nomParameter = admi_nom != null ?
                new ObjectParameter("admi_nom", admi_nom) :
                new ObjectParameter("admi_nom", typeof(string));
    
            var admi_apePaterParameter = admi_apePater != null ?
                new ObjectParameter("admi_apePater", admi_apePater) :
                new ObjectParameter("admi_apePater", typeof(string));
    
            var admi_apeMaterParameter = admi_apeMater != null ?
                new ObjectParameter("admi_apeMater", admi_apeMater) :
                new ObjectParameter("admi_apeMater", typeof(string));
    
            var admi_codigoParameter = admi_codigo != null ?
                new ObjectParameter("admi_codigo", admi_codigo) :
                new ObjectParameter("admi_codigo", typeof(string));
    
            var admi_contraParameter = admi_contra != null ?
                new ObjectParameter("admi_contra", admi_contra) :
                new ObjectParameter("admi_contra", typeof(string));
    
            var admi_dniParameter = admi_dni != null ?
                new ObjectParameter("admi_dni", admi_dni) :
                new ObjectParameter("admi_dni", typeof(string));
    
            var admi_direccionParameter = admi_direccion != null ?
                new ObjectParameter("admi_direccion", admi_direccion) :
                new ObjectParameter("admi_direccion", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_ActualizarAdministrador", id_admiParameter, admi_nomParameter, admi_apePaterParameter, admi_apeMaterParameter, admi_codigoParameter, admi_contraParameter, admi_dniParameter, admi_direccionParameter);
        }
    
        public virtual int usp_ActualizarCliente(string id_cliente, string clie_nom, string clie_apePater, string clie_apeMater, string clie_correo, string clie_tipoDocumento, string clie_documento, string id_Ubigeo, string clie_codigo, string clie_contra, string clie_sexo)
        {
            var id_clienteParameter = id_cliente != null ?
                new ObjectParameter("id_cliente", id_cliente) :
                new ObjectParameter("id_cliente", typeof(string));
    
            var clie_nomParameter = clie_nom != null ?
                new ObjectParameter("clie_nom", clie_nom) :
                new ObjectParameter("clie_nom", typeof(string));
    
            var clie_apePaterParameter = clie_apePater != null ?
                new ObjectParameter("clie_apePater", clie_apePater) :
                new ObjectParameter("clie_apePater", typeof(string));
    
            var clie_apeMaterParameter = clie_apeMater != null ?
                new ObjectParameter("clie_apeMater", clie_apeMater) :
                new ObjectParameter("clie_apeMater", typeof(string));
    
            var clie_correoParameter = clie_correo != null ?
                new ObjectParameter("clie_correo", clie_correo) :
                new ObjectParameter("clie_correo", typeof(string));
    
            var clie_tipoDocumentoParameter = clie_tipoDocumento != null ?
                new ObjectParameter("clie_tipoDocumento", clie_tipoDocumento) :
                new ObjectParameter("clie_tipoDocumento", typeof(string));
    
            var clie_documentoParameter = clie_documento != null ?
                new ObjectParameter("clie_documento", clie_documento) :
                new ObjectParameter("clie_documento", typeof(string));
    
            var id_UbigeoParameter = id_Ubigeo != null ?
                new ObjectParameter("id_Ubigeo", id_Ubigeo) :
                new ObjectParameter("id_Ubigeo", typeof(string));
    
            var clie_codigoParameter = clie_codigo != null ?
                new ObjectParameter("clie_codigo", clie_codigo) :
                new ObjectParameter("clie_codigo", typeof(string));
    
            var clie_contraParameter = clie_contra != null ?
                new ObjectParameter("clie_contra", clie_contra) :
                new ObjectParameter("clie_contra", typeof(string));
    
            var clie_sexoParameter = clie_sexo != null ?
                new ObjectParameter("clie_sexo", clie_sexo) :
                new ObjectParameter("clie_sexo", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_ActualizarCliente", id_clienteParameter, clie_nomParameter, clie_apePaterParameter, clie_apeMaterParameter, clie_correoParameter, clie_tipoDocumentoParameter, clie_documentoParameter, id_UbigeoParameter, clie_codigoParameter, clie_contraParameter, clie_sexoParameter);
        }
    
        public virtual ObjectResult<usp_ConsultarAdministrador_Result> usp_ConsultarAdministrador(string id_admi)
        {
            var id_admiParameter = id_admi != null ?
                new ObjectParameter("id_admi", id_admi) :
                new ObjectParameter("id_admi", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_ConsultarAdministrador_Result>("usp_ConsultarAdministrador", id_admiParameter);
        }
    
        public virtual ObjectResult<usp_ConsultarCliente_Result> usp_ConsultarCliente(string id_cliente)
        {
            var id_clienteParameter = id_cliente != null ?
                new ObjectParameter("id_cliente", id_cliente) :
                new ObjectParameter("id_cliente", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_ConsultarCliente_Result>("usp_ConsultarCliente", id_clienteParameter);
        }
    
        public virtual int usp_EliminarAdministrador(string id_admi)
        {
            var id_admiParameter = id_admi != null ?
                new ObjectParameter("id_admi", id_admi) :
                new ObjectParameter("id_admi", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_EliminarAdministrador", id_admiParameter);
        }
    
        public virtual int usp_EliminarCliente(string id_cliente)
        {
            var id_clienteParameter = id_cliente != null ?
                new ObjectParameter("id_cliente", id_cliente) :
                new ObjectParameter("id_cliente", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_EliminarCliente", id_clienteParameter);
        }
    
        public virtual int usp_InsertarAdministrador(string admi_nom, string admi_apePater, string admi_apeMater, string admi_codigo, string admi_contra, string admi_dni, string admi_direccion)
        {
            var admi_nomParameter = admi_nom != null ?
                new ObjectParameter("admi_nom", admi_nom) :
                new ObjectParameter("admi_nom", typeof(string));
    
            var admi_apePaterParameter = admi_apePater != null ?
                new ObjectParameter("admi_apePater", admi_apePater) :
                new ObjectParameter("admi_apePater", typeof(string));
    
            var admi_apeMaterParameter = admi_apeMater != null ?
                new ObjectParameter("admi_apeMater", admi_apeMater) :
                new ObjectParameter("admi_apeMater", typeof(string));
    
            var admi_codigoParameter = admi_codigo != null ?
                new ObjectParameter("admi_codigo", admi_codigo) :
                new ObjectParameter("admi_codigo", typeof(string));
    
            var admi_contraParameter = admi_contra != null ?
                new ObjectParameter("admi_contra", admi_contra) :
                new ObjectParameter("admi_contra", typeof(string));
    
            var admi_dniParameter = admi_dni != null ?
                new ObjectParameter("admi_dni", admi_dni) :
                new ObjectParameter("admi_dni", typeof(string));
    
            var admi_direccionParameter = admi_direccion != null ?
                new ObjectParameter("admi_direccion", admi_direccion) :
                new ObjectParameter("admi_direccion", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_InsertarAdministrador", admi_nomParameter, admi_apePaterParameter, admi_apeMaterParameter, admi_codigoParameter, admi_contraParameter, admi_dniParameter, admi_direccionParameter);
        }
    
        public virtual int usp_InsertarCliente(string clie_nom, string clie_apePater, string clie_apeMater, string clie_correo, string clie_tipoDocumento, string clie_documento, string id_Ubigeo, string clie_codigo, string clie_contra, string clie_sexo)
        {
            var clie_nomParameter = clie_nom != null ?
                new ObjectParameter("clie_nom", clie_nom) :
                new ObjectParameter("clie_nom", typeof(string));
    
            var clie_apePaterParameter = clie_apePater != null ?
                new ObjectParameter("clie_apePater", clie_apePater) :
                new ObjectParameter("clie_apePater", typeof(string));
    
            var clie_apeMaterParameter = clie_apeMater != null ?
                new ObjectParameter("clie_apeMater", clie_apeMater) :
                new ObjectParameter("clie_apeMater", typeof(string));
    
            var clie_correoParameter = clie_correo != null ?
                new ObjectParameter("clie_correo", clie_correo) :
                new ObjectParameter("clie_correo", typeof(string));
    
            var clie_tipoDocumentoParameter = clie_tipoDocumento != null ?
                new ObjectParameter("clie_tipoDocumento", clie_tipoDocumento) :
                new ObjectParameter("clie_tipoDocumento", typeof(string));
    
            var clie_documentoParameter = clie_documento != null ?
                new ObjectParameter("clie_documento", clie_documento) :
                new ObjectParameter("clie_documento", typeof(string));
    
            var id_UbigeoParameter = id_Ubigeo != null ?
                new ObjectParameter("id_Ubigeo", id_Ubigeo) :
                new ObjectParameter("id_Ubigeo", typeof(string));
    
            var clie_codigoParameter = clie_codigo != null ?
                new ObjectParameter("clie_codigo", clie_codigo) :
                new ObjectParameter("clie_codigo", typeof(string));
    
            var clie_contraParameter = clie_contra != null ?
                new ObjectParameter("clie_contra", clie_contra) :
                new ObjectParameter("clie_contra", typeof(string));
    
            var clie_sexoParameter = clie_sexo != null ?
                new ObjectParameter("clie_sexo", clie_sexo) :
                new ObjectParameter("clie_sexo", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_InsertarCliente", clie_nomParameter, clie_apePaterParameter, clie_apeMaterParameter, clie_correoParameter, clie_tipoDocumentoParameter, clie_documentoParameter, id_UbigeoParameter, clie_codigoParameter, clie_contraParameter, clie_sexoParameter);
        }
    
        public virtual ObjectResult<usp_HabitacionDisponiblePorTipo_Result> usp_HabitacionDisponiblePorTipo(string id_tipo_habi)
        {
            var id_tipo_habiParameter = id_tipo_habi != null ?
                new ObjectParameter("id_tipo_habi", id_tipo_habi) :
                new ObjectParameter("id_tipo_habi", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_HabitacionDisponiblePorTipo_Result>("usp_HabitacionDisponiblePorTipo", id_tipo_habiParameter);
        }
    
        public virtual ObjectResult<usp_ListarTipoHabitacion_Result> usp_ListarTipoHabitacion()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_ListarTipoHabitacion_Result>("usp_ListarTipoHabitacion");
        }
    
        public virtual ObjectResult<usp_DetalleTipoHabitacion_Result> usp_DetalleTipoHabitacion(string id_tipoHabi)
        {
            var id_tipoHabiParameter = id_tipoHabi != null ?
                new ObjectParameter("id_tipoHabi", id_tipoHabi) :
                new ObjectParameter("id_tipoHabi", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_DetalleTipoHabitacion_Result>("usp_DetalleTipoHabitacion", id_tipoHabiParameter);
        }
    
        public virtual ObjectResult<usp_ListaNombresCliente_Result> usp_ListaNombresCliente()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_ListaNombresCliente_Result>("usp_ListaNombresCliente");
        }
    }
}
