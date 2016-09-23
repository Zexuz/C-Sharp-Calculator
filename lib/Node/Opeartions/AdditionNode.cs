namespace Calculator.lib.Node.Opeartions {

    public class AdditionNode:OpNode {

        public override double Evaluate() {
            return Left.Evaluate() + Right.Evaluate();
        }

    }

}