using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Tamagochi.Classes
{
    internal class Items
    {
        string name; // нейм
        int id; // айди
        int action; // акшенс

        public int get_id() { return id; }
        public void set_id(int value) { this.id = value; }
        public int get_action(){ return action;}
        public void set_action(int value){this.action = value;}
        public string get_name() { return name;}
        public void set_name(string value) { this.name = value;}

        public Items(string name_picbox)
        {
            if (!string.IsNullOrEmpty(name_picbox))
            {
                string[] parts = name_picbox.Split('_');
                if (parts.Length == 3)
                {
                    name = parts[0];
                    id = int.Parse(parts[1]);
                    action = int.Parse(parts[2]);
                }
            }
        }
    }
}
