namespace HomeWork12;

public class WrongPasswordException : Exception 
{
    public WrongPasswordException(string message) : base(message) { }
}
//Исключения WrongLoginException и WrongPasswordException необходимо реализовать самостоятельно. Каждый класс должен содержать:
//    -Конструктор по умолчанию
//    - Конструктор, принимающий текст сообщения и передающий его в конструктор базового класса Exception
