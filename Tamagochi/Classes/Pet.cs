using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tamagochi.Classes
{
    internal class Pet
    {
        string name;//dog tiger lion 
        int id;
        int hp;
        int satiety;
        int experience;
        int clean;
        int happy;

        public int get_id() { return id; }
        public void set_id(int value) { this.id = value; }
        public string get_name() { return name; }
        public void set_name(string value) { this.name = value; }
        public int get_hp() { return hp; }
        public void set_hp(int value) { this.hp = value; }
        public int get_satiety() { return satiety; }
        public void set_satiety(int value) { this.satiety = value; }
        public int get_experience() { return experience; }
        public void set_experience(int value) { this.experience = value; }
        public int get_clean() { return clean; }
        public void set_clean(int value) { this.clean = value; }
        public int get_happy() { return happy; }
        public void set_happy(int value) { this.happy = value; }

        public Pet()
        {
            name = "dog";
            id = 0;
            hp = 100;
            satiety = 100;
            experience = 0;
            clean = 100;
            happy = 100;
        }

        public Pet(string new_name)
        {
            name = new_name;
            out_file();
        }

        //сохранение в файл и загрузка из файла
        public void in_file()
        {
            string file_path = name + ".txt";
            if (!File.Exists(file_path))
                File.Create(file_path).Close();

            StreamWriter sw = new StreamWriter(file_path, true, Encoding.ASCII);
            sw.WriteLine($"{id},{hp},{satiety},{experience},{clean},{happy}");
        }

        public void out_file()
        {
            string file_path = name + ".txt";
            if (File.Exists(file_path))
            {
                StreamReader reader = new StreamReader(file_path);
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] values = line.Split(',');
                    if (values.Length == 6)
                    {
                        id = int.Parse(values[0]);
                        hp = int.Parse(values[1]);
                        satiety = int.Parse(values[2]);
                        experience = int.Parse(values[3]);
                        clean = int.Parse(values[4]);
                        happy = int.Parse(values[5]);
                    }
                }
            }
            else
            {
                hp = 100;
                satiety = 100;
                experience = 0;
                clean = 100;
                happy = 100;
            }
        }



        void decrease_satiety(int food)
        {
            if (food==1) satiety--;
            //if яблоко hunger-=1;  if кекс hunger-=2; if курица hunger-=3; if хотдог hunger-=2; if салат hunger-=1;
        }

        void increase_hp()
        {
            //if шприц 
            hp--;
        }

        void increase_experience(int a)
        {
            experience += a;
            if (experience%100==0)
            {
                //менять label с уровнем и его progressbar
            }
        }

        public void update_time(DateTime prevtime)
        {
            int prev_sat = satiety;
            TimeSpan time = DateTime.Now - prevtime;
            int x = int.Parse(time.TotalHours.ToString());

            int interval =(int)Math.Ceiling(prev_sat / 5.0);
            if (x > interval)
            {
                x -= interval;
                satiety = 0;
                if (hp - x > 10) hp -= x;
                else hp = 10;
            }
            else satiety -= x * 5;
        }

        public void update()
        {
            /*TimeSpan time = DateTime.Now - prevtime;
            int x = int.Parse(time.TotalHours.ToString());
            //проверка с таймеро
            if (satiety <= 0) 
                hp-=10;//каждые 5 минут
            */
        }

        public void get_item(string name_picbox)
        {
            Items item = new Items(name_picbox);
            int var = item.get_id();
            int act = item.get_action();
            switch (var)
            {
                case 1://душ 
                    if (clean + act <= 100) { clean += act; increase_experience(act); }
                    else clean = 100;
                    break;
                case 2: //кухня 
                    if (satiety + act <=100) { satiety += act; increase_experience(act); }
                    else satiety = 100;
                    break;
                case 3: //лечение 
                    if (hp + act <= 100) {hp += act; increase_experience(act); }
                    else hp = 100;
                    break;
                case 4://игра 
                    if (happy + act <= 100) { happy += act; increase_experience(act); }
                    else happy = 100;
                    break;

            }
        }

     
    }


}
