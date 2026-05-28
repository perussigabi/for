/* Atividade 2 — Lista de números
Crie um array para 6 números inteiros (digitados pelo usuário) e exiba todos usando
for. */

public static class AtividadeArray2
{
    public static void Executar()
    {
        int[] numeros = { 0, 0, 0, 0, 0, 0 };

        for (int numerosInteiros = 0; numerosInteiros < 6; numerosInteiros++)
        {
            Console.WriteLine($"Digite {numerosInteiros + 1}º número: ");
            numeros[numerosInteiros] = int.Parse(Console.ReadLine()!);
        }
        Console.Clear();

        Console.WriteLine("=== Lista dos números ===");
        for (int listar = 0; listar < 6; listar++)
        {
            Console.WriteLine(numeros[listar]);
        }
    }
}