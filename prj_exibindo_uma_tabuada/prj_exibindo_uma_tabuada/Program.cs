using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prj_exibindo_uma_tabuada
{
    
    class Program
    {
        static void Main(string[] args)
        {
            int c, num;
            Console.Write("Digite o número para a tabuada: ");
            num = Convert.ToInt32(Console.ReadLine());
            for (c = 1; c <= 10; c++)
            {
                Console.WriteLine(num + " X " + c + " = " + (num * c));
            }
            Console.WriteLine("\nPress. <ENTER> para Finalizar\n");
            Console.ReadKey();
        }
    }
}