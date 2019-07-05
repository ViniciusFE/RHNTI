using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace RH.Model
{
    [MetadataType(typeof(MD_Cargo))]
    public partial class Cargo
    {
        internal class MD_Cargo
        {
            [DisplayName("Código")]
            public int Car_ID { get; set; }

            [DisplayName("Setor do cargo")]
            [Required(ErrorMessage ="Selecione o cargo do setor")]
            public int Car_Setor_Set_ID { get; set; }

            [DisplayName("Nome do cargo")]
            [Required(ErrorMessage ="Digite o nome do setor")]
            public string Car_Nome { get; set; }

            [DisplayName("Data de Cadastro")]
            public string Car_DataCadastro { get; set; }

            [DisplayName("Situação do Cargo")]
            public bool Car_Situation { get; set; }
        }
    }
}
