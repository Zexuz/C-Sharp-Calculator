namespace Calculator.lib.Node.Opeartions {

    public class DivissionNode:OpNode {

        public override double Evaluate() {
            return Left.Evaluate() / Right.Evaluate();
        }

    }

}