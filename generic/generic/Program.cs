namespace Main
{
    class Program
    {
        delegate bool IfLeap(DateTime dateTime);
        public static void Main()
        {
            T1();
        }

        public static void  T1()
        {
            IfLeap ifLeap = dateTime => ((dateTime.Year % 100 != 0) && (dateTime.Year % 4 == 0)) || (dateTime.Year % 400 == 0);
            Console.WriteLine(ifLeap(new DateTime(1999, 1, 1)));
            Console.WriteLine(ifLeap(new DateTime(1600, 1, 1)));
        }
    }

    class GenericCollection <T>
    {
        private List<T> RandomList;
        private Random value;

        public GenericCollection()
        {
            RandomList = new List<T>();
            value = new Random();
        }
        public bool ifEmpty()
        {
            return RandomList.Any();
        }
        public T Get(int i)
        {
            return RandomList[value.Next(1, 100)];
        }
        public void Add(T el)
        {
            if(value.Next(1,100) > 25)
            {
                RandomList.Insert(0, el);
            }
            else
            {
                RandomList.Add(el);
            }
        }
    }


}