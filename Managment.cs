using Microsoft.VisualBasic;
using System;
using System.Text;

namespace AssetEditor
{
    public static class Managment
    {
        public static string GetNewString(string propertyToChange, string currentString)
        {
            string result;
            bool isEmpty;
            do
            {
                result = Interaction.InputBox($"Введите свойство \"{propertyToChange}\"", $"Текущая строка: {currentString}");
                isEmpty = string.IsNullOrEmpty(result) || string.IsNullOrWhiteSpace(result);
            }
            while (isEmpty);
            return result;
        }
        public static Asset.CurrencyEnum GetNewCurrency(Asset.CurrencyEnum currentCurency)
        {
            string input;
            int indexCurrency;
            bool isDigit, isIndexExist;
            StringBuilder sb = new StringBuilder();
            string[] currencies = Enum.GetNames(typeof(Asset.CurrencyEnum));
            for (int i = 0; i < currencies.Length; i++)
                sb.AppendLine($"{i} - {currencies[i]}");
            sb.AppendLine("Введите индекс новой валюты");
            do
            {
                input = Interaction.InputBox(sb.ToString(), $"Текущая валюта: {currentCurency}");
                isDigit = int.TryParse(input, out indexCurrency);
                isIndexExist = indexCurrency >= 0 && indexCurrency < currencies.Length;
            }
            while (!isDigit || !isIndexExist);
            return (Asset.CurrencyEnum)indexCurrency;
        }
        public static double GetNewDouble(string propertyToChange, double currentDouble)
        {
            string input;
            double result;
            bool isDouble;
            do
            {
                input = Interaction.InputBox($"Введите свойство \"{propertyToChange}\"", $"Текущее число: {currentDouble}");
                isDouble = double.TryParse(input, out result);
            }
            while (!isDouble);
            return result;
        }
        public static int GetNewInt(string propertyToChange, int currentInt)
        {
            string input;
            int result;
            bool isInt;
            do
            {
                input = Interaction.InputBox($"Введите свойство \"{propertyToChange}\"", $"Текущее число: {currentInt}");
                isInt = int.TryParse(input, out result);
            }
            while (!isInt);
            return result;
        }
    }
}
