/*
################################
MÓDULO:OPERADORES DE ATRIBUIÇÃO
################################
*/

using mudandotipodedados;
MudarTipo valorParaConverter = new MudarTipo();
valorParaConverter.valorEmReais = 500;
valorParaConverter.ConverterParaDolares();

/*
##################################################
Para converter tipos de dados, é necessário utilizar a classe "Convert.To", 
porém é necessário atenção ao fazer isso.
##################################################
*/

string dadoDeString = "TextoDeString";
int dadoDeInteiro = 1;

/*
##################################################
Reatribuindo novo valor para dadoDeInteiro para uma string
##################################################

------------------------------------
dadoDeInteiro = "3"; 
------------------------------------




###########################################################################
Ele acusa de erro, é preciso passar o método Convert.ToString()
###########################################################################

------------------------------------
Convert.ToString(dadoDeInteiro);
------------------------------------



###########################################################################
Também é possível passar diretamente ao declarar a variável
###########################################################################

------------------------------------
int dadoDeInteiro = Convert.ToString("1");
------------------------------------
*/


Convert.ToString(dadoDeInteiro);
Console.WriteLine(dadoDeInteiro);

/*
################################################
Existe outra forma de converter tipos de dados:
utilizando o método parse da classe de dado desejada.
################################################
*/
int.Parse();
float.Parse();
decimal.Parse();
/*
################################################
Contudo, entre o método Parse e a classe Convert,
é preferível a classe Convert, pois ela consegue tratar
valores nulos, ao contrário do método Parse, o qual
acusa um erro ao se deparar com valores nulos.

Detalhe a respeito da conversão de strings:
É possível utilizar o método .ToString() em qualquer tipo de dado,
por exemplo abaixo:
################################################
*/

decimal valorDecimal = 5.3;
string novaString = valorDecimal.ToString();
//novaString = "5.3"

/*
################################################
Isso ocorre porque as variáveis pertencem à classe Object,
a qual engloba todos os tipos de dados e nela existe o método 
ToString() herdado em todos os tipos de dados
################################################

*/

/*
################################################
Casting Implícito:

Em algumas situações não é necessário converter 
explicitamente os tipos de dados, tal como a 
conversão de um tipo string em um tipo int. Tipos 
de dados que suportam pelo menos mesma memória 
que outros tipos, não precisam receber conversão explicitamente.

Por exemplo: 
################################################

int numeroInteiro = 3;
decimal numeroDecimal = numeroInteiro;


################################################
Acima ocorre um casting implícito, pois tipo de 
dado decimal é capaz de suportar no mínimo os 
mesmos valores armazenados pelo tipo int, ou seja, 
todos os números que podem existir em int, podem 
ser representados em decimal, porém, o contrário não ocorre.

Confira:
################################################
*/
decimal numeroDecimal = 4.6;
int numeroInteiro = numeroDecimal

/*
################################################
O exemplo acima não pode ocorrer, pois o tipo de 
dados decimal, pode adotar valores além dos valores 
de int, os quais fogem da representação de int.
################################################


*/