using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite o raio da esfera: ");

        string input = Console.ReadLine();

        if (decimal.TryParse(input, out decimal raio))
        {
            decimal pi = (decimal)Math.PI;
            decimal volume = (4.0m / 3.0m) * pi * (decimal)Math.Pow((double)raio, 3);

            Console.WriteLine($"O volume da esfera com raio {raio} é: {volume}");
        }
        else
        {
            Console.WriteLine("Por favor, insira um valor válido para o raio da esfera.");
        }
    }
}
