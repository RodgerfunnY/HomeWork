using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork6
{
    class CreditCard
    {
        public string score = "";
        public double amount = 0;

        static double Кeplenishment(double depositingTheAmount, double amount)
        {
            amount += depositingTheAmount;
            return amount;
        }

        static double Withdrawal(double depositingTheAmount, double amount)
        {
            amount -= depositingTheAmount;
            return amount;
        }

        public void Change(string namberScore, double namberАmount)
        {
            while (true)
            {
                Console.WriteLine("\nВыберете действие которое хотите совершить?");
                Console.WriteLine("\nДля пополнения счета - нажмите 1");
                Console.WriteLine("Для снятия наличных - нажмите 2");
                Console.WriteLine("Просмотр информации счета - нажмите 3");
                Console.WriteLine("Выход - нажмите 4");

                int choice = int.Parse(Console.ReadLine());

                if (choice == 1) // проверка на значение и заход на пополнение счета
                {

                    Console.WriteLine("\nВведите сумму которую хотите внести: ");
                    double depositingTheAmount = double.Parse(Console.ReadLine());
                    amount = Кeplenishment(depositingTheAmount, amount);
                    Console.WriteLine($"Операция прошла успешно, зачислено {depositingTheAmount} руб. ");
                    break;

                }
                else if (choice == 2) // проверка и списание средств
                {
                    Console.WriteLine("\nВведите сумму которую хотите снять: ");
                    double depositingTheAmount = double.Parse(Console.ReadLine());
                    if (amount >= depositingTheAmount)
                    {
                        amount = Withdrawal(depositingTheAmount, amount);
                        Console.WriteLine($"Операция прошла успешно, снятие {depositingTheAmount} руб. ");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Недостаточно средств!");
                        break;
                    }
                    
                }
                else if (choice == 3) // Инфо и вывод информации
                {
                    Console.WriteLine($"\nНомер счета: {namberScore}.  Остаток суммы:{namberАmount}");
                }
                else if (choice == 4) // выход из программы
                {
                    Console.WriteLine("\nДо свидания!");
                    break;
                }
                else // не правильный ввод
                {
                    Console.WriteLine("\nНеверный выбор, попробуйте заново!");
                    continue;
                }
            }
        }
    }
}
