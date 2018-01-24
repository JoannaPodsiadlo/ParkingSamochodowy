using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ParkingSamochodowy;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_Uzytkownik()
        {
            Uzytkownik testowy = new Uzytkownik("test_imie", "test_nazwisko", "test_hasło", "test_nr", "test_id");
            Assert.AreEqual("test_imie", testowy.Imie);
            Assert.AreEqual("test_nazwisko", testowy.Nazwisko);
            //Rezerwacja testowa_rezerwacja = new Rezerwacja("2018-02-02", "2018-02-03", 3);
            //testowy.Zarezerwuj(testowa_rezerwacja);         
            //Assert.AreEqual(1, testowy.LiczbaRezerwacji);

        }

        [TestMethod]
        public void Test_Rezerwacja()
        {
            Rezerwacja testowa = new Rezerwacja("2018-02-02", "2018-02-03", 1);
            string format = "yyyy-MM-dd";
            Assert.AreEqual("2018-02-02", testowa.DataOd.ToString(format));
            Assert.AreEqual("2018-02-03", testowa.DataDo.ToString(format));
            Assert.AreEqual(20.00, testowa.ObliczCene());


        }

        [TestMethod]
        public void Test_Wyjatek()
        {

        }

        [TestMethod]
        public void Test_MiejsceParkingowe()
        {
        }

        [TestMethod]
        public void Test_Parking()
        {
        }

        [TestMethod]
        public void Test_BazaUzytkownikow()
        {
        }
    }
}
