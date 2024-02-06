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
    public partial class Form5 : Form
    {
        private Form6 form6;
        private bool isAnswerCorrect;
        public Form5()
        {
            InitializeComponent();
            form6 = new Form6();
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) //good answer
        {
            isAnswerCorrect = true;
            Form1.answersList.Add(isAnswerCorrect);
            this.Hide();
            if (form6 == null || form6.IsDisposed)
            {
                form6 = new Form6();
            }
            form6.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            isAnswerCorrect = false;
            Form1.answersList.Add(isAnswerCorrect);
            this.Hide();
            if (form6 == null || form6.IsDisposed)
            {
                form6 = new Form6();
            }
            form6.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            isAnswerCorrect = false;
            Form1.answersList.Add(isAnswerCorrect);
            this.Hide();
            if (form6 == null || form6.IsDisposed)
            {
                form6 = new Form6();
            }
            form6.Show();

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
