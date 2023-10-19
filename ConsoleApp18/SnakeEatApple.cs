using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    partial class Program
    {
        private static bool SnakeEatApple()
        {
            return (apple[0] == snake[0][0] && apple[1] == snake[0][1]);
        }
        private static bool SnakeEatFuapple()
        {
            return (Fuapple[0] == snake[0][0] && Fuapple[1] == snake[0][1]);

            if (snake.Count == 1 & Fuapple[0] == snake[0][0] && Fuapple[1] == snake[0][1])
            {
                GameOver();
            }
        }
    }
}

