using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace RH.Model
{
    [MetadataType(typeof(MD_DadoDependente))]
    public partial class DadoDependente
    {
        internal class MD_DadoDependente
        {
            [DisplayName("Código Dependente")]
            public int DP_ID { get; set; }

            [DisplayName("Funcionário")]
            [Required(ErrorMessage ="Selecione a quem essa pessoa é dependente")]
            public int DP_Pessoa_Pes_ID { get; set; }

            [DisplayName("Nome")]
            [Required(ErrorMessage = "Digite o nome do dependete")]
            public string DP_Nome { get; set; }

            [DisplayName("Parentesco")]
            [Required(ErrorMessage ="Informe o parentesco que essa pessoa tem com o funcionário")]
            public string DP_Parentesco { get; set; }

            [DisplayName("Situação")]
            public bool DP_Situation { get; set; }

            [DisplayName("Data de Cadastro")]
            public string DP_DataCadastro { get; set; }
        }
    }
}
