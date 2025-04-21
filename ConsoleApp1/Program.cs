namespace ConsoleApp1
{
    internal class Program
    {
        static string Encrypt(string text, int key)
        {
            string a = "абвгдеёжзийклмнопрстуфхцчшщъыьеюя";
            string result = "";

            foreach (char symbol in text)
            {
                char lowerSymbol = char.ToLower(symbol);
                int index = a.IndexOf(lowerSymbol);
                if (index > -1)
                {
                    int newIndex = index + key;
                    char newSymbol = a[newIndex];
                    if (symbol == char.ToLower(symbol))
                    {
                        result += newSymbol;
                    }
                    else
                    {
                        result += char.ToUpper(newSymbol);
                    }
                }
                else if (index >= -1)
                {
                    result += symbol;
                }
                else
                {
                    Console.WriteLine("Ошиька!");
                }
    
            }
            return result;
        }
    }
}