namespace YieldReturn
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbers = GetNumbers();
        }

        public static IEnumerable<int> GetNumbers()
        {
            return new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        }
    }
}
