Console.WriteLine("## Conversão de tipos ##\n");
//Conversão implícita, conversão explícita, Método ToString(), Métodos da classe Convert.

int varInt = 100;
double varDouble = varInt;   //fazendo conversão do tipo Int para o tipo Double
Console.WriteLine(varDouble);

//int usa 4 bytes e double usa 8 bytes - consigo guardar 4 bytes em 8 bytes, porém o processo inverso não pode ser feito
Console.WriteLine("Conversão implícita");
int numeroInt = 2145678;
long numeroLong = numeroInt;
float numeroFloat = numeroInt;
float numeroDouble = numeroInt;
float numeroDecimal = numeroInt;

Console.WriteLine(numeroInt);
Console.WriteLine(numeroLong);
Console.WriteLine(numeroFloat);
Console.WriteLine(numeroDouble);
Console.WriteLine(numeroDecimal);
//conversão implícita 

Console.ReadLine();

//conversão explícita
Console.WriteLine("Conversão explícita");
double varDouble2 = 12.456;       //8 bytes
int varInt2 = (int)varDouble2;   //4 bytes  -> perda de precisão

Console.WriteLine(varInt2);

int num1 = 10;
int num2 = 4;
float resultado = (float)num1 / num2;  // 10/4 = 2.5
Console.WriteLine(resultado);

//método ToString()
Console.WriteLine("Método ToString()");
int valorInt3 = 123;
double valorDouble3 = 12.45;
decimal valorDecimal3 = 12.45678m;

string s1 = valorInt3.ToString();
string s2 = valorDouble3.ToString();
string s3 = valorDecimal3.ToString();

Console.WriteLine(s1);
Console.WriteLine(s2);
Console.WriteLine(s3);

//classe Convert()
Console.WriteLine("Métodos da classe Convert()");

int valorInt4 = 10;
double valorDouble4 = 5.35;
bool valorBool4 = true;

Console.WriteLine(Convert.ToString(valorInt4));
Console.WriteLine(Convert.ToString(valorInt4));
Console.WriteLine(Convert.ToString(valorBool4));
Console.WriteLine(Convert.ToInt32(valorDouble4));
Console.WriteLine();

//as conversões de ampliação ou estreitamento entre dois tipos de dados que não resultarem em perda de dados, terão êxito e o método retornará
//um valor do tipo de destino. Quando uma conversão de estreitamento de dados resultar em perda de dados vai ocorrer uma OverflowException

int varInt5 = 100000;
Console.WriteLine(Convert.ToByte(varInt5));
//intervalo do byte = 0 a 255, conversão com estreitamento de dados com perda de dados

Console.ReadLine();



