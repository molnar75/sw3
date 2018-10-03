using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace autonevter
{

    class Auto : _1_gyakorlat_auto.Jarmu
    {

        //static string[] motortipusok = { "1.4", "1.6", "1.8", "2.0", "2.3" }; //tömb inicializálás
        public static List<string> motortipusok = new List<string>();
        public static int letrehozottAutok = 0;

        static Auto() //tömb inicializáló blokk
        {
            motortipusok.Add("1.4");
            motortipusok.Add("1.6");
            motortipusok.Add("1.8");
            motortipusok.Add("2.0");
            motortipusok.Add("2.3");
        }

        private string gyarto;
        private string tipus;
        private readonly int evjarat;
        //forditasi ideju konstans
        //private const int konstans = 1 ;
        private string motortipus;
        private string uzemanyag;
        private double atlagfogyasztas;

        public double Atlagfogyasztas
        {
            get { return atlagfogyasztas; }
            set { atlagfogyasztas = value; }
        }


        public string Uzemanyag
        {
            get { return uzemanyag; }
            set { uzemanyag = value; }
        }


        public string Motortipus
        {
            get { return motortipus; }
            set { motortipus = value; }
        }


        public Auto(string gyarto, string tipus, int evjarat, string motortipus, string uzemanyag, double atlagfogyasztas):base(gyarto, tipus, evjarat)
        {
            this.gyarto = gyarto;
            this.tipus = tipus;
            this.evjarat = evjarat;
            this.motortipus = motortipus;
            this.uzemanyag = uzemanyag;
            this.atlagfogyasztas = atlagfogyasztas;
        }

        public Auto(string gyarto, string tipus, int evjarat,string motortipus) : base(gyarto, tipus, evjarat)
        {
            this.gyarto = gyarto;
            this.tipus = tipus;
            this.evjarat = evjarat;
            this.motortipus = motortipus;
            this.uzemanyag = "benzin";

            switch (motortipus)
            {
                case "1.4":
                    this.atlagfogyasztas = 6.5;
                    break;

                case "1.8":
                    this.atlagfogyasztas = 7.5;
                    break;

                case "2.0":
                    this.atlagfogyasztas = 8;
                    break;

                default:
                    break;
            }

        }

        public void Motorcsere(string motortipus, string uzemanyag, double atlagfogyasztas)
        {
            bool nemeleme = true;
            while(nemeleme)
            {
                for (int i = 0; i < motortipusok.Count; i++)
                {
                    if (motortipusok[i].Equals(motortipus))
                    {
                        this.motortipus = motortipus;
                        nemeleme = false;
                    }
                }
                if (nemeleme)
                {
                    Console.WriteLine("Nincs ilyen motortipus. Ajda meg ujra: " );
                    motortipus = Console.ReadLine();
                }

            }

            this.uzemanyag = uzemanyag;
            this.atlagfogyasztas = atlagfogyasztas;
        }

        /// <summary>
        /// uzemanyag fogyasztas szamitasa
        /// </summary>
        /// <param name="uzemanyag">uzemanyag literben</param>
        /// <param name="tavolsag">tavolsag km-ben</param>
        /// <returns>fogyasztas</returns>
        public double Fogyasztas(double uzemanyag, double tavolsag)
        {
            return uzemanyag / tavolsag * 100;
        }

        public bool AtlagfogyasztasOsszehasonlit(double uzemanyag, double tavolsag)
        {
            return Fogyasztas(uzemanyag, tavolsag) <= atlagfogyasztas;
        }

        public bool AtlagfogyasztasOsszehasonlit(double fogyasztas)
        {
            return fogyasztas <= atlagfogyasztas;
        }

        public bool AtlagfogyasztasOsszehasonlit(Auto masikAuto)
        {
            return masikAuto.Atlagfogyasztas <= atlagfogyasztas;
        }

        /// <summary>
        /// uzemanyag kotlsegenek szamitasa
        /// </summary>
        /// <param name="tavolsag">tavolsag km-ben</param>
        /// <param name="uzemanyagAra">uzemanyag literenkenti ara Ft-ban</param>
        /// <returns>uzemanyag osszkoltseg</returns>
        public int UzemanyagKoltsegSzamitas(double tavolsag, int uzemanyagAra)
        {
            return (int)(atlagfogyasztas * tavolsag * uzemanyagAra / 100);
        }

        public double UzemanyagKoltsegSzamitas(double tavolsag, int uzemanyagAra, double euroArfolyam)
        {
            return atlagfogyasztas * tavolsag * uzemanyagAra / 100 / euroArfolyam;
        }

        public override string ToString()
        {
            return "Auto: "
                + Motortipus + ", "
                + Uzemanyag + ", "
                + Atlagfogyasztas;
        }

        public override double Sebesseg(double megtettUt, double ido)
        {
            return megtettUt / ido;
        }
    }
}
