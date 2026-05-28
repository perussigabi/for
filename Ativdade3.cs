/* Crie um programa que mostre os números pares de 2 até 20 usando for.
(proíbido o uso de foreach ou qualquer outro tipo, é permitido somente o uso de for) */

public static class Atividade3
{
    public static void Executar()
    {

        for (int numero = 2; numero <= 20; numero++)
        {
            Console.WriteLine(numero);
            numero++;
        }
    }
}