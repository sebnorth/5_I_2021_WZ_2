using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Zadanie5
{
    class Program
    {
        static void Main(string[] args)
        {
            string s, nazwa = @"C:\Users\sagata\Downloads\inne\kursy\C#\zaj5\pliki10\zaj6Gdynia\tekst.txt";
            FileStream plik = new FileStream(nazwa, FileMode.Open, FileAccess.Read, FileShare.None);
            System.IO.StreamReader odczyt = new StreamReader(plik);
            int ilosc_literek_aA_w_pliku = 0;
            int ilosc_literek_aA_w_linii = 0;

            while ((s = odczyt.ReadLine()) != null)
            {
                ilosc_literek_aA_w_linii = 0;
                foreach (char znak in s)
                {
                    if (znak == 'a' || znak == 'A') ilosc_literek_aA_w_linii++;
                }

                ilosc_literek_aA_w_pliku += ilosc_literek_aA_w_linii;
                Console.WriteLine("Ilość literk a w linii wynosi: {0}", ilosc_literek_aA_w_linii);

            }

            Console.WriteLine("Ilość literk a w pliku wynosi: {0}", ilosc_literek_aA_w_pliku);
            odczyt.Close();
            plik.Close();

            Console.ReadKey();
        }
    }
}
