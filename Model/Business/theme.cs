using System;
using System.Collections.Generic;
using System.Text;
using Directeur_PPE3_DAO.Model.Data;

namespace Directeur_PPE3_DAO
{
    class theme
    {
        #region Attributs
        private int _idTheme;
        private string _theme;
        #endregion

        #region Constructeurs
        public theme(int idTheme, string theme)
        {
            _idTheme = idTheme;
            _theme = theme;
        }

        public theme()
        {
            _idTheme = -1;
            _theme = "";
        }
        #endregion

        #region Accesseurs
        public int IdTheme { get => _idTheme; set => _idTheme = value; }
        public string Theme1 { get => _theme; set => _theme = value; } 
        #endregion

    }
}
