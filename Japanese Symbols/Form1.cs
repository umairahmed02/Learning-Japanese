using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Japanese_Symbols
{
    public partial class Form1 : Form
    {
        int retry;
        int difficulty = 1;
        String answer = "";
        String question = "";
        String[] katakana = {"ア", "イ", "ウ", "エ", "オ", "カ", "キ", "ク", "ケ", "コ", "サ", "シ", "ス", "セ", "ソ", "タ", "チ", "ツ", "テ", "ト", "ナ", "ニ", "ヌ", "ネ", "ノ", "ハ", "ヒ", "フ", "ヘ", "ホ", "マ", "ミ", "ム", "メ", "モ", "ヤ", "ユ", "ヨ", "ラ", "リ", "ル", "レ", "ロ", "ワ", "ヲ", "ン", "ガ", "ギ", "グ", "ゲ", "ゴ", "ザ", "ジ", "ズ", "ゼ", "ゾ", "ダ", "ヂ", "ヅ", "デ", "ド", "バ", "ビ", "ブ", "ベ", "ボ", "パ", "ピ", "プ", "ペ", "ポ"};
        String[] katakanaPhonetics = {"a", "i", "u", "e", "o", "ka", "ki", "ku", "ke", "ko", "sa", "shi", "su", "se", "so", "ta", "chi", "tsu", "te", "to", "na", "ni", "nu", "ne", "no", "ha", "hi", "fu", "he", "ho", "ma", "mi", "mu", "me", "mo", "ya", "yu", "yo", "ra", "ri", "ru", "re", "ro", "wa", "wo", "n", "ga", "gi", "gu", "ge", "go", "za", "ji", "zu", "ze", "zo", "da", "ji", "zu", "de", "do", "ba", "bi", "bu", "be", "bo", "pa", "pi", "pu", "pe", "po"};
        Random rand = new Random();

        public Form1()
        {
            InitializeComponent();
            reset();
        }
        public void randomCharacterGenerator(String[] character, String[]romanji)
        {
            int position = rand.Next(katakana.Length);

            question += character[position];
            answer += romanji[position];
        }

        public void reset()
        {
            retry = 1;
            answerButton.Enabled = true;
            resetButton.Enabled = true;
            contButton.Enabled = false;
            contButton.Visible = false;
            answerLbl.Visible = false;
            resetLbl.Visible = false;
            warnLbl.Visible = false;
            correctLbl.Visible = false;
            answer = "";
            question = "";

            for(int i = 0; i < difficulty; i++)
            {
                randomCharacterGenerator(katakana, katakanaPhonetics);
            }
            questionLbl.Text = question;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            reset();
        }

        private void answerButton_Click(object sender, EventArgs e)
        {
            if(answerTxtBox.Text == answer)
            {
                warnLbl.Visible = false;
                correctLbl.Visible = true;
                contButton.Visible = true;
                contButton.Enabled = true;
                answerTxtBox.Text = "";
            }
            else if(answerTxtBox.Text != answer && retry == 1)
            {
                warnLbl.Visible = true;
                answerTxtBox.Text = "";
                retry--;
            }
            else
            {
                resetLbl.Visible = true;
                answerButton.Enabled = false;
                resetButton.Enabled = false;
                contButton.Enabled = true;
                contButton.Visible = true;
                answerLbl.Visible = true;
                warnLbl.Visible = false;
                answerLbl.Text = "Correct answer is:" + answer;
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void contButton_Click(object sender, EventArgs e)
        {
            reset();
        }
    }
}
