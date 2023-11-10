using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Kursach
{
    internal class Validator
    {
        public string NumberValid(string phone)
        {
            Regex regex = new Regex(@"^\+\d{11}$");
            Match match = regex.Match(phone);
            if (match.Success) return null;
            else return "Неверный формат номера телефона. Пример: +79326606137";
        }
    }
}
