namespace Main
{
    internal class GenericCollection<T>
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
            if (value.Next(1, 100) > 25)
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