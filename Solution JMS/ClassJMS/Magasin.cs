using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassJMS
{
    public class Magasin
    {
        #region attributs privés
        private List<Piece> lesPieces;  // ensemble des pièces du magasin
        #endregion

        #region constructeur
        public Magasin()
        {
            this.lesPieces = new List<Piece>();
        }
        #endregion

        #region méthodes
        public bool AjouterPiece(Piece unePiece)
        {
            foreach (Piece p in this.lesPieces)
            {
                if (unePiece.GetNumSerie() == p.GetNumSerie())
                {
                    return false;
                }
            }
            lesPieces.Add(unePiece);
            return true;
        }

        public void AfficherMagasin()
        {
            string res = "";
            foreach (Piece p in this.lesPieces)
            {
                res += p.ObtenirInfos();
            }
            Console.WriteLine("{0}", res);
        }

        public double ObtenirTauxPNA()
        {
            double cpt = 0;
            double res = 0;
            foreach (Piece p in this.lesPieces)
            {
                if (p is PieceNonAgreee)
                {
                    cpt += 1;
                }
            }
            res = cpt * 100 / this.lesPieces.Count();
            return res;
        }

        public List<Piece> ControlerPieces()
        {
            List<Piece> PieceAControler = new List<Piece>();
            foreach (Piece p in this.lesPieces)
            {
                if (p.AControler() == true)
                {
                    PieceAControler.Add(p);
                }
            }
            return PieceAControler;
        }


        // Méthodes utiles pour les tests unitaires
        public List<Piece> GetLesPieces()
        {
            return this.lesPieces;
        }

        public void SetLesPieces(List<Piece> lesPieces)
        {
            this.lesPieces = lesPieces;
        }

        #endregion
    }
}
