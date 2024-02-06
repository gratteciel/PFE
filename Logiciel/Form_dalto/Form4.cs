﻿using System;
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
    public partial class Form4 : Form
    {
        private Form5 form5;
        private bool isAnswerCorrect;
        public Form4()
        {
            InitializeComponent();
            form5 = new Form5();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
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
            if (form5 == null || form5.IsDisposed)
            {
                form5 = new Form5();
            }
            form5.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            isAnswerCorrect = false;
            Form1.answersList.Add(isAnswerCorrect);
            this.Hide();
            if (form5 == null || form5.IsDisposed)
            {
                form5 = new Form5();
            }
            form5.Show();

        }

        private void button3_Click(object sender, EventArgs e) //good answer
        {
            isAnswerCorrect = true;
            Form1.answersList.Add(isAnswerCorrect);
            this.Hide();
            if (form5 == null || form5.IsDisposed)
            {
                form5 = new Form5();
            }
            form5.Show();

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
