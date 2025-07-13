using System;

namespace console.mentoria3;

public static class VerificadorEstacao
{
    
    public static void Executar()
    {
        Console.WriteLine("=== Verificador de Estação do Ano ===");
        Console.Write("Digite o número do mês (1-12): ");

        if (int.TryParse(Console.ReadLine(), out int mes))
        {
            string estacao = VerificarEstacao(mes);
            Console.WriteLine($"A estação correspondente é: {estacao}");
        }
        else
        {
            Console.WriteLine("Entrada inválida! Por favor, digite um número entre 1 e 12.");
        }
    }

   
    private static string VerificarEstacao(int mes)
    {
        if (mes == 12 || mes == 1 || mes == 2)
            return "Verão";
        else if (mes == 3 || mes == 4 || mes == 5)
            return "Outono";
        else if (mes == 6 || mes == 7 || mes == 8)
            return "Inverno";
        else if (mes == 9 || mes == 10 || mes == 11)
            return "Primavera";
        else
            return "Mês inválido!";
    }
}