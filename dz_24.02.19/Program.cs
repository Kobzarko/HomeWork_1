using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Для отладки проектов перейдите в свойства решения основного проекта и выберите "текущий выбор"

//Задание 1. Написать программу, которая считывает символы с клавиатуры,
//пока не будет введена точка.
//Программа должна сосчитать количество введенных пользователем пробелов. 

namespace dz_24._02._19
{
    class Program
    {
        static void Main(string[] args)
        {
            int spaceCount = 0;
            ConsoleKeyInfo Symbol; // описывает клавишу консоли которая была нажата
            Console.WriteLine(" Space counting program\n");

            do
            {
                Console.WriteLine(" Enter a symbol\n");
                Console.WriteLine(" For the end of enter press symbol 'point'\n");
                Symbol = Console.ReadKey();
                //Console.WriteLine("\n");
                Console.WriteLine();
                Console.Clear(); // очищает строку
                Console.WriteLine(Symbol.Key);
                if (Symbol.KeyChar == ' ')
                {
                    Console.WriteLine("Space");
                    spaceCount++;
                    
                }
                if (Symbol.KeyChar == '.')
                {
                    break;
                }
                

            } while (true);
            
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("       Number of spaces entered = " + spaceCount +"         ");
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.ReadKey();
        }
    }
}
