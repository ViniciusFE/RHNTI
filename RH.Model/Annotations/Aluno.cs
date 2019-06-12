using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace RH.Model
{
    [MetadataType(typeof(MD_Aluno))]
    public partial class Aluno
    {
        internal class MD_Aluno
        {

            [DisplayName("Nome")]
            [Required(ErrorMessage = "Por favor informe seu nome")]
            public string Alu_Nome { get; set; }


            [DisplayName("Matrícula")]
            [Required(ErrorMessage = "Por favor informe sua matrícula")]
            public int Alu_Matricula { get; set; }

            [DisplayName("Série")]
            [Required(ErrorMessage = "Por favor informe sua série")]
            public int Alu_Serie { get; set; }

            [DisplayName("Email")]
            [Required(ErrorMessage = "Por favor informe seu email")]
            [DataType(DataType.EmailAddress, ErrorMessage = "Errou", ErrorMessageResourceName = "Errou")]
            public string Alu_Email { get; set; }

            [DisplayName("Senha")]
            [Required(ErrorMessage = "Por favor informe uma senha")]
            [DataType(DataType.Password)]
            public string Alu_Senha { get; set; }



        }
    }
}
