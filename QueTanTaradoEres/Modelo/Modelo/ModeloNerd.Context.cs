﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Modelo.Modelo
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class QueTanTaradoEresEntities : DbContext
    {
        public QueTanTaradoEresEntities()
            : base("name=QueTanTaradoEresEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<PAR_Partidas> PAR_Partidas { get; set; }
        public virtual DbSet<PRE_Preguntas> PRE_Preguntas { get; set; }
        public virtual DbSet<REP_RespuestasPreguntas> REP_RespuestasPreguntas { get; set; }
        public virtual DbSet<RES_Respuestas> RES_Respuestas { get; set; }
        public virtual DbSet<REU_RespuestasUsuarios> REU_RespuestasUsuarios { get; set; }
        public virtual DbSet<USP_UsuariosPartidas> USP_UsuariosPartidas { get; set; }
        public virtual DbSet<USU_Usuarios> USU_Usuarios { get; set; }
    }
}