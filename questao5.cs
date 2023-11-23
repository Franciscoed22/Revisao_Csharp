//Alternativa A- O programa imprimirá "O número 15 é divisível por 11" e "O número 26 é divisível por 11".
using System;
namespace Divididos
{
/// <summary>
/// Summary description for Class1.
/// </summary>
class Onze
{
/// <summary>
/// The main entry point for the application.
/// </summary>
[STAThread]
static void Main(string[] args)
{
// Declaração de Variáveis
int cont;
// Inicialização de Variáveis
cont = 10;
// Utilize chaves para mais de uma instrução (bloco
while (cont <= 100)
{
if (cont % 11 == 5)
Console.WriteLine("O número {0} é d
cont = cont + 1;
}
} // Fim do Método Main
} // Fim da Classe Onze
}