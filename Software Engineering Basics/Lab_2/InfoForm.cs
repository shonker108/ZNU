﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_1
{
    public partial class InfoForm : Form
    {
        private string text;
        public InfoForm(string text)
        {
            InitializeComponent();

            this.text = text;

            label2.Text = text;
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
