using ParkingSamochodowy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace gui1
{
	/// <summary>
	/// Logika interakcji dla klasy Rezerwacja.xaml
	/// </summary>
	
	public partial class Rezerwacja1 : Window
    {
		Rezerwacja r = new Rezerwacja();
		private List<Button> przycisk;
		private List<int> _miejsca;
		public List<Button> Przycisk { get => przycisk; set => przycisk = value; }
		public List<int> Miejsca { get => _miejsca; set => _miejsca = value; }
		
		public Rezerwacja1()
		{
			InitializeComponent();
		}
		public Rezerwacja1(Rezerwacja r):this()
        {
			r.p.StworzParking();
			r._dataOd=Convert.ToDateTime(DP_dataOD.Text);
			r._dataDo = Convert.ToDateTime(DP_dataDo.Text);
			textbox_miejsce.Text = Convert.ToString(r.wybraneMiejsce);
			r.ObliczCene();
			tb_zaplata.Text = "{0:c}" + r.ObliczCene();
        }
		
		private void Button_Click(object sender, RoutedEventArgs e)
		{
			MiejsceParkingowe m = r.p.ZwrocMiejsce(1);
			m.Zajmij();
			MessageBox.Show("Miejsce zajete!");
		}

		private void Button_Click_1(object sender, RoutedEventArgs e)
		{
			MiejsceParkingowe m = r.p.ZwrocMiejsce(2);
			m.Zajmij();
			MessageBox.Show("Miejsce zajete!");
		}

		private void Button_Click_2(object sender, RoutedEventArgs e)
		{
			MiejsceParkingowe m = r.p.ZwrocMiejsce(3);
			m.Zajmij();
			MessageBox.Show("Miejsce zajete!");
		}

		private void Button_Click_3(object sender, RoutedEventArgs e)
		{
			textbox_miejsce.Text = r.p.WybierzMiejsce(4);
			r.wybraneMiejsce = r.p.WybierzMiejsce(4);
		}

		private void Button_Click_4(object sender, RoutedEventArgs e)
		{
			MiejsceParkingowe m = r.p.ZwrocMiejsce(5);
			m.Zajmij();
			MessageBox.Show("Miejsce zajete!");
		}

		private void Button_Click_5(object sender, RoutedEventArgs e)
		{
			textbox_miejsce.Text=r.p.WybierzMiejsce(6);
		}

		private void Button_Click_6(object sender, RoutedEventArgs e)
		{
			textbox_miejsce.Text=r.p.WybierzMiejsce(7);
		}

		private void Button_Click_7(object sender, RoutedEventArgs e)
		{
			MiejsceParkingowe m = r.p.ZwrocMiejsce(8);
			m.Zajmij();
			MessageBox.Show("Miejsce zajete!");
		}

		private void Button_Click_8(object sender, RoutedEventArgs e)
		{
			MiejsceParkingowe m = r.p.ZwrocMiejsce(9);
			m.Zajmij();
			MessageBox.Show("Miejsce zajete!");
		}

		private void button10_Click(object sender, RoutedEventArgs e)
		{
			textbox_miejsce.Text = r.p.WybierzMiejsce(10);
		}

		private void button11_Click(object sender, RoutedEventArgs e)
		{
			textbox_miejsce.Text = r.p.WybierzMiejsce(11);
		}

		private void button12_Click(object sender, RoutedEventArgs e)
		{
			textbox_miejsce.Text = r.p.WybierzMiejsce(12);
		}

		private void button13_Click(object sender, RoutedEventArgs e)
		{
			textbox_miejsce.Text = r.p.WybierzMiejsce(13);
		}

		private void button14_Click(object sender, RoutedEventArgs e)
		{
			textbox_miejsce.Text = r.p.WybierzMiejsce(14);
		}

		private void button15_Click(object sender, RoutedEventArgs e)
		{
			MiejsceParkingowe m = r.p.ZwrocMiejsce(15);
			m.Zajmij();
			MessageBox.Show("Miejsce zajete!");
		}

		private void Button_Click_9(object sender, RoutedEventArgs e)
		{
			r._dataOd = Convert.ToDateTime(DP_dataOD.Text);
			r._dataDo = Convert.ToDateTime(DP_dataDo.Text);
			StringBuilder sb = new StringBuilder();
			sb.AppendFormat("{0:c}", r.ObliczCene());
			tb_zaplata.Text = sb.ToString();
        
		}


        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
			if (textbox_miejsce.Text == "")
			{
				MessageBox.Show("Nie wybrales miejsca!");
				return;
			}
			else

			{
				MessageBox.Show("Udało się zarezerwować wybrane miejsce!");
				Close();
			}
        }

        

        
    }
}
