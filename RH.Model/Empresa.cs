//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class Empresa
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Empresa()
        {
            this.Beneficio = new HashSet<Beneficio>();
            this.Setor = new HashSet<Setor>();
            this.Treinamento = new HashSet<Treinamento>();
        }
    
        public int Emp_ID { get; set; }
        public int Emp_Aluno_Alu_ID { get; set; }
        public string Emp_Nome { get; set; }
        public string Emp_Estado { get; set; }
        public string Emp_Cidade { get; set; }
        public string Emp_Endereco { get; set; }
        public string Emp_CNPJ { get; set; }
        public string Emp_RegistroEstadual { get; set; }
        public System.DateTime Emp_DataCadastro { get; set; }
        public System.DateTime Emp_DataAtual { get; set; }
        public bool Emp_Situation { get; set; }
        public byte[] Emp_Logo { get; set; }
        public bool Emp_Avaliativa { get; set; }
    
        public virtual Aluno Aluno { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Beneficio> Beneficio { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Setor> Setor { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Treinamento> Treinamento { get; set; }
    }
}
