using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            try // применение оператора try
            {
                // Вычисляем факториал числа
                int i, result = 1, num = 1; // присвоение локальным переменным целого типа int

                Console.WriteLine("Введите число:"); // просьба пользователя ввести число
                i = int.Parse(Console.ReadLine()); // чтение указанного пользователем значения числа, которое имеет целый тип int

                Console.Write("\n\nФакториал {0} = ", i); // вывод на экран строки с вычисленным значением указнной переменной
                do
                {
                    result *= num; // использование операторов для вычисления 
                    num++; // указание условия
                } while (num <= i); // применение цикла while и указание условия

                Console.Write(result); // вывод на экран значения вычисленной переменной result 
            }
            catch (FormatException ex)  // оператор catch// Исключение, которое возникает в случае, если формат аргумента недопустим или строка составного формата построена неправильно.
            {
                Console.WriteLine("Вы ввели не число. {0}", ex.Message); // вывод на экран строки с вычисленным значением указнной переменной// ex.Message - Возвращает сообщение, описывающее текущее исключение.
            }
            finally
            {
                Console.ReadLine(); // чтение строки
            }
        }
    }
}
