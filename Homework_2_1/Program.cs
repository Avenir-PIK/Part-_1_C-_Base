namespace Homework_2_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите трехзначное число");
            int dig = Convert.ToInt32(Console.ReadLine());

            int d1 = dig / 100;
            int d2 = (dig / 10) % 10;
            int d3 = dig % 10;

            Console.WriteLine("{2}{0}{1}", d1, d2, d3);

            Console.WriteLine("Find and press ANY key to continue");
            Console.ReadKey();
        }
    }
}
