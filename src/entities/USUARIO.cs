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
    
    public partial class USUARIO
    {
        public string usuario1 { get; set; }
        public string contraseña { get; set; }
        public int id_estado { get; set; }
    
        public virtual ESTADO ESTADO { get; set; }
    }
}
