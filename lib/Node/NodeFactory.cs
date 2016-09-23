using System;

using Calculator.lib.Exceptions;
using Calculator.lib.Node.Opeartions;

using InvalidOperationException = Calculator.lib.Exceptions.InvalidOperationException;

namespace Calculator.lib.Node {

    public class NodeFactory {

        public static OpNode GetOperationNode(ConsoleKey key) {
            switch (key) {
                case ConsoleKey.Add:
                    return new AdditionNode();
                case ConsoleKey.Multiply:
                    return new MultiplicationNode();
                case ConsoleKey.Divide:
                    return new DivissionNode();
                case ConsoleKey.Subtract:
                    return new SubtractionNode();
                default:
                    throw new InvalidOperationException($"The operation {key} is not valid");
            }
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