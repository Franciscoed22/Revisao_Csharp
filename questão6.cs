using System;

namespace Turma
{
    class Alunos
    {
        static void Main(string[] args)
        {
            int N_ALUNOS, CONT;
            double N1, N2, N3, N4, MEDIA, MEDIATotal = 0;

            Console.Write("\t\tInforme o número de alunos: ");
            N_ALUNOS = Int32.Parse(Console.ReadLine());
            Console.WriteLine();

            for (CONT = 1; CONT <= N_ALUNOS; CONT++)
            {
                Console.Write($"\t\tInforme a 1ª nota do aluno {CONT}: ");
                N1 = Double.Parse(Console.ReadLine());
                Console.Write($"\t\tInforme a 2ª nota do aluno {CONT}: ");
                N2 = Double.Parse(Console.ReadLine());
                Console.Write($"\t\tInforme a 3ª nota do aluno {CONT}: ");
                N3 = Double.Parse(Console.ReadLine());
                Console.Write($"\t\tInforme a 4ª nota do aluno {CONT}: ");
                N4 = Double.Parse(Console.ReadLine());
                Console.WriteLine();

                MEDIA = (N1 + N2 + N3 + N4) / 4.0;

                MEDIATotal += MEDIA; 
                Console.WriteLine($"\t\tA média do aluno {CONT} é: {MEDIA}");
            }

            double MEDIAT = MEDIATotal / N_ALUNOS;

            Console.WriteLine($"\t\tA média geral da turma é: {MEDIAT}");
        }
    }
}
