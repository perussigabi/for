/* Crie um programa que peça um número ao usuário e mostre a tabuada desse número de 1 até 10.
(proíbido o uso de foreach ou qualquer outro tipo, é permitido somente o uso de for) */


public static class Atividade4
{
    public static void Executar()
    {
        Console.WriteLine("Informe um número: ");
        int i = int.Parse(Console.ReadLine()!);

        for (int multiplicador = 0; multiplicador <= 10; multiplicador++)
        {
            Console.WriteLine($"{i} x {multiplicador} = {i} * {multiplicador}");
        }
    }
}
