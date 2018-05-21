using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex2
{
    class Program
    {
        static void Main(string[] args)
        {

            //Дан массив, содержащий положительные и отрицательные числа. 
            //Заменить все элементы массива на противоположные по знаку.
            //Например, задан массив [1, -5, 0, 3, -4]. После преобразования должно получиться [-1, 5, 0, -3, 4]
            //int a = 50;
            //int b = -23;
            //int c,d;
            //c = 0 - a;
            //d = 0 + -b;
            //Console.WriteLine("pervoe znachenie {0}, = {1}", a, c);
            //Console.WriteLine("vtoroe znachenie {0} = {1} ", b, d);
            Console.WriteLine("Vedi znachenie \n");
            int number = Convert.ToInt32(Console.ReadLine());
            Random r = new Random();
            int[] myarray = new int[number];
            for (int i = 0; i < myarray.Length; i++)
            {
                myarray[i] = r.Next(-999, 999);
                Console.WriteLine("value of array {0}", myarray[i]);
            }
            for (int y =0; y < myarray.Length; y++)
            {
                if (myarray[y] > 0)
                {
                    myarray[y] = 0 - myarray[y];
                }
                else if (myarray[y] < 0)
                {
                    myarray[y] = 0 + -myarray[y];
                }
                else
                    break;
                Console.WriteLine("obratnoe znachenie {0}", myarray[y]);
            }



            Console.ReadLine();
        }

    }
}
