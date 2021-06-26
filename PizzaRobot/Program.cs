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
            //5x5 (0, 0) (1, 3) (4,4) (4, 2) (4, 2) (0, 1) (3, 2) (2, 3) (4, 1)
            Console.WriteLine("Enter");
            var input =Console.ReadLine();
            var helper = new Helper();
            try
            {
                var field = helper.CreateField(input);
                var robot = new Robot();
                foreach (var point in field.PizzaPoints)
                {
                    robot.Move(point);
                    robot.DropPizza();
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