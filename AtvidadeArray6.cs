public static class AtividadeArray6
{
    public static void Executar()
    {
        Console.Clear();
        int[] numeros = { 1, 2, 3, 4, 5 };
        int vSuporte;
        for (int numerosDigitados = 0; numerosDigitados < 5; numerosDigitados++)
        {
            Console.WriteLine($"Digite o {numerosDigitados + 1}º número");
            numeros[numerosDigitados] = int.Parse(Console.ReadLine()!);
        }
        for (int verificar = 0; verificar < 5; verificar++)
        {
            for (int organizar = 0; organizar < 4; organizar++)
            {
                if (numeros[organizar] > numeros[organizar + 1])
                {
                    vSuporte = numeros[organizar + 1];
                    numeros[organizar + 1] = numeros[organizar];
                    numeros[organizar] = vSuporte;
                }
            }
        }
        for (int listar = 0; listar < 5; listar++)
        {
            Console.Write($"{numeros[listar]}  ");
        }

    }
}