﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Datos_Distribuidora
{
    using DominioDistribuidora;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class BD_DistribuidoraEntities1 : DbContext
    {
        public BD_DistribuidoraEntities1()
            : base("name=BD_DistribuidoraEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<DetalleParametro> DetalleParametro { get; set; }
        public virtual DbSet<FuncionalidadXPerfil> FuncionalidadXPerfil { get; set; }
        public virtual DbSet<Parametro> Parametro { get; set; }
        public virtual DbSet<PerfilXRol> PerfilXRol { get; set; }
        public virtual DbSet<Usuario> Usuarios { get; set; }
    }
}