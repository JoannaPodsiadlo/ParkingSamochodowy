using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingSamochodowy
{
	class Program
	{
		static void Main(string[] args)
		{
			Uzytkownik u1 = new Uzytkownik("Joanna", "Podsiadlo", "12345", "KR123AB","1001");
			Uzytkownik u2 = new Uzytkownik("Jan", "Kowalski", "98765","GD12345","1002");
			Uzytkownik u3 = new Uzytkownik("Anna", "Nowak", "13579",  "XD098AD","1003");
			Uzytkownik u4 = new Uzytkownik("Zbigniew", "Mis", "adgk1", "PO123DF","1004");
		

			BazaUzytkownikow bazaUzytkownikow = new BazaUzytkownikow();
			bazaUzytkownikow.DodajKonto(u1);
			bazaUzytkownikow.DodajKonto(u2);
			bazaUzytkownikow.DodajKonto(u3);
			bazaUzytkownikow.DodajKonto(u4);
			bazaUzytkownikow.Sortuj();
           
            bazaUzytkownikow.ZapiszXML("baza", bazaUzytkownikow);
            BazaUzytkownikow b2 = BazaUzytkownikow.OdczytajXML("baza");
            Console.WriteLine(bazaUzytkownikow);

            Rezerwacja r = new Rezerwacja("01/08/2008 14:50:50.42", "04/08/2008 14:50:50.42", 4);
            u3.Zarezerwuj(r);
            u1.ZapiszDoBazy();
            u2.ZapiszDoBazy();
            u3.ZapiszDoBazy();
            
            u1.WypiszUzytkownikow();
			Console.ReadKey();
		}
	}
}
