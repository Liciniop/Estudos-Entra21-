namespace console.mentoria3;


public static class VerificadorIdade
{
    
    public static void Executar()
    {
        Console.WriteLine("=== Verificador de Idade ===");
        Console.Write("Digite sua idade: ");

        if (int.TryParse(Console.ReadLine(), out int idade))
        {
            string resultado = VerificarIdade(idade);
            Console.WriteLine(resultado);
        }
        else
        {
            Console.WriteLine("Entrada inválida! Digite um número inteiro.");
        }
    }

   
    private static string VerificarIdade(int idade)
    {
        if (idade < 0 || idade > 101)
            return "Idade inválida!";
        else if (idade < 18)
            return "Você é menor de idade";
        else if (idade < 65)
            return "Você é adulto";
        else
            return "Você é idoso";
    }
}
