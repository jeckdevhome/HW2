using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Дан массив целых чисел. Проверить, есть ли в нем одинаковые элементы.
            Console.WriteLine("dlina masiva");
            int number = Convert.ToInt32(Console.ReadLine());
            Random r = new Random();
            int[] myarray = new int[number];
            for (int i =0; i < myarray.Length; i++)
            {
                myarray[i] = r.Next(0, 50);
                Console.WriteLine("value {0}", myarray[i]);
            }
            for (int i = 0; i < myarray.Length; i++)
            {
                for (int j = i +1; j < myarray.Length; j++)
                {
                    if (myarray[i] == myarray[j])
                    {
                        Console.WriteLine("odenakovie chisla {0} ", myarray[i]);
                        break;
                    }
                }
            }
            Console.WriteLine("the end");
            Console.ReadLine();
        }
    }
}
