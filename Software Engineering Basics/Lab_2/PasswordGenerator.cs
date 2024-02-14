using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    public class PasswordGenerator
    {
        private Random random = new();

        // Використовую делегат для GetRandomString, як аргумент, у який зручно
        // передати функцію з генерації рандомного символу
        private delegate char RandomElementFunction();

        public string Generate(int length, double upperLettersFreq,
            double downLettersFreq, double digitsFreq, double specialSymbolsFreq)
        {
            string password = string.Empty;

            if (length <= 0)
                // Виключення будуть зловлені в MainForm
                throw new Exception("Length of the password must be greater that 0!");

            if (upperLettersFreq + downLettersFreq +
                digitsFreq + specialSymbolsFreq != 1)
                throw new Exception("Frequencies of the password elements aren't correct!");

            // Спочатку пароль буде мати таку схему: "ВЕЛИКІмаленькіЦИФРИсимволи",
            // а потім ми його перемішаємо

            password += GetRandomString(GetRandomUpperLetter, (int)Math.Ceiling(length * upperLettersFreq));

            password += GetRandomString(GetRandomDownLetter, (int)Math.Ceiling(length * downLettersFreq));

            password += GetRandomString(GetRandomDigit, (int)Math.Ceiling(length * digitsFreq));

            password += GetRandomString(GetRandomSpecialSymbol, (int)Math.Ceiling(length * specialSymbolsFreq));

            // Перемішуємо пароль
            password = Shuffle(password);
            
            // Обрізаємо пароль, бо він може вийти довшим через те,
            // що у нас можуть бути не зовсім коректні частоти і довжина,
            // наприклад, пароль довжиною 6 з елементами, у яких частоти по 0.25,
            return password.Substring(0, length);
        }

        private string Shuffle(string s)
        {
            char[] c = s.ToCharArray();

            for (int i = 0; i < c.Length; i++)
            {
                int swapIndex = random.Next(0, c.Length);

                char temp = c[i];
                c[i] = c[swapIndex];
                c[swapIndex] = temp;
            }

            return new string(c);
        }
        private string GetRandomString(RandomElementFunction func, int length)
        {
            string result = "";

            for (int i = 0; i < length; i++)
            {
                result += func();
            }

            return result;
        }
        private char GetRandomUpperLetter()
        {
            // В ASCII великі літери знаходяться в діапазоні 65 - 90
            return (char)random.Next(65, 91);
        }

        private char GetRandomDownLetter()
        {
            // В ASCII малі літери знаходяться в діапазоні 97 - 122
            return (char)random.Next(97, 123);
        }

        private char GetRandomDigit()
        {
            // В ASCII цифри знаходяться в діапазоні 48 - 57
            return (char)random.Next(48, 58);
        }

        private char GetRandomSpecialSymbol()
        {
            // В ASCII спеціальні символи розкидані, тому одразу всі можливі
            // ми не можемо отримати в якомусь конкретному діапазоні, тому
            // для простоти я обрав діапазон 33 - 48, де є більшість таких символів
            return (char)random.Next(33, 48);
        }
    }
}
