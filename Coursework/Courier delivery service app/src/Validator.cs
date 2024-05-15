using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Courier_delivery_service_app.src
{
    public static class Validator
    {
        public static bool IsEmail(string text)
        {
            string emailPattern = @"[A-Za-z0-9]+@[A-Za-z]+\.[A-Za-z]+";
            Regex emailRegex = new Regex(emailPattern);

            return emailRegex.IsMatch(text);
        }

        public static bool IsPhone(string text)
        {
            // Приклад: "0668215018"
            string phonePattern = "[0-9]{10}";
            Regex phoneRegex = new Regex(phonePattern);

            return phoneRegex.IsMatch(text);
        }

        public static bool IsTransportNumber(string text)
        {
            string numberPattern = @"[A-Z]{2}\s[0-9]{4}\s[A-Z]{2}";
            Regex numberRegex = new Regex(numberPattern);

            return numberRegex.IsMatch(text);
        }

    }
}
