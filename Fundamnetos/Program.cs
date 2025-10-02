#region primeiro programa

//Console.WriteLine("Hello, world!");

#endregion

using System.IO.Pipes;

//string nome = "José";
//int idade = 30;
//double altura = 1.8;
//Console.WriteLine($"Seu nome é {nome}\nSeja bem-vinda(o)! nesse hotel {nome} você terá uma experiência inesquecível!.\nVocê tem {idade} anos e sua altura é {altura} m");

Console.WriteLine("Digite seu nome: ");
string nome = Console.ReadLine()!;
Console.WriteLine($"Seu nome é {nome}");

Console.WriteLine("Qual sua idade?");
string idade = Console.ReadLine()!;
Console.WriteLine($"Você tem {idade} anos");

Console.WriteLine($"Você é novo no jogo?");
string premissas = Console.ReadLine()!;
Console.WriteLine($"voce é novo no jogo! {premissas}");
