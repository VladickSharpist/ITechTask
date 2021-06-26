using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace PizzaRobot.Interfaces
{
    public interface IHelper
    {
        public const string SizePattern = @"^(?<Heigth>[0-9]{1,})x(?<Width>[0-9]{1,})";
        public const string PointPattern = @"\(\s*(?<X>\d+)\s*,\s*(?<Y>\d+)\s*\)";
        public Field CreateField(string input);
        public List<Point> ParsePoints(string input);
        public List<Point> PointsFromMatches(MatchCollection matchCollection);
        public Point GetPointFromMatch(Match match);
    }
}