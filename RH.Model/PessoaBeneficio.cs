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
    
    public partial class PessoaBeneficio
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PessoaBeneficio()
        {
            this.Prova = new HashSet<Prova>();
            this.Prova1 = new HashSet<Prova>();
            this.Prova2 = new HashSet<Prova>();
            this.Prova3 = new HashSet<Prova>();
            this.Prova4 = new HashSet<Prova>();
            this.Resposta = new HashSet<Resposta>();
            this.Resposta1 = new HashSet<Resposta>();
            this.Resposta2 = new HashSet<Resposta>();
            this.Resposta3 = new HashSet<Resposta>();
            this.Resposta4 = new HashSet<Resposta>();
        }
    
        public int PB_ID { get; set; }
        public int PB_Pessoa_Pes_ID { get; set; }
        public int PB_Beneficio_Ben_ID { get; set; }
        public System.DateTime PB_DataCadastro { get; set; }
        public bool PB_Situation { get; set; }
    
        public virtual Beneficio Beneficio { get; set; }
        public virtual Pessoa Pessoa { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Prova> Prova { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Prova> Prova1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Prova> Prova2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Prova> Prova3 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Prova> Prova4 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Resposta> Resposta { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Resposta> Resposta1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Resposta> Resposta2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Resposta> Resposta3 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Resposta> Resposta4 { get; set; }
    }
}
