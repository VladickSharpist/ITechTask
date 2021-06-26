using System.Collections.Generic;

namespace PizzaRobot
{
    public class Field
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public List<Point> PizzaPoints { get; set; }
    }
}