using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lab01_Teselko_Andrey
{
    public partial class Form1 : Form
    {
        Point lastPoint;
        public Form1()
        {
            InitializeComponent();
        }

        private void button_OK_Click(object sender, EventArgs e)
        {

            if(textBox_Login.Text == "Andrey Teselko" && textBox_Password.Text == "09877654321")
            {
                MessageBox.Show("Hello Andrey");
                label_OK.BackColor = Color.Green;
            }
            else if(textBox_Login.Text == "" || textBox_Login.Text == "Введите логин")
            {
                MessageBox.Show("Введіть логін");
                label_OK.BackColor = Color.Red;
            }
            else if (textBox_Password.Text == "" || textBox_Password.Text == "Введите пароль")
            {
                MessageBox.Show("Введіть пароль");
                label_OK.BackColor = Color.Red;
            }
            else
            {
                MessageBox.Show("Невірний логін чи пароль");
                label_OK.BackColor = Color.Red;
                textBox_Login.Text = "";
                textBox_Password.Text = "";
            }
        }
    }
}
