﻿
Console.WriteLine("=== CALCULADORA SIMPLES ===");
Console.WriteLine("Operações disponíveis:");
Console.WriteLine("1 - Soma");
Console.WriteLine("2 - Subtração");
Console.WriteLine("3 - Multiplicação");
Console.WriteLine("4 - Divisão");
Console.WriteLine("5 - Potência (num1 ^ num2)");

Console.Write("\nEscolha a operação (1 a 5): ");
int escolha = int.Parse(Console.ReadLine());

Console.Write("\nDigite o primeiro número: ");
int num1 = int.Parse(Console.ReadLine());

Console.Write("Digite o segundo número: ");
int num2 = int.Parse(Console.ReadLine());

int resultado = 0;

switch (escolha)
{
    case 1:
        resultado = num1 + num2;
        Console.WriteLine("\nResultado da soma: " + resultado);
        break;

    case 2:
        resultado = num1 - num2;
        Console.WriteLine("\nResultado da subtração: " + resultado);
        break;

    case 3:
        resultado = num1 * num2;
        Console.WriteLine("\nResultado da multiplicação: " + resultado);
        break;

    case 4:
        if (num2 != 0)
        {
            double divisao = (double)num1 / num2;
            Console.WriteLine("\nResultado da divisão: " + divisao);
        }
        else
        {
            Console.WriteLine("\nErro! Não é possível dividir por zero.");
        }
        break;

    case 5:
        double potencia = Math.Pow(num1, num2);
        Console.WriteLine($"\n{num1} ^ {num2} = " + potencia);
        break;

    default:
        Console.WriteLine("\nOpção inválida!");
        break;
}

Console.WriteLine("\nFim do programa!");

