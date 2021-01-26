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
            int somma_effettiva = Gestione.SommaInt(a, b);
            Assert.AreEqual(somma_aspettata, somma_effettiva);
        }
        [TestMethod]
        public void TestSommaNulli()
        {
            int a = 0, b = 0, somma_aspettata = 0;
            int somma_effettiva = Gestione.SommaInt(a, b);
            Assert.AreEqual(somma_aspettata, somma_effettiva);
        }
        [TestMethod]
        public void TestSommaNegativi()
        {
            int a = -2, b = -5, somma_aspettata = -7;
            int somma_effettiva = Gestione.SommaInt(a, b);
            Assert.AreEqual(somma_aspettata, somma_effettiva);
        }
        [TestMethod]
        public void TestSommaPosENeg()
        {
            int a = -10, b = 1, somma_aspettata = -9;
            int somma_effettiva = Gestione.SommaInt(a, b);
            Assert.AreEqual(somma_aspettata, somma_effettiva);
        }
        [TestMethod]
        public void TestSommaDecimale()
        {
            double a = 7.5, b = 1, somma_aspettata = 8.5;
            double somma_effettiva = Gestione.SommaDecimale(a, b);
            Assert.AreEqual(somma_aspettata, somma_effettiva);
        }
        [TestMethod]
        public void TestDifferenzaPositivi()
        {
            int a = 7, b = 3, differenza_aspettata = 4;
            int somma_effettiva = Gestione.DifferenzaInt(a, b);
            Assert.AreEqual(differenza_aspettata, somma_effettiva);
        }
        [TestMethod]
        public void TestDifferenzaNulli()
        {
            int a = 0, b = 0, diff_aspettata = 0;
            int somma_effettiva = Gestione.DifferenzaInt(a, b);
            Assert.AreEqual(diff_aspettata, somma_effettiva);
        }
        [TestMethod]
        public void TestDifferenzaNegativi()
        {
            int a = -2, b = -5, diff_aspettata = 3;
            int somma_effettiva = Gestione.DifferenzaInt(a, b);
            Assert.AreEqual(diff_aspettata, somma_effettiva);
        }
        [TestMethod]
        public void TestDifferenzaPosENeg()
        {
            int a = -10, b = 1, diff_aspettata = -11;
            int somma_effettiva = Gestione.DifferenzaInt(a, b);
            Assert.AreEqual(diff_aspettata, somma_effettiva);
        }
        [TestMethod]
        public void TestDifferenzaDecimale()
        {
            double a = 7.5, b = 1, diff_aspettata = 6.5;
            double somma_effettiva = Gestione.DifferenzaDecimale(a, b);
            Assert.AreEqual(diff_aspettata, somma_effettiva);
        }
        public void TestMoltiplicazionePositivi()
        {
            int a = 3, b = 7, moltiplicazione_aspettata = 21;
            int somma_effettiva = Gestione.MoltiplicazioneInt(a, b);
            Assert.AreEqual(moltiplicazione_aspettata, somma_effettiva);
        }
        [TestMethod]
        public void TestMoltiplicazioneNulli()
        {
            int a = 0, b = 0, moltiplicazione_aspettata = 0;
            int somma_effettiva = Gestione.MoltiplicazioneInt(a, b);
            Assert.AreEqual(moltiplicazione_aspettata, somma_effettiva);
        }
        [TestMethod]
        public void TestMoltipliacazioneNegativi()
        {
            int a = -2, b = -5, moltiplicazione_aspettata = 10;
            int somma_effettiva = Gestione.MoltiplicazioneInt(a, b);
            Assert.AreEqual(moltiplicazione_aspettata, somma_effettiva);
        }
        [TestMethod]
        public void TestMoltiplicazionePosENeg()
        {
            int a = -10, b = 1, moltiplicazione_aspettata = -10;
            int somma_effettiva = Gestione.MoltiplicazioneInt(a, b);
            Assert.AreEqual(moltiplicazione_aspettata, somma_effettiva);
        }
        [TestMethod]
        public void TestMoltiplicazioneDecimale()
        {
            double a = 7.5, b = 0, moltiplicazione_aspettata = 0;
            double somma_effettiva = Gestione.MoltiplicazioneDecimale(a, b);
            Assert.AreEqual(moltiplicazione_aspettata, somma_effettiva);
        }
        public void TestDivisionePositivi()
        {
            double a = 21, b = 7, div_aspettata = 3;
            double somma_effettiva = Gestione.DivisioneDecimale(a, b);
            Assert.AreEqual(div_aspettata, somma_effettiva);
        }
        [TestMethod]
        public void TestDivisioneNulli()
        {
            double a = 0, b = 0; 
            double div_aspettata = 0;
            double somma_effettiva = Gestione.DivisioneDecimale(a, b);
            Assert.AreEqual(div_aspettata, somma_effettiva);
        }
        [TestMethod]
        public void TestDivisioneNegativi()
        {
            double a = -10, b = -5, div_aspettata = 2;
            double somma_effettiva = Gestione.DivisioneDecimale(a, b);
            Assert.AreEqual(div_aspettata, somma_effettiva);
        }
        [TestMethod]
        public void TestDivisionePosENeg()
        {
            double a = -10, b = 1, div_aspettata = -10;
            double somma_effettiva = Gestione.DivisioneDecimale(a, b);
            Assert.AreEqual(div_aspettata, somma_effettiva);
        }
        [TestMethod]
        public void TestDivisioneDecimale()
        {
            double a = 7.5, b = 1, div_aspettata = 7.5;
            double somma_effettiva = Gestione.DivisioneDecimale(a, b);
            Assert.AreEqual(div_aspettata, somma_effettiva);
        }
    }
}
