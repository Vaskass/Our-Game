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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)// настройка всех начальных параметров и начало игры
        {
            Program.Name = textBox1.Text;
            if (Program.Name == "")
                Program.Name = "Jo-jo";
            Program.maxHP = 100;
            Program.maxMP = 1;
            Program.HP = 75;
            Program.MP = 0;
            Program.maxSteps = 10;
            Program.ivent = 1;
            Program.EnemyType = 1;
            for (int i = 0; i < 35; i++)
            {
                Program.inventory[i] = "";
                Program.selecteditem[i] = 0;
            }
            Program.f4.UpgradeArmor();
            Program.f4.UpgradeArtefucts();
            Program.f4.UpgradeHelmet();
            Program.f4.UpgradeShield();
            Program.f4.UpgradeWeapon();
            Program.f4.UpgradeStaff();
            Program.map1 = 0;
            Program.map2 = 0;
            Program.map3 = 0;
            Program.map4 = 0;
            Program.map5 = 0;
            Program.f3.BackgroundImage = Properties.Resources.landscape_bridge;

            Program.f2.Hide();
            Program.f3.Show();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.SForm.button4_Click(null, null);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e) //выбор человека
        {
            if (radioButton1.Enabled == true)
            {
                pictureBox1.Image = Properties.Resources.haldric_ii;
                Program.person = 1;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e) //выбор девушки
        {
            if (radioButton2.Enabled == true)
            {
                pictureBox1.Image = Properties.Resources.human_princess;
                Program.person = 2;
            }
        }
    }
}
