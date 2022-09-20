using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassJMS
{
    public class PieceAgreee : Piece
    {
        #region attributs privés
        private DateTime dateAgrement;       // date de l'agrement
        private string nomConstructeur;     // nom du constructeur
        #endregion

        #region constructeur
        public PieceAgreee(int unNumero, string unLibelle, int unNombre, DateTime uneDate, string unConstructeur):base(unNumero, unLibelle, unNombre)
        {
            this.dateAgrement = uneDate;
            this.nomConstructeur = unConstructeur;
        }
        #endregion

        #region méthodes
        public void RenouvelerAgrement(DateTime uneDate)
        {
            this.dateAgrement = uneDate;
        }

        public int CalculerDureeAgrement()
        {
            return  DateTime.Now.Year - this.dateAgrement.Year;
        }

        public override bool AControler()
        {
            if(CalculerDureeAgrement()>2)
                return true;
            else
                return false;
        }

        public override string ObtenirInfos()
        {
            return base.ObtenirInfos() + "\nConstructeur : " + this.nomConstructeur + "\nDate Agrément : " + GetDateAgrement().ToShortDateString();
        }

        public DateTime GetDateAgrement()
        {
            return this.dateAgrement;
        }
        #endregion
    }
}
