using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Threading.Tasks;

namespace AdventureBuilder
{
    // TODO: Build file structure.
    class FilingSystem
    {
        #region VARIABLES

        private static XmlDocument xmlDoc;

        #endregion

        #region METHODS

        public static void LoadDataFile(string file)
        {
            xmlDoc = new XmlDocument();

            xmlDoc.Load(file);
        }

        public static void SaveDataFile(string file)
        {

        }

        public static void CreateDataFile(string file)
        {
            xmlDoc = new XmlDocument();

            
        }
        #endregion

        #region PROPERTIES
        public static string Filename { get; set; }
        public static string FileDirectory { get; set; }
        public static string Title { get; set; }
        public static string Description { get; set; }
        public static string Author { get; set; }

        #endregion
    }
}
