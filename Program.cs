using System;

namespace CalculaHipotenusa
{
    class Program
    {
        static void Main(string[] args)
        {
            // Algoritmo que recebe os valores dos catetos e calcula
            // a hipotenusa
            Double cateto1, cateto2, hipotenusa;
            Console.Write("Digite o valor do Cateto 1: ");
            cateto1 = float.Parse(Console.ReadLine());
            Console.Write("Digite o Cateto 2: ");
            cateto2 = float.Parse(Console.ReadLine());

            hipotenusa = Math.Sqrt(Math.Pow(cateto1, 2) + Math.Pow(cateto2, 2));
            Console.Write($"O valor da Hipotenusa para os catetos {cateto1} e {cateto2} é de {hipotenusa:0.00}");

        }
    }
}
