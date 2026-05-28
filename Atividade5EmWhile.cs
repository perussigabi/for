public static class Atividade5EmWhile
{
    public static void Executar()
    {
        /* EM WHILE */
        Console.WriteLine("Informe um número: ");
        int numero = int.Parse(Console.ReadLine()!);

        int contador = 0;

        while (contador <= 10)
        {
            int resultado = numero * contador;
            Console.WriteLine($"{numero} x {contador} = {resultado}");

            contador++;
        }

    }

}
/* Para mim ela fica mais organizada quando está em for, além de usar menos linhas de código */