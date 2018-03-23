namespace AdventureBuilder
{
    partial class FrmMain
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.butManual = new System.Windows.Forms.Button();
            this.butOpen = new System.Windows.Forms.Button();
            this.butCreate = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.butUpdates = new System.Windows.Forms.Button();
            this.OpenFile = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(122)))), ((int)(((byte)(157)))));
            this.panel1.Controls.Add(this.butUpdates);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 296);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(584, 65);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(0, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(584, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Text Adventure Builder 1.0";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(584, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "JRV Solutions 2018";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.butManual);
            this.panel2.Controls.Add(this.butOpen);
            this.panel2.Controls.Add(this.butCreate);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(292, 296);
            this.panel2.TabIndex = 1;
            // 
            // butManual
            // 
            this.butManual.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.butManual.Location = new System.Drawing.Point(20, 204);
            this.butManual.Name = "butManual";
            this.butManual.Size = new System.Drawing.Size(252, 64);
            this.butManual.TabIndex = 2;
            this.butManual.Text = "Read the manual";
            this.butManual.UseVisualStyleBackColor = true;
            this.butManual.Click += new System.EventHandler(this.butManual_Click);
            // 
            // butOpen
            // 
            this.butOpen.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.butOpen.Location = new System.Drawing.Point(20, 116);
            this.butOpen.Name = "butOpen";
            this.butOpen.Size = new System.Drawing.Size(252, 64);
            this.butOpen.TabIndex = 1;
            this.butOpen.Text = "Open an existing game";
            this.butOpen.UseVisualStyleBackColor = true;
            this.butOpen.Click += new System.EventHandler(this.butOpen_Click);
            // 
            // butCreate
            // 
            this.butCreate.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.butCreate.Location = new System.Drawing.Point(20, 28);
            this.butCreate.Name = "butCreate";
            this.butCreate.Size = new System.Drawing.Size(252, 64);
            this.butCreate.TabIndex = 0;
            this.butCreate.Text = "Create a new game";
            this.butCreate.UseVisualStyleBackColor = true;
            this.butCreate.Click += new System.EventHandler(this.butCreate_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.listView1);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(292, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(292, 296);
            this.panel3.TabIndex = 2;
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.White;
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.listView1.Location = new System.Drawing.Point(24, 36);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(256, 248);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Recent";
            // 
            // butUpdates
            // 
            this.butUpdates.FlatAppearance.BorderSize = 0;
            this.butUpdates.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butUpdates.Location = new System.Drawing.Point(244, 40);
            this.butUpdates.Name = "butUpdates";
            this.butUpdates.Size = new System.Drawing.Size(100, 23);
            this.butUpdates.TabIndex = 2;
            this.butUpdates.Text = "No Updates";
            this.butUpdates.UseVisualStyleBackColor = true;
            // 
            // OpenFile
            // 
            this.OpenFile.FileName = "openFileDialog1";
            // 
            // FrmMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(600, 400);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Text Adventure Builder";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button butManual;
        private System.Windows.Forms.Button butOpen;
        private System.Windows.Forms.Button butCreate;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button butUpdates;
        private System.Windows.Forms.OpenFileDialog OpenFile;
    }
}

