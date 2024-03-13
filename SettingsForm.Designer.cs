namespace Unscramble
{
    partial class SettingsForm
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
            this.NumericUpDownDifficulty = new System.Windows.Forms.NumericUpDown();
            this.ButtonOkDifficulty = new System.Windows.Forms.Button();
            this.ButtonCancelDifficulty = new System.Windows.Forms.Button();
            this.LabelDifficulty = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownDifficulty)).BeginInit();
            this.SuspendLayout();
            // 
            // NumericUpDownDifficulty
            // 
            this.NumericUpDownDifficulty.Location = new System.Drawing.Point(322, 179);
            this.NumericUpDownDifficulty.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.NumericUpDownDifficulty.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumericUpDownDifficulty.Name = "NumericUpDownDifficulty";
            this.NumericUpDownDifficulty.Size = new System.Drawing.Size(114, 26);
            this.NumericUpDownDifficulty.TabIndex = 1;
            this.NumericUpDownDifficulty.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // ButtonOkDifficulty
            // 
            this.ButtonOkDifficulty.Location = new System.Drawing.Point(279, 241);
            this.ButtonOkDifficulty.Name = "ButtonOkDifficulty";
            this.ButtonOkDifficulty.Size = new System.Drawing.Size(75, 39);
            this.ButtonOkDifficulty.TabIndex = 2;
            this.ButtonOkDifficulty.Text = "Ok";
            this.ButtonOkDifficulty.UseVisualStyleBackColor = true;
            this.ButtonOkDifficulty.Click += new System.EventHandler(this.ButtonOkDifficulty_Click);
            // 
            // ButtonCancelDifficulty
            // 
            this.ButtonCancelDifficulty.Location = new System.Drawing.Point(405, 241);
            this.ButtonCancelDifficulty.Name = "ButtonCancelDifficulty";
            this.ButtonCancelDifficulty.Size = new System.Drawing.Size(75, 39);
            this.ButtonCancelDifficulty.TabIndex = 3;
            this.ButtonCancelDifficulty.Text = "Cancel";
            this.ButtonCancelDifficulty.UseVisualStyleBackColor = true;
            this.ButtonCancelDifficulty.Click += new System.EventHandler(this.ButtonCancelDifficulty_Click);
            // 
            // LabelDifficulty
            // 
            this.LabelDifficulty.AutoSize = true;
            this.LabelDifficulty.Location = new System.Drawing.Point(343, 42);
            this.LabelDifficulty.Name = "LabelDifficulty";
            this.LabelDifficulty.Size = new System.Drawing.Size(69, 20);
            this.LabelDifficulty.TabIndex = 4;
            this.LabelDifficulty.Text = "Difficulty";
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LabelDifficulty);
            this.Controls.Add(this.ButtonCancelDifficulty);
            this.Controls.Add(this.ButtonOkDifficulty);
            this.Controls.Add(this.NumericUpDownDifficulty);
            this.Name = "SettingsForm";
            this.Text = "SettingsForm";
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownDifficulty)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown NumericUpDownDifficulty;
        private System.Windows.Forms.Button ButtonOkDifficulty;
        private System.Windows.Forms.Button ButtonCancelDifficulty;
        private System.Windows.Forms.Label LabelDifficulty;
    }
}