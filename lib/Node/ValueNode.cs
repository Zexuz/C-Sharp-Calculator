namespace Calculator.lib.Node {

    public class ValueNode:Node {

        private readonly double _value;


        public ValueNode(double value) {
            _value = value;
        }

        public override double Evaluate() {
            return _value;
        }

    }

}