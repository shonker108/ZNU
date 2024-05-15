using System.Globalization;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Xml.Linq;
using System.Xml.XPath;
using HtmlAgilityPack;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab_5
{
    public partial class MainForm : Form
    {
        private string? selectedFilePath;
        private FileStatistics? fileStatistics;
        private string[]? fileStatisticLines;

        // ����� ������� ��� ��������
        public int count;

        public MainForm()
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("ua-UA");

            InitializeComponent();
        }

        private void copySelectedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string selectedText = textBox.SelectedText;

            Clipboard.SetText(selectedText);
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text.Insert(textBox.SelectionStart, Clipboard.GetText());
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                saveFileDialog = new System.Windows.Forms.SaveFileDialog();
                saveFileDialog.Filter = "All files(*.*) | *.*";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllLines(saveFileDialog.FileName, textBox.Lines);
                }
                else
                {
                    throw new Exception("Can't save the file");
                }
            }
            catch (Exception ex)
            {
                ErrorForm errorForm = new ErrorForm(ex.Message);
                errorForm.Show();
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog = new System.Windows.Forms.OpenFileDialog();
                openFileDialog.ShowDialog();

                string pathToFile = openFileDialog.FileName;

                selectedFilePath = pathToFile;

                if (pathToFile == string.Empty)
                {
                    return;
                }

                if (!File.Exists(pathToFile))
                {
                    throw new Exception("There is no such file in the directory");
                }

                List<string> fileContent = new List<string>();

                using (StreamReader sr = new StreamReader(pathToFile))
                {
                    string line = "";

                    while (true)
                    {
                        line = sr.ReadLine()!;

                        if (line == null)
                            break;

                        fileContent.Add(line);
                    }
                }

                if (fileContent.Count == 0)
                {
                    textBox.Lines = new string[] { "This file is empty..." };
                }
                else
                {
                    textBox.Lines = fileContent.ToArray();
                }

                fileStatistics = new FileStatistics(pathToFile, fileContent.ToArray());

                fileStatisticLines = new string[]
                {
                    $"File size (bytes): {fileStatistics.fileSizeInBytes}",
                    $"Letters: {fileStatistics.lettersCount}",
                    $"Digits: {fileStatistics.digitsCount}",
                    $"Paragraphs: {fileStatistics.paragraphsCount}",
                    $"Empty lines: {fileStatistics.emptyLinesCount}",
                    $"Author pages: {fileStatistics.authorPagesCount}",
                    $"Vowels: {fileStatistics.vowelsCount}",
                    $"Consonants: {fileStatistics.consonantsCount}",
                    $"Special symbols: {fileStatistics.specialSymbolsCount}",
                    $"Punctuation symbols: {fileStatistics.punctuationSymbolsCount}",
                    $"Latin letters: {fileStatistics.latinLettersCount}",
                    $"Cyrillic letters: {fileStatistics.cyrillicLettersCount}"
                };
            }
            catch (Exception ex)
            {
                ErrorForm errorForm = new ErrorForm(ex.Message);
                errorForm.Show();
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedFilePath == null)
                {
                    throw new Exception("There is no selected file.");
                }

                string[] textToSave = textBox.Lines;

                File.WriteAllLines(selectedFilePath, textToSave);
            }
            catch (Exception ex)
            {
                ErrorForm errorForm = new ErrorForm(ex.Message);
                errorForm.Show();
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InfoForm infoForm = new InfoForm("Just a text editor. Made by Artur Shcherban.", "About");
            infoForm.Show();
        }

        private void statisticsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (fileStatisticLines == null)
                {
                    throw new Exception("There is no selected file.");
                }

                InfoForm infoForm = new InfoForm(fileStatisticLines, "Statistic");
                infoForm.Show();
            }
            catch (Exception ex)
            {
                ErrorForm errorForm = new ErrorForm(ex.Message);
                errorForm.Show();
            }
        }

        // ��������: � ������������� ����� WebRequest ������ ���������
        // ������������� ��������� �� ������ �������� ����� �� �����
        // https://www.znu.edu.ua/cms/index.php?action=news/view&start=0&site_id=27&lang=ukr.
        // ���������� ������� ���� ����� �������� ������� ������������ �����.
        // ϳ��� ������������ ������ ������ ���� ���������� ��� ����������� � ���������� ��������.
        private void task_button_Click(object sender, EventArgs e)
        {
            // � ����� ������ ������������ ������ � �����
            List<News> newsList = new();

            // �-�� ������, �� ������� ����������
            int count = (int)task_numericUpDown.Value;

            // �� ������ ����, ��� �������� ������ HTML-��� ���� �������
            WebRequest request = WebRequest.Create("https://www.znu.edu.ua/cms/index.php?action=news/view&start=0&site_id=27&lang=ukr");

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            Stream dataStream = response.GetResponseStream();

            StreamReader reader = new StreamReader(dataStream);

            string responseFromServer = reader.ReadToEnd();

            // ��� ������� �������� � ����
            File.WriteAllText("D:\\repos\\ZNU\\Software Engineering Basics\\Lab_4\\bin\\Debug\\net8.0-windows\\text.txt", responseFromServer);

            reader.Close();
            dataStream.Close();
            response.Close();

            // � �����-� ����� ���������� ����� �� HtmlDocument, ��� ��������� �� ������
            // ����� LINQ
            HtmlAgilityPack.HtmlDocument htmlDoc = new HtmlAgilityPack.HtmlDocument();

            htmlDoc.Load("D:\\repos\\ZNU\\Software Engineering Basics\\Lab_4\\bin\\Debug\\net8.0-windows\\text.txt");

            HtmlAgilityPack.HtmlNode bodyNode = htmlDoc.DocumentNode.SelectSingleNode("//body");

            // �������� div-� � �������� (����� � ��������)
            var newsNodes = bodyNode.Descendants("div").Where(x => x.HasClass("a-container"));

            foreach (var newsNode in newsNodes)
            {
                News news = new News();

                // �������� ��� � ������ ������
                var titleNode = newsNode.Descendants("a").First();
                news.title = titleNode.InnerText;

                // �������� ��� � ��������� ������
                var anotationNode = newsNode.Descendants("div").First();
                news.anotation = anotationNode.InnerText;

                // ��������, �� ��� ��������� �������� �����,
                // ��������� �� �-�� ��� �������
                if (newsList.Count == count)
                    break;
                else
                    newsList.Add(news);
            }

            List<string> text = new();

            // �������� �� ����� (text box) ������ �� �� ��������
            foreach (News news in newsList)
            {
                text.Add(news.title);
                text.Add(news.anotation);
                text.Add("\n");
            }

            textBox.Lines = text.ToArray();
        }

        // ��� ������� ����� �������� ��� � ������ �� �����
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Singleton<LogRegistrator>.Instance.SaveLog();
        }

        private string[] prevText = new string[0];

        // ĳ������� ����� ���� ��, �� �� ���� ��������
        private void textBox_TextChanged(object sender, EventArgs e)
        {
            int prevTextLength = 0;

            for (int i = 0; i < prevText.Length; i++)
            {
                // ������� ����� �� �������� �� ����� �����, �� �� �����������, �� ������, �� �� ������
                string line = prevText[i].Replace(Environment.NewLine, "");

                prevTextLength += line.Length;
            }

            int currTextLength = 0;

            for (int i = 0; i < textBox.Lines.Length; i++)
            {
                string line = textBox.Lines[i].Replace(Environment.NewLine, "");

                currTextLength += line.Length;
            }

            int selectionStart = textBox.SelectionStart;

            int charRow = textBox.GetLineFromCharIndex(selectionStart);
            int charCol = selectionStart - textBox.GetFirstCharIndexFromLine(charRow);

            char character = ' ';
            string eventType = "�����/������� �� ���� ���";

            if (prevTextLength < currTextLength)
            {
                character = textBox.Lines[charRow][charCol - 1];

                eventType = "���������";
            }
            else if (prevTextLength > currTextLength)
            {
                character = prevText[charRow][charCol - 1];

                eventType = "���������";
            }

            if (eventType == "���������") charCol++;

            LogData logData = new LogData(DateTime.Now, character, charRow, charCol, eventType);

            Singleton<LogRegistrator>.Instance.AddLog(logData);

            prevText = textBox.Lines;
        }
    }
}
