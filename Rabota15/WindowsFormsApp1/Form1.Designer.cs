namespace Rabota_15
{
    partial class Kalendar
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
            this.KalendarDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.MessageLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // KalendarDateTimePicker
            // 
            this.KalendarDateTimePicker.Location = new System.Drawing.Point(220, 96);
            this.KalendarDateTimePicker.Name = "KalendarDateTimePicker";
            this.KalendarDateTimePicker.Size = new System.Drawing.Size(316, 22);
            this.KalendarDateTimePicker.TabIndex = 0;
            this.KalendarDateTimePicker.ValueChanged += new System.EventHandler(this.KalendarDateTimePicker_ValueChanged);
            // 
            // MessageLabel
            // 
            this.MessageLabel.AutoSize = true;
            this.MessageLabel.Location = new System.Drawing.Point(217, 46);
            this.MessageLabel.Name = "MessageLabel";
            this.MessageLabel.Size = new System.Drawing.Size(106, 16);
            this.MessageLabel.TabIndex = 1;
            this.MessageLabel.Text = "Выберите дату";
            
            // 
            // Kalendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MessageLabel);
            this.Controls.Add(this.KalendarDateTimePicker);
            this.Name = "Kalendar";
            this.Text = "Лабораторная работа 15";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker KalendarDateTimePicker;
        private System.Windows.Forms.Label MessageLabel;
    }
}

