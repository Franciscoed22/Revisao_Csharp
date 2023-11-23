using System;

class Numericos
{
    static void Main(string[] args)
    {
        // Solicita e lê um número de 4 dígitos
        int num;
        do
        {
            Console.Write("\n\t\tInforme um número de 4 dígitos: ");
            num = ObterNumero();
        } while (!VerificarQuatroDigitos(num));

        // Extrai os 4 dígitos do número fornecido
        int d1 = ExtrairDigito(num, 1000);
        int d2 = ExtrairDigito(num, 100);
        int d3 = ExtrairDigito(num, 10);
        int d4 = ExtrairDigito(num, 1);

        // Exibe o número
        ExibirDigitos(num, d1, d2, d3, d4);
    }

    static int ObterNumero()
    {
        return Int32.Parse(Console.ReadLine());
    }

    static int ExtrairDigito(int numero, int divisor)
    {
        return (numero / divisor) % 10;
    }

    static void ExibirDigitos(int num, int d1, int d2, int d3, int d4)
    {
        // Exibe o número formatado
        Console.WriteLine($"\n\t\tO número fornecido é: {d1} {d2} {d3} {d4} ({num})");
    }

    static bool VerificarQuatroDigitos(int numero)
    {
        int count = 0;
        while (numero != 0)
        {
            numero /= 10;
            count++;
        }
        return count == 4;
    }
}
