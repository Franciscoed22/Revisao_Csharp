using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite o limite máximo para calcular as potências de 2: ");
        int limite = int.Parse(Console.ReadLine());

        int expoente = 0;
        double resultado = 0;

        Console.WriteLine("Potências de 2:");

        while (resultado <= limite)
        {
            resultado = Math.Pow(2, expoente);
            Console.WriteLine($"2^{expoente} = {(int)resultado}");

            expoente++;
        }
    }
}
