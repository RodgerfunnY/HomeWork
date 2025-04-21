namespace HomeWork11._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pair<int, string> pair = new Pair<int, string>(1, "abs");
            Console.WriteLine(pair.Id.ToString(), pair.Add);
        }
    }
    public class Pair<T1, T2>
    {
        public  T1 Id { get; set; }
        public T2 Add { get; set; }

        public  Pair(T1 id, T2 add)
        {
            Id = id;
            Add = add;
        }      
    }
}
