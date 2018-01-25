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
            //MiejsceParkingowe m_testowe = new MiejsceParkingowe();
            Uzytkownik testowy = new Uzytkownik("test_imie", "test_nazwisko", "test_hasło", "test_nr", "test_id");
            Assert.AreEqual("test_imie", testowy.Imie);
            Assert.AreEqual("test_nazwisko", testowy.Nazwisko);
            //Rezerwacja testowa_rezerwacja = new Rezerwacja("2018-02-02", "2018-02-03", m_testowe.NrMiejsca);
            //testowy.Zarezerwuj(testowa_rezerwacja);         
            //Assert.AreEqual(1, testowy._mojeRezerwacje.Count);

        }

        [TestMethod]
        public void Test_Rezerwacja()
        {

            MiejsceParkingowe m_testowe = new MiejsceParkingowe();
            Rezerwacja testowa = new Rezerwacja("2018-02-02", "2018-02-04",m_testowe.NrMiejsca);
            string format = "yyyy-MM-dd";
            Assert.AreEqual("2018-02-02", testowa.DataOd.ToString(format));
            Assert.AreEqual("2018-02-04", testowa.DataDo.ToString(format));
           
        }       

        [TestMethod]
        public void Test_MiejsceParkingowe()
        {
            MiejsceParkingowe m_testowe = new MiejsceParkingowe();
            Assert.AreEqual(18, m_testowe.NrMiejsca);
        }

        

        [TestMethod]
        public void Uzytkownik_rezerwacja()
        {
            
            Uzytkownik testowy = new Uzytkownik("test_imie", "test_nazwisko", "test_hasło", "test_nr", "test_id");
            Rezerwacja testowa_rezerwacja = new Rezerwacja("2018-02-02", "2018-02-03", 1);
            testowy.Zarezerwuj(testowa_rezerwacja);         
            Assert.AreEqual(1, testowy._mojeRezerwacje.Count);
        }
    }
}
