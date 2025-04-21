using System.Reflection;

namespace HomeWork4._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {

                Console.WriteLine("Добрый день! Вас приветствует программа подсчета оценок группы студентов. Введите номер группы или напишите 'Выход' для выхода из программы:");
                string namber_grup = Console.ReadLine();
                if (namber_grup == "Выход" || namber_grup == "выход")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Введите колличество студентов в группе:");
                    int namber_stud = int.Parse(Console.ReadLine());
                    int[] grada = new int[namber_stud];
                    int sum = 0;
                    int sum1 = 0;

                    for (int i = 0; i < grada.Length; i++)
                    {
                        Console.WriteLine($"Хорошо, введите оценку по 10-и бальной ситеме для студента номер {i + 1}:");
                        int grada1 = int.Parse(Console.ReadLine());
                        if (0 <= grada1 && grada1 <= 10)
                        {
                            grada[i] = grada1;
                        }
                        else
                        {
                            Console.WriteLine("Веден не верный формат оценки");
                            break;

                        }
                    }

                    int max = grada[0];

                    for (int i = 0; i < grada.Length; i++)
                    {
                        sum += grada[i];
                    }
                    sum1 = sum / namber_stud;
                    Console.WriteLine($"Средняя оценка в группе: {sum1}");

                    for (int i = 0; i < grada.Length; i++)
                    {
                        if (max <= grada[i])
                            max = grada[i];
                    }
                    Console.WriteLine($"Максимальная оценка в группе: {max}");

                    int min = grada[0];

                    for (int i = 0; i < grada.Length; i++)
                    {
                        if (min >= grada[i])
                            min = grada[i];
                    }
                    Console.WriteLine($"Минимальная оценка в группе: {min}");

                    int sred = 0;
                    for (int i = 0; i < grada.Length; i++)
                    {
                        if (sum1 <= grada[i])
                            sred += 1;
                    }
                    Console.WriteLine($"Количество студентов, получивших оценки выше среднего: {sred}");
                }

                Console.WriteLine("Можем продолжать подсчет!");
            }
            Console.WriteLine("Спасибо что выбрали нас!");
        }
    }
}