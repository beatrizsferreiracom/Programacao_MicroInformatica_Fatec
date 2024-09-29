using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrjSoma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declarar variáveis
            double N1 = 0, N2 = 0, R = 0;
            Console.WriteLine("Informe um número:");
            N1 = Convert.ToDouble(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Informe outro número:");
            N2 = Convert.ToDouble(Console.ReadLine());
            R = N1 + N2;
            Console.Write(N1 + " + " + N2 + " = " + R.ToString());
            Console.ReadKey();
        }
    }
}
