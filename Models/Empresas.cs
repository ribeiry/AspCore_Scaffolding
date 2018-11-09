using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AspCore_Scaffolding
{
    public partial class Empresas
    {
        public int IdEmpresa { get; set; }
        [Display(Name= "Nome da Empresa")]
        
        public string NomeEmpresa { get; set; }
        [Display(Name= "Score")]
        public int numero {get; set;}
        [Display(Name= "Cnpj da Empresa")]
        public string cnpjEmpresa { get; set; }
        [Display(Name= "Endereço")]
        public string Endereco { get; set; }
    }
}
