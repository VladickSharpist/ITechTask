using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using PizzaRobot.Interfaces;

namespace PizzaRobot
{
    public class FieldBuilder : IFieldBuilder
    {
        private const string SizePattern = @"^(?<Heigth>[0-9]{1,})x(?<Width>[0-9]{1,})\s+";
        private const string PointPattern = @"\(\s*(?<X>-?\d+)\s*,\s*(?<Y>-?\d+)\s*\)";

        private Point GetPointFromMatch(Match match)
        {
            var x = Convert.ToInt32(match.Groups["X"].Value);
            var y = Convert.ToInt32(match.Groups["Y"].Value);
            if (x < 0 || y < 0)
            {
                throw new Exception("x or y is lower then zero");
            }

            return new Point(x, y);
        }

        private List<Point> ParsePoints(string input)
        {
            var pointExpr = new Regex(PointPattern);
            var matches = pointExpr.Matches(input);
            if (matches.Count == 0)
            {
                throw new Exception("No points to deliver or input is wrong");
            }

            return matches
                .Select(GetPointFromMatch)
                .ToList();
        }

        public Field CreateField(string input)
        {
            var size = new Regex(SizePattern);

            var match = size.Match(input);
            if (match.Length == 0)
            {
                throw new Exception("Field size or input is wrong");
            }

            var newPointList = ParsePoints(input);
            var field = new Field
            {
                PizzaPoints = newPointList,
                Height = Convert.ToInt32(match.Groups["Heigth"].Value),
                Width = Convert.ToInt32(match.Groups["Width"].Value)
            };
            return field;
        }
    }
}