using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingSamochodowy
{
    [Table("Parkingi")]
    public class Parking
    {

        public List<MiejsceParkingowe> parking;
        public List<MiejsceParkingowe> Parking1 { get => parking; set => parking = value; }
        public const int ILOSC_MIEJSC = 16;
        public Parking()
        {
            parking = new List<MiejsceParkingowe>();
        }

		/// <summary>
		/// Metoda tworzaca parking majacy 15 miejsc
		/// </summary>
        public void StworzParking()
        {
			parking.Clear();
            for (int i = 0; i < ILOSC_MIEJSC; i++)
            {
                MiejsceParkingowe m = new MiejsceParkingowe();
                parking.Add(m);
            }
        }
		/// <summary>
		/// Parkowanie, rezerwowanie miejsca
		/// </summary>
		/// <param name="a"></param>
		/// <returns></returns>
        public string WybierzMiejsce(int a)
        {
            MiejsceParkingowe m = parking.Find(mce => mce.NrMiejsca.Equals(a));
            m.Zajmij();
            return m.NrMiejsca.ToString();
        }
		/// <summary>
		/// Pobieranie numeru miejsca, pomocnicza funkcja do GUI
		/// </summary>
		/// <param name="a"></param>
		/// <returns></returns>
		public MiejsceParkingowe ZwrocMiejsce(int a)
		{
			return parking[a];
		}
	
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (MiejsceParkingowe m in parking)
            {
                sb.AppendLine(m.ToString());
            }

            return sb.ToString();
        }
        [Key]
        public int ParkingId { get; set; }
    }

}