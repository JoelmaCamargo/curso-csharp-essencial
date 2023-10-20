Console.WriteLine("Saída de dados : Usando sequência de escapes\n");

//string local = "c: \dados\poesias.txt"; //a barra \ invertida na linguagem C# é considerado um caracter escape inválido;

string local = "c: \\dados\\poesias.txt";
Console.WriteLine(local);
Console.WriteLine();

//string frase = "Ele falou : "Não fui eu""; //não podemos usar "" dentro de "" e para resolver podemos usar a sequência de escapes
//são combinações de caracteres consistindo de uma barra invertida(\) seguida por uma letra ou por uma combinação de dígitos.

string frase = "Ele falou : \"Não fui eu\"";
Console.WriteLine(frase);
Console.WriteLine();

string pizza = "\nPizza\nde\nMussarela\n";
string bolo = "\nBolo\tde\tchocolate";
Console.WriteLine(pizza);
Console.WriteLine(bolo);

Console.ReadLine();
