using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using MineSweeperGame.src;

namespace MineSweeperGame.Tests
{
    [TestClass()]
    public class MainWindowTests
    {
        [TestMethod()]
        public void TestStateIsBomb()
        {
            State newState = new State(0, 0, true);

            Assert.AreEqual(true, newState.IsBomb);
        }

        [TestMethod()]
        public void TestGenerateRandomPoint()
        {
            int dimensions = 5;
            List<Point> pointsList = new List<Point> { };

            Point randomPoint = Point.GenerateValidRandomPoint(dimensions, dimensions, pointsList);

            Assert.IsNotNull(randomPoint.X);
        }


    }
}