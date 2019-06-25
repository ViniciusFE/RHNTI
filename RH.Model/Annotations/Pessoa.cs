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
            [DisplayName("Código do Funcionário")]
            public int Pes_ID { get; set; }

            [DisplayName("Nome")]
            [Required(ErrorMessage = "Por favor digite o nome do funcionário")]
            public string Pes_Nome { get; set; }

            [DisplayName("CPF")]
            [Required(ErrorMessage = "Por favor digite o cpf do funcionário")]
            public string Pes_CPF { get; set; }

            [DisplayName("Carteria de Trabalho")]
            [Required(ErrorMessage = "Por favor digite a carteira de trabalho do funcionário")]
            public string Pes_CTrabalho { get; set; }

            [DisplayName("Salário")]
            [Required(ErrorMessage = "Por favor digite o salário do funcionário")]
            public double Pes_Salario { get; set; }

            [DisplayName("Cidade")]
            [Required(ErrorMessage = "Por favor digite a cidade do funcionário")]
            public string Pes_Cidade { get; set; }

            [DisplayName("Endereço")]
            [Required(ErrorMessage = ("Por favor digite o endereço do funcionário"))]
            public string Pes_Endereco { get; set; }

            [DisplayName("Data de admissão")]
            public System.DateTime Pes_DataAdmissao { get; set; }

            [DisplayName("Situação")]
            public bool Pes_Situation { get; set; }

            [DisplayName("Cargo do Funcionário")]
            [Required(ErrorMessage = "Por favor selecione o cargo de ocupação do funcionário")]
            public int Pes_Cargo_Car_ID { get; set; }

            [DisplayName("Imagem do funcionário")]
            public byte[] Pes_Imagem { get; set; }
        }
    }
}
