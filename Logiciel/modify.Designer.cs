namespace Logiciel
{
    partial class modify
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            trackBar1 = new TrackBar();
            trackBar2 = new TrackBar();
            trackBar3 = new TrackBar();
            trackBar4 = new TrackBar();
            trackBar5 = new TrackBar();
            label5 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar5).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(69, 37);
            label1.Name = "label1";
            label1.Size = new Size(55, 25);
            label1.TabIndex = 0;
            label1.Text = "High";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(69, 141);
            label2.Name = "label2";
            label2.Size = new Size(47, 25);
            label2.TabIndex = 1;
            label2.Text = "Mid";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(69, 249);
            label3.Name = "label3";
            label3.Size = new Size(49, 25);
            label3.TabIndex = 2;
            label3.Text = "Low";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(69, 364);
            label4.Name = "label4";
            label4.Size = new Size(110, 25);
            label4.TabIndex = 3;
            label4.Text = "Luminosité";
            label4.Click += label4_Click;
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(69, 77);
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(299, 45);
            trackBar1.TabIndex = 4;
            trackBar1.Scroll += trackBar1_Scroll;
            // 
            // trackBar2
            // 
            trackBar2.Location = new Point(69, 185);
            trackBar2.Name = "trackBar2";
            trackBar2.Size = new Size(299, 45);
            trackBar2.TabIndex = 5;
            trackBar2.Scroll += trackBar2_Scroll;
            // 
            // trackBar3
            // 
            trackBar3.Location = new Point(69, 297);
            trackBar3.Name = "trackBar3";
            trackBar3.Size = new Size(299, 45);
            trackBar3.TabIndex = 6;
            trackBar3.Scroll += trackBar3_Scroll;
            // 
            // trackBar4
            // 
            trackBar4.Location = new Point(69, 408);
            trackBar4.Name = "trackBar4";
            trackBar4.Size = new Size(299, 45);
            trackBar4.TabIndex = 7;
            trackBar4.Scroll += trackBar4_Scroll;
            // 
            // trackBar5
            // 
            trackBar5.Location = new Point(524, 77);
            trackBar5.Name = "trackBar5";
            trackBar5.Size = new Size(299, 45);
            trackBar5.TabIndex = 8;
            trackBar5.Scroll += trackBar5_Scroll;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(524, 37);
            label5.Name = "label5";
            label5.Size = new Size(98, 25);
            label5.TabIndex = 9;
            label5.Text = "Contraste";
            label5.Click += label5_Click;
            // 
            // button1
            // 
            button1.Location = new Point(649, 414);
            button1.Name = "button1";
            button1.Size = new Size(145, 39);
            button1.TabIndex = 10;
            button1.Text = "Exit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // modify
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(858, 520);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(trackBar5);
            Controls.Add(trackBar4);
            Controls.Add(trackBar3);
            Controls.Add(trackBar2);
            Controls.Add(trackBar1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "modify";
            Text = "modify";
            Load += modify_Load;
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar2).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar3).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar4).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TrackBar trackBar1;
        private TrackBar trackBar2;
        private TrackBar trackBar3;
        private TrackBar trackBar4;
        private TrackBar trackBar5;
        private Label label5;
        private Button button1;
    }
}