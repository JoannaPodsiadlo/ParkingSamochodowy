using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ParkingSamochodowy
{
	[Serializable]
	public class Uzytkownik: ICloneable, IComparable
	{
		private string _imie;
		private string _nazwisko;
		private string _haslo;
		private string _nrRejestracyjnyPojazdu;
		private string _IDUzytkownika;
		
		private List<Rezerwacja> _mojeRezerwacje;
		public string Imie { get => _imie; set => _imie = value; }
		public string Nazwisko { get => _nazwisko; set => _nazwisko = value; }
		public string Haslo { get => _haslo; set => _haslo = value; }
		public string NrRejestracyjnyPojazdu { get => _nrRejestracyjnyPojazdu; set => _nrRejestracyjnyPojazdu = value; }
		public string IDUzytkownika { get => _IDUzytkownika; set => _IDUzytkownika = value; }

		public Uzytkownik()
		{
			_mojeRezerwacje = new List<Rezerwacja>();
		}

		public Uzytkownik(string imie, string nazwisko, string haslo, string nrRejestracyjnyPojazdu, string idUzytkownika):this()
		{
			_mojeRezerwacje = null;
			_imie = imie;
			_nazwisko = nazwisko;
			_haslo = haslo;
			_nrRejestracyjnyPojazdu = nrRejestracyjnyPojazdu;
			_IDUzytkownika = idUzytkownika;

		}
		public void Zarezerwuj(Rezerwacja r)
		{
			_mojeRezerwacje.Add(r);
		}

		public override string ToString()
		{
			StringBuilder sb = new StringBuilder();
			sb.AppendFormat(" {0},  {1}  {2} ID: {3}  haslo: {4}", _imie,_nazwisko,_nrRejestracyjnyPojazdu, _IDUzytkownika, _haslo);
			return sb.ToString();
		}

		public bool PoprawnoscHaslo(string h)
		{
            return _haslo.Equals(h);
         
        }
		
		public int Compare(Uzytkownik a, Uzytkownik b)
		{
			if (a != null && b != null)
			{ return a._IDUzytkownika.CompareTo(b._IDUzytkownika); }
			else { return 0; }

		}
		public object Clone()
		{
			return (Uzytkownik)this.MemberwiseClone();
		}

		
		public int CompareTo(object o)
		{
			if (o != null)
			{
				Uzytkownik c = (Uzytkownik)o;
				int cmp = Nazwisko.CompareTo(c.Nazwisko);
				if (cmp != 0)
				{
					return cmp;
				}
				return Imie.CompareTo(c.Imie);
			}
			return 1;
		}
	}
}
