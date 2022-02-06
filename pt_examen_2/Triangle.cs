using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pt_examen_2
{
    public class Triangle
    {
        public Triangle(Point p1, Point p2, Point p3)
        {
            P1 = p1;
            P2 = p2;
            P3 = p3;
        }

        public Point P1 { get; }
        public Point P2 { get; }
        public Point P3 { get; }

        public void Translate(int dx, int dy)
        {
            P1.Translate(dx, dy);
            P2.Translate(dx, dy);
            P3.Translate(dx, dy);
        }
        public void Print()
        {
            Console.WriteLine("Triangle configuration:");
            Console.WriteLine($"P1 - {P1.xPosition} X {P1.yPosition}");
            Console.WriteLine($"P2 - {P2.xPosition} X {P2.yPosition}");
            Console.WriteLine($"P3 - {P3.xPosition} X {P3.yPosition}");
        }
    }
}
