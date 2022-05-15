using System;
using System.Linq;



namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FaultyOdometer(55));

        }

        static public int FaultyOdometer(int n)
        {
            int NormalOdometry = 0;
            string m = n.ToString();
            int dlina = m.Length;
            int[] digitArray = new int[dlina];
            for (int k = 0; k < m.Length; k++)
            {
                digitArray[k] = int.Parse(m[k].ToString());
            }
            //int[] digitArray = m.Select(digit => int.Parse(digit.ToString())).ToArray();  short way 
            Array.Reverse(digitArray);
            for (int i = 0; i < digitArray.Length; i++)
            {
                if (digitArray[i] > 4)
                {
                    NormalOdometry += (int) ((digitArray[i] - 1) * System.Math.Pow(9, i));
                }
                else
                {
                    NormalOdometry += (int) (digitArray[i] * System.Math.Pow(9, i));
                }
                

            }

            return NormalOdometry;


        }
    }
}