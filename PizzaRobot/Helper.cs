using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using PizzaRobot.Interfaces;

namespace PizzaRobot
{
    public class Helper : IHelper
    {
        private const string SizePattern = @"^(?<Heigth>[0-9]{1,})x(?<Width>[0-9]{1,})";
        private const string PointPattern = @"\(\s*(?<X>\d+)\s*,\s*(?<Y>\d+)\s*\)";

        public List<Point> ParsePoints(string input)
        {
            var pointExpr = new Regex(PointPattern);
            var match2 = pointExpr.Matches(input);
            if (match2.Count == 0)
            {
                throw new Exception("No points to deliver or input is wrong");
            }
            var pointList = new List<Point>();
            for (var i = 0; i < match2.Count; i++)
            {
                var x = Convert.ToInt32(match2[i].Groups["X"].Value);
                var y = Convert.ToInt32(match2[i].Groups["Y"].Value);
                pointList.Add(new Point(x,y));
            }
            var sortedPoints = pointList.OrderBy(x=>x.X).ThenBy(x=>x.Y).ToList();
            return sortedPoints;
        }
        public Field CreateField(string input)
        {
            var sizeExpr = new Regex(SizePattern);

            var match = sizeExpr.Match(input);
            if (match.Length == 0)
            {
                throw new Exception("Field size input is wrong");
            }
            var newPointList = ParsePoints(input);
            var field = new Field {PizzaPoints = newPointList,
                Height = Convert.ToInt32(match.Groups["Heigth"].Value),
                Width = Convert.ToInt32(match.Groups["Width"].Value)};
            return field;
        }
    }
}