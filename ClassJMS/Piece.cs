using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassJMS
{
    public class Piece
    {
        #region attributs privés
        private int numSerie;       // numéro de série
        private string libelle;     // libellé de la pièce
        private int nbHeures;       // nombre d'heures de fonctionnement
        #endregion

        #region constructeur
        
        #endregion

        #region méthodes
        public virtual bool AControler()
        {
            return false;
        }
        #endregion
    }
}
