//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Gestión_de_Recursos_Tecnológicos.src.entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class ESTADOS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ESTADOS()
        {
            this.HISTORIALES_RECURSOS_TECNOLOGICOS = new HashSet<HISTORIALES_RECURSOS_TECNOLOGICOS>();
            this.HISTORIALES_TURNOS = new HashSet<HISTORIALES_TURNOS>();
        }
    
        public int id_estado { get; set; }
        public int id_ambito { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
    
        public virtual AMBITOS AMBITOS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HISTORIALES_RECURSOS_TECNOLOGICOS> HISTORIALES_RECURSOS_TECNOLOGICOS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HISTORIALES_TURNOS> HISTORIALES_TURNOS { get; set; }
    }
}