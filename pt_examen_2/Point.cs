using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pt_examen_2
{
    public class Point
    {
        public int xPosition { get; set; }
        public int yPosition { get; set; }

        public Point(int x, int y)
        {
            xPosition = x;
            yPosition = y;
        }

        public void PrintPoint(Point p)
        {
            Console.WriteLine($"{p.xPosition} - {p.yPosition}");
        }

        public void Translate(int dx, int dy)
        {
            xPosition = xPosition + dx;
            yPosition = yPosition + dy;
        }
    }
}
