using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace RH.Model
{
    [MetadataType(typeof(MD_DadoBancario))]
    public partial class DadoBancario
    {
        internal class MD_DadoBancario
        {
            [DisplayName("Código")]
            public int DB_ID { get; set; }

            [DisplayName("Funcionário")]
            public int DB_Pessoa_Pes_ID { get; set; }

            [DisplayName("Tipo de dado bancário")]
            [Required(ErrorMessage ="Selecione o tipo do dado bancário")]
            public string DB_Tipo { get; set; }

            [DisplayName("Número")]
            [Required(ErrorMessage ="Informe o número do dado bancário")]
            public string DB_Numero { get; set; }

            [DisplayName("Data de Cadastro")]
            public string DB_DataCadastro { get; set; }

            [DisplayName("Situação")]
            public bool DB_Situation { get; set; }

        }
    }
}
