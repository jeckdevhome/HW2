using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Найти сумму положительных элементов массива.
            Console.WriteLine("Vedi chislo");
            int number = Convert.ToInt32(Console.ReadLine());
            int[] myarray = new int[number];
            Random r = new Random();
            int sum = 0;
            for (int i = 0; i < myarray.Length; i++)
            {
                myarray[i] = r.Next(-20, 20);
                Console.WriteLine("v.a {0}",myarray[i]);
            }
            for (int y = 0; y < myarray.Length; y++)
            {
                if (myarray[y] > 0)
                {
                    sum += myarray[y];
                }
            }
                

            Console.WriteLine("\nsuma polozhitelnih elementov {0}", sum);
            Console.WriteLine(" array ");
            Console.ReadLine();
        }
    }
}
