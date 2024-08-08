namespace Strategist
{
    partial class EditTournament
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditTournament));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.ButtonCloseWindow = new System.Windows.Forms.PictureBox();
            this.Label_WindowName = new System.Windows.Forms.Label();
            this.Label_Prize = new System.Windows.Forms.Label();
            this.TextBox_Prize = new System.Windows.Forms.TextBox();
            this.Label_Date = new System.Windows.Forms.Label();
            this.TextBox_Date = new System.Windows.Forms.TextBox();
            this.Label_Game = new System.Windows.Forms.Label();
            this.TextBox_Game = new System.Windows.Forms.TextBox();
            this.Label_Name = new System.Windows.Forms.Label();
            this.TextBox_Name = new System.Windows.Forms.TextBox();
            this.ButtonCreate = new System.Windows.Forms.Button();
            this.Label_Message = new System.Windows.Forms.Label();
            this.Button_YesDelete = new System.Windows.Forms.Button();
            this.Button_NoDelete = new System.Windows.Forms.Button();
            this.Button_Delete = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonCloseWindow)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(106)))));
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.ButtonCloseWindow);
            this.panel1.Controls.Add(this.Label_WindowName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(630, 30);
            this.panel1.TabIndex = 2;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::Strategist.Properties.Resources.ProgramLogo;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(3, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 25);
            this.pictureBox2.TabIndex = 27;
            this.pictureBox2.TabStop = false;
            // 
            // ButtonCloseWindow
            // 
            this.ButtonCloseWindow.BackgroundImage = global::Strategist.Properties.Resources.close;
            this.ButtonCloseWindow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonCloseWindow.Location = new System.Drawing.Point(602, 3);
            this.ButtonCloseWindow.Name = "ButtonCloseWindow";
            this.ButtonCloseWindow.Size = new System.Drawing.Size(25, 25);
            this.ButtonCloseWindow.TabIndex = 1;
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
            this.Label_WindowName.Size = new System.Drawing.Size(630, 30);
            this.Label_WindowName.TabIndex = 0;
            this.Label_WindowName.Text = "EDIT: Tournament name";
            this.Label_WindowName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Label_WindowName.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ClickDown);
            this.Label_WindowName.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Drag);
            // 
            // Label_Prize
            // 
            this.Label_Prize.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label_Prize.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Label_Prize.Location = new System.Drawing.Point(3, 126);
            this.Label_Prize.Name = "Label_Prize";
            this.Label_Prize.Size = new System.Drawing.Size(210, 24);
            this.Label_Prize.TabIndex = 17;
            this.Label_Prize.Text = "Prize money";
            this.Label_Prize.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TextBox_Prize
            // 
            this.TextBox_Prize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(17)))), ((int)(((byte)(22)))));
            this.TextBox_Prize.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBox_Prize.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBox_Prize.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.TextBox_Prize.Location = new System.Drawing.Point(219, 126);
            this.TextBox_Prize.Name = "TextBox_Prize";
            this.TextBox_Prize.Size = new System.Drawing.Size(400, 24);
            this.TextBox_Prize.TabIndex = 13;
            this.TextBox_Prize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Label_Date
            // 
            this.Label_Date.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label_Date.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Label_Date.Location = new System.Drawing.Point(3, 96);
            this.Label_Date.Name = "Label_Date";
            this.Label_Date.Size = new System.Drawing.Size(210, 24);
            this.Label_Date.TabIndex = 16;
            this.Label_Date.Text = "Date";
            this.Label_Date.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TextBox_Date
            // 
            this.TextBox_Date.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(17)))), ((int)(((byte)(22)))));
            this.TextBox_Date.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBox_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBox_Date.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.TextBox_Date.Location = new System.Drawing.Point(219, 96);
            this.TextBox_Date.Name = "TextBox_Date";
            this.TextBox_Date.Size = new System.Drawing.Size(400, 24);
            this.TextBox_Date.TabIndex = 12;
            this.TextBox_Date.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Label_Game
            // 
            this.Label_Game.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label_Game.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Label_Game.Location = new System.Drawing.Point(3, 36);
            this.Label_Game.Name = "Label_Game";
            this.Label_Game.Size = new System.Drawing.Size(210, 24);
            this.Label_Game.TabIndex = 15;
            this.Label_Game.Text = "Name of the game";
            this.Label_Game.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TextBox_Game
            // 
            this.TextBox_Game.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(17)))), ((int)(((byte)(22)))));
            this.TextBox_Game.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBox_Game.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBox_Game.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.TextBox_Game.Location = new System.Drawing.Point(219, 36);
            this.TextBox_Game.Name = "TextBox_Game";
            this.TextBox_Game.Size = new System.Drawing.Size(400, 24);
            this.TextBox_Game.TabIndex = 10;
            this.TextBox_Game.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Label_Name
            // 
            this.Label_Name.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label_Name.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Label_Name.Location = new System.Drawing.Point(3, 66);
            this.Label_Name.Name = "Label_Name";
            this.Label_Name.Size = new System.Drawing.Size(210, 24);
            this.Label_Name.TabIndex = 14;
            this.Label_Name.Text = "Tournament name";
            this.Label_Name.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TextBox_Name
            // 
            this.TextBox_Name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(17)))), ((int)(((byte)(22)))));
            this.TextBox_Name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBox_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBox_Name.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.TextBox_Name.Location = new System.Drawing.Point(219, 66);
            this.TextBox_Name.Name = "TextBox_Name";
            this.TextBox_Name.Size = new System.Drawing.Size(400, 24);
            this.TextBox_Name.TabIndex = 11;
            this.TextBox_Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ButtonCreate
            // 
            this.ButtonCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(62)))));
            this.ButtonCreate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonCreate.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonCreate.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ButtonCreate.Location = new System.Drawing.Point(12, 218);
            this.ButtonCreate.Name = "ButtonCreate";
            this.ButtonCreate.Size = new System.Drawing.Size(226, 60);
            this.ButtonCreate.TabIndex = 18;
            this.ButtonCreate.Text = "Edit tournament";
            this.ButtonCreate.UseVisualStyleBackColor = false;
            this.ButtonCreate.Click += new System.EventHandler(this.AcceptEdit);
            // 
            // Label_Message
            // 
            this.Label_Message.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label_Message.ForeColor = System.Drawing.Color.IndianRed;
            this.Label_Message.Location = new System.Drawing.Point(244, 182);
            this.Label_Message.Name = "Label_Message";
            this.Label_Message.Size = new System.Drawing.Size(374, 96);
            this.Label_Message.TabIndex = 23;
            this.Label_Message.Text = "Error message";
            this.Label_Message.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Label_Message.Visible = false;
            // 
            // Button_YesDelete
            // 
            this.Button_YesDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(62)))));
            this.Button_YesDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Button_YesDelete.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_YesDelete.ForeColor = System.Drawing.Color.IndianRed;
            this.Button_YesDelete.Location = new System.Drawing.Point(186, 182);
            this.Button_YesDelete.Name = "Button_YesDelete";
            this.Button_YesDelete.Size = new System.Drawing.Size(52, 30);
            this.Button_YesDelete.TabIndex = 26;
            this.Button_YesDelete.Text = "Yes";
            this.Button_YesDelete.UseVisualStyleBackColor = false;
            this.Button_YesDelete.Visible = false;
            this.Button_YesDelete.Click += new System.EventHandler(this.YesDeleteButton);
            // 
            // Button_NoDelete
            // 
            this.Button_NoDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(62)))));
            this.Button_NoDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Button_NoDelete.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_NoDelete.ForeColor = System.Drawing.Color.LightGreen;
            this.Button_NoDelete.Location = new System.Drawing.Point(128, 182);
            this.Button_NoDelete.Name = "Button_NoDelete";
            this.Button_NoDelete.Size = new System.Drawing.Size(52, 30);
            this.Button_NoDelete.TabIndex = 25;
            this.Button_NoDelete.Text = "No";
            this.Button_NoDelete.UseVisualStyleBackColor = false;
            this.Button_NoDelete.Visible = false;
            this.Button_NoDelete.Click += new System.EventHandler(this.NoDeleteButton);
            // 
            // Button_Delete
            // 
            this.Button_Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(62)))));
            this.Button_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Button_Delete.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_Delete.ForeColor = System.Drawing.Color.IndianRed;
            this.Button_Delete.Location = new System.Drawing.Point(12, 182);
            this.Button_Delete.Name = "Button_Delete";
            this.Button_Delete.Size = new System.Drawing.Size(110, 30);
            this.Button_Delete.TabIndex = 24;
            this.Button_Delete.Text = "Delete";
            this.Button_Delete.UseVisualStyleBackColor = false;
            this.Button_Delete.Click += new System.EventHandler(this.DeleteButton);
            // 
            // EditTournament
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(630, 290);
            this.Controls.Add(this.Button_YesDelete);
            this.Controls.Add(this.Button_NoDelete);
            this.Controls.Add(this.Button_Delete);
            this.Controls.Add(this.Label_Message);
            this.Controls.Add(this.ButtonCreate);
            this.Controls.Add(this.Label_Prize);
            this.Controls.Add(this.TextBox_Prize);
            this.Controls.Add(this.Label_Date);
            this.Controls.Add(this.TextBox_Date);
            this.Controls.Add(this.Label_Game);
            this.Controls.Add(this.TextBox_Game);
            this.Controls.Add(this.Label_Name);
            this.Controls.Add(this.TextBox_Name);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditTournament";
            this.Text = "EditTournament";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonCloseWindow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox ButtonCloseWindow;
        private System.Windows.Forms.Label Label_WindowName;
        private System.Windows.Forms.Label Label_Prize;
        private System.Windows.Forms.TextBox TextBox_Prize;
        private System.Windows.Forms.Label Label_Date;
        private System.Windows.Forms.TextBox TextBox_Date;
        private System.Windows.Forms.Label Label_Game;
        private System.Windows.Forms.TextBox TextBox_Game;
        private System.Windows.Forms.Label Label_Name;
        private System.Windows.Forms.TextBox TextBox_Name;
        private System.Windows.Forms.Button ButtonCreate;
        private System.Windows.Forms.Label Label_Message;
        private System.Windows.Forms.Button Button_YesDelete;
        private System.Windows.Forms.Button Button_NoDelete;
        private System.Windows.Forms.Button Button_Delete;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}