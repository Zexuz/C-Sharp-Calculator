using System;

using Calculator.lib.Node;

using NUnit.Framework;

namespace UnitTest {

    [TestFixture]
    internal class Program {

        [Test]
        public void TestAddOperation() {
            Assert.AreEqual(NodeFactory.GetSumFromNode(ConsoleKey.Add, 10, 5), 15);
        }

        [Test]
        public void TestDivideOperation() {
            Assert.AreEqual(NodeFactory.GetSumFromNode(ConsoleKey.Divide, 10, 5), 2);
            Assert.AreEqual(NodeFactory.GetSumFromNode(ConsoleKey.Divide, 10, 6), 10.0 / 6.0, 0.00001);
            Assert.AreEqual(double.IsInfinity(NodeFactory.GetSumFromNode(ConsoleKey.Divide, 10, 0)), true);
        }

        [Test]
        public void TestSubtractOperation() {
            Assert.AreEqual(NodeFactory.GetSumFromNode(ConsoleKey.Subtract, 10, 5), 5);
            Assert.AreEqual(NodeFactory.GetSumFromNode(ConsoleKey.Subtract, 5, 5), 0);
            Assert.AreEqual(NodeFactory.GetSumFromNode(ConsoleKey.Subtract, 5, 6), -1);
        }

        [Test]
        public void TestMultiplyOperation() {
            Assert.AreEqual(NodeFactory.GetSumFromNode(ConsoleKey.Multiply, 10, 5), 50);
            Assert.AreEqual(NodeFactory.GetSumFromNode(ConsoleKey.Multiply, 10, 5.5), 55);
            Assert.AreEqual(NodeFactory.GetSumFromNode(ConsoleKey.Multiply, 10, 0.1), 1);
        }

    }

}