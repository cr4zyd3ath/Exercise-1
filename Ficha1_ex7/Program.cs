using System;

namespace Ficha1_ex7
{
 class Program
    {
        static void Main(string[] args)
        {
            //Declaração das variáveis
            double nota = 0.0, soma = 0.0;
            double media = 0.0;
            int i;

            for (i = 0; i < 6; i++)
            {
                Console.WriteLine("Insira o valor das notas: ");
                nota = Convert.ToDouble(Console.ReadLine());

                soma = soma + nota;
            }

            media = soma / i;

            Console.WriteLine("A média das 6 notas: " + media);
            Console.WriteLine();
            Console.Write("Pressione qualquer tecla para terminar . . . ");
            Console.ReadKey();
        }
    }
}