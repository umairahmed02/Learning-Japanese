namespace Japanese_Symbols
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.wlcmLbl = new System.Windows.Forms.Label();
            this.jpnWlcmLbl = new System.Windows.Forms.Label();
            this.hiraganaButton = new System.Windows.Forms.Button();
            this.katakanaButton = new System.Windows.Forms.Button();
            this.mixedButton = new System.Windows.Forms.Button();
            this.difficultyTrackBar = new System.Windows.Forms.TrackBar();
            this.difficultyLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.difficultyTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // wlcmLbl
            // 
            this.wlcmLbl.AutoSize = true;
            this.wlcmLbl.Location = new System.Drawing.Point(210, 124);
            this.wlcmLbl.Name = "wlcmLbl";
            this.wlcmLbl.Size = new System.Drawing.Size(381, 16);
            this.wlcmLbl.TabIndex = 0;
            this.wlcmLbl.Text = "Welcome to Umair\'s Japanese Character Learning Application!";
            // 
            // jpnWlcmLbl
            // 
            this.jpnWlcmLbl.AutoSize = true;
            this.jpnWlcmLbl.Location = new System.Drawing.Point(246, 156);
            this.jpnWlcmLbl.Name = "jpnWlcmLbl";
            this.jpnWlcmLbl.Size = new System.Drawing.Size(308, 16);
            this.jpnWlcmLbl.TabIndex = 1;
            this.jpnWlcmLbl.Text = "ウマイヤの日本語文字学習アプリケーションへようこそ";
            // 
            // hiraganaButton
            // 
            this.hiraganaButton.Location = new System.Drawing.Point(151, 259);
            this.hiraganaButton.Name = "hiraganaButton";
            this.hiraganaButton.Size = new System.Drawing.Size(140, 23);
            this.hiraganaButton.TabIndex = 2;
            this.hiraganaButton.Text = "Hiragana";
            this.hiraganaButton.UseVisualStyleBackColor = true;
            this.hiraganaButton.Click += new System.EventHandler(this.hiraganaButton_Click);
            // 
            // katakanaButton
            // 
            this.katakanaButton.Location = new System.Drawing.Point(324, 259);
            this.katakanaButton.Name = "katakanaButton";
            this.katakanaButton.Size = new System.Drawing.Size(140, 23);
            this.katakanaButton.TabIndex = 3;
            this.katakanaButton.Text = "Katakana";
            this.katakanaButton.UseVisualStyleBackColor = true;
            this.katakanaButton.Click += new System.EventHandler(this.katakanaButton_Click);
            // 
            // mixedButton
            // 
            this.mixedButton.Location = new System.Drawing.Point(504, 259);
            this.mixedButton.Name = "mixedButton";
            this.mixedButton.Size = new System.Drawing.Size(140, 23);
            this.mixedButton.TabIndex = 4;
            this.mixedButton.Text = "Mixed";
            this.mixedButton.UseVisualStyleBackColor = true;
            this.mixedButton.Click += new System.EventHandler(this.mixedButton_Click);
            // 
            // difficultyTrackBar
            // 
            this.difficultyTrackBar.Location = new System.Drawing.Point(184, 357);
            this.difficultyTrackBar.Maximum = 32;
            this.difficultyTrackBar.Name = "difficultyTrackBar";
            this.difficultyTrackBar.Size = new System.Drawing.Size(438, 56);
            this.difficultyTrackBar.TabIndex = 5;
            this.difficultyTrackBar.Scroll += new System.EventHandler(this.difficultyTrackBar_Scroll);
            // 
            // difficultyLabel
            // 
            this.difficultyLabel.AutoSize = true;
            this.difficultyLabel.Location = new System.Drawing.Point(359, 316);
            this.difficultyLabel.Name = "difficultyLabel";
            this.difficultyLabel.Size = new System.Drawing.Size(62, 16);
            this.difficultyLabel.TabIndex = 6;
            this.difficultyLabel.Text = "Difficulty: ";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.difficultyLabel);
            this.Controls.Add(this.difficultyTrackBar);
            this.Controls.Add(this.mixedButton);
            this.Controls.Add(this.katakanaButton);
            this.Controls.Add(this.hiraganaButton);
            this.Controls.Add(this.jpnWlcmLbl);
            this.Controls.Add(this.wlcmLbl);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.difficultyTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label wlcmLbl;
        private System.Windows.Forms.Label jpnWlcmLbl;
        private System.Windows.Forms.Button hiraganaButton;
        private System.Windows.Forms.Button katakanaButton;
        private System.Windows.Forms.Button mixedButton;
        private System.Windows.Forms.TrackBar difficultyTrackBar;
        private System.Windows.Forms.Label difficultyLabel;
    }
}