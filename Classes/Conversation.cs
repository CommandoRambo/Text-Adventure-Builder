using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureBuilder
{
    class Conversation
    {
        #region VARIABLES

        private int _id;
        private GameCharacter _character;
        #endregion

        #region CONSTRUCTORS

        public Conversation()
        {

        }
        #endregion

        #region METHODS

        #endregion

        #region PROPERTIES
        public int Id { get { return _id; } set { _id = value; } }
        public GameCharacter Character { get { return _character; } set { _character = value; } }
        #endregion
    }
}
