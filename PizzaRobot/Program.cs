using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace PizzaRobot
{
    class Program
    {
        static void Main(string[] args)
        {
            //5x5 (0, 0) (1, 3) (4,4) (4, 2) (4, 2) (0, 1) (3, 2) (2, 3) (4, 1)3x3 (0, 0) (0, 2) (2,2) (2, 0)
            
            Console.WriteLine("Enter");
            var input =Console.ReadLine();
            var builder = new FieldBuilder();
            try
            {
                var field = builder.CreateField(input);
                var robot = new Robot();
                while (field.PizzaPoints.Count!=0)
                {
                    var point = robot.GetNearbyPoint(field.PizzaPoints);
                    robot.Move(point);
                    robot.DropPizza();
                    field.PizzaPoints.Remove(point);
                }
                Console.WriteLine($"Finished at position: {robot.Position} Route: {robot.Route}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}