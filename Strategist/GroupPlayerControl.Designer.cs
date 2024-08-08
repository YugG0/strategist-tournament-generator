namespace Strategist
{
    partial class GroupPlayerControl
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
            this.Label_CountMatches = new System.Windows.Forms.Label();
            this.Label_Score = new System.Windows.Forms.Label();
            this.Label_PlayerNick = new System.Windows.Forms.Label();
            this.Label_PlayerPosition = new System.Windows.Forms.Label();
            this.Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel
            // 
            this.Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(62)))));
            this.Panel.Controls.Add(this.Label_CountMatches);
            this.Panel.Controls.Add(this.Label_Score);
            this.Panel.Controls.Add(this.Label_PlayerNick);
            this.Panel.Controls.Add(this.Label_PlayerPosition);
            this.Panel.Location = new System.Drawing.Point(0, 0);
            this.Panel.Name = "Panel";
            this.Panel.Size = new System.Drawing.Size(950, 35);
            this.Panel.TabIndex = 10;
            // 
            // Label_CountMatches
            // 
            this.Label_CountMatches.Dock = System.Windows.Forms.DockStyle.Right;
            this.Label_CountMatches.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label_CountMatches.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Label_CountMatches.Location = new System.Drawing.Point(800, 0);
            this.Label_CountMatches.Name = "Label_CountMatches";
            this.Label_CountMatches.Size = new System.Drawing.Size(50, 35);
            this.Label_CountMatches.TabIndex = 6;
            this.Label_CountMatches.Text = "0";
            this.Label_CountMatches.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label_Score
            // 
            this.Label_Score.Dock = System.Windows.Forms.DockStyle.Right;
            this.Label_Score.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label_Score.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Label_Score.Location = new System.Drawing.Point(850, 0);
            this.Label_Score.Name = "Label_Score";
            this.Label_Score.Size = new System.Drawing.Size(100, 35);
            this.Label_Score.TabIndex = 5;
            this.Label_Score.Text = "0 - 0";
            this.Label_Score.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label_PlayerNick
            // 
            this.Label_PlayerNick.Dock = System.Windows.Forms.DockStyle.Left;
            this.Label_PlayerNick.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label_PlayerNick.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Label_PlayerNick.Location = new System.Drawing.Point(50, 0);
            this.Label_PlayerNick.Name = "Label_PlayerNick";
            this.Label_PlayerNick.Size = new System.Drawing.Size(409, 35);
            this.Label_PlayerNick.TabIndex = 4;
            this.Label_PlayerNick.Text = "Player Nick 123";
            this.Label_PlayerNick.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label_PlayerPosition
            // 
            this.Label_PlayerPosition.Dock = System.Windows.Forms.DockStyle.Left;
            this.Label_PlayerPosition.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label_PlayerPosition.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Label_PlayerPosition.Location = new System.Drawing.Point(0, 0);
            this.Label_PlayerPosition.Name = "Label_PlayerPosition";
            this.Label_PlayerPosition.Size = new System.Drawing.Size(50, 35);
            this.Label_PlayerPosition.TabIndex = 3;
            this.Label_PlayerPosition.Text = "#.";
            this.Label_PlayerPosition.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GroupPlayerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Panel);
            this.Name = "GroupPlayerControl";
            this.Size = new System.Drawing.Size(950, 35);
            this.Panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel;
        private System.Windows.Forms.Label Label_CountMatches;
        private System.Windows.Forms.Label Label_Score;
        private System.Windows.Forms.Label Label_PlayerNick;
        private System.Windows.Forms.Label Label_PlayerPosition;
    }
}
