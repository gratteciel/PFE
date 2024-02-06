using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace Logiciel.Form_dalto
{
    public partial class Form2 : Form
    {
        private Form3 form3;
        private bool isAnswerCorrect;

        public Form2()
        {
            InitializeComponent();
            form3 = new Form3();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            isAnswerCorrect = false;
            Form1.answersList.Add(isAnswerCorrect);
            this.Hide();
            form3.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            isAnswerCorrect = false;
            Form1.answersList.Add(isAnswerCorrect);
            this.Hide();
            form3.Show();
        }

        private void button3_Click(object sender, EventArgs e) //good answer
        {
            isAnswerCorrect = true;
            Form1.answersList.Add(isAnswerCorrect);
            this.Hide();
            form3.Show();
        }
    }
}
