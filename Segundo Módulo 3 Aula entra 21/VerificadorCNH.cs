namespace console.mentoria3;


public static class VerificadorCNH
{
    
    public static void Executar()
    {
        Console.WriteLine("=== Verificador de CNH ===");
        Console.Write("Você possui CNH? (sim/não): ");
        string? resposta = Console.ReadLine()?.Trim().ToLower();

        string resultado = (resposta == "sim") ? "Você pode dirigir." : "Você NÃO pode dirigir.";

        Console.WriteLine(resultado);
    }
}
