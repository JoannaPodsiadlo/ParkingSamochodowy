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
using ParkingSamochodowy;
using System.Threading;

namespace gui1
{
 
    public partial class Rejestracja : Window
    {

        Uzytkownik nowyUzytkownik = new Uzytkownik();
        BazaUzytkownikow baza1 = BazaUzytkownikow.OdczytajXML("baza");
        
        public Rejestracja()
        {
            InitializeComponent();

        }
        public Rejestracja(Uzytkownik nowyUzytkownik) : this()
        {
            this.nowyUzytkownik = nowyUzytkownik;
            ImieTB.Text = nowyUzytkownik.Imie;
            NazwiskoTB.Text = nowyUzytkownik.Nazwisko;
            NrRejTB.Text = nowyUzytkownik.NrRejestracyjnyPojazdu;
            IDTB.Text = nowyUzytkownik.IDUzytkownika;
            HasloTB.Text = nowyUzytkownik.Haslo;
          
        }

        private void ZarejestrujButton_Click(object sender, RoutedEventArgs e)
        {
            if (ImieTB.Text == "" || NazwiskoTB.Text == "" || NrRejTB.Text == "" || HasloTB.Text == "" || PowtorzHasloTB.Text == "" || IDTB.Text=="")
            {
                MessageBox.Show("Nie wypełniłeś wszystkich pól, spróbuj ponownie");
                return;
            }
            else
                if (HasloTB.Text != PowtorzHasloTB.Text)
            {
                MessageBox.Show("Nieprawidłowe hasło, spróbuj ponownie");
                return;
            }
                else
                {
                nowyUzytkownik.Imie = ImieTB.Text;
                nowyUzytkownik.Nazwisko = NazwiskoTB.Text;
                nowyUzytkownik.NrRejestracyjnyPojazdu = NrRejTB.Text;
                nowyUzytkownik.Haslo = HasloTB.Text;
                nowyUzytkownik.IDUzytkownika =IDTB.Text;
                baza1.DodajKonto(nowyUzytkownik);
                baza1.ZapiszXML("baza", baza1);
                MessageBox.Show("Udało się! Aby sie zalogowac uruchom program ponownie");
                Close();
                 }
        }
    }
}
