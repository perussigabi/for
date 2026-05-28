public static class DesafioTutui
{
    public static void Executar()
    {
        int[,] tabela = new int[4, 4];
        int vSuporte;
        int numeros = 1;
        for (int y = 0; y < 4; y++)
        {
            for (int x = 0; x < 4; x++)
            {
                Console.WriteLine($"Digite o {numeros}º número");
                tabela[x, y] = int.Parse(Console.ReadLine()!);
            }
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
}
