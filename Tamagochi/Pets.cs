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
    public partial class Pets : Form
    {
        public Pets()
        {
            InitializeComponent();
        }
        private void button_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Button btn = (System.Windows.Forms.Button)sender;
            Form1.set_pet(btn.Name);
            this.Close();
        }
    }
}
