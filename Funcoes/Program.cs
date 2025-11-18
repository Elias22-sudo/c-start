#region atividade de função



// string continuar;
// void imprimirlinhas()
// {
//        Console.WriteLine("--------------------------------------");

// }


// void ConverterCelsiusparaFahrenheit()
// {
//     double temperatura, resultado;
//     temperatura = double.Parse(Console.ReadLine()!);
//     resultado = (temperatura * 9 / 5) + 32;
//     Console.WriteLine($"{temperatura}°C = {resultado:F2}°F");

    
// }



// void ConverterFahrenheitparaCelsius()
// {   double temperatura, resultado;
//     temperatura = double.Parse(Console.ReadLine()!);
//     resultado = (temperatura - 32) * 5 / 9;
//     Console.WriteLine($"{temperatura}°F = {resultado:F2}°C");


// }




// void ConverterCelsiusparaKelvin()
// {
//     double temperatura, resultado;
//         temperatura = double.Parse(Console.ReadLine()!);
//         resultado = temperatura + 273.15;
//         Console.WriteLine($"{temperatura}°C = {resultado:F2}K");   


// }





// void ConverterKelvinparaCelsius()
// {
//     double temperatura, resultado;
          
//             temperatura = double.Parse(Console.ReadLine()!);
//             resultado = temperatura - 273.15;
//             Console.WriteLine($"{temperatura}K = {resultado:F2}°C");
    
// }



// void OpcoesDeconverter()
// {
//     Console.WriteLine("Conversor de Temperatura");
//     Console.WriteLine("Escolha a opção de conversão:");
//     Console.WriteLine("1 - Celsius para Fahrenheit");
//     Console.WriteLine("2 - Fahrenheit para Celsius");
//     Console.WriteLine("3 - Celsius para Kelvin");
//     Console.WriteLine("4 - Kelvin para Celsius");
//     Console.Write("Opção: ");
// }



// do
// {
//     imprimirlinhas();
//     OpcoesDeconverter();

//     string opcao = Console.ReadLine()!;


//     switch (opcao)
//     {
//         case "1":
//             ConverterCelsiusparaFahrenheit();
//             Console.Write("Digite a temperatura em Celsius: ");

//             break;

//         case "2":
//             ConverterFahrenheitparaCelsius();
//             Console.Write("Digite a temperatura em Fahrenheit: ");


//             break;

//         case "3":
//             ConverterCelsiusparaKelvin();
//             Console.Write("Digite a temperatura em Celsius: ");


//             break;

//         case "4":
//             ConverterKelvinparaCelsius();
//             Console.Write("Digite a temperatura em Kelvin: ");


//             break;

//         default:
//             Console.WriteLine("Opção inválida!");
//             break;
//     }

//     Console.Write("Deseja fazer outra conversão? (S/N): ");
//     continuar = Console.ReadLine()!;
//     Console.WriteLine();

// } while (continuar.Equals("S", StringComparison.OrdinalIgnoreCase));

// Console.WriteLine("Programa encerrado.");

#endregion



#region atividade de função 2

string continuar;

void imprimilinha()
{
       Console.WriteLine("--------------------------------------");

}

void Opcoes()
{
    Console.WriteLine("Tabuada");
    Console.WriteLine("Escolha a opção para o resultado:");
    Console.WriteLine("1 - subtrair");
    Console.WriteLine("2 - multiplicar");
    Console.WriteLine("3 - somar");
    Console.WriteLine("4 - dividir");
    Console.Write("Opção: ");
}

void soma(int )
{
    
}




do
{
    
    Opcoes();

    string opcao = Console.ReadLine()!;


    switch (opcao)
    {
    case "1":
            imprimilinha();
            soma();
            Console.Write("Digite a temperatura em Celsius: ");

            break;

    case "2":
            imprimilinha();
            divisão();
            Console.Write("Digite a temperatura em Fahrenheit: ");


            break;

    case "3":
            imprimilinha();
            subtração();
            Console.Write("Digite a temperatura em Celsius: ");


            break;

    case "4":
            imprimilinha();
            multiplicaçao();
            Console.Write("Digite os número : ");


            break;

    default:
            imprimilinha();
            Console.WriteLine("Opção inválida!");
            break;
    }

    Console.Write("Deseja fazer outra conversão? (S/N): ");
    continuar = Console.ReadLine()!;
    Console.WriteLine();

} while (continuar.Equals("S", StringComparison.OrdinalIgnoreCase));

Console.WriteLine("Programa encerrado.");




#endregion







