using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mudandotipodedados
{
    public class MudarTipo
    {
        public decimal valorEmReais{get;set;}
        public decimal valorEmDolares {get;set;} 

        public void ConverterParaDolares(){
            decimal dolares =valorEmReais/6;
            Console.WriteLine($"R${valorEmReais},00 valem ${dolares}");            
        }


    }
}