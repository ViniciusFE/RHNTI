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
            [DisplayName("Código do cargo")]
            public int Car_ID { get; set; }

            [DisplayName("Código do setor")]
            public int Car_Setor_Set_ID { get; set; }

            [DisplayName("Cargo chefe")]
            public int Car_Cargo_Car_ID { get; set; }

            [DisplayName("Nome do cargo")]
            [Required(ErrorMessage = "Por favor preencha o nome do cargo")]
            public string Car_Nome { get; set; }

            [DisplayName("Data de cadastro")]
            [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
            public System.DateTime Car_DataCadastro { get; set; }

            [DisplayName("Situação do cargo")]
            public bool Car_Situation { get; set; }
            
        }
    }
}
