using System.Collections.Generic;

namespace PizzaRobot.Interfaces
{
    public interface IHelper
    {
        public Field CreateField(string input);
        public List<Point> ParsePoints(string input);
    }
}