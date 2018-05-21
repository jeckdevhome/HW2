using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex9
{
    class Program
    {
        static void Main(string[] args)
        {
            //Дан массив, например, состоящий только из 0 и 1.
            //Определить самое большое количество подряд идущих единиц
            //и вывести на экран индексы начала и конца этого диапазона.
            Console.WriteLine("Enter mass length ");
            int number = Convert.ToInt32(Console.ReadLine());
            Random r = new Random();
            int[] myarray = new int[number];
            for (int i = 0; i < myarray.Length; i++)
            {
                myarray[i] = r.Next(0, 2);
                Console.WriteLine("value is {0}", myarray[i]);
            }
            int numberLength = 0;
            int indexValue = 0;
            //int numberLength1 = 0;
            int counter = 1;
            int maxcounter = 0;
            int maxcounterend = 0;


            for (int i = 0; i < myarray.Length - 1; i++)
            {
                while (myarray[i] == myarray[i + 1])
                {
                    counter++;
                    if (counter > maxcounter)
                    {
                        maxcounter = counter;
                        maxcounterend = i + 1;
                    }
                    i++;
                    if (i + 1 == myarray.Length) { break; }
                }
                counter = 1;
            }
            Console.WriteLine("Counter {0}, start {1}, end {2}", maxcounter, maxcounterend - maxcounter + 1, maxcounterend);



            Console.WriteLine("Count length {0}", numberLength);

            Console.ReadLine(); 
        }
    }
}
