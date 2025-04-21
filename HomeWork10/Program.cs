using System.Collections.Generic;
using System.Numerics;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace HomeWork10
{
    internal class Program
    {
        delegate void Filtr(List<int> list);
        static void Main(string[] args)
        {
            List <int> list = new List<int>() {1, 2, 5, 10, 20, 62, 57, 87, 105, 98, 647, 2154, 874, 9, 14, 81};
            foreach (int i in list) {Console.WriteLine(i);}
            while (true)
            {
               Console.WriteLine("\nВыберите действие которое хотите совершить со списком:\n" +
                "\n1 - Оставить только четные цифры." +
                "\n2 - Оставить только не четные цифры." +
                "\n3 - Оставить числа больше 10." +
                "\n4 - Оставить числа которые больше 100." +
                "\n0 - Выход.");
            string vibor = Console.ReadLine();
            
            Filtr filtr = null;
            switch (vibor)
            {
                case "1":
                    filtr = OutputOfEvenNumbers;
                    break;
                case "2":
                    filtr = OutputOfOddNumbers;
                    break;
                case "3":
                    filtr = OutputtingMoreNumbers10;
                    break;
                case "4":
                    filtr = OutputtingMoreNumbers100;
                    break;
                case "0":
                    Console.WriteLine("\nДо встречи!");
                    return;
                default:
                    Console.WriteLine("\nУпс... Такую операция я выполнить не могу:(");
                    break;
            }
            Filter(list, filtr); 
            }
            
        }
        static void Filter(List<int> list, Filtr filtr)
        {
            filtr(list);
        }
            
        static void OutputOfEvenNumbers(List <int> list)
        {
            List<int> result = new List<int>();

            foreach (int number in list)
            {
                if (number % 2 == 0)
                {
                    result.Add(number);
                }
            }
            OutputOfTheResult(result);
        }
        static void OutputOfOddNumbers(List<int> list)
        {
            List<int> result = new List<int>();

            foreach (int number in list)
            {
                if (number % 2 != 0)
                {
                    result.Add(number);
                }
            }
            OutputOfTheResult(result);
        }
        static void OutputtingMoreNumbers10(List<int> list)
        {
            List<int> result = new List<int>();

            foreach (int number in list)
            {
                if (number >= 10)
                {
                    result.Add(number);
                }
            }
            OutputOfTheResult(result);
        }
        static void OutputtingMoreNumbers100(List<int> list)
        {
            List<int> result = new List<int>();

            foreach (int number in list)
            {
                if (number >= 100)
                {
                    result.Add(number);
                }
            }
            OutputOfTheResult(result);
        }
        static void OutputOfTheResult(List<int> result)
        {
            foreach (int number in result)
            {
                Console.WriteLine(number);
            }

        }

    }
}
