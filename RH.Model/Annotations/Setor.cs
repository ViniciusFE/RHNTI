using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace RH.Model
{
    [MetadataType(typeof(MD_Setor))]
    public partial class Setor
    {
        internal class MD_Setor
        {
            [DisplayName("Código do Setor")]
            public int Set_ID { get; set; }

            //[DisplayName("Nome da Empresa")]
            //public int Set_Empresa_Emp_ID { get; set; }

            [DisplayName("Nome do Setor")]
            [Required(ErrorMessage ="Por favor digite o nome do Setor")]
            public int Set_Nome { get; set; }

            [DisplayName ("Data de Cadastro")]
            [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
            public int Set_DataCadastro { get; set; }

            [DisplayName("Empresa")]
            [Required(ErrorMessage = "Por favor selecione a Empresa")]
            public int Set_Empresa_Emp_ID { get; set; }
        }
    }
}
