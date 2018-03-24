using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureBuilder
{
    public class GameLocation
    {
        #region VARIABLES

        private int _id;                        // Unique location number.
        private string _name;                   // Location name.
        private string _description;            // Description of the location.
        private List<GameObject> _objects;      // Object at this location.
        private bool _visited;                  // Has this location been visited before.


        private bool _isFinished;       // This indicates that your happy with this room ready for publication.

        #endregion

        #region CONSTRUCTORS

        public GameLocation()
        {

        }
        #endregion

        #region METHODS

        #endregion

        #region PROPERTIES
        public int Id { get { return _id; } set { _id = value; } }
        public string Name { get { return _name; } set { _name = value; } }
        public string Description { get { return _description; } set { _description = value; } }
        public List<GameObject> Objects { get { return _objects; } set { _objects = value; } }
        public bool Visited { get { return _visited; } set { _visited = value; } }

        public bool Finished { get { return _isFinished; } set { _isFinished = value; } }
        #endregion
    }
}
