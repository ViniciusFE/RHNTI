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
    
    public partial class Vaga
    {
        public int Vag_ID { get; set; }
        public int Vag_Cargo_Car_ID { get; set; }
        public string Vag_Descricao { get; set; }
        public System.DateTime Vag_DataCadastro { get; set; }
        public System.DateTime Vag_DataTermino { get; set; }
        public bool Vag_Situation { get; set; }
    
        public virtual Cargo Cargo { get; set; }
    }
}
