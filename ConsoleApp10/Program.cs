using System;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            //Объявление и ввод количества строк и столбцов двумерного массива
            int rows, cols;
            Console.WriteLine("Введите количество строк:");
            rows = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите количество столбцов:");
            cols = Convert.ToInt32(Console.ReadLine());
            int[,] array = new int[rows, cols];
            //Значение которое будет присваиваться элементам массива
            int value = 1;
            //Координаты движения по массиву
            int x = 0, y = 0, oldsx;
            //Максимальные и минимальные значения координат массива
            int maxx = cols, maxy = rows, minx = 0, miny = 1;
            //Направление движения по массиву
            int sx = 1, sy = 0;
            //Проверка выхода за координаты массива
            bool found;           
            array[0, 0] = value;
            do
            {
                found = false;
                while ((sx > 0 & x <maxx-1) | (sx < 0 & x > minx) | (sy > 0 & y < maxy-1) | (sy < 0 & y > miny))
                {                   
                    x += sx;
                    y += sy;
                    value += 1;
                    array[y, x] = value;                    
                    found = true;
                }
                //Уменьшение координат массива для проверки
                if (sx < 0) minx += 1;
                if (sx > 0) maxx -= 1;
                if (sy < 0) miny += 1;
                if (sy > 0) maxy -= 1; 
                //Изменение направления движения по массиву
                oldsx = sx;
                sx = -1 * sy;
                sy = oldsx;                
            } while (found == true);
            //Отображение массива
            Console.WriteLine("Двумерный массив, заполненый по спирали:");
            for(int i=0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write("\t{0}", array[i, j]);
                }
                Console.WriteLine("");
            }
        }
    }
}
