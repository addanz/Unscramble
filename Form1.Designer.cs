namespace Unscramble
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.LabelScrambledWord = new System.Windows.Forms.Label();
            this.TextBoxUserGuess = new System.Windows.Forms.TextBox();
            this.ButtonSubmitGuess = new System.Windows.Forms.Button();
            this.LabelCorrectOrIncorrect = new System.Windows.Forms.Label();
            this.ButtonGetHint = new System.Windows.Forms.Button();
            this.LabelDisplayHint = new System.Windows.Forms.Label();
            this.LabelScore = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LabelScrambledWord
            // 
            this.LabelScrambledWord.AutoSize = true;
            this.LabelScrambledWord.Location = new System.Drawing.Point(455, 161);
            this.LabelScrambledWord.Name = "LabelScrambledWord";
            this.LabelScrambledWord.Size = new System.Drawing.Size(170, 20);
            this.LabelScrambledWord.TabIndex = 0;
            this.LabelScrambledWord.Text = "Label Scrambled Word";
            // 
            // TextBoxUserGuess
            // 
            this.TextBoxUserGuess.Location = new System.Drawing.Point(422, 285);
            this.TextBoxUserGuess.Name = "TextBoxUserGuess";
            this.TextBoxUserGuess.Size = new System.Drawing.Size(233, 26);
            this.TextBoxUserGuess.TabIndex = 1;
            // 
            // ButtonSubmitGuess
            // 
            this.ButtonSubmitGuess.Location = new System.Drawing.Point(459, 343);
            this.ButtonSubmitGuess.Name = "ButtonSubmitGuess";
            this.ButtonSubmitGuess.Size = new System.Drawing.Size(150, 50);
            this.ButtonSubmitGuess.TabIndex = 2;
            this.ButtonSubmitGuess.Text = "Submit";
            this.ButtonSubmitGuess.UseVisualStyleBackColor = true;
            this.ButtonSubmitGuess.Click += new System.EventHandler(this.ButtonSubmitGuess_Click);
            // 
            // LabelCorrectOrIncorrect
            // 
            this.LabelCorrectOrIncorrect.AutoSize = true;
            this.LabelCorrectOrIncorrect.Location = new System.Drawing.Point(481, 491);
            this.LabelCorrectOrIncorrect.Name = "LabelCorrectOrIncorrect";
            this.LabelCorrectOrIncorrect.Size = new System.Drawing.Size(128, 20);
            this.LabelCorrectOrIncorrect.TabIndex = 3;
            this.LabelCorrectOrIncorrect.Text = "Correct/Incorrect";
            // 
            // ButtonGetHint
            // 
            this.ButtonGetHint.Location = new System.Drawing.Point(492, 419);
            this.ButtonGetHint.Name = "ButtonGetHint";
            this.ButtonGetHint.Size = new System.Drawing.Size(97, 32);
            this.ButtonGetHint.TabIndex = 4;
            this.ButtonGetHint.Text = "Get Hint";
            this.ButtonGetHint.UseVisualStyleBackColor = true;
            this.ButtonGetHint.Click += new System.EventHandler(this.ButtonGetHint_Click);
            // 
            // LabelDisplayHint
            // 
            this.LabelDisplayHint.AutoSize = true;
            this.LabelDisplayHint.Location = new System.Drawing.Point(488, 247);
            this.LabelDisplayHint.Name = "LabelDisplayHint";
            this.LabelDisplayHint.Size = new System.Drawing.Size(93, 20);
            this.LabelDisplayHint.TabIndex = 5;
            this.LabelDisplayHint.Text = "Display Hint";
            // 
            // LabelScore
            // 
            this.LabelScore.AutoSize = true;
            this.LabelScore.Location = new System.Drawing.Point(507, 46);
            this.LabelScore.Name = "LabelScore";
            this.LabelScore.Size = new System.Drawing.Size(51, 20);
            this.LabelScore.TabIndex = 6;
            this.LabelScore.Text = "Score";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 669);
            this.Controls.Add(this.LabelScore);
            this.Controls.Add(this.LabelDisplayHint);
            this.Controls.Add(this.ButtonGetHint);
            this.Controls.Add(this.LabelCorrectOrIncorrect);
            this.Controls.Add(this.ButtonSubmitGuess);
            this.Controls.Add(this.TextBoxUserGuess);
            this.Controls.Add(this.LabelScrambledWord);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Unscramble";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelScrambledWord;
        private System.Windows.Forms.TextBox TextBoxUserGuess;
        private System.Windows.Forms.Button ButtonSubmitGuess;
        private System.Windows.Forms.Label LabelCorrectOrIncorrect;
        private System.Windows.Forms.Button ButtonGetHint;
        private System.Windows.Forms.Label LabelDisplayHint;
        private System.Windows.Forms.Label LabelScore;
    }
}

