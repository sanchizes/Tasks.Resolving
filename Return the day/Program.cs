namespace Return_the_day
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        public static string ReturnDay(int day)
        {
            string today = String.Empty;
            switch (day)
            {
                case 1:
                    today = "Monday";
                    break;
                case 2:
                    today = "Tuesday";
                    break;
                case 3:
                    today = "Wednesday";
                    break;
                case 4:
                    today = "Thursday";
                    break;
                case 5:
                    today = "Friday";
                    break;
                case 6:
                    today = "Saturday";
                    break;
                case 7:
                    today = "Sunday";
                    break;
            }
            return today;
        }
    }
}
