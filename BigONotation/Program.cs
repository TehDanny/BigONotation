using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigONotation
{
    class Program
    {
        static void Main(string[] args)
        {
            //TestExists();

            /*
            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
            sw.Start();

            long result = FiboCalc(10);

            sw.Stop();
            long time = sw.ElapsedMilliseconds;
            */
        }

        private static void TestExists()
        {
            int[] a = new int[] { 6, 3, 2, 8, 5, 1, 4, 7 };
            Console.WriteLine(Exists(a, 6));
        }

        private static bool Exists(int[] inData, int findValue)
        {
            for (int i = 0; i < inData.Length; i++)
            {
                if (inData[i] == findValue)
                    return true;
            }
            return false;
        }

        private static void Sort(int[] inData)
        {
            for (int i = 0; i < inData.Length - 1; i++)
            {
                for (int j = i + 1; j < inData.Length; j++)
                {
                    if (inData[i] > inData[j])
                    {
                        int tmp = inData[j];
                        inData[j] = inData[i];
                        inData[i] = tmp;
                    }
                }
            }
        }

        private static long FiboCalc(int input)
        {
            if (input <= 1)
                return input;
            else
                return FiboCalc(input - 1) + FiboCalc(input - 2);
        }
    }
}
