namespace UnderstandingScope
{
    class Program
    {
        private static string K = "";
        static void Main(string[] args)
        {
            string j = "";
            for (int i =0; i<10; i++)
            {
                j = i.ToString();
                K = i.ToString();
                Console.WriteLine(i);

            }
            //Console.WriteLine(i);
            Console.WriteLine("outside of the for: " + j);
            Console.WriteLine("outside of the for: " + K);
            HelperMethod();
            Console.ReadLine();
        }
        static void HelperMethod()
        {
            Console.WriteLine("value of k from HelperMethod:" + K);
        }

    }
}