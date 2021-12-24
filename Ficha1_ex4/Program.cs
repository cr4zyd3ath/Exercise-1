using System;

namespace Ficha1_ex4
{
    class VolCilindro
    {
        static void Main(string[] args)
        {
            //Declaração das variáveis
            double PI, r, vol;
            PI = 3.1416;
            //mensagem para digitar o raio
            Console.Write("Digite o valor do raio: ");
            //variável r recebe o valor
            r = double.Parse(Console.ReadLine());
            //O volume recebe os dados
            vol = (4 / 3) * PI * (r * r * r);
            Console.WriteLine("O valor do volume da esfera: " + vol);
            Console.WriteLine();
            Console.Write("Pressione qualquer tecla para terminar . . . ");
            Console.ReadKey();
        }
    }
}