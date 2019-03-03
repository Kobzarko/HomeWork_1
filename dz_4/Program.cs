using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Задание 4.  Даны целые положительные числа A и B(A<B).
//Вывести все целые числа от A до B включительно; 
//    каждое число должно выводиться на новой строке; 
//    при этом каждое число должно выводиться количество раз, 
//    равное его значению.

namespace dz_4
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(" Enter A and B , when A<B");
            try
            {
                Console.WriteLine("Enter А");
                int A = int.Parse(Console.ReadLine());
                
                Console.WriteLine("Enter B");
                int B = int.Parse(Console.ReadLine());
                
                if (A >= B || A <= 0 || B <= 0)
                {
                    Console.WriteLine("Condition A <B is not met or numbers A and B are not positive ");
                    return;
                }
                Console.Clear();
                for (int i = A; i <= B; i++)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write(i);
                    }
                    Console.WriteLine();
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
        }
    }
}
