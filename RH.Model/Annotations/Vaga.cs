using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace RH.Model
{
    [MetadataType(typeof(MD_Vaga))]
    public partial class Vaga
    {
        internal class MD_Vaga
        {
            [DisplayName("Código da Vaga")]
            [Required(ErrorMessage ="Digite o código da Vaga")]
            public int Vag_ID { get; set; }

            [DisplayName("Cargo")]
            [Required(ErrorMessage ="Selecione a vaga para a vaga")]
            public int Vag_Cargo_Car_ID { get; set; }

            [DisplayName("Descrição")]
            [Required(ErrorMessage ="Faça uma descrição da vaga")]
            public string Vag_Descricao { get; set; }

            [DisplayName("Data de Cadastro")]
            public string Vag_DataCadastro { get; set; }

            [DisplayName("Situação da Vaga")]
            public bool Vag_Situation { get; set; }

            [DisplayName("Título da Vaga")]
            [Required(ErrorMessage ="Digite o título da vaga")]
            public string Vag_Titulo { get; set; }

            [DisplayName("Vaga preenchida")]
            public bool Vag_Preenchida { get; set; }
        }
    }
}
