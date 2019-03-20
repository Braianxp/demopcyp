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
            //Demolista();
            DemoDic();
        }

        public static void DemoDic()
        {
            Dictionary<string,int> dic = new Dictionary<string, int>();
        }

        #region Demolista

        public static void Demolista()
        {
            List<string> listColors = armarlist(colors);
            List<string> listRemoveColors = armarlist(removeColors);
            readList(listColors);
            List<string> listaremovidos = removeColor(listColors, listRemoveColors);
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

        #endregion

        #region Ejemplo de lista
        private static void DemoLista()
        {
            List<string> list = new List<string>();

            // Añade elementos de colors a la Lista (uno por uno)
            foreach (var color in colors)
            {
                list.Add(color);
            }

            // Añade elementos del arreglo desde el constructor
            List<string> removeList = new List<string>(removeColors);

            Console.WriteLine("List: ");
            MostrarLista(list);

            // remueve colores
            RemueveColores(list, removeList);

            Console.WriteLine("\nList después de llamar a RemueveColores: ");
            MostrarLista(list);
        }
        private static void MostrarLista(List<string> list)
        {
            // muestra el contenido con foreach
            foreach (var element in list)
            {
                Console.Write("{0} ", element);
            }

            // muestra tamaño y capacidad
            Console.WriteLine("\nTamaño = {0}; Capacidad = {1}",
               list.Count, list.Capacity);

            int index = list.IndexOf("BLUE");

            if (index != -1)
                Console.WriteLine("La lista contiene BLUE en índice {0}.",
                   index);
            else
                Console.WriteLine("La lista no contiene BLUE.");
        }
        private static void RemueveColores(List<string> firstList, List<string> secondList)
        {
            for (int count = 0; count < secondList.Count; ++count)
            {
                firstList.Remove(secondList[count]);
            }
        }
        #endregion

    }
}
