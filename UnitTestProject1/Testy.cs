using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ParkingSamochodowy;

namespace UnitTestProject
{
    [TestClass]
    public class Testy 
    {
        [TestMethod]
        public void Test_Uzytkownik()
        {
            
            Uzytkownik testowy = new Uzytkownik("test_imie", "test_nazwisko", "test_hasło", "test_nr", "test_id");
            Assert.AreEqual("test_imie", testowy.Imie);
            Assert.AreEqual("test_nazwisko", testowy.Nazwisko);
            

        }

        [TestMethod]
        public void Test_Rezerwacja()
        {

            MiejsceParkingowe m_testowe = new MiejsceParkingowe();
            Rezerwacja testowa = new Rezerwacja("2018-02-02", "2018-02-04",6);
            string format = "yyyy-MM-dd";
            Assert.AreEqual("2018-02-02", testowa.DataOd.ToString(format));
            Assert.AreEqual("2018-02-04", testowa.DataDo.ToString(format));
            Assert.AreEqual(10.00, testowa.ObliczCene());
        }       

        [TestMethod]
        public void Test_MiejsceParkingowe()
        {
            MiejsceParkingowe m_testowe = new MiejsceParkingowe();
            Assert.AreEqual(18, m_testowe.NrMiejsca);
        }

        

        [TestMethod]
        public void Test_Uzytkownik_Zarezerwuj()
        {
            
            Uzytkownik testowy = new Uzytkownik("test_imie", "test_nazwisko", "test_hasło", "test_nr", "test_id");
            Rezerwacja testowa_rezerwacja = new Rezerwacja("2018-02-02", "2018-02-03", 20);
            testowy.Zarezerwuj(testowa_rezerwacja);         
            Assert.AreEqual(1, testowy._mojeRezerwacje.Count);
        }


        [TestMethod]
        [ExpectedException(typeof(NieUzytkownikException))]
        public void Test_Wyjatek()
        {
            BazaUzytkownikow baza_testowa = new BazaUzytkownikow();
            baza_testowa.CzyJestUzytkownikiem("3333333");
        }

        [TestMethod]
        
        public void Test_Baza()
        {
            BazaUzytkownikow baza_testowa = new BazaUzytkownikow();
            Uzytkownik testowy = new Uzytkownik("test_imie", "test_nazwisko", "test_hasło", "test_nr", "test_id");
            baza_testowa.DodajKonto(testowy);
            Assert.AreEqual(1, baza_testowa._baza.Count);

        }

        [TestMethod]

        public void Test_Parking()
        {
            Parking p_testowy = new Parking();
            p_testowy.StworzParking();
            Assert.AreEqual(16, p_testowy.parking.Count);

        }
        








    }
}
