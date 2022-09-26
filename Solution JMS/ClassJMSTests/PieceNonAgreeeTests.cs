using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassJMS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassJMS.Tests
{
    [TestClass()]
    public class PieceNonAgreeeTests
    {
        [TestMethod()]
        public void ObtenirInfosTest()
        {
            // cas ou la piece est dans l'etat VERT
            PieceNonAgreee p1 = new PieceNonAgreee(125, "Anémomètre", 1250, 11000);
            string expected1 = "125 - Anémomètre\nEtat : VERT";
            Assert.AreEqual(expected1, p1.ObtenirInfos());
        }

        [TestMethod()]
        public void ChangerEtatTest()
        {
            PieceNonAgreee p = new PieceNonAgreee(125, "Anémomètre", 1250, 11000);
            p.ChangerEtat("ORANGE");
            string expected = "ORANGE";
            Assert.AreEqual(expected, p.GetEtat());
        }

        [TestMethod()]
        public void AControlerTest()
        {
            // Cas 1 : La piece est à contrôler car son état est vert et le seuil est dépassé
            PieceNonAgreee p1 = new PieceNonAgreee(125, "Anémomètre", 11000, 10000);
            bool expected1 = true;
            Assert.AreEqual(expected1, p1.AControler());

            // Cas 2 : La piece n'est pas à contrôler car le seuil n'est pas dépassé, même si son état est vert
            PieceNonAgreee p2 = new PieceNonAgreee(125, "Anémomètre", 9000, 10000);
            bool expected2 = false;
            Assert.AreEqual(expected2, p2.AControler());

            // Cas 3 : La piece n'est pas à contrôler car son état n'est pas vert, même si le seuil est dépassé
            PieceNonAgreee p3 = new PieceNonAgreee(125, "Anémomètre", 11000, 10000);
            p3.ChangerEtat("ORANGE");
            bool expected3 = false;
            Assert.AreEqual(expected3, p3.AControler());

        }
    }
}