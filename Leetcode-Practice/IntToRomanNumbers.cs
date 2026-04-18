using System.Text;
using Leetcode_Practice;

namespace Leetcode_Practice
{
    public class IntToRomanNumbers
    {
        public string IntToRoman(int num)
        {
            int[] values = { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1};
            string[] symbols = { "M", "CM", "D", "CD", "C", "XC","L", "XL", "X","IX","V","IV", "I"};
            StringBuilder roman = new();

            for (int i = 0; i < values.Length && num > 0; i++)
            {
                while(values[i] <= num)
                {
                    num -= values[i];
                    roman.Append(symbols[i]);
                }
            }
            return roman.ToString();
        }
    }
}

// IntToRomanNumbers intToRomanNumbers = new();
// int num = 3749;
// string result = intToRomanNumbers.IntToRoman(num);
// Console.WriteLine(result);