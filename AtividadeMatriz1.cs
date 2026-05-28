/* Atividade 1 — Matriz de nomes 
Crie uma matriz 2x2 de nomes (digitado pelo usuário) e exiba todos os nomes usando for aninhado. */

public static class AtividadeMatriz1
{
    public static void Executar()
    {
        string[,] nomes = new string[2, 2];

        //Estava fazendo dessa forma que está comentada para entender como o conceito de linha e coluna funciona.
        /*Console.WriteLine($"Digite o primeiro nome: ");
        nomes[0, 0] = Console.ReadLine()!;

        Console.WriteLine($"Digite o segundo nome: ");
        nomes[0, 1] = Console.ReadLine()!;

        Console.WriteLine($"Digite o terceiro nome: ");
        nomes[1, 0] = Console.ReadLine()!;

        Console.WriteLine($"Digite o quarto nome: ");
        nomes[1, 1] = Console.ReadLine()!; */
        for (int linha = 0; linha < 2; linha++)
        {
            for (int coluna = 0; coluna < 2; coluna++)
            {
                Console.WriteLine($"Digite o nome: ");
                nomes[linha, coluna] = Console.ReadLine()!;
            }
        }

        for (int linha = 0; linha < 2; linha++)
        {
            for (int coluna = 0; coluna < 2; coluna++)
            {
                Console.WriteLine($"Linha {linha}, Coluna {coluna}: {nomes[linha, coluna]}");
            }
        }


    }
}