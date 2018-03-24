using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureBuilder
{
    public class GameObject
    {
        #region VARIABLES

        private int _id;
        private string _name;
        private string _description;
        private int _initialLocation;
        private bool _isVisible;
        private int _weight;
        private int _cost;
        private EnObjectType _objectType;

        #endregion

        #region CONSTRUCTORS

        public GameObject()
        {

        }
        #endregion

        #region METHODS

        #endregion

        #region PROPERTIES
        public int Id { get { return _id; } set { _id = value; } }
        public string Name { get { return _name; } set { _name = value; } }
        public string Description { get { return _description; } set { _description = value; } }
        public int Location { get { return _initialLocation; } set { _initialLocation = value; } }
        public bool IsVisable { get { return _isVisible; } set { _isVisible = value; } }
        public int Weight { get { return _weight; } set { _weight = value; } }
        public int Cost { get { return _cost; } set { _cost = value; } }
        public EnObjectType ObjectType { get { return _objectType; } set { _objectType = value; } }
        #endregion
    }
}
