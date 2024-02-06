using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logiciel.Form_dalto
{
    public partial class Form7 : Form
    {
        private bool isAnswerCorrect;
        private string message;
        public Form7()
        {
            
            InitializeComponent();
            
        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }
        private void DisplayResults()
        {
            List<bool> answersList = Form1.answersList;

            string message = "";

            if (CheckIfAllCorrect(answersList))
            {
                message = "Félicitations ! Vous n'avez pas de daltonisme\n";
            }

            if (answersList[0] == false)
            {
                message += "Vous avez le type de daltonisme suivant : achromatopsie\n";
            }

            if (answersList[1] == false)
            {
                message += "Vous avez le type de daltonisme suivant : Protanopie\n";
            }

            if (answersList[2] == false)
            {
                message += "Vous avez le type de daltonisme suivant : Protanomalie\n";
            }

            if (answersList[3] == false)
            {
                message += "Vous avez le type de daltonisme suivant : Deutéranopie\n";
            }

            if (answersList[4] == false)
            {
                message += "Vous avez le type de daltonisme suivant : Deutéranomalie\n";
            }

            if (answersList[5] == false)
            {
                message += "Vous avez le type de daltonisme suivant : Tritanopie\n";
            }

            if (answersList[6] == false)
            {
                message += "Vous avez le type de daltonisme suivant : Tritanomalie\n";
            }

            if (string.IsNullOrEmpty(message))
            {
                message = "Vous avez tout faux, vous ne voyez rien :)\n";
            }



            MessageBox.Show(message);

            




        }
        private bool CheckIfAllCorrect(List<bool> answersList)
        {
            // Custom logic to check if all answers are correct
            // You can modify this based on your specific criteria
            return answersList.All(answer => answer);
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
            DisplayResults();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            isAnswerCorrect = false;
            Form1.answersList.Add(isAnswerCorrect);
            DisplayResults();
        }

        private void button3_Click(object sender, EventArgs e)//good answer
        {
            isAnswerCorrect = true;
            Form1.answersList.Add(isAnswerCorrect);
            DisplayResults();

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
