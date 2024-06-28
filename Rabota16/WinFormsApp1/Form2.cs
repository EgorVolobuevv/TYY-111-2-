using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rabota_16
{
    public partial class ChangePassword : Form
    {
        private BankAccount bankAccount;

        public ChangePassword(BankAccount account)
        {
            InitializeComponent();
            bankAccount = account;
        }


        private void okButton_Click(object sender, EventArgs e)
        {
            if (bankAccount.Login == loginForChangePassword.Text && bankAccount.VerifyPassword(passwordFormTwo.Text))
            {

                string text = newPassword.Text;
                bankAccount.Password = text;
                DialogResult = DialogResult.OK;

                Close();
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
