using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingSamochodowy
{

    public class Parking
    {

        private List<MiejsceParkingowe> parking;
        public List<MiejsceParkingowe> Parking1 { get => parking; set => parking = value; }
        public const int ILOSC_MIEJSC = 16;
        public Parking()
        {
            parking = new List<MiejsceParkingowe>();
        }

        public void StworzParking()
        {
			parking.Clear();
            for (int i = 0; i < ILOSC_MIEJSC; i++)
            {
                MiejsceParkingowe m = new MiejsceParkingowe();
                parking.Add(m);
            }
        }
		public void DodajMiejsce(MiejsceParkingowe m)
		{
			parking.Add(m);
		}
        public string WybierzMiejsce(int a)
        {
            MiejsceParkingowe m = parking.Find(mce => mce.NrMiejsca.Equals(a));
            m.Zajmij();
            return m.NrMiejsca.ToString();
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
    }

}