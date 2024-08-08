namespace Strategist
{
    partial class ParticipantControl
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
            this.panel6 = new System.Windows.Forms.Panel();
            this.PictureBox_Status = new System.Windows.Forms.PictureBox();
            this.Label_Nick = new System.Windows.Forms.Label();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Status)).BeginInit();
            this.SuspendLayout();
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(62)))));
            this.panel6.Controls.Add(this.PictureBox_Status);
            this.panel6.Controls.Add(this.Label_Nick);
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(260, 30);
            this.panel6.TabIndex = 1;
            // 
            // PictureBox_Status
            // 
            this.PictureBox_Status.Dock = System.Windows.Forms.DockStyle.Right;
            this.PictureBox_Status.Image = global::Strategist.Properties.Resources.Plus_Icon;
            this.PictureBox_Status.Location = new System.Drawing.Point(230, 0);
            this.PictureBox_Status.Name = "PictureBox_Status";
            this.PictureBox_Status.Size = new System.Drawing.Size(30, 30);
            this.PictureBox_Status.TabIndex = 2;
            this.PictureBox_Status.TabStop = false;
            this.PictureBox_Status.Click += new System.EventHandler(this.SetStatusButton);
            // 
            // Label_Nick
            // 
            this.Label_Nick.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label_Nick.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label_Nick.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Label_Nick.Location = new System.Drawing.Point(0, 0);
            this.Label_Nick.Name = "Label_Nick";
            this.Label_Nick.Size = new System.Drawing.Size(260, 30);
            this.Label_Nick.TabIndex = 1;
            this.Label_Nick.Text = "Player";
            this.Label_Nick.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ParticipantControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel6);
            this.Name = "ParticipantControl";
            this.Size = new System.Drawing.Size(260, 30);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Status)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.PictureBox PictureBox_Status;
        private System.Windows.Forms.Label Label_Nick;
    }
}
