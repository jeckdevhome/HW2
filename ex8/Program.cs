using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex8
{
    class Program
    {
        static void Main(string[] args)
        {
            //В одномерном массиве найти максимальный из отрицательных элементов и поменять его местами
            //с последним элементом массива.
            Console.WriteLine("Enter mass Length ");
            int number = Convert.ToInt32(Console.ReadLine());
            int[] myarray = new int[number];
            Random r = new Random();
            for (int i = 0; i < myarray.Length; i++)
            {
                myarray[i] = r.Next(-999, 999);
                Console.WriteLine("value of my array {0} ", myarray[i]);
            }
            int maxValue = 0;
            for (int i = 0; i < myarray.Length; i++)
            {
                if (maxValue < myarray[i])
                {
                    maxValue = myarray[i];
                }
            }
            int minValue = 0;
            int minindexValue = 0;
            Console.WriteLine("max value {0} ", maxValue);
            for (int i = 0; i < myarray.Length; i++)
            {
                if (minValue > myarray[i])
                {
                    minValue = myarray[i];
                    minindexValue = i;
                }
            }
            Console.WriteLine("minimal value is {0} index: {1} ", minValue, minindexValue);
            int lastIndex = 0;
            for (int i =0; i < myarray.Length; i++)
            {
                lastIndex = i;
            }
            Console.WriteLine("last index: {0}", lastIndex);
            int firstChange = myarray[lastIndex];
            //int secondChange = myarray[minindexValue];
            myarray[lastIndex] = minValue;
            myarray[minindexValue] = firstChange;
            for (int i = 0; i < myarray.Length; i++)
            {
                Console.WriteLine("new  table of my array {0}", myarray[i]);
            }
            Console.ReadLine();
        }
    }
}
