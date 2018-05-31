namespace WindowsFormsApplication1_gameoflife
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_Pause = new System.Windows.Forms.Button();
            this.button1_Start = new System.Windows.Forms.Button();
            this.button1_restart = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Controls.Add(this.button1_restart);
            this.panel1.Controls.Add(this.button_Pause);
            this.panel1.Controls.Add(this.button1_Start);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(711, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 649);
            this.panel1.TabIndex = 0;
            // 
            // button_Pause
            // 
            this.button_Pause.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Pause.Location = new System.Drawing.Point(86, 60);
            this.button_Pause.Name = "button_Pause";
            this.button_Pause.Size = new System.Drawing.Size(79, 33);
            this.button_Pause.TabIndex = 1;
            this.button_Pause.Text = "Pause";
            this.button_Pause.UseVisualStyleBackColor = true;
            this.button_Pause.Click += new System.EventHandler(this.button_Pause_Click);
            // 
            // button1_Start
            // 
            this.button1_Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1_Start.Location = new System.Drawing.Point(86, 12);
            this.button1_Start.Name = "button1_Start";
            this.button1_Start.Size = new System.Drawing.Size(79, 33);
            this.button1_Start.TabIndex = 0;
            this.button1_Start.Text = "Start";
            this.button1_Start.UseVisualStyleBackColor = true;
            this.button1_Start.Click += new System.EventHandler(this.button1_Start_Click);
            // 
            // button1_restart
            // 
            this.button1_restart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1_restart.Location = new System.Drawing.Point(86, 116);
            this.button1_restart.Name = "button1_restart";
            this.button1_restart.Size = new System.Drawing.Size(79, 33);
            this.button1_restart.TabIndex = 2;
            this.button1_restart.Text = "Restart";
            this.button1_restart.UseVisualStyleBackColor = true;
            this.button1_restart.Click += new System.EventHandler(this.button1_restart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 649);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1_Start;
        private System.Windows.Forms.Button button_Pause;
        private System.Windows.Forms.Button button1_restart;
    }
}

