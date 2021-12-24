using System;

namespace Ficha1_ex2
{
    class ConvTemp
    {
        static void Main(string[] args)
        {
            //Declaração das variáveis
            double C, F;
            //Mensagem para digitar o grau
            Console.Write("Digite o grau em Fahrenheit: ");
            //variável F recebe o valor convertido para
            F = Convert.ToDouble(Console.ReadLine());
            //O C recebe os dados
            C = 5 * (F - 32) / 9;
            //Exibir as coisas
            Console.WriteLine(" O grau " + F.ToString() + " convertido é : " + C.ToString());
            Console.ReadKey();
        }
    }
}