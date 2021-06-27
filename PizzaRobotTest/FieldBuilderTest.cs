using System;
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
        [TestCase("3x4 (1,3) (2,2)")]
        public void CreateField_correctObject(string input)
        {
            var field = _fieldBuilder.CreateField(input);
            Assert.That(field.Height == 3);
            Assert.That(field.Width == 4);
            Assert.That(field.PizzaPoints.Count == 2);
        }

        [Test]
        [TestCase("5x5 (2,3) (4,2)")]
        public void CreateField_correctPoints(string input)
        {
            var field = _fieldBuilder.CreateField(input);
            Assert.That(field.PizzaPoints
                .Exists(x => x.X == 2 && x.Y == 3));
            Assert.That(field.PizzaPoints
                .Exists(x => x.X == 4 && x.Y == 2));
        }

        [Test]
        [TestCase("")]
        [TestCase("sdasd")]
        [TestCase("5x5fd")]
        [TestCase("ds5x5")]
        [TestCase("ds5x5asd")]
        public void CreateField_WrongSizeInput(string input)
        {
            var ex = Assert.Throws<Exception>(() =>
                _fieldBuilder.CreateField(input));
            Assert.That(ex.Message == "Field size or input is wrong");
        }

        [Test]
        [TestCase("5x5 ")]
        [TestCase("5x5 (,1)")]
        [TestCase("5x5 (1,)")]
        [TestCase("5x5 (,)")]
        public void CreateField_WrongPointsInput(string input)
        {
            var ex = Assert.Throws<Exception>(() =>
                _fieldBuilder.CreateField(input));
            Assert.That(ex.Message == "No points to deliver or input is wrong");
        }

        [Test]
        [TestCase("5x5 (-1,-2)")]
        [TestCase("5x5 (-1,3)")]
        [TestCase("5x5 (5,-2)")]
        public void CreateField_PointBelowZero(string input)
        {
            var ex = Assert.Throws<Exception>(() =>
                _fieldBuilder.CreateField(input));
            Assert.That(ex.Message == "x or y is lower then zero");
        }
    }
}