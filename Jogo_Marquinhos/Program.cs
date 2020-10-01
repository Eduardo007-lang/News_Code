using System;

namespace News_Code
{
    class Program
    {
        static void Main(string[] args)
        {
             Console.WriteLine("-------------------------------------");
             Console.WriteLine("            JOGO EDUACATIVO           ");
             Console.WriteLine("-------------------------------------");
             Console.WriteLine();
             Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");
             Console.WriteLine("      SUCESSOR E ANTECESSOR         ");
             Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");
             // Pedindo pro usuario digitar algum numero
             Console.WriteLine("Digite um número: ");
             // fazendo a leitura do numero digitado e armazendando na variavel n
             string n = Console.ReadLine();
            //variaveis sucessor e antecessor
             int sucessor = n + 1;
             int antecessor = n - 1;
            //Escrevendo na tela o sucessor e antecessor do numero armazenado na variavel n
             Console.WriteLine($"O  de sucessor {n} é {sucessor}");
             Console.WriteLine($"O  de antecessor {n} é {antecessor}");





        }
    }
}
