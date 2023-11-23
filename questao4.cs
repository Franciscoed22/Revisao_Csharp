using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite a nota do estudante: ");
        double nota = double.Parse(Console.ReadLine());

        if (nota >= 7)
        {
            Console.WriteLine("O aluno está aprovado!");
        }
        else if (nota >= 4)
        {
            Console.WriteLine("O aluno precisa fazer um exame.");
        }
        else
        {
            Console.WriteLine("O aluno está reprovado.");
        }
    }
}
