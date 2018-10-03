using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_gyakorlat_auto
{
    abstract class Jarmu
    {
        private string gyarto;
        private string tipus;
        private readonly int evjarat;


        public string Tipus
        {
            get { return tipus; }
            set { tipus = value; }
        }

        public string Gyarto
        {
            get { return gyarto; }
            set { gyarto = value; }
        }

        public int Evjarat
        {
            get { return evjarat; }
           // set { evjarat = value; }
        }
  
        public Jarmu(string gyarto, string tipus, int evjarat)
        {
            this.gyarto = gyarto;
            this.tipus = tipus;
            this.evjarat = evjarat;
        }

        public override string ToString()
        {
            return "Jarmu: "
                + Tipus + ", "
                + Gyarto + ", "
                + Evjarat;
        }

        public abstract double Sebesseg(double megtettUt, double ido);
    }
}
