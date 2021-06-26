using System;
using System.Collections.Generic;

namespace PizzaRobot
{
    public class Field
    {
        public int Width
        {
            get => Width;
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Width lower then zero");
                }
            }
        }

        public int Height
        {
            get => Height;
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Height lower then zero");
                }
            }
        }

        public List<Point> PizzaPoints { get; set; }
    }
}