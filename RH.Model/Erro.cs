//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RH.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Erro
    {
        public int Err_ID { get; set; }
        public int Err_Prova_Pro_ID { get; set; }
        public string Err_RespostaCerta { get; set; }
        public string Err_RespostaAluno { get; set; }
        public string Erro_Tipo { get; set; }
    
        public virtual Prova Prova { get; set; }
    }
}
