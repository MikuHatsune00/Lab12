using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    class Program
    {
        static void Main(string[] args)
        {

            
            Circle.L();
            Circle.S();
            Circle.coordInside();
            Console.ReadKey();
        }


        public static class Circle
        {
            public static int R;
            public static int x;
            public static int y;
            public static int x1;
            public static int y1;

            static Circle()
            {
                Console.WriteLine("Введите радиус окружности R:");
                R=Convert.ToInt32(Console.ReadLine());
                x=0;
                y = 0;
            }
            public static void L()
            { 
                Console.WriteLine("Длина окружности = {0:0.00}", 2 * Math.PI * R);
            }

            public static void S()
            {
                Console.WriteLine("Площадь окружности = {0:0.00}", Math.PI * Math.Pow(R,2));
            }

            public static void coordInside()
            {
                Console.WriteLine("Проверим, лежит ли координата точка с координатами (x1,y1) в области окружности R");
                Console.WriteLine("Введите координату x1:");
                x1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите координату y1:");
                y1 = Convert.ToInt32(Console.ReadLine());
                double r1;
                r1 = Convert.ToDouble (Math.Sqrt(Math.Pow(x - x1, 2) + Math.Pow(y - y1, 2)));
                if (r1<=R)
                {
                    Console.WriteLine("Точка лежит в области окружности R");
                }
                else
                {
                    Console.WriteLine("Точка не лежит в области окружности R");
                }
            }

        }
    }
}
