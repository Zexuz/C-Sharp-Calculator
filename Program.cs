using System;
using Calculator.lib.Node;

namespace Calculator {

    internal class Program {

        private void Start() {

            Console.WriteLine("Type the operation (+,-,/,*)");
            var operation = NodeFactory.GetOperationNode(Console.ReadKey().Key);

            Console.WriteLine("\nFirst number");

            operation.Left = NodeFactory.SetValueOfNodeFromConsoleRead();

            Console.WriteLine("Seccond Number");
            operation.Right = NodeFactory.SetValueOfNodeFromConsoleRead();

            var sum = operation.Evaluate();

            Console.WriteLine($"the sum is {sum}");

            Console.ReadLine();
        }





        static void Main(string[] args) {

            new Program().Start();

        }

    }

}


