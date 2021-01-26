using Microsoft.VisualStudio.TestTools.UnitTesting;
using Operazioni;
namespace OperazioniTest
{
    [TestClass]
    public class GestioneTest
    {
        [TestMethod]
        public void TestSommaPositivi()
        {
            int a = 3, b = 7, somma_aspettata = 10;
            int somma_effettiva = Gestione.Somma(a, b);
            Assert.AreEqual(somma_aspettata, somma_effettiva);
        }
        [TestMethod]
        public void TestSommaNulli()
        {
            int a = 0, b = 0, somma_aspettata = 0;
            int somma_effettiva = Gestione.Somma(a, b);
            Assert.AreEqual(somma_aspettata, somma_effettiva);
        }
        [TestMethod]
        public void TestSommaNegativi()
        {
            int a = -2, b = -5, somma_aspettata = -7;
            int somma_effettiva = Gestione.Somma(a, b);
            Assert.AreEqual(somma_aspettata, somma_effettiva);
        }
        [TestMethod]
        public void TestSommaPosENeg()
        {
            int a = -10, b = 1, somma_aspettata = -9;
            int somma_effettiva = Gestione.Somma(a, b);
            Assert.AreEqual(somma_aspettata, somma_effettiva);
        }
    }
}
