using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    partial class Program
    {
        private static void IncreaseGameScore()
        {
            gameScore++;
            Console.Title = "Количество очков:"  + gameScore;
        }
        private static void DecreaseGameScore()
        {
            gameScore--;
            Console.Title = "Количество очков:" + gameScore;
        }

    }
}
