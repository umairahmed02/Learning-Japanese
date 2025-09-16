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
    public partial class Form2 : Form
    {
        int language;

        public Form2()
        {
            InitializeComponent();
            difficultyLabel.Text = "Difficulty: 0";
        }

        private void hiraganaButton_Click(object sender, EventArgs e)
        {
            language = 0;
            startup(language);
        }

        private void katakanaButton_Click(object sender, EventArgs e)
        {
            language = 1;
            startup(language);
        }
        private void mixedButton_Click(object sender, EventArgs e)
        {
            language = 2;
            startup(language);
        }

        private void difficultyTrackBar_Scroll(object sender, EventArgs e)
        {
            difficultyLabel.Text = "Difficulty: " + difficultyTrackBar.Value.ToString();
        }

        private void startup(int language)
        {
            Form1 form = new Form1(language);
            form.ShowDialog();
            this.Hide();
            this.Close();
        }
    }
}
