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
    
    public partial class Prova
    {
        public int Pro_ID { get; set; }
        public int Pro_Empresa_Emp_ID { get; set; }
        public int Pro_Aluno_Alu_ID { get; set; }
        public System.DateTime Pro_DataInicio { get; set; }
        public System.DateTime Pro_DataFim { get; set; }
        public bool Pro_Situation { get; set; }
    
        public virtual Aluno Aluno { get; set; }
        public virtual Empresa Empresa { get; set; }
    }
}
