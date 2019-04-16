using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abecedario
{
    class Program
    {
        static void Main(string[] args)
        {
            int ascii = 65;

            Task t1 = Task.Factory.StartNew(() =>
            {
                do{
                    if (ascii % 2 == 0)
                    {
                        Console.WriteLine(Convert.ToChar(ascii).ToString() + " : tarea 1");
                        ascii++;
                    }
                } while (ascii <= 90);


            });
            Task t2 = Task.Factory.StartNew(() =>
            {
                do
                {
                    if (ascii % 2 != 0)
                    {
                        Console.WriteLine(Convert.ToChar(ascii).ToString() + " : tarea 2");
                        ascii++;
                    }

                } while (ascii <= 90);
            });

            Task.WaitAll(t1, t2);
            Console.ReadLine();
        }
    }
}
