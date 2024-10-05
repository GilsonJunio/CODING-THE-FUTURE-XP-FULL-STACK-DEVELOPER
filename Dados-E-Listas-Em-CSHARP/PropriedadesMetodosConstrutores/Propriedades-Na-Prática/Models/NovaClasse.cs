using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PropriedadesMetodosConstrutores
{

    public class NovaClasse
    {
        public string propriedadeString {get;set;}
        public int propriedadeInt{get;set;}
        public decimal propriedadeDecimal {get;set;}
        public float propriedadeFloat {get;set;}
        public long propriedadeLong {get;set;}
        public char propriedadeChar {get;set;}
        public bool propriedadeBool {get;set;}

    }
    
    public void metodo()
    {
    
    }
}

/*

################################################################
MÓDULO: PROPRIEDADES, MÉTODOS E CONSTRUTORES
################################################################

Para definir uma propriedade no C#, faça da forma abaixo:
################################################################


public class NovaClasse
{
    public string propriedadeString {get;set;}
    public int propriedadeInt{get;set;}
    public decimal propriedadeDecimal {get;set;}
    public float propriedadeFloat {get;set;}
    public long propriedadeLong {get;set;}
    public char propriedadeChar {get;set;}
    public bool propriedadeBool {get;set;}

}




################################################################
As propriedades são definidas dentro das classes e seguem a estrutura:
################################################################

public tipodedado nomeDaPropriedade {get;set;}


################################################################
Para criar um método em C#, siga a estrutura abaixo:
################################################################

public void metodo()
{
    
}


################################################################
É importante relembrar que os métodos existem dentro das classes.
Então ao final temos a seguinte estrutura:
################################################################


    public class NovaClasse
    {
        public string propriedadeString {get;set;}
        public int propriedadeInt{get;set;}
        public decimal propriedadeDecimal {get;set;}
        public float propriedadeFloat {get;set;}
        public long propriedadeLong {get;set;}
        public char propriedadeChar {get;set;}
        public bool propriedadeBool {get;set;}

    }
    
    public void metodo()
    {
    
    }
*/




