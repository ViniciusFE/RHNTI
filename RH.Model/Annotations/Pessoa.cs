using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace RH.Model
{
    [MetadataType(typeof(MD_Pessoa))]
    public partial class Pessoa
    {
        internal class MD_Pessoa
        {
            [DisplayName("Código Funcionário")]
            public int Pes_ID { get; set; }

            [DisplayName("Nome")]
            [Required(ErrorMessage ="Digite o Nome do funcionário")]
            public string Pes_Nome { get; set; }

            [DisplayName("CPF")]
            [Required(ErrorMessage =("Digite o CPF do funcionário"))]
            public string Pes_CPF { get; set; }

            [DisplayName("Carteira de Trabalho")]
            [Required(ErrorMessage ="Digite a Carteira de Trabalho do funcionário")]
            public string Pes_CTrabalho { get; set; }

            [DisplayName("Salário")]
            public double Pes_Salario { get; set; }

            [DisplayName("Cidade")]
            [Required(ErrorMessage ="Digite a Cidade do funcionário")]
            public string Pes_Cidade { get; set; }

            [DisplayName("Endereço")]
            [Required(ErrorMessage ="Digite o Endereço do funcionário")]
            public string Pes_Endereco { get; set; }

            [DisplayName("Data de Cadastro")]
            public string Pes_DataCadastro { get; set; }

            [DisplayName("Situação")]
            public bool Pes_Situation { get; set; }

            [DisplayName("Cargo do Funcionário")]
            [Required(ErrorMessage ="Selecione o Cargo do funcionário")]
            public int Pes_Cargo_Car_ID { get; set; }

            [DisplayName("Imagem do Funcionário")]
            public byte[] Pes_Imagem { get; set; }
        }
    }
}
