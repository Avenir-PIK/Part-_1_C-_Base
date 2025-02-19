using System.ComponentModel.Design.Serialization;

namespace Homework_2_6_round_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину трубы:");

            double iPipeLenght = Convert.ToDouble(Console.ReadLine());

            // умножаем на 2, чтобы округлять до ближайшей 1цы, после чего снова делим на 2

            double oPipeLenght = Math.Round(iPipeLenght*2)/2;

            Console.WriteLine("");
            Console.WriteLine("Длина трубы округлена до ближайших 0,5");
            Console.WriteLine("");
            Console.WriteLine("Было {0}, а стало {1}", iPipeLenght, oPipeLenght);
            Console.WriteLine("");
            Console.WriteLine("Find and press ANY key to continue");
            Console.ReadKey();
        }
    }
}
