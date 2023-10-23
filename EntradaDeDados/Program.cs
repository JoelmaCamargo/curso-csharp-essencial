Console.WriteLine("\nEntrada de Dados");
Console.WriteLine("\nInforme o seu nome");
string nome = Console.ReadLine();

Console.WriteLine("\n Informe a sua idade");
int idade = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"\nO seu nome é {nome} ");
Console.WriteLine($"\ne a sua idade é: {idade} anos");

Console.ReadKey();


//ReadLine(): lê uma única linha de entrada do fluxo de entrada padrão. Retorna a mesma string
//Read(): lê apenas um único caractere do fluxo de entrada padrão. retorna o valor ASCII do caractere.
//ReadKey(): lê apenas um único caractere do fluxo de entrada padrão. Obtém a próxima tecla pressionada pelo usuário.
//Retorna um tipo ConsoleKeyInfo. É usado para segurar a telç.9a até que o usuário pressione uma tecla.