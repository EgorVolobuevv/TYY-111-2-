using System;
using System.Drawing;
using System.Windows.Forms;

namespace Работа_14
{
    public partial class Form1 : Form
    {
        private bool captured = false;
        private Button button1;

        public Form1()
        {
            InitializeComponent();
            InitializeButton();
        }

        private void InitializeButton()
        {
            button1 = new Button();
            button1.Text = "Нажми меня!";
            button1.Size = new Size(100, 50);
            button1.BackColor = Color.Red;
            this.Controls.Add(button1);
            button1.MouseHover += button1_MouseHover;
            DoubleClick += endOfProgramm;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Location = new Point((this.ClientSize.Width - button1.Width) / 2, (this.ClientSize.Height - button1.Height) / 2

             );
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            if (!captured)
            {
                RandomPosition();
            }
        }

        private void RandomPosition()
        {
            Random random = new Random();
            button1.Location = new Point(
                random.Next(0, this.ClientSize.Width - button1.Width),
                random.Next(0, this.ClientSize.Height - button1.Height)
            );
        }

        private void endOfProgramm(object sender, EventArgs e)
        {


            button1.Text = "Поймал";
            button1.BackColor = Color.Green;
            button1.MouseHover -= button1_MouseHover; // Отключаем перемещение кнопки

        }

    }
}