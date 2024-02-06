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
    public partial class Form3 : Form
    {
        private Form4 form4;
        private bool isAnswerCorrect;
        public Form3()
        {
            InitializeComponent();
            form4 = new Form4();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e) //good answer
        {
            isAnswerCorrect = true;
            Form1.answersList.Add(isAnswerCorrect);
            this.Hide();
            form4.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            isAnswerCorrect = false;
            Form1.answersList.Add(isAnswerCorrect);
            this.Hide();
            form4.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            isAnswerCorrect = false;
            Form1.answersList.Add(isAnswerCorrect);
            this.Hide();
            form4.Show();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
