using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Найти номер и значение первого положительного элемента массива.//
            Console.WriteLine("Vedi dleny masiva ");
            int masslength = Convert.ToInt32(Console.ReadLine());
            int[] myarray = new int[masslength];
            Random r = new Random();
            for (int i = 0; i < myarray.Length; i++)
            {
                myarray[i] = r.Next(-999, 999);
                Console.WriteLine("myarray: {0}", myarray[i]);
                
            }
            int indexValue = 0;
            for (int i = 0; i < myarray.Length; i++)
            {
                if (myarray[i] > 0)
                {
                    indexValue = i;
                    Console.WriteLine("Pervoe chislo {0} \nIndex is : {1} ", myarray[i], indexValue);
                    break;
                }
            }
            Console.WriteLine("massive is: {0} ", myarray);
            Console.ReadLine();

        }
    }
}
