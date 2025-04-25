using System.Collections.Generic;
using System.Text.Json;
using System.Xml.Linq;

namespace HomeWork13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Order> orders;
            string FilePath = "orders.json";

            if (File.Exists(FilePath) == true) 
            {
                string jsons = File.ReadAllText(FilePath);
                orders = JsonSerializer.Deserialize<List<Order>>(jsons);
                Console.WriteLine("Данные успешно загружены из файла.");
            }
            else 
            {
                Order order = JsonSerializer.Deserialize<Order>("orders.json");
            }
            DisplayOrders(orders);


            List<Order> orderss = new List<Order>
            {
                new Order
                {
                    OrderId = 1,
                    Date = DateTime.Now.AddDays(-3),
                    Products = new List<Product>
                    {
                        new Product { Id = 101, Name = "Ноутбук ASUS", Description = 899.99m },
                        new Product { Id = 102, Name = "Беспроводная мышь", Description = 29.99m },
                        new Product { Id = 103, Name = "Рюкзак для ноутбука", Description = 49.99m }
                    }
                },
                new Order
                {
                    OrderId = 2,
                    Date = DateTime.Now.AddDays(-1),
                    Products = new List<Product>
                    {
                        new Product { Id = 201, Name = "Смартфон Samsung", Description = 699.99m },
                        new Product { Id = 202, Name = "Чехол для телефона", Description = 19.99m }
                    }
                },
                new Order
                {
                    OrderId = 3,
                    Date = DateTime.Now,
                    Products = new List<Product>
                    {
                        new Product { Id = 301, Name = "Наушники Sony", Description = 129.99m },
                        new Product { Id = 302, Name = "USB флешка 64GB", Description = 24.99m },
                        new Product { Id = 303, Name = "Внешний SSD 1TB", Description = 149.99m },
                        new Product { Id = 304, Name = "Кабель USB-C", Description = 9.99m }
                    }
                }
            };

            string json = JsonSerializer.Serialize(orderss);
            File.WriteAllText("orders.json", json);
          
        }
        static void DisplayOrders(List<Order> orders)
        {
            Console.WriteLine("\nИстория заказов:");
            Console.WriteLine("----------------");

            foreach (var order in orders)
            {
                Console.WriteLine($"Заказ #{order.OrderId} от {order.Date:dd.MM.yyyy HH:mm}");
                Console.WriteLine("Товары:");

                foreach (var product in order.Products)
                {
                    Console.WriteLine($"  - {product.Name} (ID: {product.Id}): {product.Description:C}");
                }

                decimal total = 0;
                foreach (var product in order.Products)
                {
                    total += product.Description;
                }

                Console.WriteLine($"Итого: {total:C}\n");
            }
        }
    }

    
    
}

//    4. Сериализовать список покупок в JSON формат и сохранить его в файл orders.json
//    5. При запуске программы проверять наличие файла orders.json и десериализовать его
//    6. Вывести десериализованные данные в консоль