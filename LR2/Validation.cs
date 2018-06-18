using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace LR2
{
    class Validation : ValidationRule
    {
        private double max = Double.MaxValue;

        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            double number = 0;
            string[] values = value.ToString().Split(' ');
            foreach (string v in values)
            {
                try
                {
                    number = Double.Parse(v);
                }
                catch
                {
                    return new ValidationResult(false, "Некорректный ввод.\n Могут быть введены только числа.");
                }

                if ((number < 0) || (number > max))
                {
                    return new ValidationResult(false, "Число должно быть положительным.");
                }
                else
                    continue;
            }
            return new ValidationResult(true, null);
        }
    }
}
