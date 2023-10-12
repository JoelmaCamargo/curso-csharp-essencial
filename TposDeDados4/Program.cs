Console.WriteLine("Definindo variáveis do tipo string, object e dynamic");
Console.WriteLine();

string nome = "Curso C#";
String titulo = "Curso C# Essencial";

Console.WriteLine(nome);
Console.WriteLine(titulo);

Console.ReadLine();

//as strings são imutáveis, significa que uma vez que você declarar e atribuir um valor a uma variável do 
//tipo string, ela não pode ser alterada.

string valor = "Isto é uma string";
valor = "Isto é uma string alterada";
valor = "teste";

//para trabalhar com textos e realizar muitas alterações, não é recomendável usar o tipo string, para isso, usa-se a
//StringBuilder 

//o tipo object funciona suporta todos os tipos de dados
object nota = 10;
object valor1 = 8.55m;
object nome1 = "Maria";
object ativa = true;
object letra = 'A';

//poderia definir como dynamic também os object - dynamic é útil quando precisamos usar recursos avançados como
//Reflection ou usar recursos das linguagens dinâmicas através do Dynamic Language Runtime(DLR).

Console.WriteLine(nota);
Console.WriteLine(valor1);
Console.WriteLine(nome1);
Console.WriteLine(ativa);
Console.WriteLine(letra);

Console.ReadLine();




