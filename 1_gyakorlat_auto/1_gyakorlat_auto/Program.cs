using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace autonevter.futtathato
{
    class Program
    {
        static void Main(string[] args)
        {
            int darabszam = 2;
            Auto[] autok = new Auto[darabszam];

            autok[0] = new Auto("Skoda", "superb", DateTime.Today.Year, "1.8");
        }
    }
}
