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
        public void Salles(int idSalle, string ville)
        {
            idSalle = _idSalle;
            ville = _ville;
        }
        #endregion

        #region Accesseurs
        public int IdSalle { get => _idSalle; set => _idSalle = value; }
        public string Ville { get => _ville; set => _ville = value; }
        #endregion
    }
}
