
/*Atividade 5 — Média por aluno
Crie uma matriz em que cada linha representa um aluno e cada coluna representa uma nota. Calcule 
a média de cada aluno. */
public static class AtividadeMatriz5
{
    public static void Executar()
    {

        string[,] tabela = new string[5, 3];
        double[] soma = { 0, 0, 0 };
        int aluno = 0;
        //coluna = x linha = y
        for (int linha = 0; linha < 3; linha++)
        {
            for (int coluna = 0; coluna < 5; coluna++)
            {
                if (coluna == 0)
                {
                    Console.Write($"Digite o nome do {linha + 1}º Aluno: ");
                    tabela[coluna, linha] = Console.ReadLine()!;
                }
                else if (coluna == 4)
                {
                    tabela[coluna, linha] = $"{(soma[linha] / 3):F02}";
                }
                else
                {
                    Console.Write($"Digite a {coluna}ª nota do(a) {tabela[0, linha]}: ");
                    tabela[coluna, linha] = Console.ReadLine()!;
                    //Soma Automaticamente as notas
                    soma[aluno] += Double.Parse(tabela[coluna, linha]);
                }
            }
            aluno++;
        }

        for (int linha = 0; linha < 3; linha++)
        {
            for (int coluna = 0; coluna < 5; coluna++)
            {
                Console.WriteLine($"Linha {linha}, Coluna {coluna}: {tabela[coluna, linha]}");
            }
        }
    }
}