using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        private static readonly string[] colors = { "MAGENTA", "RED", "WHITE", "BLUE", "CYAN" };
        private static readonly string[] removeColors = { "RED", "WHITE", "BLUE" };

        static void Main(string[] args)
        {
           List<string> listColors = armarlist(colors);
           List<string> listRemoveColors = armarlist(removeColors);
           readList(listColors);
           List<string> listaremovidos = removeColor(listColors,listRemoveColors);
           readList(listaremovidos);
        }

        public static List<string> armarlist(string[] S)
        {
            List<string> list = new List<string>();

            for (int i = 0; i < S.Length; i++)
            {
                list.Add(S[i]);
            }
            return list;
        }

        public static void readList(List<string> list)
        {
            Console.WriteLine("Lista de colores");
            foreach (var item in list)
            {
                Console.WriteLine("Color: {0}", item);

            }
            Console.ReadKey();
        }

        public static List<string> removeColor(List<string> listColors,List<string> listRemovecolors)
        {
            List<string> listaremovidos = new List<string>();

            Boolean b = true;

            foreach (var item in listColors)
            {
                foreach (var item2 in listRemovecolors)
                {
                    if (item.Equals(item2))
                    {
                        b = false;
                    }
                }
                if (b)
                {
                    listaremovidos.Add(item);
                }
                b = true;
            }
            return listaremovidos;
        }

    }
}
