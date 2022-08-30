// See https://aka.ms/new-console-template for more information


using System.ComponentModel.Design;
using System.Runtime.Intrinsics;
Menu();
 
 static void Menu()
{
    Console.WriteLine("Olá! Qual operação você deseja fazer? ");
    Console.WriteLine("");
    Console.WriteLine("1 - Somar");
    Console.WriteLine("2 - Subtrair");
    Console.WriteLine("3 = Multiplicar");
    Console.WriteLine("4 - Dividir");
    Console.WriteLine("--------------------");
    Console.WriteLine("Selecione uma opção: ");

    short res = short.Parse(Console.ReadLine());

    switch (res)
    {
        case 1: Soma(); break;
        case 2: Subtracao(); break;
        case 3: Multiplicacao(); break;
        case 4: Divisao(); break;
        default: Menu(); break;
    }

}

 static void Soma()
{
Console.Clear();
Console.WriteLine("Vamos somar dois números!");
Console.WriteLine("");
Console.WriteLine("Digite o primeiro número: ");
double v1 = double.Parse(Console.ReadLine());
Console.WriteLine("Digite o segundo número: ");
double v2 = double.Parse(Console.ReadLine());

double resultadoSoma = (v1 + v2);

Console.WriteLine($"O resultado da soma é: {resultadoSoma}");
Console.ReadKey();
    Menu();
}

static void Subtracao()
{
    Console.Clear();
    Console.WriteLine("Vamos subtrair dois números!");
    Console.WriteLine("");
    Console.WriteLine("Digite o primeiro número: ");
    double v1 = double.Parse(Console.ReadLine());
    Console.WriteLine("Digite o segundo número: ");
    double v2 = double.Parse(Console.ReadLine());

    double resultadoSubtracao = (v1 - v2);
    Console.WriteLine($"O resultado da subtração é: {resultadoSubtracao}");
    Console.ReadKey();
    Menu();
}

static void Multiplicacao()
{
    Console.Clear();
    Console.WriteLine("Vamos multiplicar dois números!");
    Console.WriteLine("");
    Console.WriteLine("Digite o primeiro número: ");
    double v1 = double.Parse(Console.ReadLine());
    Console.WriteLine("Digite o segundo número: ");
    double v2 = double.Parse(Console.ReadLine());

    double resultadoMultiplicacao = v1 * v2;
    Console.WriteLine($"O resultado da multiplicação é {resultadoMultiplicacao}");
    Console.ReadKey();
    Menu();
}

static void Divisao()
{
    Console.Clear();
    Console.WriteLine("Vamos dividir!");
    Console.WriteLine("");
    Console.WriteLine("Digite o primeiro número: ");
    double v1 = double.Parse(Console.ReadLine());
    Console.WriteLine("Digite o segundo número: ");
    double v2 = double.Parse(Console.ReadLine());

    double resultadoDivisao = v1 / v2;
    Console.WriteLine($"O resultado da divisão é {resultadoDivisao}");
    Console.ReadKey();
    Menu();
}