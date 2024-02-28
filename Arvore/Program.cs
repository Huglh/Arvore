using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arvore
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe o número de linhas da pirâmide: ");
            int numLinhas = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < numLinhas; i++)
            {
                for (int j = 0; j < numLinhas - i - 1; j++)
                {
                    Console.Write(" ");
                }

                for (int k = 0; k < 2 * i + 1; k++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
