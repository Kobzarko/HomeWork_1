using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Задание 5.  Дано целое число N(> 0), найти число,
//полученное при прочтении числа N справа налево.Например,
// если было введено число 345, то программа должна вывести число 543.

namespace dz_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Enter the number N, and N> 0");
            try
            {
                Console.WriteLine("Enter N");
                string N = Console.ReadLine();
                if (Convert.ToInt32(N) < 0)
                {
                    Console.WriteLine("Not met the condition N> 0");
                    return;
                }
                Console.Clear();
                Console.WriteLine("Received number");
                for (int i = N.Length - 1; i >= 0; i--)
                {
                    Console.Write(N[i]);
                }
            }
            catch (Exception)
            {
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("End of programm");
                Console.BackgroundColor = ConsoleColor.Black;
                Environment.Exit(0);
            }
            Console.WriteLine();

        }
    }
    
}
