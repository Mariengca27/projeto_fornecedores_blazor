using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace fornecedores.Models
{
    public class Cliente{

    public int Id { get; set; }

    public string Nome { get; set; } = string.Empty;
   public string Telefone { get; set; }= string.Empty;
   
    public int MaterialId{get;set;}
 
    public Material Material { get; set; } = new Material();
}


}