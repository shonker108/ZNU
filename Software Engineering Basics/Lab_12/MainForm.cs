namespace Lab_12
{
    public partial class MainForm : Form
    {
        private string format = "";
        private const string path = "D:\\repos\\ZNU\\Software Engineering Basics\\Lab_12\\bin\\Debug\\net8.0-windows\\document.";

        public MainForm()
        {
            InitializeComponent();
        }

        private string GetDocumentText()
        {
            return textBox.Text;
        }

        private void htmlButton_Click(object sender, EventArgs e)
        {
            format = "html";

            SaveDocument(GetDocumentText());
        }

        private void txtButton_Click(object sender, EventArgs e)
        {
            format = "txt";

            SaveDocument(GetDocumentText());
        }

        private void binaryButton_Click(object sender, EventArgs e)
        {
            format = "bin";

            SaveDocument(GetDocumentText());
        }

        private void SaveDocument(string text)
        {
            var formatGenerator = DocumentFactory.GetDocumentFormatGenerator(format);

            formatGenerator.SaveDocument(text, path + format);
        }
    }
}
