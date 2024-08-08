namespace Strategist
{
    partial class PlayoffMatchControl
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.Label_Score2 = new System.Windows.Forms.Label();
            this.Label_Player2Nick = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.Label_Score1 = new System.Windows.Forms.Label();
            this.Label_Player1Nick = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(31)))));
            this.panel3.Controls.Add(this.Label_Score2);
            this.panel3.Controls.Add(this.Label_Player2Nick);
            this.panel3.Location = new System.Drawing.Point(0, 37);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(250, 39);
            this.panel3.TabIndex = 26;
            // 
            // Label_Score2
            // 
            this.Label_Score2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(70)))));
            this.Label_Score2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label_Score2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Label_Score2.Location = new System.Drawing.Point(213, 2);
            this.Label_Score2.Name = "Label_Score2";
            this.Label_Score2.Size = new System.Drawing.Size(35, 35);
            this.Label_Score2.TabIndex = 8;
            this.Label_Score2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Label_Score2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AddScore2Button);
            // 
            // Label_Player2Nick
            // 
            this.Label_Player2Nick.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(62)))));
            this.Label_Player2Nick.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label_Player2Nick.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Label_Player2Nick.Location = new System.Drawing.Point(2, 2);
            this.Label_Player2Nick.Name = "Label_Player2Nick";
            this.Label_Player2Nick.Size = new System.Drawing.Size(209, 35);
            this.Label_Player2Nick.TabIndex = 3;
            this.Label_Player2Nick.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(31)))));
            this.panel5.Controls.Add(this.Label_Score1);
            this.panel5.Controls.Add(this.Label_Player1Nick);
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(250, 39);
            this.panel5.TabIndex = 25;
            // 
            // Label_Score1
            // 
            this.Label_Score1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(70)))));
            this.Label_Score1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label_Score1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Label_Score1.Location = new System.Drawing.Point(213, 2);
            this.Label_Score1.Name = "Label_Score1";
            this.Label_Score1.Size = new System.Drawing.Size(35, 35);
            this.Label_Score1.TabIndex = 7;
            this.Label_Score1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Label_Score1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AddScore1Button);
            // 
            // Label_Player1Nick
            // 
            this.Label_Player1Nick.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(62)))));
            this.Label_Player1Nick.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label_Player1Nick.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Label_Player1Nick.Location = new System.Drawing.Point(2, 2);
            this.Label_Player1Nick.Name = "Label_Player1Nick";
            this.Label_Player1Nick.Size = new System.Drawing.Size(209, 35);
            this.Label_Player1Nick.TabIndex = 3;
            this.Label_Player1Nick.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PlayoffMatchControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel5);
            this.Name = "PlayoffMatchControl";
            this.Size = new System.Drawing.Size(250, 76);
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label Label_Score2;
        private System.Windows.Forms.Label Label_Player2Nick;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label Label_Score1;
        private System.Windows.Forms.Label Label_Player1Nick;
    }
}
