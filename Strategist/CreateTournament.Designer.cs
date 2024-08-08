namespace Strategist
{
    partial class CreateTournament
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateTournament));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.ButtonCloseWindow = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Label_Message = new System.Windows.Forms.Label();
            this.ButtonCreate = new System.Windows.Forms.Button();
            this.Label_BOPlayoffFinal = new System.Windows.Forms.Label();
            this.TextBox_BOPlayoffFinal = new System.Windows.Forms.TextBox();
            this.Label_BOPlayoff = new System.Windows.Forms.Label();
            this.TextBox_BOPlayoff = new System.Windows.Forms.TextBox();
            this.Label_BOGroupStage = new System.Windows.Forms.Label();
            this.TextBox_BOGroupStage = new System.Windows.Forms.TextBox();
            this.Label_Prize = new System.Windows.Forms.Label();
            this.TextBox_Prize = new System.Windows.Forms.TextBox();
            this.Label_Date = new System.Windows.Forms.Label();
            this.TextBox_Date = new System.Windows.Forms.TextBox();
            this.Label_Game = new System.Windows.Forms.Label();
            this.TextBox_Game = new System.Windows.Forms.TextBox();
            this.Label_Name = new System.Windows.Forms.Label();
            this.TextBox_Name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Label_CountParticipants = new System.Windows.Forms.Label();
            this.Panel_Participants = new System.Windows.Forms.Panel();
            this.Panel_NoParticipants = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonCloseWindow)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1280, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Create tournament";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ClickDown);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Drag);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(106)))));
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.ButtonCloseWindow);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1280, 30);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::Strategist.Properties.Resources.ProgramLogo;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(3, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 25);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // ButtonCloseWindow
            // 
            this.ButtonCloseWindow.BackgroundImage = global::Strategist.Properties.Resources.close;
            this.ButtonCloseWindow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonCloseWindow.Location = new System.Drawing.Point(1253, 3);
            this.ButtonCloseWindow.Name = "ButtonCloseWindow";
            this.ButtonCloseWindow.Size = new System.Drawing.Size(25, 25);
            this.ButtonCloseWindow.TabIndex = 1;
            this.ButtonCloseWindow.TabStop = false;
            this.ButtonCloseWindow.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CloseWindow);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(62)))));
            this.panel3.Controls.Add(this.Label_Message);
            this.panel3.Controls.Add(this.ButtonCreate);
            this.panel3.Controls.Add(this.Label_BOPlayoffFinal);
            this.panel3.Controls.Add(this.TextBox_BOPlayoffFinal);
            this.panel3.Controls.Add(this.Label_BOPlayoff);
            this.panel3.Controls.Add(this.TextBox_BOPlayoff);
            this.panel3.Controls.Add(this.Label_BOGroupStage);
            this.panel3.Controls.Add(this.TextBox_BOGroupStage);
            this.panel3.Controls.Add(this.Label_Prize);
            this.panel3.Controls.Add(this.TextBox_Prize);
            this.panel3.Controls.Add(this.Label_Date);
            this.panel3.Controls.Add(this.TextBox_Date);
            this.panel3.Controls.Add(this.Label_Game);
            this.panel3.Controls.Add(this.TextBox_Game);
            this.panel3.Controls.Add(this.Label_Name);
            this.panel3.Controls.Add(this.TextBox_Name);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 30);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(638, 690);
            this.panel3.TabIndex = 3;
            // 
            // Label_Message
            // 
            this.Label_Message.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label_Message.ForeColor = System.Drawing.Color.IndianRed;
            this.Label_Message.Location = new System.Drawing.Point(248, 618);
            this.Label_Message.Name = "Label_Message";
            this.Label_Message.Size = new System.Drawing.Size(387, 60);
            this.Label_Message.TabIndex = 22;
            this.Label_Message.Text = "Error message";
            this.Label_Message.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Label_Message.Visible = false;
            // 
            // ButtonCreate
            // 
            this.ButtonCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(62)))));
            this.ButtonCreate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonCreate.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonCreate.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ButtonCreate.Location = new System.Drawing.Point(16, 618);
            this.ButtonCreate.Name = "ButtonCreate";
            this.ButtonCreate.Size = new System.Drawing.Size(226, 60);
            this.ButtonCreate.TabIndex = 16;
            this.ButtonCreate.Text = "Create tournament";
            this.ButtonCreate.UseVisualStyleBackColor = false;
            this.ButtonCreate.Click += new System.EventHandler(this.CreateTournamentButton);
            // 
            // Label_BOPlayoffFinal
            // 
            this.Label_BOPlayoffFinal.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label_BOPlayoffFinal.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Label_BOPlayoffFinal.Location = new System.Drawing.Point(12, 269);
            this.Label_BOPlayoffFinal.Name = "Label_BOPlayoffFinal";
            this.Label_BOPlayoffFinal.Size = new System.Drawing.Size(415, 24);
            this.Label_BOPlayoffFinal.TabIndex = 15;
            this.Label_BOPlayoffFinal.Text = "Best for the playoff final (min: 1, max 5)";
            this.Label_BOPlayoffFinal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TextBox_BOPlayoffFinal
            // 
            this.TextBox_BOPlayoffFinal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(17)))), ((int)(((byte)(22)))));
            this.TextBox_BOPlayoffFinal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBox_BOPlayoffFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBox_BOPlayoffFinal.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.TextBox_BOPlayoffFinal.Location = new System.Drawing.Point(433, 269);
            this.TextBox_BOPlayoffFinal.Name = "TextBox_BOPlayoffFinal";
            this.TextBox_BOPlayoffFinal.Size = new System.Drawing.Size(187, 24);
            this.TextBox_BOPlayoffFinal.TabIndex = 6;
            this.TextBox_BOPlayoffFinal.Text = "1";
            this.TextBox_BOPlayoffFinal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextBox_BOPlayoffFinal.TextChanged += new System.EventHandler(this.CheckBOChange);
            // 
            // Label_BOPlayoff
            // 
            this.Label_BOPlayoff.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label_BOPlayoff.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Label_BOPlayoff.Location = new System.Drawing.Point(12, 239);
            this.Label_BOPlayoff.Name = "Label_BOPlayoff";
            this.Label_BOPlayoff.Size = new System.Drawing.Size(415, 24);
            this.Label_BOPlayoff.TabIndex = 13;
            this.Label_BOPlayoff.Text = "Best of the playoffs (min: 1, max 5)";
            this.Label_BOPlayoff.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TextBox_BOPlayoff
            // 
            this.TextBox_BOPlayoff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(17)))), ((int)(((byte)(22)))));
            this.TextBox_BOPlayoff.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBox_BOPlayoff.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBox_BOPlayoff.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.TextBox_BOPlayoff.Location = new System.Drawing.Point(433, 239);
            this.TextBox_BOPlayoff.Name = "TextBox_BOPlayoff";
            this.TextBox_BOPlayoff.Size = new System.Drawing.Size(187, 24);
            this.TextBox_BOPlayoff.TabIndex = 5;
            this.TextBox_BOPlayoff.Text = "1";
            this.TextBox_BOPlayoff.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextBox_BOPlayoff.TextChanged += new System.EventHandler(this.CheckBOChange);
            // 
            // Label_BOGroupStage
            // 
            this.Label_BOGroupStage.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label_BOGroupStage.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Label_BOGroupStage.Location = new System.Drawing.Point(12, 209);
            this.Label_BOGroupStage.Name = "Label_BOGroupStage";
            this.Label_BOGroupStage.Size = new System.Drawing.Size(415, 24);
            this.Label_BOGroupStage.TabIndex = 11;
            this.Label_BOGroupStage.Text = "Best of the group stage (min: 1, max 5)";
            this.Label_BOGroupStage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TextBox_BOGroupStage
            // 
            this.TextBox_BOGroupStage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(17)))), ((int)(((byte)(22)))));
            this.TextBox_BOGroupStage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBox_BOGroupStage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBox_BOGroupStage.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.TextBox_BOGroupStage.Location = new System.Drawing.Point(433, 209);
            this.TextBox_BOGroupStage.Name = "TextBox_BOGroupStage";
            this.TextBox_BOGroupStage.Size = new System.Drawing.Size(187, 24);
            this.TextBox_BOGroupStage.TabIndex = 4;
            this.TextBox_BOGroupStage.Text = "1";
            this.TextBox_BOGroupStage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextBox_BOGroupStage.TextChanged += new System.EventHandler(this.CheckBOChange);
            // 
            // Label_Prize
            // 
            this.Label_Prize.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label_Prize.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Label_Prize.Location = new System.Drawing.Point(5, 153);
            this.Label_Prize.Name = "Label_Prize";
            this.Label_Prize.Size = new System.Drawing.Size(210, 24);
            this.Label_Prize.TabIndex = 9;
            this.Label_Prize.Text = "Prize money";
            this.Label_Prize.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TextBox_Prize
            // 
            this.TextBox_Prize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(17)))), ((int)(((byte)(22)))));
            this.TextBox_Prize.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBox_Prize.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBox_Prize.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.TextBox_Prize.Location = new System.Drawing.Point(221, 153);
            this.TextBox_Prize.Name = "TextBox_Prize";
            this.TextBox_Prize.Size = new System.Drawing.Size(399, 24);
            this.TextBox_Prize.TabIndex = 3;
            this.TextBox_Prize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Label_Date
            // 
            this.Label_Date.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label_Date.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Label_Date.Location = new System.Drawing.Point(5, 123);
            this.Label_Date.Name = "Label_Date";
            this.Label_Date.Size = new System.Drawing.Size(210, 24);
            this.Label_Date.TabIndex = 7;
            this.Label_Date.Text = "Date";
            this.Label_Date.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TextBox_Date
            // 
            this.TextBox_Date.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(17)))), ((int)(((byte)(22)))));
            this.TextBox_Date.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBox_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBox_Date.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.TextBox_Date.Location = new System.Drawing.Point(221, 123);
            this.TextBox_Date.Name = "TextBox_Date";
            this.TextBox_Date.Size = new System.Drawing.Size(399, 24);
            this.TextBox_Date.TabIndex = 2;
            this.TextBox_Date.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Label_Game
            // 
            this.Label_Game.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label_Game.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Label_Game.Location = new System.Drawing.Point(5, 63);
            this.Label_Game.Name = "Label_Game";
            this.Label_Game.Size = new System.Drawing.Size(210, 24);
            this.Label_Game.TabIndex = 5;
            this.Label_Game.Text = "Name of the game";
            this.Label_Game.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TextBox_Game
            // 
            this.TextBox_Game.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(17)))), ((int)(((byte)(22)))));
            this.TextBox_Game.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBox_Game.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBox_Game.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.TextBox_Game.Location = new System.Drawing.Point(221, 63);
            this.TextBox_Game.Name = "TextBox_Game";
            this.TextBox_Game.Size = new System.Drawing.Size(399, 24);
            this.TextBox_Game.TabIndex = 0;
            this.TextBox_Game.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Label_Name
            // 
            this.Label_Name.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label_Name.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Label_Name.Location = new System.Drawing.Point(5, 93);
            this.Label_Name.Name = "Label_Name";
            this.Label_Name.Size = new System.Drawing.Size(210, 24);
            this.Label_Name.TabIndex = 3;
            this.Label_Name.Text = "Tournament name";
            this.Label_Name.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TextBox_Name
            // 
            this.TextBox_Name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(17)))), ((int)(((byte)(22)))));
            this.TextBox_Name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBox_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBox_Name.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.TextBox_Name.Location = new System.Drawing.Point(221, 93);
            this.TextBox_Name.Name = "TextBox_Name";
            this.TextBox_Name.Size = new System.Drawing.Size(399, 24);
            this.TextBox_Name.TabIndex = 1;
            this.TextBox_Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(638, 60);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tournament settings";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(62)))));
            this.panel2.Controls.Add(this.Label_CountParticipants);
            this.panel2.Controls.Add(this.Panel_Participants);
            this.panel2.Controls.Add(this.Panel_NoParticipants);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(642, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(638, 690);
            this.panel2.TabIndex = 4;
            // 
            // Label_CountParticipants
            // 
            this.Label_CountParticipants.Dock = System.Windows.Forms.DockStyle.Top;
            this.Label_CountParticipants.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label_CountParticipants.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Label_CountParticipants.Location = new System.Drawing.Point(0, 30);
            this.Label_CountParticipants.Name = "Label_CountParticipants";
            this.Label_CountParticipants.Size = new System.Drawing.Size(638, 30);
            this.Label_CountParticipants.TabIndex = 5;
            this.Label_CountParticipants.Text = "(48/0)";
            this.Label_CountParticipants.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Panel_Participants
            // 
            this.Panel_Participants.AutoScroll = true;
            this.Panel_Participants.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(17)))), ((int)(((byte)(22)))));
            this.Panel_Participants.Location = new System.Drawing.Point(325, 56);
            this.Panel_Participants.Name = "Panel_Participants";
            this.Panel_Participants.Size = new System.Drawing.Size(299, 580);
            this.Panel_Participants.TabIndex = 4;
            // 
            // Panel_NoParticipants
            // 
            this.Panel_NoParticipants.AutoScroll = true;
            this.Panel_NoParticipants.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(17)))), ((int)(((byte)(22)))));
            this.Panel_NoParticipants.Location = new System.Drawing.Point(15, 56);
            this.Panel_NoParticipants.Name = "Panel_NoParticipants";
            this.Panel_NoParticipants.Size = new System.Drawing.Size(299, 580);
            this.Panel_NoParticipants.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(638, 30);
            this.label3.TabIndex = 2;
            this.label3.Text = "Participants";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CreateTournament
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CreateTournament";
            this.Text = "CreateTournament";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonCloseWindow)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ButtonCloseWindow;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TextBox_Name;
        private System.Windows.Forms.Label Label_Name;
        private System.Windows.Forms.Label Label_Game;
        private System.Windows.Forms.TextBox TextBox_Game;
        private System.Windows.Forms.Label Label_Prize;
        private System.Windows.Forms.TextBox TextBox_Prize;
        private System.Windows.Forms.Label Label_Date;
        private System.Windows.Forms.TextBox TextBox_Date;
        private System.Windows.Forms.Label Label_BOPlayoffFinal;
        private System.Windows.Forms.TextBox TextBox_BOPlayoffFinal;
        private System.Windows.Forms.Label Label_BOPlayoff;
        private System.Windows.Forms.TextBox TextBox_BOPlayoff;
        private System.Windows.Forms.Label Label_BOGroupStage;
        private System.Windows.Forms.TextBox TextBox_BOGroupStage;
        private System.Windows.Forms.Panel Panel_NoParticipants;
        private System.Windows.Forms.Panel Panel_Participants;
        private System.Windows.Forms.Button ButtonCreate;
        private System.Windows.Forms.Label Label_Message;
        private System.Windows.Forms.Label Label_CountParticipants;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}