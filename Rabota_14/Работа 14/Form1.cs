using System;
using System.Drawing;
using System.Windows.Forms;

namespace Rabota_14
{
    public partial class Knopka : Form
    {
        private bool captured = false;
        private Button RunningButton;

        public Knopka()
        {
            InitializeComponent();
            InitializeButton();
        }

        private void InitializeButton()
        {
            RunningButton = new Button();
            RunningButton.Text = "Нажми меня!";
            RunningButton.Size = new Size(100, 50);
            RunningButton.BackColor = Color.Red;
            Controls.Add(RunningButton);
            RunningButton.MouseHover += RunningButton_MouseHover;
            DoubleClick += endOfProgramm;
        }

        private void Knopka_Load(object sender, EventArgs e)
        {
            RunningButton.Location = new Point((ClientSize.Width - RunningButton.Width) / 2, (ClientSize.Height - RunningButton.Height) / 2

             );
        }

        private void RunningButton_MouseHover(object sender, EventArgs e)
        {
            if (!captured)
            {
                RandomPosition();
            }
        }

        private void RandomPosition()
        {
            Random random = new Random();
            RunningButton.Location = new Point(
                random.Next(0,ClientSize.Width - RunningButton.Width),
                random.Next(0, ClientSize.Height - RunningButton.Height)
            );
        }

        private void endOfProgramm(object sender, EventArgs e)
        {


            RunningButton.Text = "Поймал";
            RunningButton.BackColor = Color.Green;
            RunningButton.MouseHover -= RunningButton_MouseHover; // Отключаем перемещение кнопки

        }

    }
}