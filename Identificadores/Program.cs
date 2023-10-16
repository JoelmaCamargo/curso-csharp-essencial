Console.WriteLine("Definindo Identificadores");
//um identificador é um nome que você atribui a um tipo (classe, interface, struct, record, delegate ou enum),
//membro, propriedade, variável ou namespace.
//Uma boa prática é utilizar nomes significativos que permitam inferir o propósito do identificador.
//Ex: calculoDoImpostoIcms, valorTotalComDesconto, dataVencimentoFatura
//Não criar identificadoes usando o mesmo nome mas alternando o uso de maiúsculas e minúsculas.
//Ex: valorTotal, ValorTotal, Valor_Total, valortotal
//case sensitive: significa que é sensível a letras maiúsculas e minúsculas, ou seja, a mesma letra 
//maiúscula e minúscula é considerada diferente(o código fica confuso).

//Regras gerais para identificadores válidos
//devem começar com letra ou sublinhado(_)
//não pdoem iniciar com um número ou caracteres especiais : #$@%&()!=+-*
//não podem conter espaços
//podem usar caracteres Unicode: pre\u00E7o (\u00E7 -> ç) (válido mas não recomendado)
//não pode ser uma palavra reservada da linguagem: if, int, double, string class
//não pode exceder 512 caracteres

Console.WriteLine();

//identificadores válidos
string nome;
string nomeCompleto;
int idade;
int _valor;
int idade1;

//identificadores inválidos
//int 5idade,
//int $valor;
//int valor#total;
//string nome Completo;

//para nome de variáveis : camel case
string descontoTotal;
string desconto_Total;

Console.WriteLine();

//constantes : maiúsculas
double PI = 3.14;
string PREFIXO = "11";
string PREFIXO_SP = "11";

Console.ReadLine();

//para nome de classe e métodos : pascal case

//Camel Case: a primeira letra da primeira palavra é iniciada com minúscula. A letra de cada palavra seguinte deve ser 
//iniciada com maiúscula(não deve haver espaços entre as palavras)
//Ex: valorDoDesconto, nomeCompleto, valorDoImpostoSobreServico
//usado em nome de variáveis, parâmetros e campos internos privados
//Pascal Case: a primeira letra de cada palavra é iniciada com maiúscula.
//Ex: CalculaImpostoDeRenda, ValorDoDesconto, NomeCompleto
//usado em nomes de classes, métodos, interfaces, propriedades
//Constantes - usar letras maiúsculas.
//Ex: PI, DESCONTO, VALOR, IMPOSTO, PESSOA_FISICA
//Sublinhado(_) - usado para campos internos privados e somente leitura (camel case)
//Ex: _valorTotal, _calculoImposto, _precoComDesconto

