Console.WriteLine("## Nullable Types ##\n");

//Um nullable type é um tipo de valor que pode receber um valor null
//Tipos Anuláveis permitem atribuir um valor null a um tipo de valor
//Nullable<T> <nome> = null; (T = int, double, float, bool, etc.)
//Os Nullables Types suportam os valores do tipo mais o valor null
//Ex: Nullable<bool> b = null; suporta true, false e null

Nullable<int> i = null;
Nullable<double> d = null;
Nullable<bool> b = null;

Console.WriteLine(i);
Console.WriteLine(d);
Console.WriteLine(b);

Console.ReadLine();

//declaração simplificada usando ?
//int? i = null;
//double? d = null;
//bool? b = null;

//Nullable Type são diferentes dos tipos por valor
//O Nullable Type int? é diferente do tipo int
//int é um tipo não anulável ou Non-Nullable Type
//int? é um Nullable Type

//int? a = null;
//int b = a;
//Console.WriteLine(b);
//Nesse código eu estou definindo um nullable type do tipo int com um nome A e estou atribuindo o valor null.
//e aqui estou definindo um int com o nome b, atribuindo o valor a, só que a, foi definido como sendo um nullable type.
//nessa atribuição o compilador vai emitir um erro, ele não pode converter um nullable type por int.
//para isso vamos utilizar o operador ?? para atribuir um tipo anulável a um tipo não anulável.
//Ex: int? a = null;
//int b = a ?? 0; vamos utilizar o operador de coalescência nula (??)
//Console.WriteLine(b);

int? c = null;
int e = c ?? 0;
Console.WriteLine(e);

Console.WriteLine();

//expressões
//int? x = 4; para resolver int? x = 4;               
//int y = 3;                int? y = 3;
//int z = x * y;            int? z = x * y;
//Console.WriteLine(z);     Console.WriteLine(z); 
//Console.ReadLine();       Console.ReadLine();

int? x = 4;
int? y = 3;
int? z = x * y;
Console.WriteLine(z);

Console.WriteLine();

//o nullable type fornece duas propriedades somente leitura que posso usar para examinar e obter o valor de 
//uma variável que foi declarada como sendo do nullable type, sendo:
//HasValue = true se tiver um valor e false se não tiver um valor (null);
//Value = exibe o valor atribuído;

Console.WriteLine("HasValue e Value");
int? valor = 100;
if (valor.HasValue)
{
    Console.WriteLine($"valor = {valor.Value}");
}
else
{
    Console.WriteLine("valor não possui um valor (null)");
}
Console.ReadLine();

Console.WriteLine();
int? valor2 = null;
if (valor2.HasValue)
{
    Console.WriteLine($"valor = {valor2.Value}");
}
else
{
    Console.WriteLine("valor2 não possui um valor (null)");
}
Console.ReadLine();




