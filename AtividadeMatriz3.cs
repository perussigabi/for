/* Atividade 3 — Soma dos valores
Crie uma matriz 2x2 com números inteiros e calcule a soma de todos os valores. */

public static class AtividadeMatriz3
{
    public static void Executar()
    {
        int[,] numeros = new int[2, 2];
        int soma = 0;

        // Estava fazendo dessa forma que está comentada para entender como o conceito de linha e coluna funciona.
        /* Console.WriteLine($"Digite o primeiro número: ");
         numeros[0, 0] = int.Parse(Console.ReadLine()!);

         Console.WriteLine($"Digite o segundo número: ");
         numeros[0, 1] = int.Parse(Console.ReadLine()!);

         Console.WriteLine($"Digite o terceiro número: ");
         numeros[1, 0] = int.Parse(Console.ReadLine()!);

         Console.WriteLine($"Digite o quarto número: ");
         numeros[1, 1] = int.Parse(Console.ReadLine()!); */

        for (int linha = 0; linha < 2; linha++)
        {
            for (int coluna = 0; coluna < 2; coluna++)
            {
                Console.WriteLine($"Digite o número: ");
                numeros[linha, coluna] = int.Parse(Console.ReadLine()!);
                soma += numeros[linha, coluna];
            }
        }
        Console.WriteLine($"A soma dos números é {soma}");


    }
}