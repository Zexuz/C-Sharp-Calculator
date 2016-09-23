using System;

namespace Calculator.lib.Exceptions {

    public class InvalidOperationException : Exception {

        public InvalidOperationException(string message) : base(message) {}

    }

}