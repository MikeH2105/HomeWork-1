/*Пользователь вводит с клавиатуры два числа. Первое
число — это значение, второе число процент, который
необходимо посчитать. Например, мы ввели с клавиатуры
90 и 10. Требуется вывести на экран 10 процентов от 90.
Результат: 9.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.WriteLine("Доброго дня!\nВведіть будь-ласка число");
            string numberString = Console.ReadLine();
            double number = Convert.ToInt32(numberString);
            Console.WriteLine("Введіть будь ласка відсоток");
            string procentString = Console.ReadLine();
            double procent = Convert.ToInt32(procentString);
            double rezult;
            rezult = number / 100 * procent;
            Console.WriteLine(+procent + "відсотків від числа: " + number + " = " + rezult);
            Console.WriteLine("Дякуємо!!!");
            Console.ReadKey();
        }
    }
}
