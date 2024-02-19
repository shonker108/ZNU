using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    public class FileStatistics
    {
        public string filePath = "";
        public string[] fileLines;
        public long fileSizeInBytes = 0;
        public int lettersCount = 0;
        public int digitsCount = 0;
        public int paragraphsCount = 0;
        public int emptyLinesCount = 0;
        public int authorPagesCount = 0;
        public int vowelsCount = 0;
        public int consonantsCount = 0;
        public int specialSymbolsCount = 0;
        public int punctuationSymbolsCount = 0;
        public int latinLettersCount = 0;
        public int cyrillicLettersCount = 0;

        public FileStatistics(string filePath, string[] fileLines)
        {
            this.filePath = filePath;
            this.fileLines = fileLines;

            fileSizeInBytes = GetFileSizeInBytes(filePath);
            lettersCount = GetLettersCount(fileLines);
            digitsCount = GetDigitsCount(fileLines);
            paragraphsCount = GetParagraphsCount(fileLines);
            emptyLinesCount = GetEmptyLinesCount(fileLines);
            authorPagesCount = GetAuthorPagesCount(fileLines);
            vowelsCount = GetVowelsCount(fileLines);
            consonantsCount = GetСonsonantsCount(fileLines);
            specialSymbolsCount = GetSpecialSymbolsCount(fileLines);
            punctuationSymbolsCount= GetPunctuationSymbolsCount(fileLines);
            latinLettersCount = GetLatinLetters(fileLines);
            cyrillicLettersCount = GetCyrillicLetters(fileLines);
        }

        private int GetLettersCount(string[] fileLines)
        {
            int lettersCount = 0;

            foreach (string line in fileLines)
            {
                for (int i = 0; i < line.Length; i++)
                {
                    if (char.IsLetter(line[i]))
                        lettersCount++;
                }
            }

            return lettersCount;
        }

        private int GetDigitsCount(string[] fileLines)
        {
            int digitsCount = 0;

            foreach (string line in fileLines)
            {
                for (int i = 0; i < line.Length; i++)
                {
                    if (char.IsDigit(line[i]))
                        digitsCount++;
                }
            }

            return digitsCount;
        }

        private int GetParagraphsCount(string[] fileLines)
        {
            int paragraphsCount = 0;

            foreach (string line in fileLines)
            {
                // Параграф існує, якщо у нас лінія більше 0
                if (line.Length > 0)
                {
                    paragraphsCount++;
                }
            }

            return paragraphsCount;
        }

        private int GetEmptyLinesCount(string[] fileLines)
        {
            int emptyLinesCount = 0;

            foreach (string line in fileLines)
            {
                if (line.Length == 0)
                    emptyLinesCount++;  
            }

            return emptyLinesCount;
        }

        private int GetAuthorPagesCount(string[] fileLines)
        {
            int authorPagesCount = 0;
            int symbolsCount = 0;

            foreach (string line in fileLines)
            {
                for (int i = 0; i < line.Length; i++)
                {
                    if (char.IsLetterOrDigit(line[i]))
                    {
                        symbolsCount++;

                        if (symbolsCount == 1800)
                            authorPagesCount++;
                    }
                }
            }

            return authorPagesCount;
        }

        // Отримати кількість голосних у файлі
        private int GetVowelsCount(string[] fileLines)
        {
            const string vowels = "aeiouаеіоуияєю";
            int vowelsCount = 0;

            foreach (string line in fileLines)
            {
                for (int i = 0; i < line.Length; i++)
                {
                    if (char.IsLetter(line[i]) && vowels.Contains(char.ToLower(line[i])))
                        vowelsCount++;
                }
            }

            return vowelsCount;
        }

        // Приголосні
        private int GetСonsonantsCount(string[] fileLines)
        {
            const string vowels = "aeiouаеіоуияєю";
            int сonsonantsCount = 0;

            foreach (string line in fileLines)
            {
                for (int i = 0; i < line.Length; i++)
                {
                    if (char.IsLetter(line[i]) && !vowels.Contains(char.ToLower(line[i])))
                        сonsonantsCount++;
                }
            }

            return сonsonantsCount;
        }

        private int GetSpecialSymbolsCount(string[] fileLines)
        {
            const string specialSymbols = @"@#$%^&*()_+=/\{}[]|";
            int specialSymbolsCount = 0;

            foreach (string line in fileLines)
            {
                for (int i = 0; i < line.Length; i++)
                {
                    if (specialSymbols.Contains(line[i]))
                        specialSymbolsCount++;
                }
            }

            return specialSymbolsCount;
        }

        private int GetPunctuationSymbolsCount(string[] fileLines)
        {
            const string punctuationSymbols = @".,:;?!-";
            int punctuationSymbolsCount = 0;

            foreach (string line in fileLines)
            {
                for (int i = 0; i < line.Length; i++)
                {
                    if (punctuationSymbols.Contains(line[i]))
                        punctuationSymbolsCount++;
                }
            }

            return punctuationSymbolsCount;
        }

        private int GetLatinLetters(string[] fileLines)
        {
            const string latinLetters = "abcdefghijklmnopqrstuvwxyz";
            int latinLettersCount = 0;

            foreach (string line in fileLines)
            {
                for (int i = 0; i < line.Length; i++)
                {
                    if (latinLetters.Contains(char.ToLower(line[i])))
                        latinLettersCount++;
                }
            }

            return latinLettersCount;
        }

        private int GetCyrillicLetters(string[] fileLines)
        {
            const string сyrillicLetters = "абвгґдеєжзиіїйклмнопрстуфхцчшщьюя";
            int сyrillicLettersCount = 0;

            foreach (string line in fileLines)
            {
                for (int i = 0; i < line.Length; i++)
                {
                    if (сyrillicLetters.Contains(char.ToLower(line[i])))
                        сyrillicLettersCount++;
                }
            }

            return сyrillicLettersCount;
        }

        public string[] TrimFileLines(string[] fileLines)
        {
            List<string> lines = new List<string>();

            foreach (string line in fileLines)
            {
                if (line.Length == 0)
                    continue;

                string newLine = "";

                for (int i = 0; i < line.Length; i++)
                {
                    if (line[i] == '\t')
                        continue;

                    bool addWhiteSpace = false;

                    while (i < line.Length && line[i] == ' ')
                    {
                        addWhiteSpace = true;
                        i++;
                    }

                    if (addWhiteSpace)
                        newLine += ' ';

                    if (i < line.Length)
                        newLine += line[i];
                }

                newLine = newLine.Trim();

                lines.Add(newLine);
            }

            return lines.ToArray();
        }
        private long GetFileSizeInBytes(string filePath)
        {
            return new System.IO.FileInfo(filePath).Length;
        }
    }
}
