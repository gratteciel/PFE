using Logiciel.Form_dalto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading;


namespace Logiciel
{
    public partial class main_form : Form
    {
        private Form1 form1;
        private modify modify;
        [DllImport("user32.dll")]
        private static extern void keybd_event(byte bVk, byte bScan, uint dwFlags, UIntPtr dwExtraInfo);
        public main_form()
        {
            InitializeComponent();
            form1 = new Form1();
            modify = new modify();
        }

        private void main_form_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {


        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e) //reset
        {
            try
            {
                // Specify the path to your .reg file
                string regFilePath = @"C:\Users\mitue\OneDrive\Documents\ECE\ING5\Cours\PFE\Reg\reset.reg";

                // Start regedit.exe with the path to the .reg file as an argument
                Process.Start("regedit.exe", $"/s {regFilePath}");

                // Simulate Windows + Ctrl + C
                SimulateKeyPress(Keys.LWin, Keys.ControlKey, Keys.C);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (modify == null || modify.IsDisposed)
            {
                modify = new modify();
            }
            modify.Show();


        }

        private void button9_Click(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e) //deuté
        {
            try
            {
                // Specify the path to your .reg file
                string regFilePath = @"C:\Users\mitue\OneDrive\Documents\ECE\ING5\Cours\PFE\Reg\deutera.reg";

                // Start regedit.exe with the path to the .reg file as an argument
                Process.Start("regedit.exe", $"/s {regFilePath}");

                // Simulate Windows + Ctrl + C
                SimulateKeyPress(Keys.LWin, Keys.ControlKey, Keys.C);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void SimulateKeyPress(Keys key1, Keys key2, Keys key3)
        {
            keybd_event((byte)key1, 0, 0, UIntPtr.Zero);
            keybd_event((byte)key2, 0, 0, UIntPtr.Zero);
            keybd_event((byte)key3, 0, 0, UIntPtr.Zero);

            Thread.Sleep(100);  // Add a small delay to ensure correct order of key events

            keybd_event((byte)key3, 0, 2, UIntPtr.Zero);
            keybd_event((byte)key2, 0, 2, UIntPtr.Zero);
            keybd_event((byte)key1, 0, 2, UIntPtr.Zero);
        }

        private void button11_Click(object sender, EventArgs e) //Prota
        {
            try
            {
                // Specify the path to your .reg file
                string regFilePath = @"C:\Users\mitue\OneDrive\Documents\ECE\ING5\Cours\PFE\Reg\prota.reg";

                // Start regedit.exe with the path to the .reg file as an argument
                Process.Start("regedit.exe", $"/s {regFilePath}");

                // Simulate Windows + Ctrl + C
                SimulateKeyPress(Keys.LWin, Keys.ControlKey, Keys.C);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void button14_Click_1(object sender, EventArgs e)
        {
            if (form1 == null || form1.IsDisposed)
            {
                form1 = new Form1();
            }
            form1.Show();
        }

        private void button12_Click_1(object sender, EventArgs e) // Tritanopie
        {
            try
            {
                // Specify the path to your .reg file
                string regFilePath = @"C:\Users\mitue\OneDrive\Documents\ECE\ING5\Cours\PFE\Reg\trita.reg";

                // Start regedit.exe with the path to the .reg file as an argument
                Process.Start("regedit.exe", $"/s {regFilePath}");

                // Simulate Windows + Ctrl + C
                SimulateKeyPress(Keys.LWin, Keys.ControlKey, Keys.C);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button13_Click_1(object sender, EventArgs e) // Acro
        {
            try
            {
                // Specify the path to your .reg file
                string regFilePath = @"C:\Users\mitue\OneDrive\Documents\ECE\ING5\Cours\PFE\Reg\achroma.reg";

                // Start regedit.exe with the path to the .reg file as an argument
                Process.Start("regedit.exe", $"/s {regFilePath}");

                // Simulate Windows + Ctrl + C
                SimulateKeyPress(Keys.LWin, Keys.ControlKey, Keys.C);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button15_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       
    }
}
