//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DominioDistribuidora
{
    using System;
    using System.Collections.Generic;
    
    public partial class PerfilXRol
    {
        public int Id_PerfilXRol { get; set; }
        public long FK_DetalleParametro_Rol { get; set; }
        public long FK_DetalleParametro_Perfil { get; set; }
        public bool estado_PerfilXRol { get; set; }
    
        public virtual DetalleParametro DetalleParametro { get; set; }
        public virtual DetalleParametro DetalleParametro1 { get; set; }
    }
}
