namespace HomeWork12;

public class WrongLoginException : Exception
{
    public WrongLoginException(string message) : base(message) { }
}