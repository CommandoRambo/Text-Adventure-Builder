namespace AdventureBuilder
{
    partial class FrmBuilder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.StatusBar = new System.Windows.Forms.StatusStrip();
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.treeGame = new System.Windows.Forms.TreeView();
            this.MenuBar = new System.Windows.Forms.ToolStrip();
            this.SuspendLayout();
            // 
            // StatusBar
            // 
            this.StatusBar.Location = new System.Drawing.Point(0, 539);
            this.StatusBar.Name = "StatusBar";
            this.StatusBar.Size = new System.Drawing.Size(784, 22);
            this.StatusBar.SizingGrip = false;
            this.StatusBar.TabIndex = 0;
            this.StatusBar.Text = "statusStrip1";
            // 
            // MainMenu
            // 
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(784, 24);
            this.MainMenu.TabIndex = 1;
            this.MainMenu.Text = "menuStrip1";
            // 
            // treeGame
            // 
            this.treeGame.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeGame.Location = new System.Drawing.Point(0, 49);
            this.treeGame.Name = "treeGame";
            this.treeGame.Size = new System.Drawing.Size(200, 490);
            this.treeGame.TabIndex = 3;
            // 
            // MenuBar
            // 
            this.MenuBar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.MenuBar.Location = new System.Drawing.Point(0, 24);
            this.MenuBar.Name = "MenuBar";
            this.MenuBar.Size = new System.Drawing.Size(784, 25);
            this.MenuBar.TabIndex = 4;
            this.MenuBar.Text = "toolStrip1";
            // 
            // FrmBuilder
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.treeGame);
            this.Controls.Add(this.StatusBar);
            this.Controls.Add(this.MenuBar);
            this.Controls.Add(this.MainMenu);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.MainMenu;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "FrmBuilder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Builder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip StatusBar;
        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.TreeView treeGame;
        private System.Windows.Forms.ToolStrip MenuBar;
    }
}