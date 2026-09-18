namespace GetTheRepsWeb.Domain.Exceptions
{
    public class InvalidProductDataException : Exception
    {
        public InvalidProductDataException(string message) : base(message) { }
    }
}
