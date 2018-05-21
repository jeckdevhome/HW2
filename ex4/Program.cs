using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            //В одномерном массиве найти минимальный и максимальный элементы. Вычислить их разность.
            //Например, дан массив[3, 5, 9, 4, 2, 6]. Максимальным числом является 9, минимальным является 2.Разность составляет 9 - 2 = 7.
            Console.WriteLine("vedi mas length");
            int number = Convert.ToInt32(Console.ReadLine());
            int[] myarray = new int[number];
            Random r = new Random();
            for(int i = 0; i <myarray.Length; i++)
            {
                myarray[i] = r.Next(0, 999);
                Console.WriteLine("znach mas: {0}", myarray[i]);
            }
            int maxValue = 0;
            for (int i = 0; i<myarray.Length; i++)
            {
                if (maxValue < myarray[i])
                    maxValue = myarray[i];
            }
            int minValue = maxValue;
            for (int i =0; i< myarray.Length; i++)
            {
                if (minValue > myarray[i])
                    minValue = myarray[i];
            }
            int raznValue = maxValue - minValue;
            Console.WriteLine("max value of my array is: {0}", maxValue);
            Console.WriteLine("min value is: {0}", minValue);
            Console.WriteLine(" Raznost elementov = {0}", raznValue);
            Console.ReadLine();
        }
    }
}
