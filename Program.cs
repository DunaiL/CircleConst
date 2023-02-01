using System;

namespace Circle
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 0, y = 0; // Координаты центра окружности. 
            double r = 10; // Радиус окружности. 

            Console.Write("Введите координаты точки: ");

            x = Convert.ToDouble(Console.ReadLine()); // Ввод координат X. 

            y = Convert.ToDouble(Console.ReadLine()); // Ввод координат Y.

            if (Math.Sqrt(Math.Pow(x - 0, 2) + Math.Pow(y - 0, 2)) <= r) // Проверка, находятся ли указанные координаты (x;y) внутри указанной окружности (r).  
                Console.WriteLine("Точка ({0};{1}) - попала!", x, y);
            else
                Console.WriteLine("Точка ({0};{1}) - не попалa!", x, y);

            Console.ReadKey();
        }
    }
}