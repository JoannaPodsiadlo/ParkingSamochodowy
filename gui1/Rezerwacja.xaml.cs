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
		
		List<Button> przycisk;
		List<int> _miejsca;

		public List<Button> Przycisk { get => przycisk; set => przycisk = value; }
		public List<int> Miejsca { get => _miejsca; set => _miejsca = value; }
		public Rezerwacja1()
		{
			InitializeComponent();
			//kalendarz.Visibility = Visibility.Hidden;
			//kalendarz.DisplayDateStart = DateTime.Today;
		}
		public Rezerwacja1(Rezerwacja r):this()
        {
			DP_dataOD.Text = Convert.ToString(r._dataOd);
			DP_dataDo.Text = Convert.ToString(r._dataDo);
			textbox_miejsce.Text = Convert.ToString(r.wybraneMiejsce);
        }

		private void Button_Click(object sender, RoutedEventArgs e)
		{

		}

		private void Button_Click_1(object sender, RoutedEventArgs e)
		{

		}

		private void Button_Click_2(object sender, RoutedEventArgs e)
		{

		}

		private void Button_Click_3(object sender, RoutedEventArgs e)
		{

		}

		private void Button_Click_4(object sender, RoutedEventArgs e)
		{

		}

		private void Button_Click_5(object sender, RoutedEventArgs e)
		{

		}

		private void Button_Click_6(object sender, RoutedEventArgs e)
		{

		}

		private void Button_Click_7(object sender, RoutedEventArgs e)
		{

		}

		private void Button_Click_8(object sender, RoutedEventArgs e)
		{

		}
	}
}
