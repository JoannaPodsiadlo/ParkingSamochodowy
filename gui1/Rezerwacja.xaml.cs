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
    public partial class Rezerwacja : Window
    {
		Rezerwacja r1 = new Rezerwacja();
		public Rezerwacja()
        {
            InitializeComponent();
			kalendarz.Visibility = Visibility.Hidden;
			kalendarz.DisplayDateStart = DateTime.Today;



        }

		private void button1_kalendarz_Click(object sender, RoutedEventArgs e)
		{
			if (kalendarz.Visibility == Visibility.Hidden)
			{
				kalendarz.Visibility = Visibility.Visible;
			}
			else
			{
				kalendarz.Visibility = Visibility.Hidden;
			}
		}

		private void button2_kalendarz_Click(object sender, RoutedEventArgs e)
		{

			if (kalendarz.Visibility == Visibility.Hidden)
			{
				kalendarz.Visibility = Visibility.Visible;
			}
			else
			{
				kalendarz.Visibility = Visibility.Hidden;
			}
		}
		private void double_click_calendar(object sender, MouseButtonEventArgs e)
		{
			if (kalendarz.SelectedDate.HasValue)
			{
				textbox_data1.Text = kalendarz.SelectedDate.Value.ToString("dd/MM/yyyy");
			}
			kalendarz.Visibility = Visibility.Hidden;
			
		}
		private void double2_click_calendar(object sender, MouseButtonEventArgs e)
		{
			if (kalendarz.SelectedDate.HasValue)
			{
				textbox_data2.Text = kalendarz.SelectedDate.Value.ToString("dd/MM/yyyy");
			}
			kalendarz.Visibility = Visibility.Hidden;
			
		}

	}
}
