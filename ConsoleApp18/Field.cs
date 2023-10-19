using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    partial class Program
    {
        private static void Field()
        {
            Pen pole = new Pen(Brushes.AliceBlue, 1);
            graphics.DrawRectangle(pole, 20, 20, 410, 410);
        }
    }

}
    

