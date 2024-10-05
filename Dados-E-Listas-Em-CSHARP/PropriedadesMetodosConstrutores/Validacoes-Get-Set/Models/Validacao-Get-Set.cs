using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace ValidacaoGetSet.Models
{
    public class ValidacaoDeValoresValidado
    {
        private string _propriedadevalidada;
        public string PropriedadeValidada 
        {
            get{
                return _propriedadevalidada; 
            }
            set{
                if(value == ""){
                    throw new ArgumentException("O valor não pode ser vazio");
                }
                _propriedadevalidada = value;
            }
        }
    }
}

/*
####################################################################
MÓDULO: VALIDAÇÃO DE VALORES
####################################################################

namespace ValidacaoGetSet.Models
{
    public class Validacao
    {
        public string Propriedade {get;set}
    }
}

####################################################################
O código acima define uma classe Validacao com uma propriedade "Propriedade".    
Essa propriedade recebe o "get" e o "set", os quais definem a ação de resgatar e atribuir, respectivamente.
A ação de "set" atribui valores à propriedade "Propriedade", quaisquer valores são aceitos.

Para estabelecer limites de atribuição à propriedade, ou seja, não atribuir qualquer valor, 
tais como caracteres especiais ou vazio, é necessário fazer a validação dos valores repassados pelo usuário.

O código abaixo faz isso:
####################################################################

namespace ValidacaoGetSet.Models
{
    public class ValidacaoDeValores
    {
        private string _propriedadeValidadaPrivada;
        public string Propriedade 
        {
            get
            {
                return _propriedadeValidadaPrivada; 
            }
            set
            {
                if(value == "")
                {
                    throw new ArgumentException("O valor não pode ser vazio");
                }
                _propriedadeValidadaPrivada = value;
            }
        }
    }
}



/*

####################################################################################
O código acima apresenta limitações quanto aos valores repassado para a propriedade "Propriedade". 

A ação "set" recebe uma condicional "IF" com parâmetro de string vazia, a qual, ao ser
encaixada, irá disparar uma exceção de argumento escrito "O valor não pode ser vazio". 
Caso a condição não seja encontrada, o valor recebido nesta propriedade será atribuído
 ao campo _propriedadeValidadaPrivada, o qual é um campo privado.

A ação "get" ocorre ao resgatar o valor da propriedade em algum lugar com interpolação.
Então, ao acionarmos o "get" quando referenciamos a propriedade "Propriedade", o valor 
retornado será do campo "_propriedadeValidadaPrivada".


Essas validações são chamadas Encapsulamento.


Vale a pena lembrar que "public" e "private" gerenciam o acesso de modificação de campos,
propriedades ou classes. 

Esses dois statements garantem que a modificação dos campos ocorram somente através da 
classe onde o campo ou propriedade estão contidos. Assim é inválido:
####################################################################################


InstanciaDaClasse._propriedadevalidada = 'adadadada';

        #################
        Corrigindo abaixo:
        #################

InstanciaDaClasse.Propriedade = 'adadadadadada'



########################################################################################
A validação de inteiros segue a mesma ideia:
########################################################################################

namespace ValidacaoGetSet.Models
{
    public class ValidacaoDeValores
    {
        private int _propriedadeValidadaPrivada;
        public int Propriedade 
        {
            get
            {
                return _propriedadeValidadaPrivada; 
            }
            set
            {
                if(value < 0)
                {
                    throw new ArgumentException("A idade não pode ser Zero!");
                }
                _propriedadeValidadaPrivada = value;
            }
        }
    }
}





/*

########################################################################################
Body expressions são formas de enxugar o códigos simples, segue abaixo:
########################################################################################

namespace ValidacaoDeValores.models
{
    public class ValoresValidados
    {
        private int _propriedadeValidada;
        public int ValorValidado
        {
            get=> return _propriedadeValidada;
            set
            {
                if(value == ""){                {
                throw new ArgumentException("Blablablabla")
                }
                _propriedadeValidada = value
            }
        }
    }
}

*/





/*
REFERÊNCIAS DE MÉTODOS E CLASSES:
ToUpper();
Convert.ToInt32()
Convert.ToInt64()
Convert.ToFloat()
Convert.ToString()
Convert.ToDecimal()
Convert.ToChar()
Convert.ToDateTime()
Convert.ToBoolean()
Convert.ToDouble()
Convert.ToInt32()
Convert.ToInt32()
int.Parse();
decimal.Parse();
double.Parse();
float.Parse();
*/
