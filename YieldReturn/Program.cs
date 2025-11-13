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
            
            foreach (var item in GetNumOrdinary().Take(5))
            {
                Console.WriteLine(item);
            }

            foreach (var item in GetNumYield().Take(5))
            {
                Console.WriteLine(item);
            }
        }

        private static IEnumerable<int> GetNumOrdinary()
        {
            var i = 0;
            var res = new List<int>();

            while (i < 10000000)
            {
                res.Add(i++);
            }

            return res;
        }
        private static IEnumerable<int> GetNumYield()
        {
            var i = 0;

            while (i < 10000000)
            {
                yield return i++;
            }
        }

        public static IEnumerable<int> GetNumbers()
        {
            return new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            //foreach (var item in li)
            //{
            //    yield return item;
            //}

            //yield return 1;
            //yield return 2;
            //yield return 3;
            //yield return 4;
          
        }
    }
}
