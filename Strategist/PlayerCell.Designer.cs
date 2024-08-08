namespace Strategist
{
    partial class PlayerCell
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
            this.panel11 = new System.Windows.Forms.Panel();
            this.LabelNick = new System.Windows.Forms.Label();
            this.panel11.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(62)))));
            this.panel11.Controls.Add(this.LabelNick);
            this.panel11.Location = new System.Drawing.Point(0, 0);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(249, 48);
            this.panel11.TabIndex = 10;
            // 
            // LabelNick
            // 
            this.LabelNick.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(62)))));
            this.LabelNick.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelNick.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelNick.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.LabelNick.Location = new System.Drawing.Point(0, 0);
            this.LabelNick.Name = "LabelNick";
            this.LabelNick.Size = new System.Drawing.Size(249, 48);
            this.LabelNick.TabIndex = 5;
            this.LabelNick.Text = "Player Nick 123";
            this.LabelNick.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LabelNick.Click += new System.EventHandler(this.EditPlayerClick);
            // 
            // PlayerCell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel11);
            this.Name = "PlayerCell";
            this.Size = new System.Drawing.Size(249, 48);
            this.panel11.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Label LabelNick;
    }
}
