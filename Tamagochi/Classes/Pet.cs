using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tamagochi.Classes
{
    public class Pet
    {
        string name;//dog tiger lion 
        int id;
        int hp;
        int satiety;
        int experience;
        int clean;
        int happy;
        int lvl;

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
        public int get_lvl() { return lvl; }
        public void set_lvl(int value) { this.lvl = value; }

        public Pet()
        {
            name = "dog";
            id = 0;
            hp = 100;
            satiety = 100;
            experience = 0;
            clean = 100;
            happy = 100;
            lvl = 1;
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
            string s= $"{id},{hp},{satiety},{experience},{clean},{happy},{lvl}";
            File.WriteAllText(file_path, s);
            //StreamWriter sw = new StreamWriter(file_path, true, Encoding.ASCII);
            //sw.WriteLine($"{1},{2},{3},{4},{5},{6}",id, hp, satiety, experience, clean, happy);
            //sw.WriteLine(s);
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
                    if (values.Length == 7)
                    {
                        id = int.Parse(values[0]);
                        hp = int.Parse(values[1]);
                        satiety = int.Parse(values[2]);
                        experience = int.Parse(values[3]);
                        clean = int.Parse(values[4]);
                        happy = int.Parse(values[5]);
                        lvl = int.Parse(values[6]);
                    }
                }
                reader.Close();
            }
            else
            {
                hp = 100;
                satiety = 100;
                experience = 0;
                clean = 100;
                happy = 100;
                lvl = 1;
            }
        }


        void increase_experience(int a)
        {
            experience += a;
            if (experience >= 100)
            {
                experience -= 100;
                lvl++;
            }
        }

        public void update_time(DateTime prevtime)
        {
            int prev_sat = satiety;
            TimeSpan time = DateTime.Now - prevtime;
            int x = Convert.ToInt32(double.Parse(time.TotalHours.ToString()));

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
            if (satiety >= 5) satiety -= 5;
            else satiety = 0;
            if (clean >=1) clean--;
            else clean = 0;
            if (happy >=2) happy-=2;
            else happy = 0;

            if (satiety <= 0 && hp >= 5) hp -= 5;
            else if (satiety <= 0 && hp < 5) hp = 0;

            if (clean <= 0 && hp >= 1) hp --;
            else if (clean <= 0 && hp < 1) hp = 0;

            if (happy <= 0 && hp >= 2) hp -= 2;
            else if (happy <= 0 && hp < 2) hp = 0;

            if (hp == 0)
            {
                MessageBox.Show("Ваш питомец сбежал!","Упс...");
                string file_path = name + ".txt";
                File.Delete(file_path);
                Pets pets = new Pets();
                pets.ShowDialog();
            }
        }

        public int get_item(string name_picbox)
        {
            Items item = new Items(name_picbox);
            int var = item.get_id();
            int act = item.get_action();
            switch (var)
            {
                case 1://душ 
                    if (clean != 100)
                    {
                        if (clean + act <= 100) clean += act;
                        else clean = 100;
                        increase_experience(5);
                        return 0;
                    }
                    else return 1;
                case 2: //кухня няма няма
                    if (satiety != 100)
                    {
                        if (satiety + act <= 100) satiety += act;
                        else satiety = 100;

                        if (clean - act / 2 >= 0) clean -= act / 2;
                        else clean = 0;
                        increase_experience(10);
                        return 0;
                    }
                    else return 1;
                case 3: //лечение 
                    if (hp != 100)
                    {
                        if (hp + act <= 100) hp += act;
                        else hp = 100;

                        if (happy - 5 >= 0) happy -= 5;
                        else happy = 0;
                        increase_experience(5);
                        return 0;
                    }
                    else return 1;
                case 4://игра
                    if (happy != 100)
                    {
                        if (happy + act <= 100)
                        {
                            happy += act;
                        }
                        else happy = 100;

                        if (satiety - act >= 0) satiety -= act;
                        else satiety = 0;
                        if (clean - act / 2 >= 0) clean -= act / 2;
                        else clean = 0;
                        increase_experience(20);
                        return 0;
                    }
                    else return 1;
                default: return 1;
            }
        }

     
    }


}
