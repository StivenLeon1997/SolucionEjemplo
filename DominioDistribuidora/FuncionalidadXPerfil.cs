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
    
    public partial class FuncionalidadXPerfil
    {
        public int Id_FuncionalidadXPerfil { get; set; }
        public long Fk_DetalleParametro_Perfil { get; set; }
        public long FK_DetalleParametro_Funcionalidad { get; set; }
        public bool Estado_FuncionalidadXPerfil { get; set; }
    
        public virtual DetalleParametro DetalleParametro { get; set; }
        public virtual DetalleParametro DetalleParametro1 { get; set; }
    }
}
