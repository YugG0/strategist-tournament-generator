namespace Strategist
{
    partial class HomeTabsBttnsControl
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
            this.Label_ButtonText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Label_ButtonText
            // 
            this.Label_ButtonText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(62)))));
            this.Label_ButtonText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label_ButtonText.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label_ButtonText.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Label_ButtonText.Location = new System.Drawing.Point(0, 0);
            this.Label_ButtonText.Name = "Label_ButtonText";
            this.Label_ButtonText.Size = new System.Drawing.Size(120, 26);
            this.Label_ButtonText.TabIndex = 9;
            this.Label_ButtonText.Text = "Text №";
            this.Label_ButtonText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Label_ButtonText.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButtonClick);
            // 
            // HomeTabsBttnsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Label_ButtonText);
            this.Name = "HomeTabsBttnsControl";
            this.Size = new System.Drawing.Size(120, 26);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Label_ButtonText;
    }
}
