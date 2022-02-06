using System;

namespace pt_examen_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(1, 1);
            p1.PrintPoint(p1);
            p1.Translate(4, 5);
            p1.PrintPoint(p1);
            Point p2 = new Point(4, 8);
            Point p3 = new Point(1, 6);
            Point p4 = new Point(8, 3);

            Triangle t1 = new Triangle(p1, p2, p3);
            t1.Print();
            t1.Translate(4, 5);
            t1.Print();

            Rectangle r1 = new Rectangle(p1, 5, 7);
            r1.Print();
            r1.Translate(2, 2);
            r1.Print();

            int factorial = Recursivity.Rec(5);
            Console.WriteLine(factorial);
        }
    }
}
