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
}