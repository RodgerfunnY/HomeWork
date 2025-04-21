using System;

namespace CaesarCipher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Добро пожаловать в программу шифрования Цезаря!");

            while (true)
            {
                Console.WriteLine("\nВыберите действие:");
                Console.WriteLine("1 - Зашифровать сообщение");
                Console.WriteLine("2 - Расшифровать сообщение");
                Console.WriteLine("3 - Выйти");
                string choice = Console.ReadLine();

                if (choice == "1" || choice == "2")
                {
                    Console.Write("Введите ключ шифрования (число): ");
                    int key;
                    while (!int.TryParse(Console.ReadLine(), out key))
                    {
                        Console.WriteLine("Некорректный ввод. Введите целое число.");
                        Console.Write("Введите ключ шифрования (число): ");
                    }

                    Console.Write("Введите сообщение: ");
                    string text = Console.ReadLine();

                    if (choice == "1")
                    {
                        string encryptedText = Encrypt(text, key);
                        Console.WriteLine("Зашифрованное сообщение: " + encryptedText);
                    }
                    else if (choice == "2")
                    {
                        string decryptedText = Decrypt(text, key);
                        Console.WriteLine("Расшифрованное сообщение: " + decryptedText);
                    }
                }
                else if (choice == "3")
                {
                    Console.WriteLine("Спасибо за использование программы. До свидания!");
                    break;
                }
                else
                {
                    Console.WriteLine("Неверный выбор. Попробуйте снова.");
                }
            }
        }


        static string Encrypt(string text, int key)
        {
            string alphabet = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";
            string result = "";

            foreach (char symbol in text)
            {
                char lowerSymbol = char.ToLower(symbol);
                int index = alphabet.IndexOf(lowerSymbol);

                if (index >= 0) // Если символ найден в алфавите
                {
                    int newIndex = (index + key) % alphabet.Length; 
                    if (newIndex < 0) newIndex += alphabet.Length; 
                    char newSymbol = alphabet[newIndex];


                    if (char.IsUpper(symbol))
                    {
                        result += char.ToUpper(newSymbol);
                    }
                    else
                    {
                        result += newSymbol;
                    }
                }
                else
                {
                    result += symbol; 
                }
            }

            return result;
        }


        static string Decrypt(string text, int key)
        {
            return Encrypt(text, -key); 
        }
    }
}