using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureBuilder
{
    class GameCharacter
    {
        #region VARIABLES

        private int _id;
        private string _firstName;
        private string _secondName;
        private string _description;
        private int _inventoryId;
        private int _slots;

        #endregion

        #region CONSTRUCTORS

        public GameCharacter()
        {

        }
        #endregion

        #region METHODS

        #endregion

        #region PROPERTIES
        public int Id { get { return _id; } set { _id = value; } }
        public string FirstName { get { return _firstName; } set { _firstName = value; } }
        public string SecondName { get { return _secondName; } set { _secondName = value; } }
        public string Description { get { return _description; } set { _description = value; } }
        public int InventoryId { get { return _inventoryId; } set { _inventoryId = value; } }
        #endregion
    }
}
