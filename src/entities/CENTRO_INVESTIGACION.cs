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
    
    public partial class CENTRO_INVESTIGACION
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CENTRO_INVESTIGACION()
        {
            this.CIENTIFICOS = new HashSet<CIENTIFICOS>();
            this.DIRECTORES = new HashSet<DIRECTORES>();
            this.RESPONSABLES_TECNICOS = new HashSet<RESPONSABLES_TECNICOS>();
            this.RECURSOS_TECNOLOGICOS = new HashSet<RECURSOS_TECNOLOGICOS>();
        }
    
        public int id_centro_investigacion { get; set; }
        public string nombre { get; set; }
        public string sigla { get; set; }
        public string direccion { get; set; }
        public System.DateTime fecha_hora_inicio { get; set; }
        public string email { get; set; }
        public string actividad { get; set; }
        public string reglamento { get; set; }
        public Nullable<int> tiempo_antelacion { get; set; }
        public int id_facultad { get; set; }
        public Nullable<System.DateTime> fecha_baja { get; set; }
        public string motivo_baja { get; set; }
    
        public virtual FACULTADES FACULTADES { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CIENTIFICOS> CIENTIFICOS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIRECTORES> DIRECTORES { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RESPONSABLES_TECNICOS> RESPONSABLES_TECNICOS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RECURSOS_TECNOLOGICOS> RECURSOS_TECNOLOGICOS { get; set; }
    }
}
