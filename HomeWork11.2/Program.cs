namespace HomeWork11._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ComparablePair<int, string> comparablePair1 = new ComparablePair < int, string> (1, "abrakadabra");
            ComparablePair<int, string> comparablePair2 = new ComparablePair<int, string>(5, "abradabra");

        }


    }

    internal class ComparablePair <T1, T2> 
    {
        public T1 First { get; set; }

        public T2 Second { get; set; }

        public ComparablePair(T1 first, T2 second)
        {
            First = first;
            Second = second;
        }

        public void Max (ComparablePair a, ComparablePair b)
        {
            throw new NotImplementedException();
        }

    }
}
//Создать класс ComparablePair<T1, T2>
//    - Он должен реализовывать обобщённый интерфейс IComparable
//    - Ограничить типы T1 и T2, чтобы каждый из них реализовывал обобщённый интерфейс IComparable
//    - Создать два экземпляра класса ComparablePair<T1, T2> и сравнить их
//    - Сравнение похоже на сортировку строк:
//        -Экземпляр 1 меньшего экземпляра 2, если его первое значение меньше первого значения экземпляра 2
//        - В случае, когда первые значения равны, аналогичным образом сравниваются вторые значения