using System.Text.RegularExpressions;
using Microsoft.VisualStudio.TestPlatform.Utilities.Helpers.Interfaces;
using Moq;
using NUnit.Framework;
using PizzaRobot;
using PizzaRobot.Interfaces;
using Match = System.Text.RegularExpressions.Match;

namespace PizzaRobotTest
{
    public class HelperTest
    {
        private IHelper _helper;
        [SetUp]
        public void Setup()
        {
            _helper = new Helper();
        }

        [Test]
        public void GetPointFromMatch()
        {
            
        }
    }
}