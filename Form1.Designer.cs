namespace SONAR
{
    partial class Form1
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.button1 = new System.Windows.Forms.Button();
			this.prgsCM = new System.Windows.Forms.ProgressBar();
			this.label2 = new System.Windows.Forms.Label();
			this.txtCOM = new System.Windows.Forms.TextBox();
			this.button2 = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.label1 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.instuctablesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.youtubeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.fBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(7, 177);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(219, 31);
			this.button1.TabIndex = 0;
			this.button1.Text = "READ DISTANCE";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// prgsCM
			// 
			this.prgsCM.BackColor = System.Drawing.SystemColors.ControlText;
			this.prgsCM.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.prgsCM.Location = new System.Drawing.Point(7, 253);
			this.prgsCM.Name = "prgsCM";
			this.prgsCM.Size = new System.Drawing.Size(219, 22);
			this.prgsCM.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(7, 29);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(259, 15);
			this.label2.TabIndex = 4;
			this.label2.Text = "Type in serial port that you wish to connect to";
			// 
			// txtCOM
			// 
			this.txtCOM.Location = new System.Drawing.Point(401, 25);
			this.txtCOM.Name = "txtCOM";
			this.txtCOM.Size = new System.Drawing.Size(52, 22);
			this.txtCOM.TabIndex = 5;
			this.txtCOM.Text = "COM12";
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(7, 215);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(219, 31);
			this.button2.TabIndex = 6;
			this.button2.Text = "Stop";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.Transparent;
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.txtCOM);
			this.groupBox1.Location = new System.Drawing.Point(16, 333);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(490, 55);
			this.groupBox1.TabIndex = 7;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Connect to Arduino Serial (COM)";
			// 
			// groupBox2
			// 
			this.groupBox2.BackColor = System.Drawing.Color.Transparent;
			this.groupBox2.Controls.Add(this.label1);
			this.groupBox2.Controls.Add(this.prgsCM);
			this.groupBox2.Controls.Add(this.button2);
			this.groupBox2.Controls.Add(this.button1);
			this.groupBox2.Location = new System.Drawing.Point(273, 45);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(233, 282);
			this.groupBox2.TabIndex = 8;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Distance";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("DigiGrotesk LT BoldCondensed", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(44, 54);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(151, 85);
			this.label1.TabIndex = 9;
			this.label1.Text = "000";
			this.label1.TextChanged += new System.EventHandler(this.label1_TextChanged);
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
			this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pictureBox1.Location = new System.Drawing.Point(16, 45);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(240, 282);
			this.pictureBox1.TabIndex = 9;
			this.pictureBox1.TabStop = false;
			// 
			// menuStrip1
			// 
			this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.menuStrip1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("menuStrip1.BackgroundImage")));
			this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.instuctablesToolStripMenuItem,
            this.youtubeToolStripMenuItem,
            this.fBToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(518, 24);
			this.menuStrip1.TabIndex = 10;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
			this.aboutToolStripMenuItem.Text = "About";
			this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
			// 
			// instuctablesToolStripMenuItem
			// 
			this.instuctablesToolStripMenuItem.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.instuctablesToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.instuctablesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("instuctablesToolStripMenuItem.Image")));
			this.instuctablesToolStripMenuItem.Name = "instuctablesToolStripMenuItem";
			this.instuctablesToolStripMenuItem.Size = new System.Drawing.Size(28, 20);
			this.instuctablesToolStripMenuItem.Text = "Instuctables";
			this.instuctablesToolStripMenuItem.Click += new System.EventHandler(this.instuctablesToolStripMenuItem_Click);
			// 
			// youtubeToolStripMenuItem
			// 
			this.youtubeToolStripMenuItem.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.youtubeToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.youtubeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("youtubeToolStripMenuItem.Image")));
			this.youtubeToolStripMenuItem.Name = "youtubeToolStripMenuItem";
			this.youtubeToolStripMenuItem.Size = new System.Drawing.Size(28, 20);
			this.youtubeToolStripMenuItem.Text = "Youtube";
			this.youtubeToolStripMenuItem.Click += new System.EventHandler(this.youtubeToolStripMenuItem_Click);
			// 
			// fBToolStripMenuItem
			// 
			this.fBToolStripMenuItem.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.fBToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.fBToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("fBToolStripMenuItem.Image")));
			this.fBToolStripMenuItem.Name = "fBToolStripMenuItem";
			this.fBToolStripMenuItem.Size = new System.Drawing.Size(28, 20);
			this.fBToolStripMenuItem.Text = "FB";
			this.fBToolStripMenuItem.Click += new System.EventHandler(this.fBToolStripMenuItem_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(518, 400);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.menuStrip1);
			this.Font = new System.Drawing.Font("DigiGrotesk LT BoldCondensed", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Form1";
			this.Text = "BlueCore Tech HC-SR04 Distance meter";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ProgressBar prgsCM;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCOM;
        private System.Windows.Forms.Button button2;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem instuctablesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem youtubeToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem fBToolStripMenuItem;
	}
}

