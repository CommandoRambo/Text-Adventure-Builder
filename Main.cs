using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdventureBuilder
{
    public partial class FrmMain : Form
    {
        #region VARIABLES

        #endregion

        #region CONSTRUCTORS
        public FrmMain()
        {
            InitializeComponent();

            if (butUpdates.Text == "No Updates")
            {
                butUpdates.Visible = false;
            }
        }
        #endregion

        #region METHODS
        private void butCreate_Click(object sender, EventArgs e)
        {
            FrmBuilder builder = new FrmBuilder();
            builder.Show();
            builder.Focus();
            this.Hide();
        }

        private void butOpen_Click(object sender, EventArgs e)
        {
            OpenFile.Title = "Select Adventure to edit.";
            OpenFile.FileName = "";
            OpenFile.DefaultExt = "*.tab";
            OpenFile.Filter = "Adventure Files | *.tab";
            OpenFile.ShowDialog();
        }

        private void butManual_Click(object sender, EventArgs e)
        {
            Process.Start(Application.StartupPath + "/Manual.html");
        }
        #endregion

        #region PROPERTIES

        #endregion


    }
}
