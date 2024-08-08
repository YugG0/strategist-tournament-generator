namespace Strategist
{
    partial class TourTabsBttnsControl
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
            this.Label_Round = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Label_Round
            // 
            this.Label_Round.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(62)))));
            this.Label_Round.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label_Round.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label_Round.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Label_Round.Location = new System.Drawing.Point(0, 0);
            this.Label_Round.Name = "Label_Round";
            this.Label_Round.Size = new System.Drawing.Size(100, 26);
            this.Label_Round.TabIndex = 8;
            this.Label_Round.Text = "Text №";
            this.Label_Round.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Label_Round.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButtonClick);
            // 
            // TourTabsBttnsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Label_Round);
            this.Name = "TourTabsBttnsControl";
            this.Size = new System.Drawing.Size(100, 26);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Label_Round;
    }
}
