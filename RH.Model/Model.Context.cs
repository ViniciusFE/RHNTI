﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RH.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class RHEntities : DbContext
    {
        public RHEntities()
            : base("name=RHEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Aluno> Aluno { get; set; }
        public virtual DbSet<Avaliacao> Avaliacao { get; set; }
        public virtual DbSet<Beneficio> Beneficio { get; set; }
        public virtual DbSet<CadastroTreinamento> CadastroTreinamento { get; set; }
        public virtual DbSet<Cargo> Cargo { get; set; }
        public virtual DbSet<Curso> Curso { get; set; }
        public virtual DbSet<DadoBancario> DadoBancario { get; set; }
        public virtual DbSet<DadoDependente> DadoDependente { get; set; }
        public virtual DbSet<Demissao> Demissao { get; set; }
        public virtual DbSet<Empresa> Empresa { get; set; }
        public virtual DbSet<Erro> Erro { get; set; }
        public virtual DbSet<Movimentacao> Movimentacao { get; set; }
        public virtual DbSet<Nota> Nota { get; set; }
        public virtual DbSet<Pessoa> Pessoa { get; set; }
        public virtual DbSet<PessoaBeneficio> PessoaBeneficio { get; set; }
        public virtual DbSet<Professor> Professor { get; set; }
        public virtual DbSet<Prova> Prova { get; set; }
        public virtual DbSet<Setor> Setor { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Treinamento> Treinamento { get; set; }
        public virtual DbSet<Vaga> Vaga { get; set; }
    }
}
