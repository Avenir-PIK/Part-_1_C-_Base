using System.ComponentModel.Design.Serialization;

namespace Homework_2_5_PipeRound
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину трубы:");

            double iPipeLenght = Convert.ToDouble(Console.ReadLine());
            
            // Лучше приводить через явное преобразование или через конверт?

            // через конверт
            //int oPipeLenght = Convert.ToInt32(Math.Ceiling(iPipeLenght));
            
            // через явное
            int oPipeLenght = (int)(Math.Ceiling(iPipeLenght));


            Console.WriteLine("");
            Console.WriteLine("Длина трубы округлена вверх");
            Console.WriteLine("");
            Console.WriteLine("Было {0}, а стало {1}", iPipeLenght, oPipeLenght);
            Console.WriteLine("");
            Console.WriteLine("Find and press ANY key to continue");
            Console.ReadKey();
        }
    }
}
