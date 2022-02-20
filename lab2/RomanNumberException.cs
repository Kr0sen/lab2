namespace lab2
{
    public class RomanNumberException : Exception
    {
        public RomanNumberException() { }
        public RomanNumberException(string message) : base(message) { }
        public RomanNumberException(string message, RomanNumberException inner) : base(message, inner) { }
        protected RomanNumberException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
