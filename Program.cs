using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {

            double[] balance = { 2340.0, 4523.69, 3421.0 };



            int[] A = { 234, 452, 342, 123, 345, 456 };

            Console.WriteLine("kokokwawa welcome message");

            Console.WriteLine("Hello World");






            BubbleSort(A);

            Console.ReadKey();

        }



        public static void BubbleSort(int[] intArray)
        {
            Console.WriteLine("==========UnSorted Array Input===============");
            for (int i = 0; i < intArray.Length; i++)
            {
                Console.WriteLine(intArray[i]);
            }

            for (int i = intArray.Length - 1; i > 0; i--)
            {
                for (int j = 0; j <= i - 1; j++)
                {
                    if (intArray[j] > intArray[j + 1])
                    {
                        int highValue = intArray[j];

                        intArray[j] = intArray[j + 1];
                        intArray[j + 1] = highValue;
                    }
                }
            }

            Console.WriteLine("==========Sorted Array Using BubbleSort===============");
            for (int i = 0; i < intArray.Length; i++)
            {
                Console.WriteLine(intArray[i]);
            }
        }

    }
}