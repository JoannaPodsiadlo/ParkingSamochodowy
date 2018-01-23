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
using System.Windows.Navigation;
using System.Windows.Shapes;
using ParkingSamochodowy;
using System.Collections.ObjectModel;

namespace gui1
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       public BazaUzytkownikow baza = new BazaUzytkownikow();
       public Uzytkownik uzytkownik = new Uzytkownik();
        public MainWindow()
        {
            InitializeComponent();
            Odczytaj("baza");
        }

        private void Odczytaj(string nazwa)
        {
            baza = BazaUzytkownikow.OdczytajXML(nazwa);
        }


        private void ZalogujButton_Click(object sender, RoutedEventArgs e)
        {
            if (IDTextBox.Text == "" || HasloTextBox.Text == "")
            {
                MessageBox.Show("Nie uzupelniles wszystkich pól");
                return;
            }

            else

                
                try
                {
                    baza.CzyJestUzytkownikiem(IDTextBox.Text);
                    uzytkownik = baza.ZnajdzKonto(IDTextBox.Text);
                    if (uzytkownik.PoprawnoscHaslo(HasloTextBox.Text))
                    {
                        Rezerwacja okno = new Rezerwacja();
                        okno.ShowDialog();
                    }
                    else MessageBox.Show("Złe hasło, spróbuj ponownie");
                }
                catch
                {
                    MessageBox.Show("Nie ma takiego ID, spróbuj ponownie");
                    return;
                }
            
        }

        private void NoweKontoButton_Click(object sender, RoutedEventArgs e)
        {
            Rejestracja okno = new Rejestracja();
            okno.ShowDialog();
        }
    }
}
