using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Our_Game
{
    public partial class Map : Form
    {
        public Map()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.f3.BackgroundImage = Properties.Resources.landscape_bridge;
            if (Program.map1 % 25 == 0 && Program.map1 != 0)
            {
                Program.Map.Hide();
                Program.ivent = 7;
                Program.f3.Show();
            }
            else
            {
                Program.Map.Hide();
                Program.ivent = 2;
                Program.f3.Show();
            }
        }

        private void button1_VisibleChanged(object sender, EventArgs e)
        {
            mapUpd();
        }
        private void mapUpd()
        {
            label1.Text = "Уровней: " + Program.map1;
            if (Program.map1 > 29)
                button2.Enabled = true;
            else button2.Enabled = false;
            label2.Text = "Уровней: " + Program.map2;
            if (Program.map2 > 29)
                button3.Enabled = true;
            else button3.Enabled = false;
            label3.Text = "Уровней: " + Program.map3;
            if (Program.map3 > 29)
                button4.Enabled = true;
            else button4.Enabled = false;
            label4.Text = "Уровней: " + Program.map4;
            if (Program.map4 > 29)
                button5.Enabled = true;
            else button5.Enabled = false;
            label5.Text = "Уровней: " + Program.map5;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Program.f3.BackgroundImage = Properties.Resources.grim_altar;
            if (Program.map2 % 25 == 0 && Program.map2 != 0)
            {
                Program.Map.Hide();
                Program.ivent = 8;
                Program.f3.Show();
            }
            else
            {
                Program.Map.Hide();
                Program.ivent = 3;
                Program.f3.Show();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Program.f3.BackgroundImage = Properties.Resources.landscape_castle;
            if (Program.map3 % 25 == 0 && Program.map3 != 0)
            {
                Program.Map.Hide();
                Program.ivent = 9;
                Program.f3.Show();
            }
            else
            {
                Program.Map.Hide();
                Program.ivent = 4;
                Program.f3.Show();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Program.f3.BackgroundImage = Properties.Resources.landscape_plain;
            if (Program.map4 % 25 == 0 && Program.map4 != 0)
            {
                Program.Map.Hide();
                Program.ivent = 10;
                Program.f3.Show();
            }
            else
            {
                Program.Map.Hide();
                Program.ivent = 5;
                Program.f3.Show();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Program.f3.BackgroundImage = Properties.Resources.swamp_03;
            if (Program.map5 % 25 == 0 && Program.map5 != 0)
            {
                Program.Map.Hide();
                Program.ivent = 11;
                Program.f3.Show();
            }
            else
            {
                Program.Map.Hide();
                Program.ivent = 6;
                Program.f3.Show();
            }
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.Map.Hide();
            Program.f4.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Program.Map.Hide();
            Program.f5.Show();
        }

        private void Map_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.SForm.button4_Click(null, null);
        }
    }
}
