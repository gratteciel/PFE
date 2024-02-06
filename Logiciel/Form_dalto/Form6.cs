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
    public partial class Form6 : Form
    {
        private Form7 form7;
        private bool isAnswerCorrect;
        public Form6()
        {
            InitializeComponent();
            form7 = new Form7();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            isAnswerCorrect = false;
            Form1.answersList.Add(isAnswerCorrect);
            this.Hide();
            if (form7 == null || form7.IsDisposed)
            {
                form7 = new Form7();
            }
            form7.Show();


        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e) //good answer
        {
            isAnswerCorrect = true;
            Form1.answersList.Add(isAnswerCorrect);
            this.Hide();
            if (form7 == null || form7.IsDisposed)
            {
                form7 = new Form7();
            }
            form7.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            isAnswerCorrect = false;
            Form1.answersList.Add(isAnswerCorrect);
            this.Hide();
            if (form7 == null || form7.IsDisposed)
            {
                form7 = new Form7();
            }
            form7.Show();

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {


        }
    }
}
