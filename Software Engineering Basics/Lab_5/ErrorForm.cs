using System;
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
    public partial class ErrorForm : Form
    {
        private string errorText;
        public ErrorForm(string errorText)
        {
            InitializeComponent();

            this.errorText = errorText;
        }

        private void ErrorForm_Load(object sender, EventArgs e)
        {
            label1.Text = label1.Text + errorText;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
