using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingSamochodowy
{

    public class Rezerwacja
    {
        private DateTime _dataOd;
        private DateTime _dataDo;
        private static int _cenaZaGodzine;
        private Parking p;
        private string wybraneMiejsce;
        private List<string> _godziny;

        public DateTime DataOd { get => _dataOd; set => _dataOd = value; }
        public DateTime DataDo { get => _dataDo; set => _dataDo = value; }
        public static int CenaZaGodzine { get => _cenaZaGodzine; set => _cenaZaGodzine = value; }
        public Parking P { get => p; set => p = value; }
        public string WybraneMiejsce { get => wybraneMiejsce; set => wybraneMiejsce = value; }
        public List<string> Godziny { get => _godziny; set => _godziny = value; }

        static Rezerwacja()
        {
            _cenaZaGodzine = 3;
        }

        public Rezerwacja()
        {
            P = new Parking();
            P.StworzParking();
        }
        public Rezerwacja(string dataOd, string dataDo, int a) : this()
        {
            _dataOd = Convert.ToDateTime(dataOd);
            _dataDo = Convert.ToDateTime(dataDo);
            wybraneMiejsce = p.WybierzMiejsce(a);
        }
        public double ObliczCene()
        {
            var ile = (_dataDo - _dataOd);
            var hours = ile.TotalHours;
            return hours * _cenaZaGodzine;
        }
        public void DodajGodz()
        {
            for (int i = 1; i < 25; i++)
            {
                string h = i.ToString() + ":00";
                _godziny.Add(h);
            }
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Potwierdzenie rezerwacji");
            sb.AppendFormat("Data od {0}", _dataOd.ToShortDateString());
            sb.AppendFormat("Data do {0}", _dataDo.ToShortDateString());
            sb.AppendFormat("Oplata: {0:c}", ObliczCene());
            sb.AppendFormat("Miejsce numer:" + wybraneMiejsce);
            return sb.ToString();
        }
    }
}