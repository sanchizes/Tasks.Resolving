namespace OppositeNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var num = new Program();
            Console.WriteLine("Hello, World!");
            Console.WriteLine(num.Opposite(5));
        }

        public int Opposite(int number)
        {
            return number * -1;
        }
    }
}
