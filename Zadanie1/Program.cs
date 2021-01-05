using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie1
{
    class Program
    {

        struct Osoba {

            public string imie;
            public string nazwisko;
            public string adresEmail;
            public string nrTelefonu;
        }

        static void Main(string[] args)
        {
            Osoba os;

            Console.WriteLine("Podaj imię: ");
            os.imie = Console.ReadLine();

            Console.WriteLine("Podaj nazwisko: ");
            os.nazwisko = Console.ReadLine();

            Console.WriteLine("Podaj adres e-mail: ");
            os.adresEmail = Console.ReadLine();

            Console.WriteLine("Podaj numer telefonu: ");
            os.nrTelefonu = Console.ReadLine();
        }
    }
}
