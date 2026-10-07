using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace liste_2026_lazar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a;
            a = new int[10];
            a[5] = 5;

            List<string> ime;
            ime = new List<string>();
            ime.Add("a");
            ime.Add("b");
            ime.Add("c");

            List<int>[] niz;
            niz = new List<int>[10];
            niz[5] = new List<int>();

            Console.WriteLine(ime[1]);
        }
    }
}
