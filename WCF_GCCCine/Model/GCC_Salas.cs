//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WCF_GCCCine.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class GCC_Salas
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public GCC_Salas()
        {
            this.GCC_Funciones = new HashSet<GCC_Funciones>();
            this.GCC_Sillas = new HashSet<GCC_Sillas>();
        }
    
        public int SalaId { get; set; }
        public string Nombre { get; set; }
        public string Location { get; set; }
        public Nullable<int> Capacidad { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GCC_Funciones> GCC_Funciones { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GCC_Sillas> GCC_Sillas { get; set; }
    }
}
