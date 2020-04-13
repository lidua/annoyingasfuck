using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace annoyingasfuck
{
    public partial class Form1 : Form
    {
        public static int score;
        public Form1()
        {
            InitializeComponent();
            label1.Text = "score = " + score;
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.Location = new Point(button1.Location.X, button1.Location.Y + 50);
            this.Height += 50;
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.Location = new Point(button1.Location.X, button1.Location.Y + 50);
            this.Height += 50;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.Location = new Point(button1.Location.X, button1.Location.Y + 50);
            this.Height += 50;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            score += 1;
            label1.Text = "score = " + score;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Location = new Point(12, 34);
            this.Height = 559;
        }
    }
}
