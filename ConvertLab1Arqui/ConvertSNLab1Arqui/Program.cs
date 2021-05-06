using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertSNLab1Arqui
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el numero binario: ");
            int binaryNumber = int.Parse(Console.ReadLine());
            int decimalValue = 0;

            int base1 = 1;

            while (binaryNumber > 0)
            {
                int reminder = binaryNumber % 10;
                binaryNumber = binaryNumber / 10;
                decimalValue += reminder * base1;
                base1 = base1 * 2;
            }
            Console.Write($"Valor en decimal es: {decimalValue} ");
            Console.ReadKey();
        }
    }
}
