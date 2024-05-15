﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_5
{
    public partial class InfoForm : Form
    {
        public InfoForm(string text, string title)
        {
            InitializeComponent();

            label2.Text = text;

            this.Text = title;
        }
        public InfoForm(string[] lines, string title)
        {
            InitializeComponent();

            string joined = string.Join('\n', lines);

            label2.Text = joined;
        
            this.Text = title;
        }
        private void InfoForm_Load(object sender, EventArgs e)
        {
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}