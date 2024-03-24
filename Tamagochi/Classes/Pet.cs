using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tamagochi.Classes
{
    internal class Pet
    {
        string name { get; set; }//dog tiger lion 
        int id { get; set; }
        int hp { get; set; }
        int hunger { get; set; }
        int experience { get;set; }


        void decrease_hunger(int food)
        {
            if (food==1) hunger--;
            //if яблоко hunger-=1;  if кекс hunger-=2; if курица hunger-=3; if хотдог hunger-=2; if салат hunger-=1;
        }

        void increase_hp()
        {
            //if шприц 
            hp--;
        }

    }
}
