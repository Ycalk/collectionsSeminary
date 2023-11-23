using System;

namespace collectionsSeminary
{
    internal class Program
    {
        private static void Main()
        {
            T5();
        }

        private static void T1()
        {
            var array = new[] { 5, 1, 2, 3, -1, 4, 3 };
            var t1 = new Task1(array);

            Console.WriteLine(t1.GetSumOnInterval(1, 5));
            Console.WriteLine(t1.GetSumOnInterval(4, 4));
            Console.WriteLine(t1.GetSumOnInterval(1,4));
        }

        private static void T2()
        {
            var t2 = new Task2(7);

            t2.CreateRequest(1, 7, 1);
            t2.CreateRequest(2, 3, 4);
            t2.CreateRequest(3, 5, 3);
            t2.CreateRequest(1, 2, 1);
            t2.CreateRequest(5, 7, 4);
            t2.CreateRequest(2, 4, 10);
            t2.CreateRequest(3, 4, 2);
            t2.CreateRequest(1, 6, 3);

            t2.PrintArray();
        }

        private static void T3()
        {
            var array = new[]
            {
                10, 31, -41, 59, 26, -53, 58, 97, -93, -23, 84
            };
            Console.WriteLine(Task3.Solution (array));
        }
        private static void T4()
        {
            var array = new[]
            {
                10, 31, -41, 59, 26, -53, 58, 97, -93, -23, 84
            };
            Console.WriteLine(Task4.Solution(array, 3));
        }

        private static void T5()
        {
            var mas1 = new[]
            {
                20, 1, 30, 40
            };

            var mas2 = new[]
            {
                1, 50, 60, 70
            };

            Console.WriteLine(Task5.Solution(mas1, mas2));
        }
    }
}
