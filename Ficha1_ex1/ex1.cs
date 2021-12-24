using System;

namespace Ficha1_ex1
{
    class VolCampoFutebol
    {
        static void Main(string[] args)
        {
            //Declaração das variáveis
            double l1, l2, l3, vol;
            //mensagem para digitar o lado
            Console.Write("Digite o valor do primeiro lado: ");
            //variável l1 recebe o valor convertido para
            l1 = Convert.ToDouble(Console.ReadLine());
            //mensagem para digitar o lado
            Console.Write("Digite o valor do segundo lado: ");
            //variável l2 recebe o valor convertido para
            l2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite o valor do terceiro lado: ");
            //variável l3 recebe o valor convertido para
            l3 = Convert.ToDouble(Console.ReadLine());
            //O volume recebe os dados
            vol = l1 * l2 * l3;
            //Exibir as coisas
            Console.WriteLine("O volume do campo de futebol é: " + vol.ToString("F2") + " (cm³)");
            Console.WriteLine("Pressione qualquer tecla para sair!");
            Console.ReadKey();
        }
    }
}