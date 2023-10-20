using System;

Console.WriteLine("Saída de dados : Formatação");
Console.WriteLine();

int idade = 25;
string nome = "Maria";

//Escreva na mesma linha "Maria tem 25 anos"
Console.Write(nome);
Console.Write(" tem ");
Console.Write(idade);
Console.Write(" anos");
Console.WriteLine();
Console.WriteLine("----------------");

Console.WriteLine("Concatenação");
//usar a concatenação : usando o operador +
Console.WriteLine(nome + " tem " + idade + " anos");
Console.WriteLine("----------------");

Console.WriteLine("Interpolação");
//usa a interpolação de strings : $ -> a interpolaçao no inicio e coloca as variavéis entre {}
Console.WriteLine($"{nome} tem {idade} anos");
Console.WriteLine("----------------");

//usar place holders : usa {} com numeração com início em zero
Console.WriteLine("Place holders");
Console.WriteLine("{0} tem {1} anos", nome, idade);
Console.ReadLine();

