using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Media;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;



namespace ParkingSamochodowy
{
    [DataContract]
    [Serializable]
    [XmlInclude(typeof(BazaUzytkownikow))]
    [XmlInclude(typeof(Uzytkownik))]
    public class BazaUzytkownikow : ICloneable, IBaza
	{
        
		private List<Uzytkownik> _baza;
      
		public List<Uzytkownik> Baza { get => _baza; set => _baza = value; }
		

		public BazaUzytkownikow()
		{
			_baza = new List<Uzytkownik>();
		}

		
		/// Dodanie nowego uzytkownika do bazy
		
		public void DodajKonto(Uzytkownik u)
		{
			_baza.Add(u);
		}
        public Uzytkownik ZnajdzKonto(string id)
        {
           return  _baza.Find(p => (p.IDUzytkownika.Equals(id)));
        }
        
        /// Usuniecie uzytkownika z bazy poprzez podanie jego ID
        
        public void UsunKonto(string id)
		{
			
			_baza.Remove(_baza.Find(p => (p.IDUzytkownika.Equals(id))));
		}
		
		public bool CzyJestUzytkownikiem(string id)
		{
			
			if(_baza.Any(p => (p.IDUzytkownika.Equals(id))))
                return true;
            else
                throw new NieUzytkownikException();

        }
	
        
		public void Sortuj()
		{
			_baza.Sort();
		}
		
		
		public object Clone()
		{
            //return (Uzytkownik)this.MemberwiseClone();
            // Klonowanie poprzez serializacje do pamieci
            IFormatter formatter = new BinaryFormatter();
            using (MemoryStream ms = new MemoryStream())
            {
                formatter.Serialize(ms, this);
                ms.Seek(0, SeekOrigin.Begin);
                return (BazaUzytkownikow)formatter.Deserialize(ms);
            }
        }
		
		public BazaUzytkownikow DeepCopy()
		{
			BazaUzytkownikow kopia = (BazaUzytkownikow)this.Clone();
			kopia._baza = new List<Uzytkownik>(this._baza.Select(x => (Uzytkownik)x.Clone()));
			return kopia;
		}

		public override string ToString()
		{
			StringBuilder sb = new StringBuilder();
			sb.AppendLine("******BAZA********") ;
			foreach (Uzytkownik u in _baza)
			{
				sb.AppendLine(u.ToString());
			}
			return sb.ToString();
		}

        public void ZapiszXML(string nazwa, BazaUzytkownikow b)
        {
            XmlSerializer srlzr = new XmlSerializer(typeof(BazaUzytkownikow));
            StreamWriter writer = new StreamWriter(nazwa);
            srlzr.Serialize(writer, b);
            writer.Close();
        }

        static public BazaUzytkownikow OdczytajXML(string nazwa)
        {
            XmlSerializer srlzr = new XmlSerializer(typeof(BazaUzytkownikow));
            Stream stream = new FileStream(nazwa, FileMode.Open);
            BazaUzytkownikow a = (BazaUzytkownikow)srlzr.Deserialize(stream);
            stream.Close();
            return a;
        }
    }

    
}
