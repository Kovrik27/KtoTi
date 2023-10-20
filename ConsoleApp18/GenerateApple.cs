using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    partial class Program
    {
        private static object poisonApple;

        private static void GenerateApple()
        {
            // с помощью рандомайзера сгенерировать 2 числа в промежутке от 0 до 40, полученные числа домножить на 10
            // назначить полученные числа в координаты apple
            // нарисовать зеленый круг размером 10 на 10 по новым координатам
            for (int i = 0; i < 2; i++)
                apple[i] = random.Next(2, 27);

            if (apple != snake[0])
            {
                apple[0] = apple[0] * 10;
                apple[1] = apple[1] * 10;
                graphics.FillEllipse(System.Drawing.Brushes.Red, apple[0], apple[1], 10, 10);
            }
            else
                GenerateApple();
        }
        private static void GenerateFuapple()
        {
            //Отравленное яблоко
            Random random = new Random();
            bool firstPrint = true; //отравленное яблоко не может появиться первым 

            for (int i = 0; i < 10; i++)
            {
                double chance = random.NextDouble(); //шанс появления яблока
                if (firstPrint)
                {
                    firstPrint = false;
                }
                else if (chance < 0.5)// если шанс в chance меньше 0.5, то яблоко рисуется 
                {
                    do// проверка на совпадение яблока с змейкой
                    {

                        for (int j = 0; j < 2; j++)
                            Fuapple[j] = random.Next(2, 27);
                        Fuapple[0] = Fuapple[0] * 10;
                        Fuapple[1] = Fuapple[1] * 10;
                        graphics.FillEllipse(System.Drawing.Brushes.Yellow, Fuapple[0], Fuapple[1], 10, 10); // создает несколько яблок, но только одно из них
                    }                                                                                               // является настоящим
                    while (IntersectAppleWithSnake(Fuapple[0], Fuapple[1]));
                }
            }
        }
        private static bool IntersectAppleWithSnake(int x, int y)
        {
            for (int s = 0; s < snake.Count; s++)
            {
                if (snake[s][0] == x && snake[s][1] == y)
                    return true;
            }
            return false;
        }
    }
}
