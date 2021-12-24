using System;

namespace Ficha1_ex3
{
    class VolCilindro
    {
        static void Main(string[] args)
        {
            //Declaração das variáveis
            double alt, r, vol;
            //Mensagem para digitar a altura
            Console.Write("Digite o valor do altura: ");
            //variável alt recebe o valor convertido para
            alt = double.Parse(Console.ReadLine());
            //mensagem para digitar o raio
            Console.Write("Digite o valor do raio: ");
            //variável r recebe o valor
            r = double.Parse(Console.ReadLine());
            //O volume recebe os dados
            vol = Math.PI * r * r * alt;
            Console.WriteLine("O valor do volume: " + vol);
            Console.WriteLine();
            Console.Write("Pressione qualquer tecla para terminar . . . ");
            Console.ReadKey();
        }
    }
}