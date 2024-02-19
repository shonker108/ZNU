using lab_1;
using System.Diagnostics;

namespace Lab_3
{
    public partial class Form1 : Form
    {
        private string pathToFiles = "D:\\repos\\ZNU\\Software Engineering Basics\\Lab_3\\bin\\Debug\\net8.0-windows\\filesToRead";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string fileName = fileNameTextBox.Text;

                if (fileName.Length == 0 )
                {
                    throw new Exception("File name length equals to 0");
                }

                string pathToFile = pathToFiles + "\\" + fileName;

                if (!File.Exists(pathToFile)) 
                {
                    throw new Exception("There is no such file in the directory");
                }

                string[] fileContent = File.ReadAllLines(pathToFile);

                // Так як у нас мультилінійний textBox, тому до нього передаємо масив рядків,
                // які представляють лінії.
                if (fileContent.Length == 0 )
                {
                    fileContentTextBox.Lines = new string[] { "This file is empty..." };
                }
                else
                {
                    fileContentTextBox.Lines = fileContent;
                }
            }
            catch (Exception ex)
            {
                ErrorForm errorForm = new ErrorForm(ex.Message);
                errorForm.Show();
            }
        }
    }
}
