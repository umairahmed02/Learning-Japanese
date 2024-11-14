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
        int position;

        //list that will record the last 16 answers as 1 or 0; 1 being correct and 0 being incorrect. This will be used to interpret how well the student is doing and whether they can go up in difficulty or not.
        //chose to make it a list for ease of removing the first item as this is the most common manipulation that will happen to it
        //could make it an array however the way to remove the first item in an array requires making new arrays everytime and is thus a heavy burden to the program
        List<int> answers = new List<int> { };

        //made public for this class as more than one function needs these variables visible
        String answer = "";
        String question = "";
        int language;

        //although a dictonary would be best in this use-case i will be adding hiragana later and as there is no way to have a dictionary with 2 keys to a value it would make it take more space
        //old arrays are just here for reference if i do a boo boo
        //String[] hiragana = {"あ", "い", "う", "え", "お", "ん", "か", "き", "く", "け", "こ", "さ", "し", "す", "せ", "そ", "た", "ち", "つ", "て", "と", "な", "に", "ぬ", "ね", "の", "は", "ひ", "ふ", "へ", "ほ", "ま", "み", "む", "め", "も", "ら", "り", "る", "れ", "ろ", "わ", "を", "や", "ゆ", "よ", "が", "ぎ", "ぐ", "げ", "ご", "ざ", "じ", "ず", "ぜ", "ぞ", "だ", "ぢ", "づ", "で", "ど", "ば", "び", "ぶ", "べ", "ぼ", "ぱ", "ぴ", "ぷ", "ぺ", "ぽ"};
        //String[] katakana = {"ア", "イ", "ウ", "エ", "オ", "ン", "カ", "キ", "ク", "ケ", "コ", "サ", "シ", "ス", "セ", "ソ", "タ", "チ", "ツ", "テ", "ト", "ナ", "ニ", "ヌ", "ネ", "ノ", "ハ", "ヒ", "フ", "ヘ", "ホ", "マ", "ミ", "ム", "メ", "モ", "ラ", "リ", "ル", "レ", "ロ", "ワ", "ヲ", "ヤ", "ユ", "ヨ", "ガ", "ギ", "グ", "ゲ", "ゴ", "ザ", "ジ", "ズ", "ゼ", "ゾ", "ダ", "ヂ", "ヅ", "デ", "ド", "バ", "ビ", "ブ", "ベ", "ボ", "パ", "ピ", "プ", "ペ", "ポ"};
        String[,] characters =
        {
            {"あ", "い", "う", "え", "お", "ん", "か", "き", "く", "け", "こ", "さ", "し", "す", "せ", "そ", "た", "ち", "つ", "て", "と", "な", "に", "ぬ", "ね", "の", "は", "ひ", "ふ", "へ", "ほ", "ま", "み", "む", "め", "も", "ら", "り", "る", "れ", "ろ", "わ", "を", "や", "ゆ", "よ", "が", "ぎ", "ぐ", "げ", "ご", "ざ", "じ", "ず", "ぜ", "ぞ", "だ", "ぢ", "づ", "で", "ど", "ば", "び", "ぶ", "べ", "ぼ", "ぱ", "ぴ", "ぷ", "ぺ", "ぽ"},
            {"ア", "イ", "ウ", "エ", "オ", "ン", "カ", "キ", "ク", "ケ", "コ", "サ", "シ", "ス", "セ", "ソ", "タ", "チ", "ツ", "テ", "ト", "ナ", "ニ", "ヌ", "ネ", "ノ", "ハ", "ヒ", "フ", "ヘ", "ホ", "マ", "ミ", "ム", "メ", "モ", "ラ", "リ", "ル", "レ", "ロ", "ワ", "ヲ", "ヤ", "ユ", "ヨ", "ガ", "ギ", "グ", "ゲ", "ゴ", "ザ", "ジ", "ズ", "ゼ", "ゾ", "ダ", "ヂ", "ヅ", "デ", "ド", "バ", "ビ", "ブ", "ベ", "ボ", "パ", "ピ", "プ", "ペ", "ポ"}
        };
        String[] romanji = {"a", "i", "u", "e", "o", "n", "ka", "ki", "ku", "ke", "ko", "sa", "shi", "su", "se", "so", "ta", "chi", "tsu", "te", "to", "na", "ni", "nu", "ne", "no", "ha", "hi", "fu", "he", "ho", "ma", "mi", "mu", "me", "mo", "ra", "ri", "ru", "re", "ro", "wa", "wo", "ya", "yu", "yo", "ga", "gi", "gu", "ge", "go", "za", "ji", "zu", "ze", "zo", "da", "ji", "zu", "de", "do", "ba", "bi", "bu", "be", "bo", "pa", "pi", "pu", "pe", "po"};
        Random rand = new Random();
        
        public Form1(int lang)
        {
            InitializeComponent();
            reset();
            language = lang;
        }
        public void randomCharacterGenerator(String[,] characterList, String[]romanji)
        {
            //this if else block basically makes it so that first you get a whole new set to learn
            //once the new set is competently learned you are then tested on all the sets you have passed together to make sure user retains the previous knowledge
            //almost certain the math here is wrong, jesus take the wheel (it was)
            if (difficulty % 2 == 0)
            {
                position = rand.Next(6 + (difficulty / 2) * 5);
            }
            else
            {
                position = rand.Next(6 + ((difficulty -1) / 2) * 5, 6 + ((difficulty + 1) / 2) * 5);
            }
            //Console.WriteLine("Character generated from position: " + position); //debugging to make sure my calc is right for when it should take from where

            question += characterList[language, position];
            answer += romanji[position];
        }

        public void showContinue()
        {
            answerButton.Enabled = false;
            resetButton.Enabled = false;
            contButton.Enabled = true;
            contButton.Visible = true;
            warnLbl.Visible = false;
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
            difficultyLbl.Text = "Difficulty: " + difficulty;
            answer = "";
            question = "";

            for(int i = 0; i < 1; i++)
            {
                randomCharacterGenerator(characters, romanji);
            }
            questionLbl.Text = question;
        }

        public void recordAnswer(int answer)
        {
            answers.Add(answer);
            //Console.WriteLine("Answer is: " + answer); //more debugging stuff

            for(int i = 0; i < answers.Count; i++) //even more debugging stuff, but i think its done for now
            {
                Console.WriteLine(answers[i]);
            }

            if (answers.Count > 16)
            {
                answers.RemoveAt(0);
            }

            if (answers.Count == 16)
            {
                int averageScore = 0;
                for (int i = 0; i < answers.Count; i++)
                {
                    averageScore += answers[i];
                }

                if (averageScore > 12)
                {
                    //Console.WriteLine("Answers before being wiped" + answers.ToString());
                    difficulty++;
                    answers.Clear();
                    //Console.WriteLine("Difficulty upped"); //debugging to test if difficulty is increasing
                    //Console.WriteLine("Answers after being wiped: " + answers.ToString()); //checking that it's only increasing on the correct notations
                }
                else
                {
                    //doing this so it acts as a buffer before rechecking if they reach proper proficiency.
                    answers.RemoveRange(0, 4);
                    Console.WriteLine(answers); //checking they are being deleted properly
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            reset();
        }

        private void answerButton_Click(object sender, EventArgs e)
        {
            if (answerTxtBox.Text == answer)
            {
                showContinue();
                correctLbl.Visible = true;
                recordAnswer(1);

            }
            else if (answerTxtBox.Text != answer && retry == 1)
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
                answerLbl.Text = "Correct answer is:" + answer;
                recordAnswer(0);
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

        private void resetDiffButton_Click(object sender, EventArgs e)
        {
            difficulty = 0;
            answers.Clear();
            reset();
        }
    }
}
