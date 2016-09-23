namespace Calculator.lib.Node.Opeartions {

    public class MultiplicationNode:OpNode {

        public override double Evaluate() {
            return Left.Evaluate() * Right.Evaluate();
        }

    }

}