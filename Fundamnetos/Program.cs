//#region primeiro programa

//Console.WriteLine("Hello, world!");

//#endregion

//using System.IO.Pipes;

//string nome = "José";
//int idade = 30;
//double altura = 1.8;
//Console.WriteLine($"Seu nome é {nome}\nSeja bem-vinda(o)! nesse hotel {nome} você terá uma experiência inesquecível!.\nVocê tem {idade} anos e sua altura é {altura} m");





//#region 


//int idade;
//string username;

//Console.Write("digite seu nome: ");
//username = Console.ReadLine()!;
//Console.Write("digite sua idade: ");
//idade = int.Parse(Console.ReadLine()!);
//Console.WriteLine($"Olá {username}, você tem {idade} anos!");
//#endregion





//int B = 1 * 2;
//Console.WriteLine(B);
//int C = 2 + 2;
//Console.WriteLine(C);
//int D = 15 / 3;
//Console.WriteLine(D);
//int e = 12 - 5;
//Console.WriteLine(e);
//int t = 11 % 7;
//Console.WriteLine(t);
//int f = 9 % 5;
//Console.WriteLine(f);

//int j = 20;
//double n = 3.14 * (j * j); 
//Console.WriteLine($" 3.14 * {j}² = {n} ");

//int a = 158;
//double b = (a - 32) * 5 / 9;
//Console.WriteLine($"{a}°F é igual a {b}°C");





//#region Atividade 1




//int number1, number2, number3, number4, soma;
//Console.Write("Digite o primeiro número: ");
//number1 = int.Parse(Console.ReadLine()!);
//Console.Write("Digite o segundo número: "); 
//number2 = int.Parse(Console.ReadLine()!);
//Console.Write("Digite o terceiro número: ");
//number3 = int.Parse(Console.ReadLine()!);
//Console.Write("Digite o quarto número: ");
//number4 = int.Parse(Console.ReadLine()!);
//soma = number1 + number2 + number3 + number4;
//Console.WriteLine($"A soma dos números é: {soma}");







//#endregion


#region Atividade 2
float number1, number2, soma;
Console.Write("Digite o primeiro número: ");
number1 = float.Parse(Console.ReadLine()!);
Console.Write("Digite o segundo número: ");
number2 = float.Parse(Console.ReadLine()!);
soma = number1 + number2;
Console.WriteLine($"A soma dos números é: {soma}");

#endregion



#region Atividade 3



char letra = Console.ReadKey().KeyChar;
Console.WriteLine($"\nA letra digitada foi: {letra}");






#endregion

#region Atividade 4

string nome;
Console.Write("Digite seu nome: ");
nome = Console.ReadLine()!;
Console.WriteLine($"Olá {nome}, seja bem-vinda(o)!");








#endregion

#region Atividade 5

decimal numero1, numero2, multiplicacao;
Console.Write("Digite o primeiro número: ");
numero1 = decimal.Parse(Console.ReadLine()!);
Console.Write("Digite o segundo número: ");
numero2 = decimal.Parse(Console.ReadLine()!);
multiplicacao = numero1 * numero2;
Console.WriteLine($"A multiplicação dos números é: {multiplicacao}");









#endregion
#region Atividade 6
int quadrado;
Console.Write("Digite um número: ");
quadrado = int.Parse(Console.ReadLine()!);
quadrado = quadrado * quadrado;
Console.WriteLine($"O quadrado do número é: {quadrado}");









#endregion

#region Atividade 7
double numero3, numero4, media;
Console.Write("Digite o primeiro número: ");
numero3 = double.Parse(Console.ReadLine()!);
Console.Write("Digite o segundo número: ");
numero4 = double.Parse(Console.ReadLine()!);
media = (numero3 + numero4) / 2;
Console.WriteLine($"A média dos números é: {media}");









#endregion

#region Atividade 8
float subtrair;
Console.Write("Digite um número: ");
subtrair = float.Parse(Console.ReadLine()!);
subtrair = subtrair - 10.5f;
Console.WriteLine($"O resultado da subtração é: {subtrair}");











#endregion

#region Atividade 9


string cidade;
int idade;

Console.Write("Digite o nome da sua cidade: ");
cidade = Console.ReadLine()!;
Console.Write("Digite sua idade: ");
idade = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Você mora em {cidade} e tem {idade} anos.");








#endregion

#region Atividade 10


int rua;
string bairro;
char caractere;
Console.Write("Digite o número da sua rua: ");
rua = int.Parse(Console.ReadLine()!);
Console.Write("Digite o nome do seu bairro: ");
bairro = Console.ReadLine()!;
Console.Write("Digite um caractere especial: ");
caractere = Console.ReadKey().KeyChar;
Console.WriteLine($"\nVocê mora na rua {rua}, no bairro {bairro} e o caractere especial digitado foi: {caractere}");






#endregion


#region Atividade 11
double media1, media2, media3, mediaponderada;
Console.Write("Digite a primeira nota: ");
media1 = double.Parse(Console.ReadLine()!);
Console.Write("Digite a segunda nota: ");
media2 = double.Parse(Console.ReadLine()!);
Console.Write("Digite a terceira nota: ");
media3 = double.Parse(Console.ReadLine()!);
mediaponderada = (media1 * 2 + media2 * 3 + media3 * 5) / 10;
Console.WriteLine($"A média ponderada é: {mediaponderada}");








#endregion



#region Atividade 12




int a;
Console.Write("Digite a temperatura em Celsius: ");
a = int.Parse(Console.ReadLine()!);

double b = a * 9/5  + 32;
Console.WriteLine($"A temperatura em Fahrenheit é: {b}°F");




#endregion
