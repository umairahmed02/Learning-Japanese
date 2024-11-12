
namespace Japanese_Symbols
{
    partial class Form1
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
            this.questionLbl = new System.Windows.Forms.Label();
            this.answerTxtBox = new System.Windows.Forms.TextBox();
            this.answerButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.correctLbl = new System.Windows.Forms.Label();
            this.contButton = new System.Windows.Forms.Button();
            this.warnLbl = new System.Windows.Forms.Label();
            this.resetLbl = new System.Windows.Forms.Label();
            this.answerLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // questionLbl
            // 
            this.questionLbl.AutoSize = true;
            this.questionLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionLbl.Location = new System.Drawing.Point(415, 111);
            this.questionLbl.Name = "questionLbl";
            this.questionLbl.Size = new System.Drawing.Size(95, 36);
            this.questionLbl.TabIndex = 0;
            this.questionLbl.Text = "label1";
            // 
            // answerTxtBox
            // 
            this.answerTxtBox.Location = new System.Drawing.Point(336, 175);
            this.answerTxtBox.Name = "answerTxtBox";
            this.answerTxtBox.Size = new System.Drawing.Size(236, 22);
            this.answerTxtBox.TabIndex = 1;
            // 
            // answerButton
            // 
            this.answerButton.Location = new System.Drawing.Point(336, 213);
            this.answerButton.Name = "answerButton";
            this.answerButton.Size = new System.Drawing.Size(115, 23);
            this.answerButton.TabIndex = 2;
            this.answerButton.Text = "Check Answer";
            this.answerButton.UseVisualStyleBackColor = true;
            this.answerButton.Click += new System.EventHandler(this.answerButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(457, 213);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(115, 23);
            this.resetButton.TabIndex = 3;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // correctLbl
            // 
            this.correctLbl.AutoSize = true;
            this.correctLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.correctLbl.Location = new System.Drawing.Point(258, 278);
            this.correctLbl.Name = "correctLbl";
            this.correctLbl.Size = new System.Drawing.Size(433, 16);
            this.correctLbl.TabIndex = 4;
            this.correctLbl.Text = "Correct, well done! Please click the \'Continue\' button for the next question";
            // 
            // contButton
            // 
            this.contButton.Location = new System.Drawing.Point(405, 242);
            this.contButton.Name = "contButton";
            this.contButton.Size = new System.Drawing.Size(96, 23);
            this.contButton.TabIndex = 5;
            this.contButton.Text = "Continue";
            this.contButton.UseVisualStyleBackColor = true;
            this.contButton.Click += new System.EventHandler(this.contButton_Click);
            // 
            // warnLbl
            // 
            this.warnLbl.AutoSize = true;
            this.warnLbl.ForeColor = System.Drawing.Color.Red;
            this.warnLbl.Location = new System.Drawing.Point(258, 278);
            this.warnLbl.Name = "warnLbl";
            this.warnLbl.Size = new System.Drawing.Size(467, 16);
            this.warnLbl.TabIndex = 6;
            this.warnLbl.Text = "Uh oh! That was wrong. You have one more try before the question is changed";
            // 
            // resetLbl
            // 
            this.resetLbl.AutoSize = true;
            this.resetLbl.Location = new System.Drawing.Point(185, 278);
            this.resetLbl.Name = "resetLbl";
            this.resetLbl.Size = new System.Drawing.Size(670, 16);
            this.resetLbl.TabIndex = 7;
            this.resetLbl.Text = "Doh! It looks like you got the answer wrong again. Please click the \'Continue\' bu" +
    "tton when you are done reviewing";
            // 
            // answerLbl
            // 
            this.answerLbl.AutoSize = true;
            this.answerLbl.Location = new System.Drawing.Point(433, 156);
            this.answerLbl.Name = "answerLbl";
            this.answerLbl.Size = new System.Drawing.Size(44, 16);
            this.answerLbl.TabIndex = 8;
            this.answerLbl.Text = "label1";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(911, 509);
            this.Controls.Add(this.answerLbl);
            this.Controls.Add(this.resetLbl);
            this.Controls.Add(this.warnLbl);
            this.Controls.Add(this.contButton);
            this.Controls.Add(this.correctLbl);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.answerButton);
            this.Controls.Add(this.answerTxtBox);
            this.Controls.Add(this.questionLbl);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label questionLbl;
        private System.Windows.Forms.TextBox answerTxtBox;
        private System.Windows.Forms.Button answerButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Label correctLbl;
        private System.Windows.Forms.Button contButton;
        private System.Windows.Forms.Label warnLbl;
        private System.Windows.Forms.Label resetLbl;
        private System.Windows.Forms.Label answerLbl;
    }
}

