using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    class Point
    {
        double x;
        double y;

        public double GetDistance1()
        {
            return x;
        }

        public double GetDistance2()
        {
            return y;
        }
        public void SetX(double x)
        {
            this.x = x;
        }
        public void SetY(double y)
        {
            this.y = y;
        }
        public double X { get; set; } // Автосвойство
        public double Y { get; set; }
        public void Print()
        {
            Console.WriteLine($"X = {X}\tY = {Y}");
        }
        public void Distance(double X)
        {
            Console.WriteLine($"Расстояние до указанной точки: {X}");
        }
        public void FindDistance(double X, double Y)
        {
            Console.WriteLine($"Расстояние между {X} и {Y} = {X-Y}");
        }
    }
}
