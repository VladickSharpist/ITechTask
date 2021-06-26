using System;
using System.Text;
using PizzaRobot.Interfaces;

namespace PizzaRobot
{
    public class Robot : IRobot
    {
        public Point Position { get; set; }
        public StringBuilder Route { get; }

        public Robot()
        {
            Position = new Point(0, 0);
            Route = new StringBuilder();
        }

        public Robot(Point start)
        {
            Position = new Point(start.X, start.Y);
            Route = new StringBuilder();
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