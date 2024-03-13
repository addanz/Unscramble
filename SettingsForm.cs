using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unscramble
{
    public partial class SettingsForm : Form
    {
        public int Difficulty { get; private set; }

        public SettingsForm()
        {
            InitializeComponent();
            LoadSettings();

        }
        private void LoadSettings()
        {
            //place for loading difficulty, we are setting it default for now, will update in near future
            Difficulty = 1; 
            NumericUpDownDifficulty.Value = Difficulty;
        }

        private void ButtonOkDifficulty_Click(object sender, EventArgs e)
        {
            Difficulty = (int)NumericUpDownDifficulty.Value;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void ButtonCancelDifficulty_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
