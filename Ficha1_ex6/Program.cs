using System;

namespace Ficha1_ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaração das variáveis coloquei double para calcular numeros com ou sem ,
            double n1, n2, media;
            //mensagem para digitar o n1
            Console.Write("Digite o valor nota 1: ");
            //variável r recebe o valor
            n1 = double.Parse(Console.ReadLine());
            //mensagem para digitar o n2
            Console.Write("Digite o valor nota 2: ");
            //variável r recebe o valor
            n2 = double.Parse(Console.ReadLine());
            //O volume recebe os dados
            media = (n1 + n2) / 2;
            Console.WriteLine("A media das notas: " + media);
            Console.WriteLine();
            Console.Write("Pressione qualquer tecla para terminar . . . ");
            Console.ReadKey();
        }
    }
}
