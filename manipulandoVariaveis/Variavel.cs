using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;

namespace variavel
{
    public class Variavel
    {
        public string variavelMutavel {get; set;}

        public void MostrarConteudo(){
            Console.WriteLine($"{variavelMutavel}");
        }
        
    }
}