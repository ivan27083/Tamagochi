using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tamagochi
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
            if (Tamagochi.check_state) { checkBox1.CheckState = CheckState.Checked; }
            else checkBox1.CheckState = CheckState.Unchecked;
        }
        private void trackBar_music_Scroll(object sender, EventArgs e)
        {
            Tamagochi.wmp.settings.volume = trackBar_music.Value * 10;
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Tamagochi.check_state = checkBox1.Checked;
        }
    }
}
