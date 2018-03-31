using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdventureBuilder
{
    // TODO: Build file structure.
    public class FilingSystem
    {
        #region VARIABLES
        private static readonly byte[] _tag = { 0x54, 0x41, 0x42 };
        private static byte _major;
        private static byte _minor;
        private static byte _flags;
        private static byte[] _size;

        private static int _headerSize = 10;

        private static string _filename;
        private static string _directory;
        private static string _title;
        private static string _description;
        private static string _author;
        private static int _majorVersion;
        private static int _minorVersion;

        private static StreamReader _reader;
        private static StreamWriter _writer;


        #endregion

        #region METHODS

        public static void LoadDataFile(string file)
        {
            _reader = new StreamReader(file);

            // Check header tag.
            // _reader.Read(_tag, 0, 3);

            //if (_tag[0] != Header.Tag[0])
            //{
            //    MessageBox.Show("Wrong file type.", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}

            // Check major and minor version numbers.

            // Check what flags are set.

            // Get the size.

        }

        public static void SaveDataFile(string file)
        {

        }

        public static void CreateDataFile(string file)
        {
            _writer = new StreamWriter(file);



            // _writer.Write(Header.Tag);

            _writer.Dispose();
        }
        #endregion

        #region PROPERTIES
        public static string Filename { get { return _filename; } set { _filename = value; } }
        public static string FileDirectory { get { return _directory; } set { _directory = value; } }
        public static string Title { get { return _title; } set { _title = value; } }
        public static string Description { get { return _description; } set { _description = value; } }
        public static string Author { get { return _author; } set { _author = value; } }
        public static int MajorVersion { get { return _majorVersion; } set { _majorVersion = value; } }
        public static int MinorVersion { get { return _minorVersion; } set { _minorVersion = value; } }
        #endregion
    }
}
