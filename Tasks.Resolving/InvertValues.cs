using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks.Resolving
{
    public class InvertValues
    {
        public static int[] ArraysInversion(int[] input)
        {
            int[] invertedArray = new int[input.Length];

            for (int i = 0; i < invertedArray.Length; i++)
            {
                invertedArray[i] = Opposite(input[i]);
            }
            return invertedArray;
        }

        public static int Opposite(int number) { return -number; }

        public static void Main(string[] args)
        {
            int[] inputArray = new int[] { 1, 2, 3, 4, 5 };

            int[] resultArray = ArraysInversion(inputArray);

            foreach (int i in resultArray)
            {
                Console.WriteLine(i);

            }
        }
    }

}
