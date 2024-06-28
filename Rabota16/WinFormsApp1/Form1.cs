using System.Data;
using System.Linq.Expressions;

namespace Rabota_16
{
    public partial class Account : Form
    {

        private List<BankAccount> bankAccounts;
        public Account()
        {
            InitializeComponent();
            bankAccounts = new List<BankAccount>();
            passwordTextBox.UseSystemPasswordChar = true;
            saveEdit.Visible = false;

            deleteAccountButton.Visible = false;
            showLoginButton.Visible = false;
            changePasswordButton.Visible = false;
            changeInfoButton.Visible = false;
        }
        private void createAccountButton_Click(object sender, EventArgs e)
        {
            string login = loginTextBox.Text;
            string password = passwordTextBox.Text;
            string fullName = fullNameTextBox.Text;
            DateTime birthDate = birthDateTimePicker.Value;
            string phoneNumber = phoneNumberTextBox.Text;

            if (birthDate.AddYears(16) > DateTime.Now)
            {
                MessageBox.Show("Пользователь должен быть старше 16 лет.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
       
            BankAccount newAccount = new BankAccount(login, password, fullName, birthDate, phoneNumber);
            bankAccounts.Add(newAccount);
            MessageBox.Show($"Успешно создан банковский счет с ID: {newAccount.Id}", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            loginTextBox.Enabled = true;
            passwordTextBox.Enabled = true;

            deleteAccountButton.Enabled = true;
            changePasswordButton.Enabled = true;
            changeInfoButton.Enabled = true;
            fullNameTextBox.Visible = false;
            birthDateTimePicker.Visible = false;
            phoneNumberTextBox.Visible = false;
            createAccountButton.Visible = false;
            FullNameLabel.Visible = false;
            BirthDateLabel.Visible = false;
            PhoneNumber.Visible = false;
            showLoginButton.Visible = true;
            changePasswordButton.Visible = true;
            changeInfoButton.Visible = true;
        }
        private void showLoginButton_Click(object sender, EventArgs e)
        {
            if (loginTextBox.Text == bankAccounts[0].Id.ToString())
            {
                using (var loginForm = new ShowLogin(bankAccounts[0]))
                {
                    if (loginForm.ShowDialog() == DialogResult.OK)
                    {
                        if (bankAccounts[0] != null && loginTextBox.Text == bankAccounts[0].Id.ToString())
                        {
                            MessageBox.Show($"Логин банковского счета: {bankAccounts[0].Login}", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }

                }
            }
            else
            {
                MessageBox.Show("Неверный идентификатор счета.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

        }
        private void showPasswordButton_Click(object sender, EventArgs e)
        {
            passwordTextBox.UseSystemPasswordChar = !passwordTextBox.UseSystemPasswordChar;
        }
        private void deleteAccountButton_Click(object sender, EventArgs e)
        {

            BankAccount account = FindAccountByID(loginTextBox.Text);
            bankAccounts.Remove(account);
            MessageBox.Show("Банковский счет успешно удален.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);


            createAccountButton.Visible = true;

            loginTextBox.Text = null;
            passwordTextBox.Text = null;
            birthDateTimePicker.Value = DateTime.Now;
            phoneNumberTextBox.Text = null;
            fullNameTextBox.Text = null;
            saveEdit.Visible = false;

            deleteAccountButton.Visible = false;
            showLoginButton.Visible = false;
            changePasswordButton.Visible = false;
            changeInfoButton.Visible = false;



        }

        private BankAccount FindAccountByID(string id)
        {
            try
            {
                return bankAccounts.FirstOrDefault(account => account.Id.ToString() == id);
            }
            catch (Exception)
            {
                return null;
            }
        }


        private void changePasswordButton_Click(object sender, EventArgs e)
        {

            using (var loginForm = new ChangePassword(bankAccounts[0]))
            {
                if (loginForm.ShowDialog() == DialogResult.OK)
                {
                    MessageBox.Show("Пароль успешно изменен.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }

        }
        private void changeInfoButton_Click(object sender, EventArgs e)
        {
            if (loginTextBox.Text == bankAccounts[0].Login && bankAccounts[0].VerifyPassword(passwordTextBox.Text))
            {
                fullNameTextBox.Visible = true;
                birthDateTimePicker.Visible = true;
                phoneNumberTextBox.Visible = true;
                deleteAccountButton.Visible = true;
                FullNameLabel.Visible = true;
                BirthDateLabel.Visible = true;
                PhoneNumber.Visible = true;
                saveEdit.Visible = true;
            }
        }

        private void saveEdit_Click(object sender, EventArgs e)
        {

            bankAccounts[0].FullName = fullNameTextBox.Text;
            bankAccounts[0].BirthDate = birthDateTimePicker.Value;
            bankAccounts[0].PhoneNumber = phoneNumberTextBox.Text;
            MessageBox.Show("Информация о владельце успешно изменена.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            fullNameTextBox.Visible = false;
            birthDateTimePicker.Visible = false;
            phoneNumberTextBox.Visible = false;

            saveEdit.Visible = false;

            FullNameLabel.Visible = false;
            BirthDateLabel.Visible = false;
            PhoneNumber.Visible = false;
            deleteAccountButton.Visible = false;

        }



    }
    public partial class BankAccount
    {
        private string login;
        private string password;
        private string fullName;
        private Guid id;

        private DateTime birthDate;
        private string phoneNumber;

        public string Login
        {
            get { return login; }
        }

        public string Password
        {
            set { password = value; }
            get { return password; }

        }

        public string FullName
        {
            get { return fullName; }
            set { fullName = value; }
        }

        public Guid Id

        {
            get { return id; }
        }

        public DateTime BirthDate
        {
            get { return birthDate; }
            set { birthDate = value; }
        }

        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }
        public bool VerifyPassword(string password)
        {
            return Password == password;
        }
        public BankAccount(string login, string password, string fullName, DateTime birthDate, string phoneNumber)
        {
            this.login = login;
            this.password = password;
            this.fullName = fullName;
            id = Guid.NewGuid();


            this.birthDate = birthDate;
            this.phoneNumber = phoneNumber;
        }
    }
}
