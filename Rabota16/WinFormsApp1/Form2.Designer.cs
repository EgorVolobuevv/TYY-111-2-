namespace Rabota_16
{
    partial class ChangePassword
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
            loginForChangePassword = new TextBox();
            passwordFormTwo = new TextBox();
            label1 = new Label();
            label2 = new Label();
            okButton = new Button();
            label3 = new Label();
            newPassword = new TextBox();
            SuspendLayout();
            // 
            // loginForChangePassword
            // 
            loginForChangePassword.Location = new Point(273, 86);
            loginForChangePassword.Name = "loginForChangePassword";
            loginForChangePassword.Size = new Size(207, 27);
            loginForChangePassword.TabIndex = 0;
            // 
            // passwordFormTwo
            // 
            passwordFormTwo.Location = new Point(273, 160);
            passwordFormTwo.Name = "passwordFormTwo";
            passwordFormTwo.Size = new Size(207, 27);
            passwordFormTwo.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(193, 91);
            label1.Name = "label1";
            label1.Size = new Size(52, 20);
            label1.TabIndex = 2;
            label1.Text = "Логин";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(193, 160);
            label2.Name = "label2";
            label2.Size = new Size(62, 20);
            label2.TabIndex = 3;
            label2.Text = "Пароль";
            // 
            // okButton
            // 
            okButton.Location = new Point(275, 291);
            okButton.Name = "okButton";
            okButton.Size = new Size(205, 29);
            okButton.TabIndex = 4;
            okButton.Text = "Подтвердить действие";
            okButton.UseVisualStyleBackColor = true;
            okButton.Click += okButton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(133, 236);
            label3.Name = "label3";
            label3.Size = new Size(112, 20);
            label3.TabIndex = 6;
            label3.Text = "Новый пароль";
            // 
            // newPassword
            // 
            newPassword.Location = new Point(273, 233);
            newPassword.Name = "newPassword";
            newPassword.Size = new Size(207, 27);
            newPassword.TabIndex = 5;
            // 
            // ChangePassword
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(newPassword);
            Controls.Add(okButton);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(passwordFormTwo);
            Controls.Add(loginForChangePassword);
            Name = "ChangePassword";
            Text = "Смена пароля";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox loginForChangePassword;
        private TextBox passwordFormTwo;
        private Label label1;
        private Label label2;
        private Button okButton;
        private Label label3;
        private TextBox newPassword;
    }
}