using System;
using System.Collections.Generic;
using System.Text;
using Directeur_PPE3_DAO.Model.Data;

namespace Directeur_PPE3_DAO
{
    class salles
    {
        #region Attributs
        private int _idSalle;
        private string _ville;
        #endregion

        #region Constructeurs
        public salles(int idSalle, string ville)
        {
           _idSalle = idSalle;
            _ville = ville;
        }

        public salles()
        {
            _idSalle = -1;
            _ville = "";
        }
        #endregion

        #region Accesseurs
        public int IdSalle { get => _idSalle; set => _idSalle = value; }
        public string Ville { get => _ville; set => _ville = value; }
        #endregion
    }
}
