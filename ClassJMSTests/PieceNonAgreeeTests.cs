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
            string expected = "125 - Anémomètre\nEtat : VERT";
            Assert.AreEqual(expected, p.GetEtat());
        }

        [TestMethod()]
        public void AControlerTest()
        {
            // Cas 1 : La piece est à contrôler car son état est vert et le seuil est dépassé
            

            // Cas 2 : La piece n'est pas à contrôler car le seuil n'est pas dépassé, même si son état est vert


            // Cas 3 : La piece n'est pas à contrôler car son état n'est pas vert, même si le seuil est dépassé


        }
    }
}