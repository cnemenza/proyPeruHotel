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
    
    public partial class CLIENTE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CLIENTE()
        {
            this.RESERVA = new HashSet<RESERVA>();
        }
    
        public string id_cliente { get; set; }
        public string clie_nom { get; set; }
        public string clie_apePater { get; set; }
        public string clie_apeMater { get; set; }
        public string clie_correo { get; set; }
        public string clie_codigo { get; set; }
        public string clie_contra { get; set; }
        public string clie_sexo { get; set; }
        public string clie_estado { get; set; }
        public string id_Ubigeo { get; set; }
        public string clie_telefono { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RESERVA> RESERVA { get; set; }
        public virtual UBIGEO UBIGEO { get; set; }
    }
}
