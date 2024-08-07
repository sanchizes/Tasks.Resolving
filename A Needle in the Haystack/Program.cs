namespace A_Needle_in_the_Haystack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "needle";
            object[] test = ["hay", "junk", "hay", "hay", "moreJunk", "needle", "randomJunk"];
            Console.WriteLine(Array.IndexOf(test, str));
        }
        public static string FindNeedle(object[] haystack)
        {
            string str = "needle";
            return $"found the needle at position {Array.IndexOf(haystack, str)}";
        }
    }
}
