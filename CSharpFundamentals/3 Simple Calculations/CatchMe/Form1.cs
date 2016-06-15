﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CatchMe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            Random rand = new Random();
            var maxWidth = this.Width - buttonCatchMe.ClientSize.Width;
            var maxHeight = this.Height - buttonCatchMe.ClientSize.Height;
            this.buttonCatchMe.Location = new Point(
                rand.Next(maxWidth), rand.Next(maxHeight));
        }

        private void Form1_Click(object sender, EventArgs e)
        {
        }

        private void buttonCatchMe_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Congratulations You win!");

        }
    }
}
