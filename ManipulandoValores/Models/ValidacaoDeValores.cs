using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

/*
####################################################################
MÓDULO: VALIDAÇÃO DE VALORES
####################################################################
*/

namespace ManipulandoValores.Models
{
    public class ValidacaoDeValores
    {
        public string Propriedade {get;set}
    }
}
/*
####################################################################

O código acima define uma classe ValidadeDeValores com uma propriedade "Propriedade".
Essa propriedade recebe o "get" e o "set", os quais definem a ação de resgatar e atribuir, respectivamente.
A ação de "set" atribui valores à propriedade "Propriedade", quaisquer valores são aceitos.

Para estabelecer limites de atribuição à propriedade, ou seja, não atribuir qualquer valor, tais como caracteres especiais ou vazio, é necessário fazer a validação dos valores repassados pelo usuário.
O código abaixo faz isso:
####################################################################




*/

namespace ManipulandoValores.Models
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
                value = _propriedadevalidada;
            }
        }
    }
}
/*

####################################################################################
O código acima apresenta limitações quanto aos valores repassado para a propriedade
PropriedadeValidada. A ação "set" recebe uma condicional com parâmetro de string vazia,
a qual, ao ser encaixada, irá disparar uma exceção de argumento escrito "O valor não 
pode ser vazio". Caso a condição não seja encontrada, o valor recebido nesta propriedade
será atribuído à outra propriedade _propriedadevalidada, a qual é uma propriedade privada.

A ação "get" ocorre ao resgatar o valor da propriedade em algum lugar com interpolação
então, ao acionarmos o "get", o valor retornado será da propriedade "_propriedadevalidada"
####################################################################################

************************************************************************************
************************************************************************************

*/