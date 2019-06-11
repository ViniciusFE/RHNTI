using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace RH.Model
{
    [MetadataType(typeof(MD_Empresa))]
    public partial class Empresa
    {
        internal class MD_Empresa
        {
            [DisplayName("Código da Empresa")]
            public int Emp_ID { get; set; }

            [DisplayName("Dono da Empresa")]
            public int Emp_Aluno_Alu_ID { get; set; }

            [DisplayName("Nome da Empresa")]
            [Required(ErrorMessage = "Por favor digite o nome da empresa")]
            public string Emp_Nome { get; set; }

            [DisplayName("Estado")]
            [Required(ErrorMessage = "Por favor selecione o estado da empresa")]
            public string Emp_Estado { get; set; }

            [DisplayName("Cidade")]
            [Required(ErrorMessage = "Por favor digite a cidade da empresa")]
            public string Emp_Cidade { get; set; }

            [DisplayName("Endereço")]
            [Required(ErrorMessage = "Por favor digite o endereço da empresa")]
            public string Emp_Endereco { get; set; }

            [DisplayName("CNPJ")]
            [Required(ErrorMessage = "Por favor digite o CNPJ da empresa")]
            public string Emp_CNPJ { get; set; }

            [DisplayName("Registro Estadual")]
            [Required(ErrorMessage = "Por favor digite o Registro Estadual da Empresa")]
            public string Emp_RegistroEstadual { get; set; }

            [DisplayName("Data de cadastro")]
            public System.DateTime Emp_DataCadastro { get; set; }

            [DisplayName("Data atual")]
            public System.DateTime Emp_DataAtual { get; set; }

            [DisplayName("Situação da Empresa")]
            public bool Emp_Situation { get; set; }

            [DisplayName("Logo da empresa")]
            public byte[] Emp_Logo { get; set; }
        }
    }
}
