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
    
    public partial class GCC_Peliculas
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public GCC_Peliculas()
        {
            this.GCC_Funciones = new HashSet<GCC_Funciones>();
        }
    
        public int PeliculaId { get; set; }
        public string Titulo { get; set; }
        public string Genero { get; set; }
        public Nullable<int> Duracion { get; set; }
        public Nullable<decimal> Rating { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GCC_Funciones> GCC_Funciones { get; set; }
    }
}
