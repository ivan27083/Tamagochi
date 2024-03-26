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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using System.Media;
using WMPLib;
namespace Tamagochi
{
    public partial class Tamagochi : Form
    {
        static Pet pet;
        int current_room;
        public string check_name;
        public static WindowsMediaPlayer wmp;
        
        public Tamagochi()
        {
            InitializeComponent();
            out_file();
            ((Control)pb_pet).AllowDrop = true;
            update_pet_image();
            timer.Start();
            current_room = 0;
            update_progress();
            tbc_menu.DrawMode = TabDrawMode.OwnerDrawFixed;
            wmp_init();
        }
        public static void set_pet(string str)
        {
            pet = new Pet(str);
        }
        private void wmp_init()
        {
            wmp = new WindowsMediaPlayer();
            wmp.URL = @"C:\Учеба\2 курс\2 семестр\Практика\Tamagochi\Tamagochi\Resources\music.wav";
            wmp.controls.play();
            wmp.settings.setMode("loop", true);
        }
        void update_progress()
        {
            pb_health.Value = pet.get_hp();
            pb_hunger.Value = pet.get_satiety();
            pb_happiness.Value = pet.get_happy();
            pb_cleanliness.Value = pet.get_clean();
            lb_lvl.Text = "Lvl. " + pet.get_lvl().ToString();
            pb_exp.Value = pet.get_experience();
        }
        private void update_pet_image()
        {
            if (pet.get_name() == "dog") pb_pet.BackgroundImage = new Bitmap(Properties.Resources.dog);
            else if (pet.get_name() == "lion") pb_pet.BackgroundImage = new Bitmap(Properties.Resources.lion);
            else if (pet.get_name() == "cow") pb_pet.BackgroundImage = new Bitmap(Properties.Resources.cow);
            else if (pet.get_name() == "tiger") pb_pet.BackgroundImage = new Bitmap(Properties.Resources.tiger);
        }
        private void btn_settings_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings();
            settings.ShowDialog();
        }

        private void btn_pets_Click(object sender, EventArgs e)
        {
            in_file();
            Pets pets = new Pets();
            pets.ShowDialog();
            update_pet_image();
            update_progress();
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
            update_progress();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            pet.update();
            update_progress();
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
                DateTime time;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] values = line.Split(',');
                    if (values.Length == 2)
                    {
                        string name = values[0];
                        pet = new Pet(name);
                        time = DateTime.Parse(values[1]);
                        pet.update_time(time);
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

        private void tbc_menu_SelectedIndexChanged(object sender, EventArgs e)
        {
            current_room = tbc_menu.SelectedIndex;
            check_room();
        }

        private void tbc_menu_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.Graphics.SetClip(e.Bounds);
            string text = tbc_menu.TabPages[e.Index].Text;
            SizeF sz = e.Graphics.MeasureString(text, e.Font);
            System.Drawing.Color color;
            switch (current_room)
            {
                case 0: color = System.Drawing.Color.Bisque;
                    break;
                case 1: color = System.Drawing.Color.Lavender;
                    break;
                case 2:
                    color = System.Drawing.Color.MistyRose;
                    break;
                case 3:
                    color = System.Drawing.Color.Khaki;
                    break;
                default: color = System.Drawing.Color.White; break;
            }
            bool bSelected = (e.State & DrawItemState.Selected) == DrawItemState.Selected;
            using (SolidBrush b = new SolidBrush(bSelected ? color : System.Drawing.Color.SeaShell))
                e.Graphics.FillRectangle(b, e.Bounds);

            using (SolidBrush b = new SolidBrush(bSelected ? SystemColors.ControlText : SystemColors.ControlText))
                e.Graphics.DrawString(text, e.Font, b, e.Bounds.X + 2, e.Bounds.Y + (e.Bounds.Height - sz.Height) / 2);

            if (tbc_menu.SelectedIndex == e.Index)
                e.DrawFocusRectangle();

            e.Graphics.ResetClip();
        }
    }
}