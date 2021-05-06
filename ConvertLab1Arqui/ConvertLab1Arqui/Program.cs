using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertLab1Arqui
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Convertidor");
            Console.WriteLine("1. ASCII a Entero");
            Console.WriteLine("2. Entero a ASCII");
            string opcion = Console.ReadLine();
            switch (opcion)
            {
                case "1":
                    try
                    {
                        Console.WriteLine("ASCII a Entero");
                        Console.WriteLine("Ingrese un caracter: ");
                        char letra = Convert.ToChar(Console.ReadLine());
                        int num = (int)letra;
                        Console.WriteLine("{0}", num);
                        Console.ReadLine();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e);
                    }
                    break;
                case "2":
                    try
                    {
                        Console.WriteLine("Entero a ASCII");
                        Console.WriteLine("Ingrese un numero: ");
                        int num2 = int.Parse(Console.ReadLine());
                        char letra2 = (char)num2;
                        Console.WriteLine("{0}", letra2);
                        Console.ReadLine();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e);
                    }
                    break;
            }
        }
    }
}
