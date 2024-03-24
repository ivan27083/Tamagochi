using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tamagochi
{
    public partial class Form1 : Form
    {
        static string[] rooms = { "Bath", "Kitchen", "Heal", "Play" };
        int current_room;
        GroupBox[] groupBoxes = new GroupBox[4];
        public Form1()
        {
            InitializeComponent();
            current_room = 0;
            groupBoxes[0] = gb_1;
            groupBoxes[1] = gb_2;
            groupBoxes[2] = gb_3;
            groupBoxes[3] = gb_4;
            for (int i = 0; i < groupBoxes.Length; i++)
            {
                groupBoxes[i].Visible = false;
            }
            groupBoxes[current_room].Visible = true;
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
            if (current_room > 0) current_room--;
            check_room();
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            if (current_room < 3) current_room++;
            check_room();
        }
        private void check_room()
        {
            switch (current_room)
            {
                case 0:
                    this.BackgroundImage = new Bitmap(Properties.Resources.bath_fon);
                    break;
                case 1:
                    this.BackgroundImage = new Bitmap(Properties.Resources.eat_fon);
                    break;
                case 2:
                    this.BackgroundImage = new Bitmap(Properties.Resources.hospital_fon);
                    break;
                case 3:
                    this.BackgroundImage = new Bitmap(Properties.Resources.game_fon);
                    break;
                default: 
                    break;
            }
            for (int i = 0; i < groupBoxes.Length; i++) { groupBoxes[i].Visible = false; }
            groupBoxes[current_room].Visible = true;
        }

        private void btn_bath_Click(object sender, EventArgs e)
        {
            current_room = 0;
            check_room();
        }

        private void btn_kitchen_Click(object sender, EventArgs e)
        {
            current_room = 1;
            check_room();
        }

        private void btn_heal_Click(object sender, EventArgs e)
        {
            current_room = 2;
            check_room();
        }

        private void btn_play_Click(object sender, EventArgs e)
        {
            current_room = 3;
            check_room();
        }
    }
}
