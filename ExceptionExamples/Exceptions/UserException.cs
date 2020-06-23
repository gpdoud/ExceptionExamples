using System;
using System.Collections.Generic;
using System.Text;

namespace ExceptionExamples.Exceptions {

    public class UserException : Exception {

        public double NumberInError { get; set; }

        public UserException() 
            : base() { }

        public UserException(string message) 
            : base(message) { }

        public UserException(string message, Exception innerException) 
            : base(message, innerException) { }
    }
}
