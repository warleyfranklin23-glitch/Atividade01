﻿using System;

class UrnaEletronica
{
    static void Main()
    {
        // Variáveis para contar os votos de cada opção
        int votosMSDN = 0;
        int votosTechNet = 0;
        int votosSpokeDotNet = 0;
        int votosBranco = 0;
        int votosNulos = 0;

        // Exibe a data e hora atuais
        Console.WriteLine("Data e hora atual: " + DateTime.Now);

        // Exibe a mensagem inicial
        Console.WriteLine("=================================");
        Console.WriteLine("VOTE CERTO!");
        Console.WriteLine("=================================");

        // Loop para continuar recebendo votos enquanto o usuário quiser
        string continuarVotando = "sim";
        while (continuarVotando.ToLower() == "sim")
        {
            // Exibe o menu de opções de voto
            Console.WriteLine("\nEscolha uma opção de voto:");
            Console.WriteLine("1 - MSDN Brasil");
            Console.WriteLine("2 - TechNet Brasil");
            Console.WriteLine("3 - The Spoke .Net");
            Console.WriteLine("4 - Voto em branco");
            Console.WriteLine("5 - Voto nulo");

            // Solicita que o usuário digite sua opção de voto
            Console.Write("\nDigite sua opção (1-5): ");
            string opcao = Console.ReadLine();

            // Registra o voto utilizando a estrutura switch
            switch (opcao)
            {
                case "1":
                    votosMSDN++;
                    Console.WriteLine("Você votou em MSDN Brasil.");
                    break;
                case "2":
                    votosTechNet++;
                    Console.WriteLine("Você votou em TechNet Brasil.");
                    break;
                case "3":
                    votosSpokeDotNet++;
                    Console.WriteLine("Você votou em The Spoke .Net.");
                    break;
                case "4":
                    votosBranco++;
                    Console.WriteLine("Você votou em branco.");
                    break;
                case "5":
                    votosNulos++;
                    Console.WriteLine("Você votou nulo.");
                    break;
                default:
                    Console.WriteLine("Opção inválida! Tente novamente.");
                    continue;
            }

            // Pergunta se o usuário deseja continuar votando
            Console.Write("\nDeseja continuar votando? (sim/não): ");
            continuarVotando = Console.ReadLine();
        }

        // Exibe o total de votos de cada opção
        Console.WriteLine("\n=================================");
        Console.WriteLine("Resultado final da votação:");
        Console.WriteLine($"MSDN Brasil: {votosMSDN} votos");
        Console.WriteLine($"TechNet Brasil: {votosTechNet} votos");
        Console.WriteLine($"The Spoke .Net: {votosSpokeDotNet} votos");
        Console.WriteLine($"Votos em branco: {votosBranco} votos");
        Console.WriteLine($"Votos nulos: {votosNulos} votos");
        Console.WriteLine("=================================");
    }
}
