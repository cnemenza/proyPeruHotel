//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class vw_VistaReserva
    {
        public string id_reserva { get; set; }
        public System.DateTime reser_fechaIngreso { get; set; }
        public System.DateTime reser_fechaReser { get; set; }
        public Nullable<System.DateTime> reser_fechaSalida { get; set; }
        public string id_cliente { get; set; }
        public string Nombre { get; set; }
        public Nullable<int> Cant_Hab { get; set; }
        public Nullable<decimal> Total { get; set; }
        public Nullable<int> Cant_Dias { get; set; }
        public Nullable<decimal> Monto_hab { get; set; }
        public Nullable<decimal> Monto_servicio { get; set; }
        public string estado { get; set; }
    }
}
