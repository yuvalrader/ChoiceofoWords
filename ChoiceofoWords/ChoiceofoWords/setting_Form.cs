﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChoiceofoWords
{
    public partial class setting_Form : Form
    {
        public setting_Form()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1.setnumOfLetter(int.Parse(textBox1.Text));
            Form1.setTurnLength(int.Parse(textBox2.Text));
            Form1.setMod(checkBox1.Checked);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1.setMod(false);
            Form1.setnumOfLetter(5);
            Form1.setTurnLength(60);
            textBox1.Text = "5";
            textBox2.Text = "60";
            checkBox1.Checked = false;
        }
    }
}
