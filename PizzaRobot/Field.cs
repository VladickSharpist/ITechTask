using System;
using System.Collections.Generic;

namespace PizzaRobot
{
    public class Field
    {

        private int _width;
        private int _height;
        public int Width
        {
            get => _width;
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Width lower then zero");
                }

                _width = value;
            }
        }

        public int Height
        {
            get => _height;
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Height lower then zero");
                }

                _height = value;
            }
        }

        public List<Point> PizzaPoints { get; set; }
    }
}