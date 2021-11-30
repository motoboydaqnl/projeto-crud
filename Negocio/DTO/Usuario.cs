using System;
using Dapper.Contrib;
using Dapper.Contrib.Extensions;

namespace ProjetoBlazor
{
    //ORM
   [Table("TB_USUARIO")]
    public class Usuario  
    {
        [Key]
        public int USUID {get;set;}
        public string USULOGIN {get;set;}
        public string USUEMAIL {get;set;}
        public string USUNOMECOMPLETO {get;set;}
        public string USUSENHA {get;set;}
        public DateTime USUDATAHORACRIACAO {get;set;}
        public bool USUATIVO {get;set;}
        public string USUCPF {get;set;}
        public string USUTELEFONE {get;set;}
    }
}