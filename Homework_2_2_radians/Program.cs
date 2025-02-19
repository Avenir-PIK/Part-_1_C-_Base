namespace Homework_2_2_radians
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите градусы");
            int deg = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите минуты");
            int min = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите секунды");
            int sec = Convert.ToInt32(Console.ReadLine());

            // Радианы не обнуляются при 360+ градусах, а продолжают увеличиваться.

            double rad = (deg/180.0 + min/180/60.0 + sec/180/60/60.0) * Math.PI;

            Console.WriteLine(rad);

            Console.WriteLine("Find and press ANY key to continue");
            Console.ReadKey();
        }
    }
}
