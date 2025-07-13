
using console.mentoria3;

bool continuar = true;

while (continuar)
{
    Console.Clear();
    Console.WriteLine("=== Menu de Exemplos ===");
    Console.WriteLine("1 - Exemplo Idade");
    Console.WriteLine("2 - Exemplo Possuí CNH");
    Console.WriteLine("3 - Exemplo Estação do Ano");
    Console.WriteLine("0 - Sair");
    Console.Write("\nEscolha uma opção: ");

    string opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            VerificadorIdade.Executar();
            break;
        case "2":
            VerificadorCNH.Executar();
            break;
        case "3":
            VerificadorEstacao.Executar();
            break;
        case "0":
            continuar = false;
            break;
        default:
            Console.WriteLine("Opção inválida!");
            break;
    }

    if (continuar)
    {
        Console.WriteLine("\nPressione qualquer tecla para continuar...");
        Console.ReadKey();
    }
}