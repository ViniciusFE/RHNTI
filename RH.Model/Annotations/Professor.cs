using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace RH.Model
{
    [MetadataType(typeof(MD_Professor))]
    public partial class Professor
    {
        internal class MD_Professor
        {
            [DisplayName("Código do Professor")]
            public int Pro_ID { get; set; }

            [DisplayName("Nome")]
            [Required(ErrorMessage ="Digite o nome do professor")]
            public string Pro_Nome { get; set; }

            [DisplayName("Email")]
            [Required(ErrorMessage ="Digite o email do professor")]
            [EmailAddress(ErrorMessage ="O email está em um formato inválido")]
            public string Pro_Email { get; set; }

            [DisplayName("Senha")]
            [Required(ErrorMessage ="Digite a senha do professor")]
            [DataType(DataType.Password)]
            public string Pro_Senha { get; set; }

            [DisplayName("Situação do professor")]
            public bool Pro_Situation { get; set; }

        }
    }
}
