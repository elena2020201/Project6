using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace наименьш_наибольш_числа_фор_консоль
{
    class Program
    {
        static void Main()
        {
            try
            {
                Console.WriteLine("Введите первое целое число");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите второе целое число");
                int num2 = Convert.ToInt32(Console.ReadLine());
                int min, max;
                if (num1 < num2)
                {
                    min = num1;
                    max = num2;
                    for (int i = min; i <= max; i++)
                        Console.WriteLine(i);
                }
                else
                {
                    max = num2;
                    min = num1;
                    for (int i = max; i <= min; i++)
                    {
                        Console.WriteLine(i);
                    }
                }
                Console.ReadKey();
            }
            catch
            {
                Console.WriteLine("Вы ввели не целое число!", "Ошибка");
            }
            Console.WriteLine("Программа завершена", "Завершение");
            Console.ReadKey();
        }
    }
}