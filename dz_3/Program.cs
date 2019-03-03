using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Задание 3. Числовые значения символов нижнего регистра
// в коде ASCII отличаются от значений символов верхнего регистра на величину 32.
//Используя эту  информацию, написать программу, 
// которая считывает с клавиатуры и конвертирует все символы нижнего регистра
// в символы верхнего регистра и наоборот.

namespace dz_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programm for converts all lowercase and uppercase characters  ");

            int spaceValue = 0;
            ConsoleKeyInfo symbol;
            do
            {
                Console.WriteLine("Enter symbol to convert register");
                Console.WriteLine("For exit press ESC");
                symbol = Console.ReadKey();
                Console.WriteLine();
                Console.Clear();
                Console.WriteLine("Введенный символ " + symbol.KeyChar);
                if (char.IsLetter(Convert.ToChar(symbol.KeyChar)))
                {
                    if (char.IsUpper(Convert.ToChar(symbol.KeyChar)))
                    {
                        Console.WriteLine("Converting symbol " + char.ToLower(Convert.ToChar(symbol.KeyChar)));
                    }
                    else
                    {
                        Console.WriteLine("Converting symbol " + char.ToUpper(Convert.ToChar(symbol.KeyChar)));
                    }
                }

                if (Convert.ToInt32(symbol.KeyChar) == 27) // код клавиши Esc
                {
                    break;
                }
            } while (true);
        }
    }
}
