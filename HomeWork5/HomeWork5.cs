using System;
using System.Linq;

namespace HomeWork5
{
    internal class HomeWork5
    {
        static void Main(string[] args)
        {
            Console.Write("Здравствуйте вы зашли в приложение 'Шифр Цезаря'!");

            
            while (true)
            {
                Console.WriteLine("\nВыберете действие которое хотите совершить.");
                Console.WriteLine("\nЗафивровать текст - нажмите 1.");
                Console.WriteLine("Расшивровать текст - нажмите 2.");
                Console.WriteLine("Завершить - нажмите 3.");
                Console.Write("\nВаш выбор:");
                int command = int.Parse(Console.ReadLine());
                if (command == 1)
                {
                    Console.Write("Отлично укажите код шифрования:");
                    int key = int.Parse(Console.ReadLine());
                    Console.WriteLine("Введите ваш текст:");
                    string text = Console.ReadLine();
                    string encryptedText = Encrypt(text, key);
                    Console.WriteLine(encryptedText);
                }
                else if (command == 2)
                {
                    Console.Write("Отлично укажите код расшифрования:");
                    int key = int.Parse(Console.ReadLine());
                    Console.WriteLine("Введите ваш текст:");
                    string text = Console.ReadLine();
                    string decryptText = Decrypt(text, key);
                    Console.WriteLine(decryptText);
                }
                else if (command == 3)
                {
                    break;
                }
            }
        }
        static string Encrypt(string text, int key)
        {
            string alphabetRus = "абвгдеёжзийклмнопрстуфхцчшщъыьеюя";
            //string alphabetEng = "abcdefghijklmnopqrstuvwxyz";
            string result = "";

            foreach (char symbol in text)
            {
                char language = char.ToLower(symbol);
                int languageIndex = alphabetRus.IndexOf(language);
                if (language >= 0)
                {
                    char lowerSymbol = char.ToLower(symbol);
                    int index = alphabetRus.IndexOf(lowerSymbol);
                    if (index >= 0)
                    {
                        int newIndex = (index + key) % alphabetRus.Length;
                        if (newIndex < 0)
                            newIndex += alphabetRus.Length;
                            char newSymbol = alphabetRus[newIndex];
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
                //else
                ////{
                //    //char lowerSymbol = char.ToLower(symbol);
                //    //int index = alphabetEng.IndexOf(lowerSymbol);
                //    //if (index >= 0)
                //    //{
                //    //    int newIndex = (index + key) % alphabetEng.Length;
                //    //    if (newIndex < 0)
                //    //        newIndex += alphabetEng.Length;
                //    //    char newSymbol = alphabetEng[newIndex];
                //    //    if (char.IsUpper(symbol))
                //    //    {
                //    //        result += char.ToUpper(newSymbol);


                //    //    }
                //    //    else
                //    //    {
                //    //        result += newSymbol;

                //    //    }
                //    //}
                //    else
                //    {
                //        result += symbol;
                //    }
                
            }
            return result;
        }
        static string Decrypt(string text, int key)
        {
            return Encrypt(text, -key);
        }

    }
}

//Создать консольное приложение "Шифр Цезаря".
//Реализовать функционал:
//1.Программа предлагает пользователю выбрать: /*зашифровать или расшифровать сообщение*/
//2. Запрашивает у пользователя ключ шифрования (число, на сколько символов сдвигать буквы)
//3. Запрашивает само сообщение (может содержать буквы, пробелы и знаки препинания)
//4. Шифрует/дешифрует сообщение:
//    -Каждая буква заменяется на другую, сдвинутую по алфавиту (например, А → Г при сдвиге на 3)
//    - Если символ не буква (пробел, точка, запятая) — не заменяется
//    - Сохраняется регистр (большие буквы остаются большими, маленькие — маленькими)
//5. Выводит результат