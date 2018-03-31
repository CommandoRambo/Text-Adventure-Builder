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
        private string _descriptiveName;
        private string _description;
        private int _initialLocation;
        private bool _isVisible;
        private int _weight;
        private int _cost;
        private int _points;
        private EnObjectType _objectType;
        private int _objectCount = 0;

        #endregion

        #region CONSTRUCTORS

        public GameObject()
        {

        }
        #endregion

        #region METHODS

        private void GetObjectCount()
        {
            
        }
        #endregion

        #region PROPERTIES
        public int Id { get { return _id; } set { _id = value; } }
        public string Name { get { return _name; } set { _name = value; } }
        public string DescriptiveName { get { return _descriptiveName; } set { _descriptiveName = value; } }
        public string Description { get { return _description; } set { _description = value; } }
        public int Location { get { return _initialLocation; } set { _initialLocation = value; } }
        public bool IsVisable { get { return _isVisible; } set { _isVisible = value; } }
        public int Weight { get { return _weight; } set { _weight = value; } }
        public int Cost { get { return _cost; } set { _cost = value; } }
        public int Points { get { return _points; } set { _points = value; } }
        public EnObjectType ObjectType { get { return _objectType; } set { _objectType = value; } }
        public int ObjectCount { get { return _objectCount; } set { _objectCount = value; } }
        #endregion
    }
}
