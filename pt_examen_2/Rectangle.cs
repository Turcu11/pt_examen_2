using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pt_examen_2
{
    public class Rectangle
    {
        public Rectangle(Point topLeftPoint, int side1, int side2)
        {
            topLeft = topLeftPoint;
            topRight = new Point(topLeft.xPosition + side1, topLeft.yPosition);
            bottomRight = new Point(topRight.xPosition, topRight.yPosition + side2);
            bottomLeft = new Point(topLeft.xPosition, bottomRight.yPosition);
        }

        public Point topLeft { get; }
        public Point topRight { get; }
        public Point bottomLeft { get; }
        public Point bottomRight { get; }

        public void Print()
        {
            Console.WriteLine($"Rectangle configuration: ");
            Console.WriteLine($"P1 - {topLeft.xPosition} X {topLeft.yPosition}");
            Console.WriteLine($"P2 - {topRight.xPosition} X {topRight.yPosition}");
            Console.WriteLine($"P3 - {bottomLeft.xPosition} X {bottomLeft.yPosition}");
            Console.WriteLine($"P4 - {bottomRight.xPosition} X {bottomRight.yPosition}");
        }

        public void Translate(int dx, int dy)
        {
            topLeft.xPosition = topLeft.xPosition + dx;
            topLeft.yPosition = topLeft.yPosition + dy;
            topRight.xPosition = topRight.xPosition + dx;
            topRight.yPosition = topRight.yPosition + dy;
            bottomLeft.xPosition = bottomLeft.xPosition + dx;
            bottomLeft.yPosition = bottomLeft.yPosition + dy;
            bottomRight.xPosition = bottomRight.xPosition + dx;
            bottomRight.yPosition = bottomRight.yPosition + dy;
        }
    }
}
