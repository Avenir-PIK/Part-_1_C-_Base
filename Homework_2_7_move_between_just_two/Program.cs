namespace Homework_2_7_move_between_just_two
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число");
            double dig1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            double dig2 = Convert.ToDouble(Console.ReadLine());

            Console.Clear();
            Console.WriteLine("Вы ввели Число1 = {0} а Число2 = {1}", dig1, dig2);
            Console.WriteLine("");

            // нечто подобное используют в шифровании с открытым ключом (SHA-256 к примеру вроде бы)

            //шаг 0
            Console.WriteLine("\tШаг 0: \ndig1 = {0} \ndig2 = {1}", dig1, dig2);
            //шаг 1
            dig1 *= dig2;
            Console.WriteLine("\tШаг 1: \tdig1 *= dig2\ndig1 = {0} \ndig2 = {1}", dig1, dig2);
            //шаг 2
            dig2 *= dig1;
            Console.WriteLine("\tШаг 2: \tdig2 *= dig1\ndig1 = {0} \ndig2 = {1}", dig1, dig2);
            //шаг 3
            dig1 = dig2 / dig1;
            Console.WriteLine("\tШаг 3: \tdig2 / dig1\ndig1 = {0} \ndig2 = {1}", dig1, dig2);
            //шаг 4
            dig2 = dig2 / dig1;
            Console.WriteLine("\tШаг 4: \tdig2 / dig1\ndig1 = {0} \ndig2 = {1}", dig1, dig2);
            //шаг 5
            dig2 = dig2 / dig1;
            Console.WriteLine("\tШаг 5: \tdig2 / dig1\ndig1 = {0} \ndig2 = {1}", dig1, dig2);

            Console.WriteLine("");
            Console.WriteLine("Магическим образом числа поменялись местами");
            Console.WriteLine("");
            Console.WriteLine("Find and press ANY key to continue");
            Console.ReadKey();
        }
    }
}
