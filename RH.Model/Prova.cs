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
    
    public partial class Prova
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Prova()
        {
            this.Erro = new HashSet<Erro>();
            this.Nota = new HashSet<Nota>();
        }
    
        public int Pro_ID { get; set; }
        public int Pro_Professor_Pro_ID { get; set; }
        public int Pro_Aluno_Alu_ID { get; set; }
        public System.DateTime Pro_DataInicio { get; set; }
        public System.DateTime Pro_DataTermino { get; set; }
        public int Pro_Setor1 { get; set; }
        public int Pro_Setor2 { get; set; }
        public int Pro_Setor3 { get; set; }
        public int Pro_Setor4 { get; set; }
        public int Pro_Setor5 { get; set; }
        public int Pro_Cargo1 { get; set; }
        public int Pro_Cargo2 { get; set; }
        public int Pro_Cargo3 { get; set; }
        public int Pro_Cargo4 { get; set; }
        public int Pro_Cargo5 { get; set; }
        public int Pro_Pessoa1 { get; set; }
        public int Pro_Pessoa2 { get; set; }
        public int Pro_Pessoa3 { get; set; }
        public int Pro_Pessoa4 { get; set; }
        public int Pro_Pessoa5 { get; set; }
        public int Pro_DadoDependente1 { get; set; }
        public int Pro_DadoDependente2 { get; set; }
        public int Pro_DadoDependente3 { get; set; }
        public int Pro_DadoDependete4 { get; set; }
        public int Pro_DadoDependete5 { get; set; }
        public int Pro_DadoBancario1 { get; set; }
        public int Pro_DadoBancario2 { get; set; }
        public int Pro_DadoBancario3 { get; set; }
        public int Pro_DadoBancario4 { get; set; }
        public int Pro_DadoBancario5 { get; set; }
        public int Pro_Beneficio1 { get; set; }
        public int Pro_Beneficio2 { get; set; }
        public int Pro_Beneficio3 { get; set; }
        public int Pro_Beneficio4 { get; set; }
        public int Pro_Beneficio5 { get; set; }
        public int Pro_BeneficioFuncionario1 { get; set; }
        public int Pro_BeneficioFuncionario2 { get; set; }
        public int Pro_BeneficioFuncionario3 { get; set; }
        public int Pro_BeneficioFuncionario4 { get; set; }
        public int Pro_BeneficioFuncionario5 { get; set; }
        public int Pro_BenefcioFuncionario6 { get; set; }
        public int Pro_BeneficioFuncionario7 { get; set; }
        public int Pro_BeneficioFuncionario9 { get; set; }
        public int Pro_BeneficioFuncionario8 { get; set; }
        public int Pro_BeneficioFuncionario10 { get; set; }
        public int Pro_AvaliacaoFuncionario1 { get; set; }
        public int Pro_AvaliacaoFuncionario2 { get; set; }
        public int Pro_AvaliacaoFuncionario3 { get; set; }
        public int Pro_AvaliacaoFuncionario4 { get; set; }
        public int Pro_Demissao1 { get; set; }
        public int Pro_Demissao2 { get; set; }
        public int Pro_Demissao3 { get; set; }
        public int Pro_Codigo { get; set; }
        public bool Pro_Situation { get; set; }
        public bool Pro_Entregue { get; set; }
        public int Pro_Vaga1 { get; set; }
        public int Pro_Vaga2 { get; set; }
        public int Pro_Vaga3 { get; set; }
        public int Pro_Vaga4 { get; set; }
        public int Pro_Vaga5 { get; set; }
    
        public virtual Aluno Aluno { get; set; }
        public virtual Avaliacao Avaliacao { get; set; }
        public virtual Avaliacao Avaliacao1 { get; set; }
        public virtual Avaliacao Avaliacao2 { get; set; }
        public virtual Avaliacao Avaliacao3 { get; set; }
        public virtual Beneficio Beneficio { get; set; }
        public virtual Beneficio Beneficio1 { get; set; }
        public virtual Beneficio Beneficio2 { get; set; }
        public virtual Beneficio Beneficio3 { get; set; }
        public virtual Beneficio Beneficio4 { get; set; }
        public virtual Cargo Cargo { get; set; }
        public virtual Cargo Cargo1 { get; set; }
        public virtual Cargo Cargo2 { get; set; }
        public virtual Cargo Cargo3 { get; set; }
        public virtual Cargo Cargo4 { get; set; }
        public virtual DadoBancario DadoBancario { get; set; }
        public virtual DadoBancario DadoBancario1 { get; set; }
        public virtual DadoBancario DadoBancario2 { get; set; }
        public virtual DadoBancario DadoBancario3 { get; set; }
        public virtual DadoBancario DadoBancario4 { get; set; }
        public virtual DadoDependente DadoDependente { get; set; }
        public virtual DadoDependente DadoDependente1 { get; set; }
        public virtual DadoDependente DadoDependente2 { get; set; }
        public virtual DadoDependente DadoDependente3 { get; set; }
        public virtual DadoDependente DadoDependente4 { get; set; }
        public virtual Demissao Demissao { get; set; }
        public virtual Demissao Demissao1 { get; set; }
        public virtual Demissao Demissao2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Erro> Erro { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Nota> Nota { get; set; }
        public virtual Pessoa Pessoa { get; set; }
        public virtual Pessoa Pessoa1 { get; set; }
        public virtual Pessoa Pessoa2 { get; set; }
        public virtual Pessoa Pessoa3 { get; set; }
        public virtual Pessoa Pessoa4 { get; set; }
        public virtual PessoaBeneficio PessoaBeneficio { get; set; }
        public virtual PessoaBeneficio PessoaBeneficio1 { get; set; }
        public virtual PessoaBeneficio PessoaBeneficio2 { get; set; }
        public virtual PessoaBeneficio PessoaBeneficio3 { get; set; }
        public virtual PessoaBeneficio PessoaBeneficio4 { get; set; }
        public virtual PessoaBeneficio PessoaBeneficio5 { get; set; }
        public virtual PessoaBeneficio PessoaBeneficio6 { get; set; }
        public virtual PessoaBeneficio PessoaBeneficio7 { get; set; }
        public virtual PessoaBeneficio PessoaBeneficio8 { get; set; }
        public virtual PessoaBeneficio PessoaBeneficio9 { get; set; }
        public virtual Professor Professor { get; set; }
        public virtual Setor Setor { get; set; }
        public virtual Setor Setor1 { get; set; }
        public virtual Setor Setor2 { get; set; }
        public virtual Setor Setor3 { get; set; }
        public virtual Setor Setor4 { get; set; }
        public virtual Vaga Vaga { get; set; }
        public virtual Vaga Vaga1 { get; set; }
        public virtual Vaga Vaga2 { get; set; }
        public virtual Vaga Vaga3 { get; set; }
        public virtual Vaga Vaga4 { get; set; }
    }
}
