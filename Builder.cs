using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdventureBuilder.Children;

namespace AdventureBuilder
{
    public partial class FrmBuilder : Form
    {
        #region VARIABLES

        public bool _isLocationFormOpen = false;
        public bool _isObjectsFormOpen = false;
        #endregion

        #region CONSTRUCTORS
        public FrmBuilder()
        {
            InitializeComponent();
            
            treeGame.ExpandAll();
        }
        #endregion

        #region METHODS

        #endregion

        #region MAIN MENU METHODS
        // FILE MENU
        private void mnuNew_Click(object sender, EventArgs e)
        {
            FilingSystem.CreateDataFile(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"/test.tab");
        }

        // EDIT MENU

        // VIEW MENU
        private void mnuLocations_Click(object sender, EventArgs e)
        {
            if (!_isLocationFormOpen)
            {
                FrmGameLocation frmGameLocation = new FrmGameLocation();
                frmGameLocation.MdiParent = this;
                frmGameLocation.Show();
                _isLocationFormOpen = true;
            }
        }

        private void mnuObjects_Click(object sender, EventArgs e)
        {
            if (!_isObjectsFormOpen)
            {
                FrmGameObject frmGameObject = new FrmGameObject();
                frmGameObject.MdiParent = this;
                frmGameObject.Show();
                _isObjectsFormOpen = true;
            }
        }
        #endregion

        #region PROPERTIES

        #endregion

        private void FrmBuilder_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }


    }
}
