namespace Homework_2_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину в дюймах");
            double inch = Convert.ToDouble(Console.ReadLine());

            // конвертируем в метры
            double totalMetric = inch * 2.54 / 100;

            // находим целые метры (округляем вниз, отрезая см и мм)
            int meters = (int)Math.Floor(totalMetric);

            // находим целые санты (тотал минус целые метры * 100 (перенос запятой на 2 знака влево)
            int smeters = (int)Math.Floor((totalMetric - meters) * 100);

            // от общего отнимаем всё что нашли, преводим в милимы (*1000) и округляем до одного знака после запятой, согласно заданию
            double mmeters = Math.Round((totalMetric - meters - smeters / 100.0) * 1000, 1);

            Console.WriteLine("{0} дюйма(-ов) это {1} метра(-ов)", inch, totalMetric);
            Console.WriteLine("{0}м {1}см {2}мм", meters, smeters, mmeters);

            Console.WriteLine("Find and press ANY key to continue");
            Console.ReadKey();
        }
    }
}
