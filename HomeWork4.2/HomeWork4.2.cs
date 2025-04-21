using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace HomeWork4._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Привет пользователь! Ты открыл для себя консольное приложение для работы с матрицами (двухмерными массивами).");
            Console.Write("\nВведи колличество строк в матрице - ");
            int line = int.Parse(Console.ReadLine());
            Console.Write("Введи колличество столбцов в матрице - ");
            int column = int.Parse(Console.ReadLine());

            int[,] matric = new int[line, column];
            Random random = new Random();

            for (int i = 0; i < line; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    matric[i, j] = random.Next(-90, 100);

                }
            }
            Console.WriteLine("\nСгенерированная матрица:");
            for (int i = 0; i < line; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    Console.Write(matric[i, j].ToString().PadLeft(5) + " ");
                }
                Console.WriteLine();
            }


            while (true)
            {
                Console.WriteLine("\nВедите номер команды которую хотите выполнить:");
                Console.WriteLine("1 - подсчёт количества положительных и отрицательных чисел в матрице");
                Console.WriteLine("2 - сортировка элементов матрицы в каждой строке от большего к меньшему");
                Console.WriteLine("3 - инверсия элементов матрицы в каждом столбце (элементы располагаются в обратном порядке)");
                Console.WriteLine("4 - завершение программы");
                string z = Console.ReadLine();

                if (z == "1")
                {
                    int negativ = 0;
                    int pol = 0;
                    for (int i = 0; i < line; i++)
                    {
                        for (int j = 0; j < column; j++)
                        {
                            if (matric[i, j] > 0)
                            {
                                pol += 1;
                            }
                            else if (matric[i, j] < 0)
                            {
                                negativ += 1;
                            }
                            else
                            {

                            }
                        }
                    }
                    Console.WriteLine($"Положительных чисел {pol}");
                    Console.WriteLine($"Отрицательных чисел {negativ}");
                }
                else if (z == "2")
                {
                    int swapped;
                    for (int i = 0; i < matric.Length - 1; i++)
                    {
                        swapped = false;
                        for (int j = 0; j < matric.Length - i - 1; j++)
                        {
                            if (matric[j] > matric[j + 1])
                            {
                                int temp = matric[j];
                                matric[j] = matric[j + 1];
                                matric[j + 1] = temp;
                                swapped = true;
                            }
                        }
                        if (!swapped)
                            break;
                    }
                }
                else if (z == "3")
                {
                    int negativ = 0;
                    int pol = 0;
                }
                else if (z == "4")
                {
                    Console.WriteLine("Спасибо, работа завершена!");
                    break;
                }
                else
                {
                    Console.WriteLine("Упс, я не знаю такую команду, попробуй заново!");
                }
            }
        }
    }   
}








//Создать консольное приложение для работы с матрицами (двухмерными массивами).
//Реализовать следующий функционал:
//1.Пользователь вводит размер матрицы
//2. Программа заполняет матрицу случайными целыми числами (например, в диапазоне от -99 до 99)
//3. Матрица выводится в консоль
//4. Программа просит пользователя выбрать одно из действий:
//    -Подсчёт количества положительных и отрицательных чисел в матрице
//    - Сортировка элементов матрицы в каждой строке от большего к меньшему
//    - Инверсия элементов матрицы в каждом столбце (элементы располагаются в обратном порядке)
//    - Завершение программы
//5. После выбора действия пользователем программа совершает действие и выводит результат в консоль
//6. Возврат в пункт 4 (выбор действия)



