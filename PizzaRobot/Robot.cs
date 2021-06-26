using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PizzaRobot.Interfaces;

namespace PizzaRobot
{
    public class Robot : IRobot
    {
        public Point Position { get; set; }
        public StringBuilder Route { get; } = new StringBuilder();

        public Robot() : this(new Point(0, 0))
        {
        }

        public Robot(Point start)
        {
            Position = new Point(start.X, start.Y);
        }

        public Point GetNearbyPoint(List<Point> points)
        {
            var distances = points.Select(x => x.GetDistance(Position)).ToList();
            var nearbyPoint = points[distances.IndexOf(distances.Min())];
            return nearbyPoint;
        }

        public void Move(Point moveToPoint)
        {
            if (moveToPoint.X > Position.X)
            {
                while (Position.X != moveToPoint.X)
                {
                    Position.X += 1;
                    Route.Append("E");
                }
            }
            else
            {
                while (Position.X != moveToPoint.X)
                {
                    Position.X -= 1;
                    Route.Append("W");
                }
            }

            if (moveToPoint.Y > Position.Y)
            {
                while (Position.Y != moveToPoint.Y)
                {
                    Position.Y += 1;
                    Route.Append("N");
                }
            }
            else
            {
                while (Position.Y != moveToPoint.Y)
                {
                    Position.Y -= 1;
                    Route.Append("S");
                }
            }
        }

        public void DropPizza()
        {
            Route.Append("D");
        }
    }
}