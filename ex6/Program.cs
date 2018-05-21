using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Написать программу расчета среднего арифметического отрицательных элементов в одномерном массиве. 
            //Заменить минимальный элемент в одномерном массиве на полученное среднее арифметическое.
            Console.WriteLine("vedi chislo");
            int number = Convert.ToInt32(Console.ReadLine());
            Random r = new Random();
            int[] myarray = new int[number];
            for (int i = 0; i < myarray.Length; i++)
            {
                myarray[i] = r.Next(-999, 999);
                Console.WriteLine("value of array {0}", myarray[i]);
            }
            int minussum = 0;
            int minLength = 0;//количество отрицатедьних элементов
            for (int i = 0; i< myarray.Length; i++)
            {
                if (myarray[i] < 0)
                {
                    minussum += myarray[i];
                    minLength += 1;
                }
            }
            int avr;
            avr = minussum / minLength;
            Console.WriteLine("avr minus is: {0}", avr);
            int maxValue = 0;
            for (int i = 0; i< myarray.Length; i++)     //при нахождении минимального в отрицательных, можно без нахождения максимального.
            {
                if (maxValue < myarray[i])
                {
                    maxValue = myarray[i];
                }
            }
            Console.WriteLine("max value {0}", maxValue);
            int minValue = maxValue;
            int minindexValue = 0;
            for (int i = 0; i< myarray.Length; i++)
            {
                if (minValue > myarray[i])
                {
                    minValue = myarray[i];
                    minindexValue = i;
                }
            }
            Console.WriteLine("min value is {0}", minValue);
            myarray[minindexValue] = avr;
            for (int i =0; i< myarray.Length; i++)
            {
                Console.WriteLine("new table of my array {0}", myarray[i]);
            }
            Console.WriteLine("\nend");
            Console.ReadLine();
        }
    }
}
