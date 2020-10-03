using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lecture06_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Number01_lable_Click(object sender, EventArgs e)
        {

        }

        private void Addition_button_Click(object sender, EventArgs e)
        {
            int number1 = int.Parse(No01_textBox.Text);
            int number2 = int.Parse(No02_textBox.Text);

            float ans = (float)number1 + number2;
            Answer_textBox.Text = ans.ToString();
        }

        private void Devision_button_Click(object sender, EventArgs e)
        {
            int number1 = int.Parse(No01_textBox.Text);
            int number2 = int.Parse(No02_textBox.Text);

            float ans = (float)number1 / number2;
            Answer_textBox.Text = ans.ToString();
        }

        private void No01_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Answer_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Subtraction_button_Click(object sender, EventArgs e)
        {
            int number1 = int.Parse(No01_textBox.Text);
            int number2 = int.Parse(No02_textBox.Text);

            int ans = number1 - number2;
            Answer_textBox.Text = ans.ToString();
        }

        private void Multiplication_button_Click(object sender, EventArgs e)
        {
            int number1 = int.Parse(No01_textBox.Text);
            int number2 = int.Parse(No02_textBox.Text);

            int ans = number1 * number2;
            Answer_textBox.Text = ans.ToString();
        }

        private void Clear_button_Click(object sender, EventArgs e)
        {
            No01_textBox.Clear();//textBoxMeter.Text = "";
            No02_textBox.Clear();//textBoxKilometer.Text = "";
            Answer_textBox.Text = "";
            No01_textBox.Focus();//cursor come to first textbox
        }
    }
}
