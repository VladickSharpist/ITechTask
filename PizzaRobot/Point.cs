using System;

namespace PizzaRobot
{
    public class Point
    {
        public Point()
        {
            
        }
        public Point(int x,int y)
        {
            X = x;
            Y = y;
        }
        public int X { get; set; }
        public int Y { get; set; }

        public override string ToString()
        {
            return $"({X},{Y})";
        }

        public double GetDistance(Point point)
        {
            return Math.Sqrt(Math.Pow(point.X-X,2)+Math.Pow(point.Y-Y,2));
        }
    }
}