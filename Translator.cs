using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Extrathicc
{
    public partial class Translator : Form
    {
        public Translator()
        {
            InitializeComponent();
        }

        private void translateButton_Click(object sender, EventArgs e)
        {
            string current = englishTextBox.Text;
            string translation = TranslateToExtrathicc(current);

            extrathiccTextBox.Clear();
            extrathiccTextBox.Text = translation;
        }

        private string TranslateToExtrathicc(string enteredText)
        {
            Dictionary<string, string> translationTable = new Dictionary<string, string>()
                                                      {
                                                        {"a", "卂"}, {"b", "乃"}, {"c", "匚"}, {"d", "刀"},
                                                        { "e", "乇"}, {"f", "下"}, {"g", "厶"}, {"h", "卄"},
                                                        { "i", "工"}, {"j", "丁"}, {"k", "长"}, {"l", "乚"},
                                                        { "m", "从"}, {"n", "𠘨"}, {"o", "口"}, {"p", "尸"},
                                                        { "q", "㔿"}, {"r", "尺"}, {"s", "丂"}, {"t", "丅"},
                                                        { "u", "凵"}, {"v", "リ"}, {"w", "山"}, {"x", "乂"},
                                                        { "y", "丫"}, {"z", "乙"}
                                                     };

            StringBuilder translatedText = new StringBuilder();
            foreach (char letter in enteredText)
            { 
                if (char.IsLetter(letter))
                {
                    translatedText.Append(translationTable[letter.ToString()]);
                }
                else
                {
                    translatedText.Append(letter);
                }
            }
            return translatedText.ToString();
        }
    }
}
