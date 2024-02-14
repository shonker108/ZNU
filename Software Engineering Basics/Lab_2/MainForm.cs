using lab_1;

namespace Lab_2
{
    public partial class MainForm : Form
    {
        PasswordGenerator passwordGenerator;
        public MainForm()
        {
            InitializeComponent();
        
            passwordGenerator = new PasswordGenerator();
        }

        // Кнопка до завдання #1
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Чистимо список від попередніх дільників
                textBox2.Lines = new string[0];

                if (!int.TryParse(this.textBox1.Text, out int number))
                {
                    throw new Exception("Can't parse given number!");
                }

                if (number == 0)
                {
                    textBox2.Text = "Всі числа, окрім самого 0";
                    return;
                }

                int end = -number;

                List<string> divisors = new List<string>();

                // Якщо число від'ємне, то йдемо зліва-направо.
                // В іншому випадку - навпаки
                if (number > 0)
                {
                    for (int i = number; i >= end; i--)
                    {
                        if (i == 0)
                            continue;

                        if (number % i == 0)
                            divisors.Add(i.ToString());
                    }
                }
                else
                {
                    for (int i = number; i <= end; i++)
                    {
                        if (i == 0)
                            continue;

                        if (number % i == 0)
                            divisors.Add(i.ToString());
                    }
                }

                // Заповнюємо textBox дільниками
                textBox2.Lines = divisors.ToArray();
            }
            catch (Exception ex)
            {
                ErrorForm errorForm = new ErrorForm(ex.Message);
                errorForm.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(textBox3.Text, out int length))
                    throw new Exception("Can't parse given length!");

                if (!double.TryParse(textBox4.Text, out double upperLettersFreq) ||
                    upperLettersFreq < 0)
                    throw new Exception("Can't parse given upper letters frequency!");

                if (!double.TryParse(textBox5.Text, out double downLettersFreq) ||
                    downLettersFreq < 0)
                    throw new Exception("Can't parse given down letters frequency!");

                if (!double.TryParse(textBox6.Text, out double digitsFreq) ||
                    digitsFreq < 0)
                    throw new Exception("Can't parse given digits frequency!");

                if (!double.TryParse(textBox7.Text, out double specialSymbolsFreq) ||
                    upperLettersFreq < 0)
                    throw new Exception("Can't parse given special symbols frequency!");

                textBox8.Text = passwordGenerator.Generate(length, upperLettersFreq,
                    downLettersFreq, digitsFreq, specialSymbolsFreq);
            }
            catch (Exception ex)
            {
                ErrorForm errorForm = new ErrorForm(ex.Message);
                errorForm.Show();
            }
        }
    }
}
