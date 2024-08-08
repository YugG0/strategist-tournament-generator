namespace Strategist
{
    partial class TournamentCell
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel13 = new System.Windows.Forms.Panel();
            this.Label_Runnerup = new System.Windows.Forms.Label();
            this.Label_Winner = new System.Windows.Forms.Label();
            this.Label_Prize = new System.Windows.Forms.Label();
            this.Label_Data = new System.Windows.Forms.Label();
            this.Label_Name = new System.Windows.Forms.Label();
            this.PictureBox_TournamentLogo = new System.Windows.Forms.PictureBox();
            this.panel13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_TournamentLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.panel13.Controls.Add(this.Label_Runnerup);
            this.panel13.Controls.Add(this.Label_Winner);
            this.panel13.Controls.Add(this.Label_Prize);
            this.panel13.Controls.Add(this.Label_Data);
            this.panel13.Controls.Add(this.Label_Name);
            this.panel13.Controls.Add(this.PictureBox_TournamentLogo);
            this.panel13.Location = new System.Drawing.Point(0, 0);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(1016, 50);
            this.panel13.TabIndex = 12;
            // 
            // Label_Runnerup
            // 
            this.Label_Runnerup.BackColor = System.Drawing.Color.Transparent;
            this.Label_Runnerup.Dock = System.Windows.Forms.DockStyle.Left;
            this.Label_Runnerup.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label_Runnerup.ForeColor = System.Drawing.Color.Thistle;
            this.Label_Runnerup.Location = new System.Drawing.Point(851, 0);
            this.Label_Runnerup.Name = "Label_Runnerup";
            this.Label_Runnerup.Size = new System.Drawing.Size(165, 50);
            this.Label_Runnerup.TabIndex = 8;
            this.Label_Runnerup.Text = "Runner-Up";
            this.Label_Runnerup.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Label_Runnerup.Click += new System.EventHandler(this.VierTournamentButton);
            // 
            // Label_Winner
            // 
            this.Label_Winner.BackColor = System.Drawing.Color.Transparent;
            this.Label_Winner.Dock = System.Windows.Forms.DockStyle.Left;
            this.Label_Winner.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label_Winner.ForeColor = System.Drawing.Color.Thistle;
            this.Label_Winner.Location = new System.Drawing.Point(685, 0);
            this.Label_Winner.Name = "Label_Winner";
            this.Label_Winner.Size = new System.Drawing.Size(166, 50);
            this.Label_Winner.TabIndex = 7;
            this.Label_Winner.Text = "Winner";
            this.Label_Winner.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Label_Winner.Click += new System.EventHandler(this.VierTournamentButton);
            // 
            // Label_Prize
            // 
            this.Label_Prize.BackColor = System.Drawing.Color.Transparent;
            this.Label_Prize.Dock = System.Windows.Forms.DockStyle.Left;
            this.Label_Prize.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label_Prize.ForeColor = System.Drawing.Color.Thistle;
            this.Label_Prize.Location = new System.Drawing.Point(572, 0);
            this.Label_Prize.Name = "Label_Prize";
            this.Label_Prize.Size = new System.Drawing.Size(113, 50);
            this.Label_Prize.TabIndex = 6;
            this.Label_Prize.Text = "$Prize";
            this.Label_Prize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Label_Prize.Click += new System.EventHandler(this.VierTournamentButton);
            // 
            // Label_Data
            // 
            this.Label_Data.BackColor = System.Drawing.Color.Transparent;
            this.Label_Data.Dock = System.Windows.Forms.DockStyle.Left;
            this.Label_Data.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label_Data.ForeColor = System.Drawing.Color.Thistle;
            this.Label_Data.Location = new System.Drawing.Point(328, 0);
            this.Label_Data.Name = "Label_Data";
            this.Label_Data.Size = new System.Drawing.Size(244, 50);
            this.Label_Data.TabIndex = 5;
            this.Label_Data.Text = "Date";
            this.Label_Data.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Label_Data.Click += new System.EventHandler(this.VierTournamentButton);
            // 
            // Label_Name
            // 
            this.Label_Name.BackColor = System.Drawing.Color.Transparent;
            this.Label_Name.Dock = System.Windows.Forms.DockStyle.Left;
            this.Label_Name.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label_Name.ForeColor = System.Drawing.Color.Thistle;
            this.Label_Name.Location = new System.Drawing.Point(100, 0);
            this.Label_Name.Name = "Label_Name";
            this.Label_Name.Size = new System.Drawing.Size(228, 50);
            this.Label_Name.TabIndex = 4;
            this.Label_Name.Text = "Name";
            this.Label_Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Label_Name.Click += new System.EventHandler(this.VierTournamentButton);
            // 
            // PictureBox_TournamentLogo
            // 
            this.PictureBox_TournamentLogo.BackgroundImage = global::Strategist.Properties.Resources.Tournament_Logo;
            this.PictureBox_TournamentLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PictureBox_TournamentLogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.PictureBox_TournamentLogo.Location = new System.Drawing.Point(0, 0);
            this.PictureBox_TournamentLogo.Name = "PictureBox_TournamentLogo";
            this.PictureBox_TournamentLogo.Size = new System.Drawing.Size(100, 50);
            this.PictureBox_TournamentLogo.TabIndex = 0;
            this.PictureBox_TournamentLogo.TabStop = false;
            this.PictureBox_TournamentLogo.Click += new System.EventHandler(this.VierTournamentButton);
            // 
            // TournamentCell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel13);
            this.Name = "TournamentCell";
            this.Size = new System.Drawing.Size(1016, 50);
            this.panel13.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_TournamentLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Label Label_Runnerup;
        private System.Windows.Forms.Label Label_Winner;
        private System.Windows.Forms.Label Label_Prize;
        private System.Windows.Forms.Label Label_Data;
        private System.Windows.Forms.Label Label_Name;
        private System.Windows.Forms.PictureBox PictureBox_TournamentLogo;
    }
}
