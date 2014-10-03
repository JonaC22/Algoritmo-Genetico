using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GAF;

namespace AlgoritmosGeneticos
{
    class Program
    {
        static void Main(string[] args)
        {
            GAFManager gaf = GAFManager.Instance;
            gaf.exampleFunction();
        }
    }
}
