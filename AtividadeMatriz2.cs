/* Atividade 2 — Matriz de números
Crie uma matriz 2x3 com números inteiros (digitado pelo usuário) e exiba todos em formato de tabela. */

using System.Xml;

public static class AtividadeMatriz2
{
    public static void Executar()
    {
        int[,] numeros = new int[2, 3];

        //Estava fazendo dessa forma que está comentada para entender como o conceito de linha e coluna funciona.
        /*Console.WriteLine($"Digite o primeiro número: ");
        numeros[0, 0] = int.Parse(Console.ReadLine()!);

        Console.WriteLine($"Digite o segundo número: ");
        numeros[0, 1] = int.Parse(Console.ReadLine()!);

        Console.WriteLine($"Digite o terceiro número: ");
        numeros[0, 2] = int.Parse(Console.ReadLine()!);

        Console.WriteLine($"Digite o quarto número: ");
        numeros[1, 0] = int.Parse(Console.ReadLine()!);

        Console.WriteLine($"Digite o quinto número: ");
        numeros[1, 1] = int.Parse(Console.ReadLine()!);

        Console.WriteLine($"Digite o sexto número: ");
        numeros[1, 2] = int.Parse(Console.ReadLine()!); */


        for (int linha = 0; linha < 2; linha++)
        {
            for (int coluna = 0; coluna < 3; coluna++)
            {
                Console.WriteLine($"Digite o número: ");
                numeros[linha, coluna] = int.Parse(Console.ReadLine()!);

            }
        }

        for (int linha = 0; linha < 2; linha++)
        {
            for (int coluna = 0; coluna < 3; coluna++)
            {
                Console.WriteLine($"Linha {linha}, Coluna {coluna}: {numeros[linha, coluna]}");
            }
        }


    }
}