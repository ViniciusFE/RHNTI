using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace RH.Model
{
    [MetadataType(typeof(MD_Beneficio))]
    public partial class Beneficio
    {
        internal class MD_Beneficio
        {
            [DisplayName("Código")]
            public int Ben_ID { get; set; }

            [DisplayName("Nome do Benefício")]
            [Required(ErrorMessage =("Digite o nome do benefício"))]
            public string Ben_Nome { get; set; }

            [DisplayName("Descrição")]
            [Required(ErrorMessage =("Digite a descrição do benefício"))]
            public string Ben_Descricao { get; set; }

            [DisplayName("Custo")]
            [Required(ErrorMessage =("Informe o custo do benefício"))]
            public double Ben_Custo { get; set; }

            [DisplayName("Situação")]
            public bool Ben_Situation { get; set; }

            [DisplayName("Data de Cadastro")]
            public System.DateTime Ben_DataCadastro { get; set; }

            [DisplayName("Nome da Empresa")]
            public int Ben_Empresa_Emp_ID { get; set; }
        }
    }
}
