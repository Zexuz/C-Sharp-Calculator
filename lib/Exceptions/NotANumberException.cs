using System;

namespace Calculator.lib.Exceptions {

    public class NotANumberException : Exception {

        public NotANumberException(string message) : base(message) {}

    }

}