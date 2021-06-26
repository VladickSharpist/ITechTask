using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace PizzaRobot.Interfaces
{
    public interface IFieldBuilder
    {
        public Field CreateField(string input);
    }
}