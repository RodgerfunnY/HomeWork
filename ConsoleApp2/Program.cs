internal class Program
{
    // Определяем делегат для фильтрации чисел
    delegate bool NumberFilter(int number);

    static void Main()
    {
        // Создаем список чисел
        List<int> numbers = new List<int> { 5, 12, 3, 8, 17, 20, 9, 14, 6, 11 };

        Console.WriteLine("Исходный список чисел:");
        PrintNumbers(numbers);

        // Предлагаем пользователю выбрать фильтр
        Console.WriteLine("\nВыберите способ фильтрации:");
        Console.WriteLine("1 - Чётные числа");
        Console.WriteLine("2 - Нечётные числа");
        Console.WriteLine("3 - Числа больше 10");
        Console.WriteLine("4 - Числа меньше или равные 10");
        Console.Write("Ваш выбор: ");

        int choice;
        while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 4)
        {
            Console.Write("Некорректный ввод. Пожалуйста, введите число от 1 до 4: ");
        }

        // Создаем соответствующий фильтр на основе выбора пользователя
        NumberFilter filter = null;
        switch (choice)
        {
            case 1:
                filter = IsEven;
                break;
            case 2:
                filter = IsOdd;
                break;
            case 3:
                filter = IsGreaterThan10;
                break;
            case 4:
                filter = IsLessOrEqual10;
                break;
        }

        // Фильтруем список и выводим результат
        List<int> filteredNumbers = Filter(numbers, filter);

        Console.WriteLine("\nОтфильтрованный список чисел:");
        PrintNumbers(filteredNumbers);
    }

    // Метод для фильтрации списка с использованием делегата
    static List<int> Filter(List<int> numbers, NumberFilter filter)
    {
        List<int> result = new List<int>();
        foreach (int number in numbers)
        {
            if (filter(number))
            {
                result.Add(number);
            }
        }
        return result;
    }

    // Метод для вывода списка чисел
    static void PrintNumbers(List<int> numbers)
    {
        foreach (int number in numbers)
        {
            Console.Write(number + " ");
        }
        Console.WriteLine();
    }

    // Методы-фильтры
    static bool IsEven(int number) => number % 2 == 0;
    static bool IsOdd(int number) => number % 2 != 0;
    static bool IsGreaterThan10(int number) => number > 10;
    static bool IsLessOrEqual10(int number) => number <= 10;
}