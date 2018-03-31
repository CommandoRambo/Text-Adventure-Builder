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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Start of Game", 6, 6);
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("End of Game", 6, 6);
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Properties", 6, 6, new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Locations", 2, 2);
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Objects", 3, 3);
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Characters", 4, 4);
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Verbs", 5, 5);
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Game", 0, 0, new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode5,
            treeNode6,
            treeNode7});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBuilder));
            this.StatusBar = new System.Windows.Forms.StatusStrip();
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNew = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLocations = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuObjects = new System.Windows.Forms.ToolStripMenuItem();
            this.treeGame = new System.Windows.Forms.TreeView();
            this.TreeImages = new System.Windows.Forms.ImageList(this.components);
            this.ToolBar = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.MainMenu.SuspendLayout();
            this.ToolBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // StatusBar
            // 
            this.StatusBar.Location = new System.Drawing.Point(0, 739);
            this.StatusBar.Name = "StatusBar";
            this.StatusBar.Size = new System.Drawing.Size(984, 22);
            this.StatusBar.SizingGrip = false;
            this.StatusBar.TabIndex = 0;
            this.StatusBar.Text = "statusStrip1";
            // 
            // MainMenu
            // 
            this.MainMenu.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(984, 27);
            this.MainMenu.TabIndex = 1;
            this.MainMenu.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuNew});
            this.mnuFile.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(41, 23);
            this.mnuFile.Text = "File";
            // 
            // mnuNew
            // 
            this.mnuNew.Name = "mnuNew";
            this.mnuNew.Size = new System.Drawing.Size(105, 24);
            this.mnuNew.Text = "New";
            this.mnuNew.Click += new System.EventHandler(this.mnuNew_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(44, 23);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuLocations,
            this.mnuObjects});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(50, 23);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // mnuLocations
            // 
            this.mnuLocations.Name = "mnuLocations";
            this.mnuLocations.Size = new System.Drawing.Size(176, 24);
            this.mnuLocations.Text = "Game Locations";
            this.mnuLocations.Click += new System.EventHandler(this.mnuLocations_Click);
            // 
            // mnuObjects
            // 
            this.mnuObjects.Name = "mnuObjects";
            this.mnuObjects.Size = new System.Drawing.Size(176, 24);
            this.mnuObjects.Text = "Game Objects";
            this.mnuObjects.Click += new System.EventHandler(this.mnuObjects_Click);
            // 
            // treeGame
            // 
            this.treeGame.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeGame.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.treeGame.ImageIndex = 0;
            this.treeGame.ImageList = this.TreeImages;
            this.treeGame.Location = new System.Drawing.Point(0, 58);
            this.treeGame.Name = "treeGame";
            treeNode1.ImageIndex = 6;
            treeNode1.Name = "Node1";
            treeNode1.SelectedImageIndex = 6;
            treeNode1.Text = "Start of Game";
            treeNode2.ImageIndex = 6;
            treeNode2.Name = "Node2";
            treeNode2.SelectedImageIndex = 6;
            treeNode2.Text = "End of Game";
            treeNode3.ImageIndex = 6;
            treeNode3.Name = "Node0";
            treeNode3.SelectedImageIndex = 6;
            treeNode3.Text = "Properties";
            treeNode4.ImageIndex = 2;
            treeNode4.Name = "Node1";
            treeNode4.SelectedImageIndex = 2;
            treeNode4.Text = "Locations";
            treeNode5.ImageIndex = 3;
            treeNode5.Name = "Node2";
            treeNode5.SelectedImageIndex = 3;
            treeNode5.Text = "Objects";
            treeNode6.ImageIndex = 4;
            treeNode6.Name = "Node3";
            treeNode6.SelectedImageIndex = 4;
            treeNode6.Text = "Characters";
            treeNode7.ImageIndex = 5;
            treeNode7.Name = "Node4";
            treeNode7.SelectedImageIndex = 5;
            treeNode7.Text = "Verbs";
            treeNode8.Checked = true;
            treeNode8.ImageIndex = 0;
            treeNode8.Name = "NodeGame";
            treeNode8.SelectedImageIndex = 0;
            treeNode8.Text = "Game";
            this.treeGame.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode8});
            this.treeGame.SelectedImageIndex = 1;
            this.treeGame.Size = new System.Drawing.Size(220, 681);
            this.treeGame.TabIndex = 3;
            // 
            // TreeImages
            // 
            this.TreeImages.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("TreeImages.ImageStream")));
            this.TreeImages.TransparentColor = System.Drawing.Color.Transparent;
            this.TreeImages.Images.SetKeyName(0, "folder-invoices.png");
            this.TreeImages.Images.SetKeyName(1, "opened-folder.png");
            this.TreeImages.Images.SetKeyName(2, "pin.png");
            this.TreeImages.Images.SetKeyName(3, "action.png");
            this.TreeImages.Images.SetKeyName(4, "gender-neutral-user.png");
            this.TreeImages.Images.SetKeyName(5, "book.png");
            this.TreeImages.Images.SetKeyName(6, "automatic.png");
            this.TreeImages.Images.SetKeyName(7, "actors.png");
            this.TreeImages.Images.SetKeyName(8, "actresses.png");
            this.TreeImages.Images.SetKeyName(9, "read.png");
            // 
            // ToolBar
            // 
            this.ToolBar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ToolBar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.ToolBar.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.ToolBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripSeparator1});
            this.ToolBar.Location = new System.Drawing.Point(0, 27);
            this.ToolBar.Name = "ToolBar";
            this.ToolBar.Size = new System.Drawing.Size(984, 31);
            this.ToolBar.TabIndex = 4;
            this.ToolBar.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::AdventureBuilder.Properties.Resources.pin;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(28, 28);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = global::AdventureBuilder.Properties.Resources.action;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(28, 28);
            this.toolStripButton2.Text = "toolStripButton2";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = global::AdventureBuilder.Properties.Resources.gender_neutral_user;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(28, 28);
            this.toolStripButton3.Text = "toolStripButton3";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = global::AdventureBuilder.Properties.Resources.book;
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(28, 28);
            this.toolStripButton4.Text = "toolStripButton4";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // FrmBuilder
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(984, 761);
            this.Controls.Add(this.treeGame);
            this.Controls.Add(this.StatusBar);
            this.Controls.Add(this.ToolBar);
            this.Controls.Add(this.MainMenu);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.MainMenu;
            this.MinimumSize = new System.Drawing.Size(1000, 800);
            this.Name = "FrmBuilder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Text Adventure Builder - v1.0";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmBuilder_FormClosing);
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.ToolBar.ResumeLayout(false);
            this.ToolBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip StatusBar;
        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.TreeView treeGame;
        private System.Windows.Forms.ToolStrip ToolBar;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuNew;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuLocations;
        private System.Windows.Forms.ToolStripMenuItem mnuObjects;
        private System.Windows.Forms.ImageList TreeImages;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}