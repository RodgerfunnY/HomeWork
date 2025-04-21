using System.ComponentModel.DataAnnotations;

namespace HomeWork12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("-----Регистрация нового пользователя-----");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("Ведите логин (логин не должен содержать пробелов и должен быть короче 20 символов):");
                Console.ResetColor();
                string login = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("Ведите пароль (Пароль не должен содержать побрелов быть короче 20 символов и содержать хотя бы одно цифру):");
                Console.ResetColor();
                string password = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine("Подтвердите пароль:");
                Console.ResetColor();
                string confirmPassword = Console.ReadLine();

                bool isValid = PersonalAccount.ValidateCredentials(login, password, confirmPassword);

                if (isValid)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Регистрация прошла успешно!");
                    Console.WriteLine($"Ваш логин: {login}");
                    Console.ResetColor();
                }

            }
            catch (WrongLoginException ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Произошла ошибка: {ex.Message}");
                Console.ResetColor();
            }
            catch (WrongPasswordException ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Произошла ошибка: {ex.Message}");
                Console.ResetColor();
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Произошла ошибка: {ex.Message}");
                Console.ResetColor();
            }
            finally
            {
                Console.WriteLine("Программа завершена!");
            }
        }
    }
}
