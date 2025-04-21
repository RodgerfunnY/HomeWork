using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== Регистрация нового пользователя ===");

        try
        {
            // Ввод логина
            Console.Write("Введите логин (без пробелов, <20 символов): ");
            string login = Console.ReadLine();

            // Ввод пароля
            Console.Write("Введите пароль (без пробелов, <20 символов, с цифрами): ");
            string password = Console.ReadLine();

            // Подтверждение пароля
            Console.Write("Подтвердите пароль: ");
            string confirmPassword = Console.ReadLine();

            // Валидация
            bool isValid = Validator.Validate(login, password, confirmPassword);

            if (isValid)
            {
                Console.WriteLine("Регистрация прошла успешно!");
                Console.WriteLine($"Ваш логин: {login}");
            }
        }
        catch (WrongLoginException e)
        {
            Console.WriteLine($"Ошибка в логине: {e.Message}");
            Console.WriteLine("Пожалуйста, попробуйте ещё раз.");
        }
        catch (WrongPasswordException e)
        {
            Console.WriteLine($"Ошибка в пароле: {e.Message}");
            Console.WriteLine("Пожалуйста, попробуйте ещё раз.");
        }
        catch (Exception e)
        {
            Console.WriteLine($"Произошла непредвиденная ошибка: {e.Message}");
        }
        finally
        {
            Console.WriteLine("\nСпасибо за использование нашей системы!");
        }
    }
}
class WrongLoginException : Exception
{
    public WrongLoginException() : base() { }
    public WrongLoginException(string message) : base(message) { }
}

class WrongPasswordException : Exception
{
    public WrongPasswordException() : base() { }
    public WrongPasswordException(string message) : base(message) { }
}

// Основной класс с методом проверки
class Validator
{
    public static bool Validate(string login, string password, string confirmPassword)
    {
        // Проверка логина
        if (login.Contains(" ") || login.Length >= 20)
        {
            throw new WrongLoginException("Логин не должен содержать пробелов и должен быть короче 20 символов");
        }

        // Проверка пароля
        if (password.Contains(" ") || password.Length >= 20)
        {
            throw new WrongPasswordException("Пароль не должен содержать пробелов и должен быть короче 20 символов");
        }

        if (!password.Any(char.IsDigit))
        {
            throw new WrongPasswordException("Пароль должен содержать хотя бы одну цифру");
        }

        if (password != confirmPassword)
        {
            throw new WrongPasswordException("Пароль и подтверждение пароля не совпадают");
        }

        return true;
    }
}