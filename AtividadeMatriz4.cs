/*Atividade 4 — Média geral
Crie uma matriz 
3x2 de notas e calcule a média geral de todas as notas. Encontre uma forma que o 
divisor (do cálculo da média) seja uma variável incrementada (não atribuir um valor fixo) */

public static class AtividadeMatriz4
{
    public static void Executar()
    {
        double[,] notas = new double[3, 2];
        double soma = 0;
        double media = 0;
        for (int linha = 0; linha < 3; linha++)
        {
            for (int coluna = 0; coluna < 2; coluna++)
            {
                Console.WriteLine($"Digite a nota: ");
                notas[linha, coluna] = double.Parse(Console.ReadLine()!);
                soma += notas[linha, coluna];
                media++;
            }
        }
        Console.WriteLine($"A média das notas é {media}");



    }
}