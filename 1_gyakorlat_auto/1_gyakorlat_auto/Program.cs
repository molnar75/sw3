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

            int aktualisEv = DateTime.Today.Year;
            string gyarto;
            string tipus;
            int gyartasiEv;
            string motortipus;
            string uzemanyag;
            double atlagfogyasztas;

            Console.WriteLine("Kerem adja meg a gyartot!\ngyarto:");
            gyarto = Console.ReadLine();

            Console.WriteLine("Kerem adja meg az auto tipusat!\ntipus:");
            tipus = Console.ReadLine();

            do
            {
                Console.WriteLine("Kerem adja meg az auto gyartasi evet!\ngyartasi ev:");
                gyartasiEv = Int32.Parse(Console.ReadLine());
            } while (gyartasiEv > aktualisEv || gyartasiEv + 20 < aktualisEv);

            Console.WriteLine("Kerem adja meg a motor tipusat!\ntipus:");
            motortipus = Console.ReadLine();

            Console.WriteLine("Kerem adja meg az auto uzemanyagat (pl. benzin)!\nuzemanyag tipusa:");
            uzemanyag = Console.ReadLine();

            Console.WriteLine("Kerem adja meg az auto atlagfogyasztasat!\natlagfogyasztas:");
            atlagfogyasztas = Convert.ToDouble(Console.ReadLine());

            autok[1] = new Auto(gyarto, tipus, gyartasiEv, motortipus, uzemanyag, atlagfogyasztas);

            Console.WriteLine("Autok adatai:");
            foreach (var auto in autok)
            {
                Console.WriteLine(auto);
            }

            autok[1].Motorcsere("1.8", "benzin", 7);
            Console.WriteLine("2. auto motorcsere utan:" + autok[1]);

            int fogyasztasokSzama = 5;
            double[] fogyasztasok = new double[fogyasztasokSzama];
            double autoAtlagfogyasztasa = 0;

            //for (int i = 0; i < fogyasztasokSzama; i++)
            for (int i = 0; i < fogyasztasok.Length; i++)
            {
                fogyasztasok[i] = autok[1].Fogyasztas(i + 5, i * 4 + 3);
                autoAtlagfogyasztasa += fogyasztasok[i];
            }

            //autoAtlagfogyasztasa /= fogyasztasokSzama;
            autoAtlagfogyasztasa /= fogyasztasok.Length;

            Console.WriteLine();
            Console.WriteLine("2. auto atlagfogyasztasa:" + autok[1].Atlagfogyasztas);
            Console.WriteLine(autok[1].AtlagfogyasztasOsszehasonlit(autoAtlagfogyasztasa));

            int koltsegszamitasokSzama = 5;
            double[] utazasiKoltsegek = new double[koltsegszamitasokSzama];
            double utazasiKoltseg = 0;
            for (int i = 0; i < utazasiKoltsegek.Length; i++)
            {
                utazasiKoltsegek[i] = autok[0].UzemanyagKoltsegSzamitas(i * 50 + 300, 500);
                utazasiKoltseg += utazasiKoltsegek[i];
            }

            Console.WriteLine("A megtett utak koltsege:" + utazasiKoltseg);

        }
    }
}
