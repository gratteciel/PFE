using Logiciel.Form_dalto;

namespace Logiciel
{

    /*
     * 
     * Form 1 = Achromatopsie
     * Form 2 = Protanopie
     * Form 3 = Protanomalie
     * Form 4 = Deutéranopie
     * Form 5 = Deutéranomalie
     * Form 6 = Tritanopie
     * Form 7 = Tritanomalie
     * 
     */
    public partial class Form1 : Form
    {
        private Form2 form2;
        // List to store answers for each form
        public static List<bool> answersList = new List<bool>();
        public Form1()
        {
            InitializeComponent();
            form2 = new Form2();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) // good answer
        {
            // Store the answer for Form1
            answersList.Add(true);
            this.Hide();
            form2.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Store the answer for Form1
            answersList.Add(false);
            this.Hide();
            form2.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {

            answersList.Add(false);
            this.Hide();
            form2.Show();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
