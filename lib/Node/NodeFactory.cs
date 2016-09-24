using System;
using System.Collections.Generic;

using Calculator.lib.Exceptions;
using Calculator.lib.Node.Opeartions;

using InvalidOperationException = Calculator.lib.Exceptions.InvalidOperationException;

namespace Calculator.lib.Node {

    public class NodeFactory {

        private static readonly Dictionary<char, OpNode> Operations = new Dictionary<char, OpNode> {
            {'+', new AdditionNode()},
            {'*', new MultiplicationNode()},
            {'/', new DivissionNode()},
            {'-', new SubtractionNode()}
        };

        public static OpNode GetOperationNode(char key) {
            if (!Operations.ContainsKey(key)) throw new InvalidOperationException($"The operation {key} is not valid");

            return Operations[key];
        }

        public static double GetSumFromNode(char key, double d1, double d2) {
            var opNode = GetOperationNode(key);
            opNode.Left = SetValueOfNode(d1);
            opNode.Right = SetValueOfNode(d2);
            return opNode.Evaluate();
        }


        public static ValueNode SetValueOfNodeFromConsoleRead() {
            double d;
            var str = Console.ReadLine();

            try {
                d = double.Parse(str);
            }
            catch (Exception) {
                throw new NotANumberException($"{str} is not a number!");
            }

            return SetValueOfNode(d);
        }

        public static ValueNode SetValueOfNode(double d) {
            return new ValueNode(d);
        }

    }

}