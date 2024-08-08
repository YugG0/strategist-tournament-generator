namespace Strategist
{
    partial class Other
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Other));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.PictureBox_Close = new System.Windows.Forms.PictureBox();
            this.Label_Window = new System.Windows.Forms.Label();
            this.Button_ClearPlayerDatabase = new System.Windows.Forms.Button();
            this.Button_ClearTournamentDatabase = new System.Windows.Forms.Button();
            this.PictureBox_CheckPlayer = new System.Windows.Forms.PictureBox();
            this.PictureBox_CheckTournament = new System.Windows.Forms.PictureBox();
            this.Button_Accept = new System.Windows.Forms.Button();
            this.Label_Warnings = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_CheckPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_CheckTournament)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(106)))));
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.PictureBox_Close);
            this.panel1.Controls.Add(this.Label_Window);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 30);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::Strategist.Properties.Resources.ProgramLogo;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(3, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 25);
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // PictureBox_Close
            // 
            this.PictureBox_Close.BackgroundImage = global::Strategist.Properties.Resources.close;
            this.PictureBox_Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PictureBox_Close.Location = new System.Drawing.Point(272, 3);
            this.PictureBox_Close.Name = "PictureBox_Close";
            this.PictureBox_Close.Size = new System.Drawing.Size(25, 25);
            this.PictureBox_Close.TabIndex = 2;
            this.PictureBox_Close.TabStop = false;
            this.PictureBox_Close.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CloseWindow);
            // 
            // Label_Window
            // 
            this.Label_Window.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label_Window.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label_Window.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Label_Window.Location = new System.Drawing.Point(0, 0);
            this.Label_Window.Name = "Label_Window";
            this.Label_Window.Size = new System.Drawing.Size(300, 30);
            this.Label_Window.TabIndex = 1;
            this.Label_Window.Text = "Other";
            this.Label_Window.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Label_Window.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ClickDown);
            this.Label_Window.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Drag);
            // 
            // Button_ClearPlayerDatabase
            // 
            this.Button_ClearPlayerDatabase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(62)))));
            this.Button_ClearPlayerDatabase.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Button_ClearPlayerDatabase.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_ClearPlayerDatabase.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Button_ClearPlayerDatabase.Location = new System.Drawing.Point(12, 81);
            this.Button_ClearPlayerDatabase.Name = "Button_ClearPlayerDatabase";
            this.Button_ClearPlayerDatabase.Size = new System.Drawing.Size(240, 30);
            this.Button_ClearPlayerDatabase.TabIndex = 5;
            this.Button_ClearPlayerDatabase.Text = "Clear Player Database";
            this.Button_ClearPlayerDatabase.UseVisualStyleBackColor = false;
            this.Button_ClearPlayerDatabase.Click += new System.EventHandler(this.ClearPlayersClick);
            // 
            // Button_ClearTournamentDatabase
            // 
            this.Button_ClearTournamentDatabase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(62)))));
            this.Button_ClearTournamentDatabase.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Button_ClearTournamentDatabase.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_ClearTournamentDatabase.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Button_ClearTournamentDatabase.Location = new System.Drawing.Point(12, 45);
            this.Button_ClearTournamentDatabase.Name = "Button_ClearTournamentDatabase";
            this.Button_ClearTournamentDatabase.Size = new System.Drawing.Size(240, 30);
            this.Button_ClearTournamentDatabase.TabIndex = 6;
            this.Button_ClearTournamentDatabase.Text = "Clear Tournament Database";
            this.Button_ClearTournamentDatabase.UseVisualStyleBackColor = false;
            this.Button_ClearTournamentDatabase.Click += new System.EventHandler(this.ClearTournamentsClick);
            // 
            // PictureBox_CheckPlayer
            // 
            this.PictureBox_CheckPlayer.BackgroundImage = global::Strategist.Properties.Resources.NoCheck_icon;
            this.PictureBox_CheckPlayer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PictureBox_CheckPlayer.Location = new System.Drawing.Point(258, 81);
            this.PictureBox_CheckPlayer.Name = "PictureBox_CheckPlayer";
            this.PictureBox_CheckPlayer.Size = new System.Drawing.Size(30, 30);
            this.PictureBox_CheckPlayer.TabIndex = 8;
            this.PictureBox_CheckPlayer.TabStop = false;
            // 
            // PictureBox_CheckTournament
            // 
            this.PictureBox_CheckTournament.BackgroundImage = global::Strategist.Properties.Resources.NoCheck_icon;
            this.PictureBox_CheckTournament.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PictureBox_CheckTournament.Location = new System.Drawing.Point(258, 45);
            this.PictureBox_CheckTournament.Name = "PictureBox_CheckTournament";
            this.PictureBox_CheckTournament.Size = new System.Drawing.Size(30, 30);
            this.PictureBox_CheckTournament.TabIndex = 7;
            this.PictureBox_CheckTournament.TabStop = false;
            // 
            // Button_Accept
            // 
            this.Button_Accept.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(62)))));
            this.Button_Accept.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Button_Accept.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_Accept.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Button_Accept.Location = new System.Drawing.Point(39, 358);
            this.Button_Accept.Name = "Button_Accept";
            this.Button_Accept.Size = new System.Drawing.Size(226, 30);
            this.Button_Accept.TabIndex = 9;
            this.Button_Accept.Text = "Accept";
            this.Button_Accept.UseVisualStyleBackColor = false;
            this.Button_Accept.Click += new System.EventHandler(this.AcceptClear);
            // 
            // Label_Warnings
            // 
            this.Label_Warnings.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label_Warnings.ForeColor = System.Drawing.Color.IndianRed;
            this.Label_Warnings.Location = new System.Drawing.Point(12, 203);
            this.Label_Warnings.Name = "Label_Warnings";
            this.Label_Warnings.Size = new System.Drawing.Size(276, 152);
            this.Label_Warnings.TabIndex = 10;
            this.Label_Warnings.Text = "If you clear the database, you will lose the data forever.";
            this.Label_Warnings.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Label_Warnings.Visible = false;
            // 
            // Other
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(300, 400);
            this.Controls.Add(this.Label_Warnings);
            this.Controls.Add(this.Button_Accept);
            this.Controls.Add(this.PictureBox_CheckPlayer);
            this.Controls.Add(this.PictureBox_CheckTournament);
            this.Controls.Add(this.Button_ClearTournamentDatabase);
            this.Controls.Add(this.Button_ClearPlayerDatabase);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Other";
            this.Text = "Other";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_CheckPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_CheckTournament)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox PictureBox_Close;
        private System.Windows.Forms.Label Label_Window;
        private System.Windows.Forms.Button Button_ClearPlayerDatabase;
        private System.Windows.Forms.Button Button_ClearTournamentDatabase;
        private System.Windows.Forms.PictureBox PictureBox_CheckTournament;
        private System.Windows.Forms.PictureBox PictureBox_CheckPlayer;
        private System.Windows.Forms.Button Button_Accept;
        private System.Windows.Forms.Label Label_Warnings;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}