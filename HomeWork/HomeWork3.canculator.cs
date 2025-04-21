namespace Homework_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Привет, это простой канкулятор! Тебе необходимо ввести данные для начала работы. Начнем с первого числа");
            Double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Отлично, теперь какое математическое действие ты хочешь с выполнить? (+, -, *, /, %, sqrt, ^)");
            string z = Console.ReadLine();

            Double result = 0;

            switch (z)
            {
                case "+":
                    Console.WriteLine("Хорошо, остался последний шаг, введи второе число!");
                    double b = Convert.ToDouble(Console.ReadLine());
                    result = a + b;
                    Console.WriteLine($"Полученый результат операции {a} {z} {b} = {result}");
                    break;
                case "sqrt":
                    if (a >= 0)
                    {
                        result = Math.Sqrt(a);
                        Console.WriteLine($"Квадратный корень числа {a} = {result}");
                    }
                    else
                    {
                        Console.WriteLine("Нельзя пределить корень числа из отрицательного числа!");
                    }
                    break;
                case "^":
                    Console.WriteLine("Хорошо, остался последний шаг, введи в какую степень вы хотите возвести число!");
                    b = Convert.ToDouble(Console.ReadLine());
                    result = Math.Pow(a, b);
                    Console.WriteLine($"Полученый результат операции {a} {z} {b} = {result}");
                    break;
                case "-":
                    Console.WriteLine("Хорошо, остался последний шаг, введи второе число!");
                    b = Convert.ToDouble(Console.ReadLine());
                    result = a - b;
                    Console.WriteLine($"Полученый результат операции {a} {z} {b} = {result}");
                    break;
                case "*":
                    Console.WriteLine("Хорошо, остался последний шаг, введи второе число!");
                    b = Convert.ToDouble(Console.ReadLine());
                    result = a * b;
                    Console.WriteLine($"Полученый результат операции {a} {z} {b} = {result}");
                    break;
                case "/":
                    Console.WriteLine("Хорошо, остался последний шаг, введи второе число!");
                    b = Convert.ToDouble(Console.ReadLine());
                    if (b != 0)
                    {
                        result = a / b;
                        Console.WriteLine($"Полученый результат операции {a} {z} {b} = {result}");
                    }
                    else
                    {
                        Console.WriteLine("На ноль делить нельзя!");
                    }
                    break;
                case "%":
                    Console.WriteLine("Хорошо, остался последний шаг, введи второе число!");
                    b = Convert.ToDouble(Console.ReadLine());
                    result = a * b / 100;
                    Console.WriteLine($"Полученый результат операции {a} {z} {b} = {result}");
                    break;
                default:
                    Console.WriteLine("Упс... Такую операция я выполнить не могу:(");
                    break;
            }
        }
    }
}
