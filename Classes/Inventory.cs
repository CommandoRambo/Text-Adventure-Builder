using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureBuilder
{
    class Inventory
    {
        #region VARIABLES

        private int _id;
        private int _totalWeight;
        private List<GameObject> _gameObjects;
        private int _slots;

        #endregion

        #region CONSTRUCTORS

        #endregion

        #region METHODS

        #endregion

        #region PROPERTIES
        private int Id { get { return _id; } set { _id = value; } }
        public int TotalWeight { get { return _totalWeight; } set { _totalWeight = value; } }
        public List<GameObject> GameObjects { get { return _gameObjects; } set { _gameObjects = value; } }
        public int Slots { get { return _slots; } set { _slots = value; } }
        #endregion
    }
}
