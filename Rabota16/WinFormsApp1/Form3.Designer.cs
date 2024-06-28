namespace Rabota_16
{
    partial class ShowLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            ShowLoginForm = new TextBox();
            fromThreeConfirmButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(131, 83);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 0;
            label1.Text = "телефон";
            // 
            // ShowLoginForm
            // 
            ShowLoginForm.Location = new Point(281, 83);
            ShowLoginForm.Name = "ShowLoginForm";
            ShowLoginForm.Size = new Size(305, 27);
            ShowLoginForm.TabIndex = 1;
            // 
            // fromThreeConfirmButton
            // 
            fromThreeConfirmButton.Location = new Point(281, 172);
            fromThreeConfirmButton.Name = "fromThreeConfirmButton";
            fromThreeConfirmButton.Size = new Size(215, 29);
            fromThreeConfirmButton.TabIndex = 2;
            fromThreeConfirmButton.Text = "Подтвердить номер";
            fromThreeConfirmButton.UseVisualStyleBackColor = true;
            fromThreeConfirmButton.Click += ConfirmButton_Click;
            // 
            // ShowLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(fromThreeConfirmButton);
            Controls.Add(ShowLoginForm);
            Controls.Add(label1);
            Name = "ShowLogin";
            Text = "Просмотр логина";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox ShowLoginForm;
        private Button fromThreeConfirmButton;
    }
}