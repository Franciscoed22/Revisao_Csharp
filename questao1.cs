using System;

class Program
{
    static void Main()
    {
        // Solicitar a entrada do usuário
        Console.WriteLine("Digite o volume em metros cúbicos (m3): ");

        // Ler a entrada do usuário como uma string
        string input = Console.ReadLine();
        
        // Tentar converter a string para um número decimal
        if (decimal.TryParse(input, out decimal metrosCubicos))
        {
            // Realizar a conversão de metros cúbicos para litros
            decimal litros = metrosCubicos * 100;
            
            // Exibir o resultado
            Console.WriteLine($"{metrosCubicos} metros cúbicos são equivalentes a {litros} litros.");
        }
        else
        {
            // Se a conversão falhar, exibir uma mensagem de erro
            Console.WriteLine("Por favor, insira um valor válido para o volume em metros cúbicos.");
        }
    }
}
