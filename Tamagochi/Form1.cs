using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tamagochi.Classes;

namespace Tamagochi
{
    public partial class Form1 : Form
    {
        Pet pet;
        int current_room;

        public Form1()
        {
            InitializeComponent();
            out_file();
            ((Control)pb_pet).AllowDrop = true;
            if (pet.get_name() == "dog") pb_pet.BackgroundImage = new Bitmap(Properties.Resources.dog);
            else if (pet.get_name() == "lion") pb_pet.BackgroundImage = new Bitmap(Properties.Resources.lion);
            else if (pet.get_name() == "cow") pb_pet.BackgroundImage = new Bitmap(Properties.Resources.cow);
            else if (pet.get_name() == "tiger") pb_pet.BackgroundImage = new Bitmap(Properties.Resources.tiger);
            timer.Start();
            current_room = 0;
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
            tbc_menu.SelectedIndex = current_room;
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
        private void item_MouseDown(object sender, MouseEventArgs e)
        {
            System.Windows.Forms.PictureBox pic = (System.Windows.Forms.PictureBox)sender;
            pic.DoDragDrop(pic.Name, DragDropEffects.Copy | DragDropEffects.Move);
        }
        private void pet_DragEnter(object sender, DragEventArgs e)
        {
            if(e.Data.GetDataPresent(DataFormats.Text)) e.Effect = DragDropEffects.Copy;
            else e.Effect = DragDropEffects.None;
            
        }
        private void pet_DragDrop(object sender, DragEventArgs e)
        {
            System.Windows.Forms.PictureBox pic = (System.Windows.Forms.PictureBox)sender;
            pet.get_item(e.Data.GetData(DataFormats.Text).ToString());
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            pb_health.Value = pet.get_hp();
        }
        public void in_file()
        {
            string file_path = "in.txt";
            string name = pet.get_name();

            if (!File.Exists(file_path))
                File.Create(file_path).Close();
            File.WriteAllText(file_path, $"{name},{DateTime.Now.ToString()}");
            pet.in_file();
        }

        public void out_file()
        {
            string file_path = "in.txt";
            if (File.Exists(file_path))
            {
                StreamReader reader = new StreamReader(file_path);
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] values = line.Split(',');
                    if (values.Length == 2)
                    {
                        string name = values[0];
                        pet = new Pet(name);
                        DateTime time = DateTime.Parse(values[1]);
                    }
                }
                reader.Close();
            }
            else
            {
                pet = new Pet();
            }
            
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            in_file();
        }
    }
}
