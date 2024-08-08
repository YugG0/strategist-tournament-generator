namespace Strategist
{
    partial class Home
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.ButtonCloseWindow = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.ButtonOther = new System.Windows.Forms.Button();
            this.ButtonCreateTournament = new System.Windows.Forms.Button();
            this.ButtonCreatePlayer = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.Panel_Upper = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Panel_Down = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.PanelCells = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonCloseWindow)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel11.SuspendLayout();
            this.Panel_Upper.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(106)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.ButtonCloseWindow);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1300, 30);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::Strategist.Properties.Resources.ProgramLogo;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(3, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 25);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // ButtonCloseWindow
            // 
            this.ButtonCloseWindow.BackgroundImage = global::Strategist.Properties.Resources.close;
            this.ButtonCloseWindow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonCloseWindow.Location = new System.Drawing.Point(1272, 3);
            this.ButtonCloseWindow.Name = "ButtonCloseWindow";
            this.ButtonCloseWindow.Size = new System.Drawing.Size(25, 25);
            this.ButtonCloseWindow.TabIndex = 1;
            this.ButtonCloseWindow.TabStop = false;
            this.ButtonCloseWindow.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CloseWindow);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1280, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Strategist";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ClickDown);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Drag);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(62)))));
            this.panel2.Controls.Add(this.panel11);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(250, 690);
            this.panel2.TabIndex = 1;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.panel11.Controls.Add(this.ButtonOther);
            this.panel11.Controls.Add(this.ButtonCreateTournament);
            this.panel11.Controls.Add(this.ButtonCreatePlayer);
            this.panel11.Controls.Add(this.label13);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.panel11.Location = new System.Drawing.Point(0, 533);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(250, 157);
            this.panel11.TabIndex = 5;
            // 
            // ButtonOther
            // 
            this.ButtonOther.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(56)))));
            this.ButtonOther.FlatAppearance.BorderSize = 0;
            this.ButtonOther.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonOther.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonOther.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ButtonOther.Location = new System.Drawing.Point(11, 115);
            this.ButtonOther.Name = "ButtonOther";
            this.ButtonOther.Size = new System.Drawing.Size(226, 30);
            this.ButtonOther.TabIndex = 9;
            this.ButtonOther.Text = "Other";
            this.ButtonOther.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonOther.UseVisualStyleBackColor = false;
            this.ButtonOther.Click += new System.EventHandler(this.OpenOtherWindow);
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
            this.ButtonCreateTournament.Size = new System.Drawing.Size(226, 30);
            this.ButtonCreateTournament.TabIndex = 8;
            this.ButtonCreateTournament.Text = "Create tournament";
            this.ButtonCreateTournament.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonCreateTournament.UseVisualStyleBackColor = false;
            this.ButtonCreateTournament.Click += new System.EventHandler(this.OpenCreateTournamentWindow);
            // 
            // ButtonCreatePlayer
            // 
            this.ButtonCreatePlayer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(56)))));
            this.ButtonCreatePlayer.FlatAppearance.BorderSize = 0;
            this.ButtonCreatePlayer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonCreatePlayer.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonCreatePlayer.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ButtonCreatePlayer.Location = new System.Drawing.Point(11, 79);
            this.ButtonCreatePlayer.Name = "ButtonCreatePlayer";
            this.ButtonCreatePlayer.Size = new System.Drawing.Size(226, 30);
            this.ButtonCreatePlayer.TabIndex = 7;
            this.ButtonCreatePlayer.Text = "Create player";
            this.ButtonCreatePlayer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonCreatePlayer.UseVisualStyleBackColor = false;
            this.ButtonCreatePlayer.Click += new System.EventHandler(this.OpenCreatePlayerWindow);
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Dock = System.Windows.Forms.DockStyle.Top;
            this.label13.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label13.Location = new System.Drawing.Point(0, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(250, 40);
            this.label13.TabIndex = 6;
            this.label13.Text = "Admin panel";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(31)))));
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(250, 30);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(3, 690);
            this.panel6.TabIndex = 3;
            // 
            // Panel_Upper
            // 
            this.Panel_Upper.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(62)))));
            this.Panel_Upper.Controls.Add(this.pictureBox1);
            this.Panel_Upper.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_Upper.Location = new System.Drawing.Point(253, 30);
            this.Panel_Upper.Name = "Panel_Upper";
            this.Panel_Upper.Size = new System.Drawing.Size(1047, 35);
            this.Panel_Upper.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Strategist.Properties.Resources.refresh;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(1019, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.UpdateListButton);
            // 
            // Panel_Down
            // 
            this.Panel_Down.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(62)))));
            this.Panel_Down.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_Down.Location = new System.Drawing.Point(253, 65);
            this.Panel_Down.Name = "Panel_Down";
            this.Panel_Down.Size = new System.Drawing.Size(1047, 26);
            this.Panel_Down.TabIndex = 7;
            this.Panel_Down.Visible = false;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(31)))));
            this.panel10.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel10.Location = new System.Drawing.Point(253, 91);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(1047, 3);
            this.panel10.TabIndex = 8;
            // 
            // PanelCells
            // 
            this.PanelCells.AutoScroll = true;
            this.PanelCells.BackColor = System.Drawing.Color.Transparent;
            this.PanelCells.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelCells.Location = new System.Drawing.Point(253, 94);
            this.PanelCells.Name = "PanelCells";
            this.PanelCells.Size = new System.Drawing.Size(1047, 626);
            this.PanelCells.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(29, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 30);
            this.label2.TabIndex = 3;
            this.label2.Text = "v0.1";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(1300, 720);
            this.Controls.Add(this.PanelCells);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.Panel_Down);
            this.Controls.Add(this.Panel_Upper);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(17)))), ((int)(((byte)(22)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Strategist - Home";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonCloseWindow)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.Panel_Upper.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox ButtonCloseWindow;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel Panel_Upper;
        private System.Windows.Forms.Panel Panel_Down;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel PanelCells;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button ButtonCreateTournament;
        private System.Windows.Forms.Button ButtonCreatePlayer;
        private System.Windows.Forms.Button ButtonOther;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
    }
}

