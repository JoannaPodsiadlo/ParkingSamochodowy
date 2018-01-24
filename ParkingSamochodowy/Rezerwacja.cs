using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingSamochodowy
{

    public class Rezerwacja
    {
        
        public DateTime _dataOd;
        public DateTime _dataDo;
        public static int _cenaZaDzien;
        public Parking p;
        public string wybraneMiejsce;
        

        public DateTime DataOd { get => _dataOd; set => _dataOd = value; }
        public DateTime DataDo { get => _dataDo; set => _dataDo = value; }
        public static int CenaZaDzien { get => _cenaZaDzien; set => _cenaZaDzien = value; }
        public Parking P { get => p; set => p = value; }
        public string WybraneMiejsce { get => wybraneMiejsce; set => wybraneMiejsce = value; }
        

        static Rezerwacja()
        {
            _cenaZaDzien = 5;

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
		/// <summary>
		/// Obliczanie oplaty za parking
		/// </summary>
		/// <returns></returns>
        public double ObliczCene()
        {
            var ile = (_dataDo - _dataOd);
            var days = ile.TotalDays;
            return days * _cenaZaDzien;
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
        [Key]
        public int RezerwacjaId { get; set; }
        public int UzytkownikId { get; set; }
        public virtual Uzytkownik Uzytkownik { get; set; }
    }
}