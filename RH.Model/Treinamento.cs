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
    
    public partial class Treinamento
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Treinamento()
        {
            this.CadastroTreinamento = new HashSet<CadastroTreinamento>();
        }
    
        public int Tre_ID { get; set; }
        public int Tre_Empresa_Emp_ID { get; set; }
        public string Tre_Nome { get; set; }
        public string Tre_Descricao { get; set; }
        public System.DateTime Tre_DataInicio { get; set; }
        public System.DateTime Tre_DataFim { get; set; }
        public bool Tre_Situation { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CadastroTreinamento> CadastroTreinamento { get; set; }
        public virtual Empresa Empresa { get; set; }
    }
}
