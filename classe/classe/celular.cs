using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Classe
{
    public class Celular
    {
        public int altura {get; set;}
        public int largura {get; set;}
        public string x {get; set;}

        public void BemVindo(){
            x = "x";
            Console.WriteLine($"A tela tem tamanho {largura}{x}{altura}!");
        }
    }
}