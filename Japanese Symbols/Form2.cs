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

        //on-click events
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

        /*
        //on-hover events
        private void hiraganaButton_Hover(object sender, EventArgs e)
        {
            hiraganaButton.BackColor = Color.PaleGoldenrod;
        }

        private void katakanaButton_Hover(object sender, EventArgs e)
        {
            katakanaButton.BackColor = Color.PaleGoldenrod;
        }

        private void mixedButton_Hover(object sender, EventArgs e)
        {
            mixedButton.BackColor = Color.PaleGoldenrod;
        }

        //on-leave events

        private void hiraganaButton_Leave(object sender, EventArgs e)
        {
            hiraganaButton.BackColor = SystemColors.ControlLight;
        }

        private void katakanaButton_Leave(object sender, EventArgs e)
        {
            katakanaButton.BackColor = SystemColors.ControlLight;
        }

        private void mixedButton_Leave(object sender, EventArgs e)
        {
            mixedButton.BackColor = SystemColors.ControlLight;
        }
        */

        //misc events
        private void difficultyTrackBar_Scroll(object sender, EventArgs e)
        {
            difficultyLabel.Text = "Difficulty: " + difficultyTrackBar.Value.ToString();
        }

        private void startup(int language)
        {
            Form1 form = new Form1(language, difficultyTrackBar.Value);
            form.ShowDialog();
            this.Hide();
            this.Close();
        }
    }
}
