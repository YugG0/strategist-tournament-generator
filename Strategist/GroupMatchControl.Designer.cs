namespace Strategist
{
    partial class GroupMatchControl
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
            this.Panel = new System.Windows.Forms.Panel();
            this.Label_Player2Nick = new System.Windows.Forms.Label();
            this.Label_Score2 = new System.Windows.Forms.Label();
            this.Label_ScoreSpace = new System.Windows.Forms.Label();
            this.Label_Score1 = new System.Windows.Forms.Label();
            this.Label_Player1Nick = new System.Windows.Forms.Label();
            this.Label_MatchPosition = new System.Windows.Forms.Label();
            this.Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel
            // 
            this.Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(62)))));
            this.Panel.Controls.Add(this.Label_Player2Nick);
            this.Panel.Controls.Add(this.Label_Score2);
            this.Panel.Controls.Add(this.Label_ScoreSpace);
            this.Panel.Controls.Add(this.Label_Score1);
            this.Panel.Controls.Add(this.Label_Player1Nick);
            this.Panel.Controls.Add(this.Label_MatchPosition);
            this.Panel.Location = new System.Drawing.Point(0, 0);
            this.Panel.Name = "Panel";
            this.Panel.Size = new System.Drawing.Size(967, 35);
            this.Panel.TabIndex = 12;
            // 
            // Label_Player2Nick
            // 
            this.Label_Player2Nick.Dock = System.Windows.Forms.DockStyle.Left;
            this.Label_Player2Nick.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label_Player2Nick.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Label_Player2Nick.Location = new System.Drawing.Point(453, 0);
            this.Label_Player2Nick.Name = "Label_Player2Nick";
            this.Label_Player2Nick.Size = new System.Drawing.Size(300, 35);
            this.Label_Player2Nick.TabIndex = 8;
            this.Label_Player2Nick.Text = "Player 2";
            this.Label_Player2Nick.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label_Score2
            // 
            this.Label_Score2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(70)))));
            this.Label_Score2.Dock = System.Windows.Forms.DockStyle.Left;
            this.Label_Score2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label_Score2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Label_Score2.Location = new System.Drawing.Point(418, 0);
            this.Label_Score2.Name = "Label_Score2";
            this.Label_Score2.Size = new System.Drawing.Size(35, 35);
            this.Label_Score2.TabIndex = 7;
            this.Label_Score2.Text = "0";
            this.Label_Score2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Label_Score2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AddScore2Button);
            // 
            // Label_ScoreSpace
            // 
            this.Label_ScoreSpace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(62)))));
            this.Label_ScoreSpace.Dock = System.Windows.Forms.DockStyle.Left;
            this.Label_ScoreSpace.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label_ScoreSpace.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Label_ScoreSpace.Location = new System.Drawing.Point(383, 0);
            this.Label_ScoreSpace.Name = "Label_ScoreSpace";
            this.Label_ScoreSpace.Size = new System.Drawing.Size(35, 35);
            this.Label_ScoreSpace.TabIndex = 6;
            this.Label_ScoreSpace.Text = "-";
            this.Label_ScoreSpace.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label_Score1
            // 
            this.Label_Score1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(70)))));
            this.Label_Score1.Dock = System.Windows.Forms.DockStyle.Left;
            this.Label_Score1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label_Score1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Label_Score1.Location = new System.Drawing.Point(348, 0);
            this.Label_Score1.Name = "Label_Score1";
            this.Label_Score1.Size = new System.Drawing.Size(35, 35);
            this.Label_Score1.TabIndex = 5;
            this.Label_Score1.Text = "0";
            this.Label_Score1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Label_Score1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AddScore1Button);
            // 
            // Label_Player1Nick
            // 
            this.Label_Player1Nick.Dock = System.Windows.Forms.DockStyle.Left;
            this.Label_Player1Nick.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label_Player1Nick.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Label_Player1Nick.Location = new System.Drawing.Point(48, 0);
            this.Label_Player1Nick.Name = "Label_Player1Nick";
            this.Label_Player1Nick.Size = new System.Drawing.Size(300, 35);
            this.Label_Player1Nick.TabIndex = 4;
            this.Label_Player1Nick.Text = "Player 1";
            this.Label_Player1Nick.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label_MatchPosition
            // 
            this.Label_MatchPosition.Dock = System.Windows.Forms.DockStyle.Left;
            this.Label_MatchPosition.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label_MatchPosition.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Label_MatchPosition.Location = new System.Drawing.Point(0, 0);
            this.Label_MatchPosition.Name = "Label_MatchPosition";
            this.Label_MatchPosition.Size = new System.Drawing.Size(48, 35);
            this.Label_MatchPosition.TabIndex = 3;
            this.Label_MatchPosition.Text = "#.";
            this.Label_MatchPosition.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GroupMatchControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Panel);
            this.Name = "GroupMatchControl";
            this.Size = new System.Drawing.Size(950, 35);
            this.Panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel;
        private System.Windows.Forms.Label Label_Player2Nick;
        private System.Windows.Forms.Label Label_Score2;
        private System.Windows.Forms.Label Label_ScoreSpace;
        private System.Windows.Forms.Label Label_Score1;
        private System.Windows.Forms.Label Label_Player1Nick;
        private System.Windows.Forms.Label Label_MatchPosition;
    }
}
