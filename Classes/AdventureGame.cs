using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureBuilder
{
    public class AdventureGame
    {
        #region VARIABLES

        private string _name;
        private string _description;
        private Guid _gameId;
        private bool _hasTime;
        private EnGenre _genre;
        private Image _splash;

        #endregion

        #region METHODS

        public void CreateAdventure()
        {

        }
        #endregion

        #region PROPERTIES
        public string name { get { return _name; } set { _name = value; } }
        public string Description { get { return _description; } set { _description = value; } }
        public Guid GameId { get { return _gameId; } set { _gameId = value; } }
        public bool HasTime { get { return _hasTime; } set { _hasTime = value; } }
        public EnGenre Genre { get { return _genre; } set { _genre = value; } }
        public Image Splash { get { return _splash; } set { _splash = value; } }
        #endregion
    }
}
