using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureBuilder
{
    class Actions
    {
        #region VARIABLES

        private int _actionId;
        private GameObject _gameObject;
        private GameLocation _gameObjectLocation;


        #endregion

        #region CONSTRUCTORS

        public Actions()
        {
            
        }
        #endregion

        #region METHODS

        #endregion

        #region PROPERTIES
        public int ActionId { get { return _actionId; } set { _actionId = value; } }
        public GameObject GameObjectName { get { return _gameObject; } set { _gameObject = value; } }
        public GameLocation GameObjectLocation { get { return _gameObjectLocation; } set { _gameObjectLocation = value; } }
        #endregion
    }
}
