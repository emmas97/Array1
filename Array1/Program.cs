using System;

namespace Array1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] number = new int[25];
            for (int i = 0; i < 26; i++)
            {
                number[i] = i + 1;
                Console.WriteLine("Element Value =" + number[i]);
            }
        }
    }
}
