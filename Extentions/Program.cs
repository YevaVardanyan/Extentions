using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extentions
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>() { 21, 342, 1, 3, 5 };
            int num = 0;
            bool result = list.HasElement(ref num);
            bool a = list[3].IsOdd();
            int max = 0;
            list.GetMax(out max);
            list.DecreasingOrder();
            foreach (int item in list)
            {
                Console.WriteLine(item);
            }

            list.IncreasingOrder();
            foreach (int item in list)
            {
                Console.WriteLine(item);
            }
            int div2 = 0;
            bool b = list.IsDevidedBy(2, out div2);
            //////////////////////////////////////
            string c = "VaLOd";
            char d = 'o';
            bool k = c.HasLetter(ref d);
            Console.WriteLine(k);
            Console.WriteLine(c.OnlyFirstLetterUp());
            c._Reverse();
            Console.ReadKey();

        }

    }

}