using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

class Program
{
    private const string FilePath = "orders.json";

    static void Main(string[] args)
    {
        List<Order> orders;

        if (File.Exists(FilePath))
        {
            string json = File.ReadAllText(FilePath);
            orders = JsonSerializer.Deserialize<List<Order>>(json);
            Console.WriteLine("Данные успешно загружены из файла.");
        }
        else
        {
            orders = CreateSampleOrders();
            Console.WriteLine("Созданы тестовые данные, так как файл не найден.");
        }

        DisplayOrders(orders);

        SaveOrders(orders);

        Console.WriteLine("\nНажмите любую клавишу для выхода...");
        Console.ReadKey();
    }

    private static List<Order> CreateSampleOrders()
    {
        return new List<Order>
        {
            new Order
            {
                OrderId = 1,
                Date = DateTime.Now.AddDays(-2),
                Products = new List<Product>
                {
                    new Product { Id = 101, Name = "Ноутбук", Price = 999.99m },
                    new Product { Id = 102, Name = "Мышь", Price = 25.50m }
                }
            },
            new Order
            {
                OrderId = 2,
                Date = DateTime.Now.AddDays(-1),
                Products = new List<Product>
                {
                    new Product { Id = 103, Name = "Клавиатура", Price = 49.99m },
                    new Product { Id = 104, Name = "Монитор", Price = 199.99m },
                    new Product { Id = 105, Name = "Коврик для мыши", Price = 5.99m }
                }
            }
        };
    }
    private static void SaveOrders(List<Order> orders)
    {
        var options = new JsonSerializerOptions { WriteIndented = true };
        string json = JsonSerializer.Serialize(orders, options);
        File.WriteAllText(FilePath, json);
        Console.WriteLine("\nДанные успешно сохранены в файл orders.json");
    }
    private static void DisplayOrders(List<Order> orders)
    {
        Console.WriteLine("\nИстория заказов:");
        Console.WriteLine("----------------");

        foreach (var order in orders)
        {
            Console.WriteLine($"Заказ #{order.OrderId} от {order.Date:dd.MM.yyyy HH:mm}");
            Console.WriteLine("Товары:");

            foreach (var product in order.Products)
            {
                Console.WriteLine($"  - {product.Name} (ID: {product.Id}): {product.Price:C}");
            }

            decimal total = 0;
            foreach (var product in order.Products)
            {
                total += product.Price;
            }

            Console.WriteLine($"Итого: {total:C}\n");
        }
    }
}
public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
}

public class Order
{
    public int OrderId { get; set; }
    public DateTime Date { get; set; }
    public List<Product> Products { get; set; } = new List<Product>();
}