using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            //В массиве найти минимальный и максимальный элементы, поменять их местами
            Console.WriteLine("Vide chislo");
            int number = Convert.ToInt32(Console.ReadLine());
            Random r = new Random();
            int[] myarray = new int[number];
            for (int i = 0; i < myarray.Length; i++)
            {
                myarray[i] = r.Next(0, 999);
                Console.WriteLine("array is: {0}", myarray[i]);
            }
            int maxValue = 0;
            int indexmaxValue = 0;
            for (int i =0; i < myarray.Length; i++)
            {
                if (maxValue < myarray[i])
                {
                    maxValue = myarray[i];
                    indexmaxValue = i;
                }
            }
            int minValue = maxValue;
            int indexminValue = 0;
            for (int i = 0; i < myarray.Length; i++)
            {
                if (minValue > myarray[i])
                {
                    minValue = myarray[i];
                    indexminValue = i;
                }
            }
            Console.WriteLine("max value is: {0}, index is: {1}",maxValue, indexmaxValue);
            Console.WriteLine("min value is: {0}, index is: {1}\n", minValue, indexminValue);
            int maxV = maxValue;
            int minV = minValue;
            myarray[indexmaxValue] = minV;
            myarray[indexminValue] = maxV;
            for(int i = 0; i< myarray.Length; i++)
            {
                Console.WriteLine("new value of array {0} ",myarray[i]);
            }
            //Console.WriteLine(sravnenie);
            Console.ReadLine();
        }
    }
}
