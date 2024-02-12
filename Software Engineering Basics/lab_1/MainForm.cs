namespace lab_1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string name = textBox1.Text;

                // Спершу дивимося, чи це взагалі число
                if (!int.TryParse(textBox2.Text, out int year))
                {
                    Exception ex = new Exception("Entered year cannot be parsed!");

                    throw ex;
                }

                // Далі дивимося, чи існує ця людина, припускаючи, що найстаріша
                // жива людина народилася у 1900 році, а також дивимося, чи
                // наданий рік не перевищує теперішній
                int minYear = 1900;
                int currentYear = DateTime.Now.Year;
                if (year < minYear || year > currentYear)
                {
                    Exception ex = new Exception("This person with this year of birth can't exist...");

                    throw ex;
                }

                string result = $"{name} will be 100 years old at the {year + 100} year";

                InfoForm infoForm = new InfoForm("First task message", result);

                infoForm.Show();
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
                if (!int.TryParse(textBox3.Text, out int messagesCount))
                {
                    Exception ex = new Exception("Entered number cannot be parsed!");

                    throw ex;
                }

                if (messagesCount <= 0)
                {
                    Exception ex = new Exception("Entered number must be greater 0!");

                    throw ex;
                }

                while (messagesCount > 0)
                {
                    InfoForm infoForm = new InfoForm("First task message", "Message... =)");

                    infoForm.Show();

                    messagesCount--;
                }
            }
            catch (Exception ex)
            {
                ErrorForm errorForm = new ErrorForm(ex.Message);

                errorForm.Show();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(textBox4.Text, out int firstNum))
                {
                    Exception ex = new Exception("First entered number cannot be parsed!");

                    throw ex;
                }

                if (!int.TryParse(textBox5.Text, out int secondNum))
                {
                    Exception ex = new Exception("Second entered number cannot be parsed!");

                    throw ex;
                }

                string result = "Is first number even: " + (firstNum % 2 == 0 ? "yes" : "no") + "\n";
                
                if (firstNum % 4 == 0)
                {
                    result += "Also, this number can be divided by 4\n";
                }

                if (firstNum % secondNum == 0)
                {
                    result += $"{firstNum} can be divided by {secondNum}\n";
                }
                else if (secondNum % firstNum == 0)
                {
                    result += $"{secondNum} can be divided by {firstNum}\n";
                }
                else
                {
                    result += "Two numbers cannot be divided by each other without a remainder\n";
                }

                InfoForm infoForm = new InfoForm("Second task message", result);

                infoForm.Show();
            }
            catch (Exception ex)
            {
                ErrorForm errorForm = new ErrorForm(ex.Message);

                errorForm.Show();
            }
        }
    }
}
