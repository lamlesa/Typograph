using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Typograph
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void DoTypograph(object sender, EventArgs e)
        {
            string text = textIn.Text;
            textIn.Text = Apply_Rules(ref text);
        }

        public string Apply_Rules(ref string text)
        {
            // RULE1: не больше одного пробела
            text = Regex.Replace(text, @"\s+", " ");

            // RULE2: для троеточия специальный символ
            text = text.Replace("...", "…");

            // RULE3: неразрывный пробел между числами и единицами измерения
            var s = Convert.ToString((char)160);
            foreach (var symbol in text)
            {
                if (text.Length >= text.IndexOf(symbol) + 2)
                {
                    if (Char.IsDigit(symbol) && Char.IsLetter(text[text.IndexOf(symbol) + 2]) && text[text.IndexOf(symbol) + 1] == ' ')
                    {
                        text = text.Insert(text.IndexOf(symbol) + 1, s);
                        text = text.Remove(text.IndexOf(symbol) + 2, 1);
                        
                    }
                }
                else
                {
                    break;
                }
            }

            // RULE4: дефис не отбивается пробелами
            text = text.Replace(" - ", "-");

            // RULE5: плюс минус специальный символ
            text = text.Replace("(+,−)", "±");
            text = text.Replace("(+,-)", "±");
            text = text.Replace("плюс минус", "±");
            text = text.Replace("плюс-минус", "±");

            // RULE6: после первой буквы м вставлять (значит масоны), потому что масоны всегда причём
            foreach (var symbol in text)
            {
                if (symbol == 'м' || symbol == 'М')
                {
                    text = text.Insert(text.IndexOf(symbol) + 1," (значит масоны)");
                    break;
                }
            }

            // RULE7: кавычки только «ёлочки»
            text = Regex.Replace(text, "\"(\\w+)", "«$1");
            string new_text = Regex.Replace(text, "(\\w+)\"", "$1»");
            text = new_text;

            return text;
        }
    }
}