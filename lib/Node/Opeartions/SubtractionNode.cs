namespace Calculator.lib.Node.Opeartions {

    public class SubtractionNode:OpNode {

        public override double Evaluate() {
            return Left.Evaluate() - Right.Evaluate();
        }

    }

}