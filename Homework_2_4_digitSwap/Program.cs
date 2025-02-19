using System.ComponentModel.Design.Serialization;

namespace Homework_2_4_digitSwap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите 4х значное число:");

            // так как по условию на входе четырехзначное число, то берем short

            short digit = Convert.ToInt16(Console.ReadLine());

            // раскладываем по переменным? так как [0-9], то берем байт

            byte d1 = (byte)(digit / 1000 % 10);
            byte d2 = (byte)(digit / 100 % 10);
            byte d3 = (byte)(digit / 10 % 10);
            byte d4 = (byte)(digit % 10);

            //почему то не даёт это сделать шортом
            int newdigit = (d1 * 1000) + (d4 * 100) + (d3 * 10) + (d2);

            // меняем цифры местами на выводе, выводим набор цифр

            Console.WriteLine("Вывод как набор цифр");
            Console.WriteLine("Было {0}, а стало {1}{2}{3}{4}", digit, d1, d4, d3, d2);

            Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");
            // вывод как число из цифр

            Console.WriteLine("Вывод как единое число");
            Console.WriteLine("Было {0}, а стало {1}", digit, newdigit);


            Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");
            Console.WriteLine("Find and press ANY key to continue");
            Console.ReadKey();
        }
    }
}
