
/* Atividade 4 — Média de notas
Crie um array para 4 notas (digitado pelo usuário) e calcule a média final. */
public static class AtividadeArray4
{
    public static void Executar()
    {
        double[] notas = { 0, 0, 0, 0 };
        double soma = 0;

        for (int pedir = 0; pedir < 4; pedir++)
        {
            Console.WriteLine($"Digite a {pedir + 1}ª nota: ");
            notas[pedir] = double.Parse(Console.ReadLine()!);
            soma += notas[pedir];
        }
        Console.Clear();

        Console.WriteLine("=== MEDIA ===");
        Console.WriteLine($"A média das notas é {soma / 4}");
    }
}