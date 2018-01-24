using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingSamochodowy
{
	interface IBaza
	{
		
		void DodajKonto(Uzytkownik u);
		void Sortuj();
		bool CzyJestUzytkownikiem(string id);
		
	}
}
