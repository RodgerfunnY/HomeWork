using System.Xml.Linq;

namespace HomeWork6
{
    internal class HomeWork6
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Добрый день!");

            CreditCard namberOne = new CreditCard();
            namberOne.score = "BY28AKBB 3819 3821 0001 7000 0000";
            namberOne.amount = 254;


            CreditCard namberTwo = new CreditCard();
            namberTwo.score = "BY88AKBB 3819 3821 0001 3000 0000";
            namberTwo.amount = 754;


            CreditCard namberThree = new CreditCard();
            namberThree.score = "BY42AKBB 3819 3821 0002 9000 0000";
            namberThree.amount = 105;

            while (true)
            {
                Console.WriteLine("\nВыберет с каким счетом хотите начать работать" +
                    $"\n1 - {namberOne.score}" +
                    $"\n2 - {namberTwo.score}" +
                    $"\n3 - {namberThree.score}" +
                    "\n4 - выйти из программы");

                string z = Console.ReadLine();

                switch (z)
                {
                    case "1":
                        namberOne.Change(namberOne.score, namberOne.amount);
                        break;
                    case "2":
                        namberTwo.Change(namberTwo.score, namberTwo.amount);
                        break;
                    case "3":
                        namberThree.Change(namberThree.score, namberThree.amount);
                        break;
                    case "4":
                        Console.WriteLine("\nДо свидания!");
                        return;
                    default:
                        Console.WriteLine("\nУпс... Такую операция я выполнить не могу:(");
                        break;

                }
            }
        }
    }
}

//Создать консольное приложение для работы с кредитными картами: 
//-Создать класс CreditCard c полями "Номер счета" и "Текущая сумма на счету"
//- Добавить метод, который позволяет начислять сумму на счёт
//- Добавить метод, который позволяет снимать со счёта некоторую сумму
//- Добавить метод, который выводит текущую информацию о карточке
//- Создать три экземпляра класса CreditCard, у которых заданы разные номера счёта и начальная сумма
//- Предоставить пользователю возможность взаимодействовать со счетами: начислять и снимать деньги