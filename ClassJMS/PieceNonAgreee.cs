using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassJMS
{
    internal class PieceNonAgreee : Piece
    {
        #region attributs privés
        private string etat;       // etat de la piece
        private int seuil;     // nombre d'heure ou il faut controler
        #endregion

        #region constructeur
        public PieceNonAgreee(int unNumero, string unLibelle, int unNombre, string unEtat, int unSeuil):base(unNumero, unLibelle, unNombre)
        {
            this.etat = unEtat;
            this.seuil = unSeuil;
        }
        #endregion

        #region méthodes
        public string GetEtat()
        {
            return this.etat;
        }

        public void ChangerEtat(string unEtat)
        {
            this.etat = unEtat;
        }

        public override bool AControler()
        {
            if (this.seuil >= nbHeures)
                return true;
            else
                return false;
        }

        public override string ObtenirInfos()
        {
            return base.ObtenirInfos() + "\nEtat : " + this.etat;
        }
        #endregion
    }
}
