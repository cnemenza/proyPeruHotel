//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WCF_Hotel
{
    using System;
    using System.Collections.Generic;
    
    public partial class ADMINISTRADOR
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ADMINISTRADOR()
        {
            this.HOTEL = new HashSet<HOTEL>();
        }
    
        public string id_admi { get; set; }
        public string admi_nom { get; set; }
        public string admi_apePater { get; set; }
        public string admi_apeMater { get; set; }
        public string admi_codigo { get; set; }
        public string admi_contra { get; set; }
        public string admi_dni { get; set; }
        public string admi_direccion { get; set; }
        public string admi_estado { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HOTEL> HOTEL { get; set; }
    }
}
