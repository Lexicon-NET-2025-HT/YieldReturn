namespace YieldReturn
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var numbers = GetNumbers();
            //IEnumerator<int> enumerator = numbers.GetEnumerator();

            //while (enumerator.MoveNext())
            //{
            //    var item = enumerator.Current;
            //    Console.WriteLine(item);
            //}

            foreach (var item in GetNumbers())
            {
                Console.WriteLine(item);
            }
        }

        public static IEnumerable<int> GetNumbers()
        {
            //return new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            yield return 1;
            yield return 2;
            yield return 3;
            yield return 4;
          
        }
    }
}
