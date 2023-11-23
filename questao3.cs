using System;

namespace CalculoVelocidadeMedia
{
    class Program
    {
        static void Main(string[] args)
        {
            double velocidade, distancia, tempo;

            Console.Write("Por favor, informe a distância percorrida pelo veículo: ");
            distancia = double.Parse(Console.ReadLine());

            Console.Write("Por favor, informe o tempo gasto na viagem em horas: ");
            tempo = double.Parse(Console.ReadLine());

            if (tempo != 0)
            {
                velocidade = distancia / tempo;
                Console.WriteLine("A velocidade média do veículo é: {0} Km/h", velocidade);
            }
            else
            {
                Console.WriteLine("O tempo não pode ser igual a zero. Verifique e tente novamente.");
            }
        } 
    } 
}
