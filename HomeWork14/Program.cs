using System.Net.Http;
using System.Text;
using System.Text.Json;

namespace HomeWork14
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            ConsoleLogger consoleLogger = new ConsoleLogger();
            HttpClient client = new HttpClient();

            Console.ForegroundColor = ConsoleColor.Red;
            consoleLogger.Log("Начало работы с API пользователей...\n");

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            consoleLogger.Log("Получение списка пользователей...");
            Thread.Sleep(3000);

            HttpResponseMessage repositorie = await client.GetAsync("https://jsonplaceholder.typicode.com/users");
            var content = await repositorie.Content.ReadAsStringAsync();

            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
                IgnoreNullValues = true
            };
            List<User> user = JsonSerializer.Deserialize<List<User>>(content, options);
                   
            foreach (var i in user)
            {
                consoleLogger.Log($"\nID: {i.Id}");
                consoleLogger.Log($"Имя: {i.Name}");
                consoleLogger.Log($"Никнейм: {i.UserName}");
                consoleLogger.Log($"Email: {i.Email}");
                consoleLogger.Log($"Телефон: {i.Phone}");
                consoleLogger.Log($"Город: {i.Address.City}");
                consoleLogger.Log($"Улица: {i.Address.Street}");
                consoleLogger.Log($"Название компании: {i.Company.Name}");
                Thread.Sleep(1000);
            }

            Console.ForegroundColor = ConsoleColor.Green;
            consoleLogger.Log("\nСоздание нового пользователя...");
            Thread.Sleep(3000);

            var data = new User
            {
                Id = 11,
                Name = "Anton",
                UserName = "Matusevich",
                Email = "anton.matusevich@mail.com",
                Phone = "+375335866162",
                Address = new Address
                {
                    City = "Minsk",
                    Street = "st.Belscogo",
                },
                Company = new Company
                {
                    Name = "InFroze",
                }
            };
            var json = JsonSerializer.Serialize(data);
            var responseUser = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await client.PostAsync("https://jsonplaceholder.typicode.com/users", responseUser);
            consoleLogger.Log($"\n{response.StatusCode}\n");
            Thread.Sleep(1000);
            consoleLogger.Log(await response.Content.ReadAsStringAsync());
            Console.ResetColor();
        }
    }
}