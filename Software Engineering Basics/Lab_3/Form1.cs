using lab_1;
using System.Diagnostics;
using System.Globalization;

namespace Lab_3
{
    public partial class Form1 : Form
    {
        private string pathToFiles = "D:\\repos\\ZNU\\Software Engineering Basics\\Lab_3\\bin\\Debug\\net8.0-windows\\filesToRead";
        private FileStatistics? fileStatistics;
        public Form1()
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("ua-UA");

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string fileName = fileNameTextBox.Text;

                if (fileName.Length == 0)
                {
                    throw new Exception("File name length equals to 0");
                }

                string pathToFile = pathToFiles + "\\" + fileName;

                if (!File.Exists(pathToFile))
                {
                    throw new Exception("There is no such file in the directory");
                }

                List<string> fileContent = new List<string>();

                // Читаємо файл лінія за лінією
                using (StreamReader sr = new StreamReader(pathToFile))
                {
                    string line = "";

                    // Використання while
                    while (true)
                    {
                        line = sr.ReadLine()!;

                        if (line == null)
                            break;

                        fileContent.Add(line);
                    }
                }

                // Так як у нас мультилінійний textBox, тому до нього передаємо масив рядків,
                // які представляють лінії.
                if (fileContent.Count == 0)
                {
                    fileContentTextBox.Lines = new string[] { "This file is empty..." };
                }
                else
                {
                    fileContentTextBox.Lines = fileContent.ToArray();
                }

                // Заповнюємо вікно зі статистикою
                fileStatistics = new FileStatistics(pathToFile, fileContent.ToArray());

                fileStatisticTextBox.Lines = new string[]
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

        private void trimButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (fileStatistics == null)
                {
                    throw new Exception("No file selected");
                }

                string[] newFileContent = fileStatistics.TrimFileLines(fileStatistics.fileLines);

                fileContentTextBox.Lines = newFileContent;

                fileStatistics = new FileStatistics(fileStatistics.filePath, newFileContent);

                fileStatisticTextBox.Lines = new string[]
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

                /*
                    Ця функція не переписує файл, щоб
                    кожного разу не розставляти по-новій
                    пробіли та пусті рядки у ньому
                 */
            }
            catch (Exception ex)
            {
                ErrorForm errorForm = new ErrorForm(ex.Message);
                errorForm.Show();
            }
        }
    }
}
