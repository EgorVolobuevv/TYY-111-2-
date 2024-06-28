using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rabota_16
{
    public partial class ShowLogin : Form
    {
        private BankAccount bankAccount;

        public ShowLogin(BankAccount account)
        {
            InitializeComponent();
            bankAccount = account;
        }



        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            if (bankAccount.PhoneNumber == ShowLoginForm.Text)
            {
                DialogResult = DialogResult.OK;

                Close();
            }
            else
            {
                MessageBox.Show("Неверный номер телефона.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
