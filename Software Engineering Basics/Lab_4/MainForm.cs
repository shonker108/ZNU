using System.Globalization;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Xml.XPath;

namespace Lab_4
{
    public partial class MainForm : Form
    {
        private string? selectedFilePath;
        private FileStatistics? fileStatistics;
        private string[]? fileStatisticLines;

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

        // Regex завдання

        // Пошук першого входження двох слів, що починаються з великих
        // букв і розділених одним(!) пропуском(ім'я та прізвище).
        private void task2_1toolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegexTask.Activate(textBox.Text, @"([A-Z]|[А-Я])([a-z]|[а-я])+ ([A-Z]|[А-Я])([a-z]|[а-я])+");
        }

        // Пошук першого входження прізвища з ініціалами (слово з великої
        // літери, пробіл, велика літера, точка, велика літера, точка).
        private void task2_2toolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegexTask.Activate(textBox.Text, @"([A-Z]|[А-Я])([a-z]|[а-я])+ ([A-Z]|[А-Я])\. ([A-Z]|[А-Я])\.");
        }

        // Перевірка наявності хоча б одного із ключових слів мови C#.
        private void task2_3toolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegexTask.Activate(textBox.Text,
                @"abstract|as|base|bool|break|byte|case|catch|char|checked|class|const|continue|decimal|default|delegate|do|double|else|enum|event|explicit|extern|false|finally|fixed|float|for|foreach|goto|if|implicit|in|int|interface|internal|is|lock|long|namespace|new|null|object|on|operator|out|override|params|private|protected|public|readonly|ref|return|sbyte|sealed|short|sizeof|stackalloc|static|string|struct|switch|this|throw|to|true|try|typeof|uint|ulong|unchecked|unsafe|ushort|using|virtual|void|volatile|while|yield"
            );
        }

        // Regex завдання закінчилися. Тепер будуть звичайні

        // Допоміжна функція, щоб знайти всі слова у масиві
        private string[] FindAllWords(string[] lines, string alphabet)
        {
            string word = "";
            List<string> result = new List<string>();

            foreach (string line in lines)
            {
                for (int i = 0; i < line.Length; i++)
                {
                    char c = char.ToLower(line[i]);
                    if (!alphabet.Contains(c) || i == line.Length - 1)
                    {
                        if (i == line.Length - 1 && alphabet.Contains(c))
                            word += line[i];

                        if (word.Length == 0)
                            continue;

                        result.Add(word);

                        word = "";
                    }
                    else
                    {
                        word += line[i];
                    }
                }
            }

            return result.ToArray();
        }

        // Для кожного зі слів тексту підрахувати, скільки разів воно
        // зустрічається у тексті.
        private void task3_1toolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dictionary<string, int> map = new Dictionary<string, int>();

            string[] words = FindAllWords(textBox.Lines,
                "abcdefghijklmnopqrstuvwxyzабвгдеєжзиіїйклмнопрстуфхцчшщьюя");

            foreach (string word in words)
            {
                if (!map.ContainsKey(word))
                    map.Add(word, 1);
                else
                    map[word]++;
            }

            List<string> result = new List<string>();

            foreach (var pair in map)
            {
                result.Add($"{pair.Key} : {pair.Value}");
            }

            InfoForm infoForm = new InfoForm(result.ToArray(), "Words count");
            infoForm.Show();
        }

        // Знайти десять найдовших слів у тексті.
        private void tast3_2toolStripMenuItem_Click(object sender, EventArgs e)
        {
            string[] words = FindAllWords(textBox.Lines,
                "abcdefghijklmnopqrstuvwxyzабвгдеєжзиіїйклмнопрстуфхцчшщьюя");

            int n = 10;

            // Використовую тут LINQ
            var longestWords = words.OrderByDescending(w => w.Length).Take(n);

            List<string> result = new List<string>();

            foreach (var word in longestWords)
            {
                result.Add(word);
            }

            InfoForm infoForm = new InfoForm(result.ToArray(), "Longest words");
            infoForm.Show();
        }


        // Знайти складені з латинських літер слова, які у тексті зустрічаються
        // найчастіше.
        private void task3_3toolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dictionary<string, int> map = new Dictionary<string, int>();

            string[] words = FindAllWords(textBox.Lines,
                "abcdefghijklmnopqrstuvwxyz");

            int maxCount = 0;
            string maxValue = "";

            foreach (string word in words)
            {
                if (!map.ContainsKey(word))
                    map.Add(word, 1);
                else
                    map[word]++;

                if (map[word] > maxCount)
                {
                    maxValue = word;
                    maxCount = map[word];
                }
            }

            InfoForm infoForm = new InfoForm($"\'{maxValue}\' is the most frequent word - {maxCount}", "Most frequent word");
            infoForm.Show();
        }

    }
}
