public static class AtividadeMatriz6
{
    public static void Executar()
    {
        Console.Clear();
        int[,] tabela = new int[2, 3];
        int maior;
        int numeros = 1;
        for (int linha = 0; linha < 2; linha++)
        {
            for (int coluna = 0; coluna < 3; coluna++)
            {
                Console.Write($"Digite o {numeros}º número: ");
                tabela[linha, coluna] = int.Parse(Console.ReadLine()!);
                numeros++;
            }
        }
        maior = tabela[0, 0];
        Console.Clear();
        for (int x = 0; x < 2; x++)
        {
            for (int y = 0; y < 3; y++)
            {
                if (maior < tabela[x, y])
                {
                    maior = tabela[x, y];
                }

            }
        }

        for (int linha = 0; linha < 3; linha++)
        {
            for (int coluna = 0; coluna < 2; coluna++)
            {
                Console.WriteLine($"Linha {linha}, Coluna {coluna}: {tabela[coluna, linha]}");
            }
        }
        Console.WriteLine("");
        Console.WriteLine($"O maior número é {maior}");
    }
}