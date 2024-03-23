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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void btn_settings_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings();
            settings.ShowDialog();
        }

        private void btn_pets_Click(object sender, EventArgs e)
        {
            Pets pets = new Pets();
            pets.ShowDialog();
        }
        private void btn_prev_Click(object sender, EventArgs e)
        {
            if (tbc_menu.SelectedIndex > 0)
                tbc_menu.SelectedIndex--;
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            if (tbc_menu.SelectedIndex < tbc_menu.TabPages.Count)
                tbc_menu.SelectedIndex++;
        }

        private void tbc_menu_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
