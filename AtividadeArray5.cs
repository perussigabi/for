/* Atividade 5 — Maior número
Crie um array para 5 números (digitado pelo usuário) e mostre qual é o maior valor digitado. */

public static class AtividadeArray5
{
    public static void Executar()
    {
        int[] numeros = { 0, 0, 0, 0, 0 };

        for (int pedir = 0; pedir < 5; pedir++)
        {
            Console.WriteLine($"Digite o {pedir + 1}º número: ");
            numeros[pedir] = int.Parse(Console.ReadLine()!);
        }
        Console.Clear();

        int maior = 0;

        for (int x = 0; x < 5; x++)
        {

            if (numeros[x] > maior)
            {
                maior = numeros[x];
            }

        }

        Console.WriteLine($"O maior número é {maior}.");

    }

}