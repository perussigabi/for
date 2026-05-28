/* Atividade 1 — Lista de nomes
Crie um array para 5 nomes de alunos (digitados pelo usuário) e exiba todos usando
for. */

using System.Runtime.CompilerServices;

public static class AtividadeArray1
{
    public static void Executar()
    {
        string[] nomes = { "", "", "", "", "" };

        for (int quantidade = 0; quantidade < 5; quantidade++)
        {
            Console.WriteLine($"Digite {quantidade + 1}º nome: ");
            nomes[quantidade] = Console.ReadLine()!;

        }
        Console.Clear();


        Console.WriteLine("NOMES DOS ALUNOS:");

        for (int listar = 0; listar < 5; listar++)
        {

            Console.WriteLine(nomes[listar]);
        }
    }
}