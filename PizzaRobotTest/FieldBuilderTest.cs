using System.Text.RegularExpressions;
using Microsoft.VisualStudio.TestPlatform.Utilities.Helpers.Interfaces;
using Moq;
using NUnit.Framework;
using PizzaRobot;
using PizzaRobot.Interfaces;
using Match = System.Text.RegularExpressions.Match;

namespace PizzaRobotTest
{
    public class FieldBuilderTest
    {
        private IFieldBuilder _fieldBuilder;
        [SetUp]
        public void Setup()
        {
            _fieldBuilder = new FieldBuilder();
        }

        [Test]
        [TestCase()]
        public void CreateField(string input)
        {
            
        }
    }
}