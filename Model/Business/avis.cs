﻿using System;
using System.Collections.Generic;
using System.Text;
using Directeur_PPE3_DAO.Model.Data;


namespace Directeur_PPE3_DAO
{
    class avis
    {
        #region Attributs
        private int _idAvis;
        private int _idClient;
        private int _idSalle;
        private string _avis;
        #endregion

        #region Constructeurs
        public void Avis(int idAvis, int idClient, int idSalle, string avis)
        {
            idAvis = _idAvis;
            idClient = _idClient;
            idSalle = _idSalle;
            avis = _avis;
        }
        #endregion

        #region Accesseurs
        public int IdAvis { get => _idAvis; set => _idAvis = value; }
        public int IdClient { get => _idClient; set => _idClient = value; }
        public int IdSalle { get => _idSalle; set => _idSalle = value; }
        public string Avis1 { get => _avis; set => _avis = value; }
        #endregion
    }
}
