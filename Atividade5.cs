/* Escolha uma das atividades anteriores e resolva de duas formas:

- Uma usando `for`;
- Outra usando `while`.

Depois, escreva uma breve explicação dizendo qual das duas formas ficou mais organizada. */

public static class Atividade5
{
    public static void Executar()
    {
        /* EM FOR */
        Console.WriteLine("Informe um número: ");
        int i = int.Parse(Console.ReadLine()!);

        for (int multiplicador = 0; multiplicador <= 10; multiplicador++)
        {
            Console.WriteLine($"{i} x {multiplicador} = {i} * {multiplicador}");
        }
    }
}

