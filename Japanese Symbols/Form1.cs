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
        int difficulty = 0;

        //list that will record the last 16 answers as 1 or 0; 1 being correct and 0 being incorrect. This will be used to interpret how well the student is doing and whether they can go up in difficulty or not.
        //chose to make it a list for ease of removing the first item as this is the most common manipulation that will happen to it
        //could make it an array however the way to remove the first item in an array requires making new arrays everytime and is thus a heavy burden to the program
        List<int> answers;

        //made public for this class as more than one function needs these variables visible
        String answer = "";
        String question = "";

        //although a dictonary would be best in this use-case i will be adding hiragana later and as there is no way to have a dictionary with 2 keys to a value it would make it take more space
        String[] katakana = {"ア", "イ", "ウ", "エ", "オ", "ン", "カ", "キ", "ク", "ケ", "コ", "サ", "シ", "ス", "セ", "ソ", "タ", "チ", "ツ", "テ", "ト", "ナ", "ニ", "ヌ", "ネ", "ノ", "ハ", "ヒ", "フ", "ヘ", "ホ", "マ", "ミ", "ム", "メ", "モ", "ラ", "リ", "ル", "レ", "ロ", "ワ", "ヲ", "ヤ", "ユ", "ヨ", "ガ", "ギ", "グ", "ゲ", "ゴ", "ザ", "ジ", "ズ", "ゼ", "ゾ", "ダ", "ヂ", "ヅ", "デ", "ド", "バ", "ビ", "ブ", "ベ", "ボ", "パ", "ピ", "プ", "ペ", "ポ"};
        String[] phonetics = {"a", "i", "u", "e", "o", "n", "ka", "ki", "ku", "ke", "ko", "sa", "shi", "su", "se", "so", "ta", "chi", "tsu", "te", "to", "na", "ni", "nu", "ne", "no", "ha", "hi", "fu", "he", "ho", "ma", "mi", "mu", "me", "mo", "ra", "ri", "ru", "re", "ro", "wa", "wo", "ya", "yu", "yo", "ga", "gi", "gu", "ge", "go", "za", "ji", "zu", "ze", "zo", "da", "ji", "zu", "de", "do", "ba", "bi", "bu", "be", "bo", "pa", "pi", "pu", "pe", "po"};
        Random rand = new Random();
        
        public Form1()
        {
            InitializeComponent();
            reset();
        }
        public void randomCharacterGenerator(String[] character, String[]romanji)
        {
            int position = rand.Next(6 + difficulty * 5);

            question += character[position];
            answer += romanji[position];
        }

        public void showContinue()
        {
            answerButton.Enabled = false;
            resetButton.Enabled = false;
            contButton.Enabled = true;
            contButton.Visible = true;
            answerTxtBox.Text = "";
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

            for(int i = 0; i < 1; i++)
            {
                randomCharacterGenerator(katakana, phonetics);
            }
            questionLbl.Text = question;
        }

        public void recordAnswer(int answer)
        {
            if(answers.Count == 16)
            {
                answers.RemoveAt(0);
                answers.Add(answer);
            }
            else
            {
                answers.Add(answer);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            reset();
        }

        private void answerButton_Click(object sender, EventArgs e)
        {
            if(answerTxtBox.Text == answer)
            {
                showContinue();
                correctLbl.Visible = true;
                
            }
            else if(answerTxtBox.Text != answer && retry == 1)
            {
                warnLbl.Visible = true;
                answerTxtBox.Text = "";
                retry--;
            }
            else
            {
                showContinue();
                resetLbl.Visible = true;
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
