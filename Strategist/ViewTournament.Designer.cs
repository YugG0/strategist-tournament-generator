namespace Strategist
{
    partial class ViewTournament
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewTournament));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ButtonCloseWindow = new System.Windows.Forms.PictureBox();
            this.Label_WindowName = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Label_Runnerup = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.ButtonCreateTournament = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.Label_Winner = new System.Windows.Forms.Label();
            this.Label_Prize = new System.Windows.Forms.Label();
            this.Label_Date = new System.Windows.Forms.Label();
            this.Label_Game = new System.Windows.Forms.Label();
            this.Label_Title = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.Panel_StageTabsUpper = new System.Windows.Forms.Panel();
            this.Panel_StageTabsDown = new System.Windows.Forms.Panel();
            this.Panel_Cells = new System.Windows.Forms.Panel();
            this.Button_EndRound = new System.Windows.Forms.Button();
            this.Label_Message = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonCloseWindow)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.Panel_Cells.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(106)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.ButtonCloseWindow);
            this.panel1.Controls.Add(this.Label_WindowName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1280, 30);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Strategist.Properties.Resources.ProgramLogo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // ButtonCloseWindow
            // 
            this.ButtonCloseWindow.BackgroundImage = global::Strategist.Properties.Resources.close;
            this.ButtonCloseWindow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonCloseWindow.Location = new System.Drawing.Point(1253, 3);
            this.ButtonCloseWindow.Name = "ButtonCloseWindow";
            this.ButtonCloseWindow.Size = new System.Drawing.Size(25, 25);
            this.ButtonCloseWindow.TabIndex = 3;
            this.ButtonCloseWindow.TabStop = false;
            this.ButtonCloseWindow.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CloseWindow);
            // 
            // Label_WindowName
            // 
            this.Label_WindowName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label_WindowName.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label_WindowName.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Label_WindowName.Location = new System.Drawing.Point(0, 0);
            this.Label_WindowName.Name = "Label_WindowName";
            this.Label_WindowName.Size = new System.Drawing.Size(1280, 30);
            this.Label_WindowName.TabIndex = 2;
            this.Label_WindowName.Text = "Tournament name";
            this.Label_WindowName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Label_WindowName.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ClickDown);
            this.Label_WindowName.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Drag);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(62)))));
            this.panel2.Controls.Add(this.Label_Runnerup);
            this.panel2.Controls.Add(this.panel11);
            this.panel2.Controls.Add(this.Label_Winner);
            this.panel2.Controls.Add(this.Label_Prize);
            this.panel2.Controls.Add(this.Label_Date);
            this.panel2.Controls.Add(this.Label_Game);
            this.panel2.Controls.Add(this.Label_Title);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(300, 760);
            this.panel2.TabIndex = 1;
            // 
            // Label_Runnerup
            // 
            this.Label_Runnerup.Dock = System.Windows.Forms.DockStyle.Top;
            this.Label_Runnerup.Font = new System.Drawing.Font("Verdana", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label_Runnerup.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Label_Runnerup.Location = new System.Drawing.Point(0, 420);
            this.Label_Runnerup.Name = "Label_Runnerup";
            this.Label_Runnerup.Size = new System.Drawing.Size(300, 40);
            this.Label_Runnerup.TabIndex = 9;
            this.Label_Runnerup.Text = "Runner-up: AfrikaEnota";
            this.Label_Runnerup.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.panel11.Controls.Add(this.ButtonCreateTournament);
            this.panel11.Controls.Add(this.label13);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.panel11.Location = new System.Drawing.Point(0, 677);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(300, 83);
            this.panel11.TabIndex = 8;
            // 
            // ButtonCreateTournament
            // 
            this.ButtonCreateTournament.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(56)))));
            this.ButtonCreateTournament.FlatAppearance.BorderSize = 0;
            this.ButtonCreateTournament.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonCreateTournament.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonCreateTournament.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ButtonCreateTournament.Location = new System.Drawing.Point(12, 43);
            this.ButtonCreateTournament.Name = "ButtonCreateTournament";
            this.ButtonCreateTournament.Size = new System.Drawing.Size(276, 30);
            this.ButtonCreateTournament.TabIndex = 8;
            this.ButtonCreateTournament.Text = "Edit tournament";
            this.ButtonCreateTournament.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonCreateTournament.UseVisualStyleBackColor = false;
            this.ButtonCreateTournament.Click += new System.EventHandler(this.OpenEditTournament);
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Dock = System.Windows.Forms.DockStyle.Top;
            this.label13.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label13.Location = new System.Drawing.Point(0, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(300, 40);
            this.label13.TabIndex = 6;
            this.label13.Text = "Admin panel";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label_Winner
            // 
            this.Label_Winner.Dock = System.Windows.Forms.DockStyle.Top;
            this.Label_Winner.Font = new System.Drawing.Font("Verdana", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label_Winner.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Label_Winner.Location = new System.Drawing.Point(0, 380);
            this.Label_Winner.Name = "Label_Winner";
            this.Label_Winner.Size = new System.Drawing.Size(300, 40);
            this.Label_Winner.TabIndex = 7;
            this.Label_Winner.Text = "Winner: YugG0";
            this.Label_Winner.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label_Prize
            // 
            this.Label_Prize.Dock = System.Windows.Forms.DockStyle.Top;
            this.Label_Prize.Font = new System.Drawing.Font("Verdana", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label_Prize.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Label_Prize.Location = new System.Drawing.Point(0, 340);
            this.Label_Prize.Name = "Label_Prize";
            this.Label_Prize.Size = new System.Drawing.Size(300, 40);
            this.Label_Prize.TabIndex = 6;
            this.Label_Prize.Text = "$10,154";
            this.Label_Prize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label_Date
            // 
            this.Label_Date.Dock = System.Windows.Forms.DockStyle.Top;
            this.Label_Date.Font = new System.Drawing.Font("Verdana", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label_Date.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Label_Date.Location = new System.Drawing.Point(0, 300);
            this.Label_Date.Name = "Label_Date";
            this.Label_Date.Size = new System.Drawing.Size(300, 40);
            this.Label_Date.TabIndex = 5;
            this.Label_Date.Text = "Apr 26 - Sep 1, 2024";
            this.Label_Date.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label_Game
            // 
            this.Label_Game.Dock = System.Windows.Forms.DockStyle.Top;
            this.Label_Game.Font = new System.Drawing.Font("Verdana", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label_Game.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Label_Game.Location = new System.Drawing.Point(0, 260);
            this.Label_Game.Name = "Label_Game";
            this.Label_Game.Size = new System.Drawing.Size(300, 40);
            this.Label_Game.TabIndex = 4;
            this.Label_Game.Text = "Company of heroes 3";
            this.Label_Game.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label_Title
            // 
            this.Label_Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.Label_Title.Font = new System.Drawing.Font("Verdana", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label_Title.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Label_Title.Location = new System.Drawing.Point(0, 200);
            this.Label_Title.Name = "Label_Title";
            this.Label_Title.Size = new System.Drawing.Size(300, 60);
            this.Label_Title.TabIndex = 3;
            this.Label_Title.Text = "Battle of world ";
            this.Label_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::Strategist.Properties.Resources.Tournament_Logo;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(300, 200);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(31)))));
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(300, 30);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(3, 760);
            this.panel6.TabIndex = 4;
            // 
            // Panel_StageTabsUpper
            // 
            this.Panel_StageTabsUpper.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(62)))));
            this.Panel_StageTabsUpper.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_StageTabsUpper.Location = new System.Drawing.Point(303, 30);
            this.Panel_StageTabsUpper.Name = "Panel_StageTabsUpper";
            this.Panel_StageTabsUpper.Size = new System.Drawing.Size(977, 35);
            this.Panel_StageTabsUpper.TabIndex = 5;
            // 
            // Panel_StageTabsDown
            // 
            this.Panel_StageTabsDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(62)))));
            this.Panel_StageTabsDown.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_StageTabsDown.Location = new System.Drawing.Point(303, 65);
            this.Panel_StageTabsDown.Name = "Panel_StageTabsDown";
            this.Panel_StageTabsDown.Size = new System.Drawing.Size(977, 26);
            this.Panel_StageTabsDown.TabIndex = 6;
            // 
            // Panel_Cells
            // 
            this.Panel_Cells.AutoScroll = true;
            this.Panel_Cells.BackColor = System.Drawing.Color.Transparent;
            this.Panel_Cells.Controls.Add(this.Button_EndRound);
            this.Panel_Cells.Controls.Add(this.Label_Message);
            this.Panel_Cells.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_Cells.Location = new System.Drawing.Point(303, 91);
            this.Panel_Cells.Name = "Panel_Cells";
            this.Panel_Cells.Size = new System.Drawing.Size(977, 699);
            this.Panel_Cells.TabIndex = 19;
            // 
            // Button_EndRound
            // 
            this.Button_EndRound.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(56)))));
            this.Button_EndRound.FlatAppearance.BorderSize = 0;
            this.Button_EndRound.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_EndRound.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_EndRound.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Button_EndRound.Location = new System.Drawing.Point(6, 15);
            this.Button_EndRound.Name = "Button_EndRound";
            this.Button_EndRound.Size = new System.Drawing.Size(87, 35);
            this.Button_EndRound.TabIndex = 20;
            this.Button_EndRound.Text = "End round";
            this.Button_EndRound.UseVisualStyleBackColor = false;
            this.Button_EndRound.Visible = false;
            this.Button_EndRound.MouseDown += new System.Windows.Forms.MouseEventHandler(this.EndRound);
            // 
            // Label_Message
            // 
            this.Label_Message.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label_Message.ForeColor = System.Drawing.Color.IndianRed;
            this.Label_Message.Location = new System.Drawing.Point(6, 15);
            this.Label_Message.Name = "Label_Message";
            this.Label_Message.Size = new System.Drawing.Size(960, 35);
            this.Label_Message.TabIndex = 21;
            this.Label_Message.Text = "-";
            this.Label_Message.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ViewTournament
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(1280, 790);
            this.Controls.Add(this.Panel_Cells);
            this.Controls.Add(this.Panel_StageTabsDown);
            this.Controls.Add(this.Panel_StageTabsUpper);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ViewTournament";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tournament";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonCloseWindow)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.Panel_Cells.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox ButtonCloseWindow;
        private System.Windows.Forms.Label Label_WindowName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Label_Date;
        private System.Windows.Forms.Label Label_Game;
        private System.Windows.Forms.Label Label_Title;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label Label_Winner;
        private System.Windows.Forms.Label Label_Prize;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Button ButtonCreateTournament;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel Panel_StageTabsUpper;
        private System.Windows.Forms.Panel Panel_StageTabsDown;
        private System.Windows.Forms.Panel Panel_Cells;
        private System.Windows.Forms.Button Button_EndRound;
        private System.Windows.Forms.Label Label_Message;
        private System.Windows.Forms.Label Label_Runnerup;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}