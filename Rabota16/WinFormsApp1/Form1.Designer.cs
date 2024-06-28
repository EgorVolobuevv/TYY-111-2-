namespace Rabota_16
{
    partial class Account
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            loginTextBox = new TextBox();
            passwordTextBox = new TextBox();
            fullNameTextBox = new TextBox();
            phoneNumberTextBox = new TextBox();
            deleteAccountButton = new Button();
            changePasswordButton = new Button();
            changeInfoButton = new Button();
            birthDateTimePicker = new DateTimePicker();
            createAccountButton = new Button();
            showLoginButton = new Button();
            showPasswordButton = new Button();
            label1 = new Label();
            label2 = new Label();
            FullNameLabel = new Label();
            BirthDateLabel = new Label();
            PhoneNumber = new Label();
            saveEdit = new Button();
            SuspendLayout();
            // 
            // loginTextBox
            // 
            loginTextBox.Location = new Point(133, 37);
            loginTextBox.Name = "loginTextBox";
            loginTextBox.Size = new Size(250, 27);
            loginTextBox.TabIndex = 0;
            loginTextBox.Tag = "Логин";
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(133, 84);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(250, 27);
            passwordTextBox.TabIndex = 1;
            // 
            // fullNameTextBox
            // 
            fullNameTextBox.Location = new Point(133, 198);
            fullNameTextBox.Name = "fullNameTextBox";
            fullNameTextBox.Size = new Size(250, 27);
            fullNameTextBox.TabIndex = 2;
            // 
            // phoneNumberTextBox
            // 
            phoneNumberTextBox.Location = new Point(133, 297);
            phoneNumberTextBox.Name = "phoneNumberTextBox";
            phoneNumberTextBox.Size = new Size(250, 27);
            phoneNumberTextBox.TabIndex = 3;
            // 
            // deleteAccountButton
            // 
            deleteAccountButton.Location = new Point(450, 295);
            deleteAccountButton.Name = "deleteAccountButton";
            deleteAccountButton.Size = new Size(223, 29);
            deleteAccountButton.TabIndex = 4;
            deleteAccountButton.Text = "Удалить профиль";
            deleteAccountButton.UseVisualStyleBackColor = true;
            deleteAccountButton.Click += deleteAccountButton_Click;
            // 
            // changePasswordButton
            // 
            changePasswordButton.Location = new Point(450, 131);
            changePasswordButton.Name = "changePasswordButton";
            changePasswordButton.Size = new Size(223, 29);
            changePasswordButton.TabIndex = 5;
            changePasswordButton.Text = "Сменить пароль";
            changePasswordButton.UseVisualStyleBackColor = true;
            changePasswordButton.Click += changePasswordButton_Click;
            // 
            // changeInfoButton
            // 
            changeInfoButton.Location = new Point(450, 198);
            changeInfoButton.Name = "changeInfoButton";
            changeInfoButton.Size = new Size(223, 29);
            changeInfoButton.TabIndex = 6;
            changeInfoButton.Text = "Редактировать профиль";
            changeInfoButton.UseVisualStyleBackColor = true;
            changeInfoButton.Click += changeInfoButton_Click;
            // 
            // birthDateTimePicker
            // 
            birthDateTimePicker.Location = new Point(133, 247);
            birthDateTimePicker.Name = "birthDateTimePicker";
            birthDateTimePicker.Size = new Size(250, 27);
            birthDateTimePicker.TabIndex = 7;
            // 
            // createAccountButton
            // 
            createAccountButton.Location = new Point(133, 367);
            createAccountButton.Name = "createAccountButton";
            createAccountButton.Size = new Size(223, 29);
            createAccountButton.TabIndex = 8;
            createAccountButton.Text = "Создать аккаунт";
            createAccountButton.UseVisualStyleBackColor = true;
            createAccountButton.Click += createAccountButton_Click;
            // 
            // showLoginButton
            // 
            showLoginButton.Location = new Point(450, 35);
            showLoginButton.Name = "showLoginButton";
            showLoginButton.Size = new Size(223, 29);
            showLoginButton.TabIndex = 9;
            showLoginButton.Text = "Показать логин";
            showLoginButton.UseVisualStyleBackColor = true;
            showLoginButton.Click += showLoginButton_Click;
            // 
            // showPasswordButton
            // 
            showPasswordButton.Location = new Point(450, 82);
            showPasswordButton.Name = "showPasswordButton";
            showPasswordButton.Size = new Size(223, 29);
            showPasswordButton.TabIndex = 10;
            showPasswordButton.Text = "Показать пароль";
            showPasswordButton.UseVisualStyleBackColor = true;
            showPasswordButton.Click += showPasswordButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 40);
            label1.Name = "label1";
            label1.Size = new Size(52, 20);
            label1.TabIndex = 12;
            label1.Text = "Логин";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 91);
            label2.Name = "label2";
            label2.Size = new Size(62, 20);
            label2.TabIndex = 13;
            label2.Text = "Пароль";
            // 
            // FullNameLabel
            // 
            FullNameLabel.AutoSize = true;
            FullNameLabel.Location = new Point(39, 202);
            FullNameLabel.Name = "FullNameLabel";
            FullNameLabel.Size = new Size(42, 20);
            FullNameLabel.TabIndex = 15;
            FullNameLabel.Text = "ФИО";
            // 
            // BirthDateLabel
            // 
            BirthDateLabel.AutoSize = true;
            BirthDateLabel.Location = new Point(3, 254);
            BirthDateLabel.Name = "BirthDateLabel";
            BirthDateLabel.Size = new Size(116, 20);
            BirthDateLabel.TabIndex = 16;
            BirthDateLabel.Text = "Дата рождения";
            // 
            // PhoneNumber
            // 
            PhoneNumber.AutoSize = true;
            PhoneNumber.Location = new Point(29, 304);
            PhoneNumber.Name = "PhoneNumber";
            PhoneNumber.Size = new Size(69, 20);
            PhoneNumber.TabIndex = 17;
            PhoneNumber.Text = "Телефон";
            // 
            // saveEdit
            // 
            saveEdit.Location = new Point(450, 248);
            saveEdit.Name = "saveEdit";
            saveEdit.Size = new Size(223, 29);
            saveEdit.TabIndex = 18;
            saveEdit.Text = "Сохранить изменения";
            saveEdit.UseVisualStyleBackColor = true;
            saveEdit.Click += saveEdit_Click;
            // 
            // Account
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(saveEdit);
            Controls.Add(PhoneNumber);
            Controls.Add(BirthDateLabel);
            Controls.Add(FullNameLabel);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(showPasswordButton);
            Controls.Add(showLoginButton);
            Controls.Add(createAccountButton);
            Controls.Add(birthDateTimePicker);
            Controls.Add(changeInfoButton);
            Controls.Add(changePasswordButton);
            Controls.Add(deleteAccountButton);
            Controls.Add(phoneNumberTextBox);
            Controls.Add(fullNameTextBox);
            Controls.Add(passwordTextBox);
            Controls.Add(loginTextBox);
            Name = "Account";
            Text = "Банковский счёт";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox loginTextBox;
        private TextBox passwordTextBox;
        private TextBox fullNameTextBox;
        private TextBox phoneNumberTextBox;
        private Button deleteAccountButton;
        private Button changePasswordButton;
        private Button changeInfoButton;
        private DateTimePicker birthDateTimePicker;
        private Button createAccountButton;
        private Button showLoginButton;
        private Button showPasswordButton;
        private Label label1;
        private Label label2;
        private Label FullNameLabel;
        private Label BirthDateLabel;
        private Label PhoneNumber;
        private Button saveEdit;
    }
}