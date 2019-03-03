using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Задание 2. Ввести с клавиатуры номер трамвайного билета(6-значное число)
//и про-верить является ли данный билет счастливым(если на билете напечатано шестизначное число,
//и сумма первых трёх цифр равна сумме последних трёх, то этот билет считается счастливым).

namespace dz_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Enter number of ticket (6 numbers)");


            string sticket = Console.ReadLine();
            if (sticket.Length == 6)
            {
               
                int ticket = Convert.ToInt32(sticket);
                Console.WriteLine((Convert.ToInt32(Convert.ToString(sticket)[0].ToString()) +
                                   Convert.ToInt32(Convert.ToString(sticket)[1].ToString()) +
                                   Convert.ToInt32(Convert.ToString(sticket)[2].ToString())) ==
                                  (Convert.ToInt32(Convert.ToString(sticket)[3].ToString()) +
                                   Convert.ToInt32(Convert.ToString(sticket)[4].ToString()) +
                                   Convert.ToInt32(Convert.ToString(sticket)[5].ToString()))
                    ? "Ticket is lucky"
                    : "Ticket is not lucky");
            }
           
            else
            { 
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("End of programm");
                Console.BackgroundColor = ConsoleColor.Black;

            }
            Console.ReadLine();
        }
    }
}
