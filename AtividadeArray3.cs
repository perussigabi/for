/* Atividade 3 — Soma dos números
Crie um array para 5 números inteiros (digitados pelo usuário) e calcule a soma de todos os valores. */

public static class AtividadeArray3
{
    public static void Executar()
    {
        int[] numeros = { 0, 0, 0, 0, 0 };
        int soma = 0;

        for (int numerosDigitados = 0; numerosDigitados < 5; numerosDigitados++)
        {
            Console.WriteLine($"Digite o {numerosDigitados + 1}º número: ");
            numeros[numerosDigitados] = int.Parse(Console.ReadLine()!);
            soma += numeros[numerosDigitados];
        }
        Console.Clear();

        Console.WriteLine("=== SOMA ===");
        Console.WriteLine($"{soma}");
    }
}