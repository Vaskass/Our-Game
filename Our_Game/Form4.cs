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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        string[] upgradeBuf = new string[6];

        private void Form4_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.SForm.button4_Click(null, null);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Program.inv.Upg();
            Program.inv.Upgrade();
            Program.f3.UpBuff();
            Program.f4.Hide();
            Program.inv.Show();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.f4.Hide();
            Program.f1.Show();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            
        }

        public void UpgradeHelmet()
        {
            upgradeBuf[0] = (string)comboBox1.SelectedItem;
            comboBox1.Items.Clear();
            comboBox1.Items.Add("нет");
            for (int i = 0; i < Program.helmetselected.Length; i++)
            {
                for (int j = 0; j < 25; j++)
                {
                    if (Program.helmetselected[i] == Program.inventory[j])
                    {
                        comboBox1.Items.Add(Program.helmetselected[i]);
                    }
                }
            }
            comboBox1.SelectedItem = upgradeBuf[0];
            comboBox1_SelectedIndexChanged(null, null);
        }

        public void UpgradeArmor()
        {
            upgradeBuf[1] = (string)comboBox2.SelectedItem;
            comboBox2.Items.Clear();
            comboBox2.Items.Add("нет");
            for (int i = 0; i < Program.armorselected.Length; i++)
            {
                for (int j = 0; j < 25; j++)
                {
                    if (Program.armorselected[i] == Program.inventory[j])
                    {
                        comboBox2.Items.Add(Program.armorselected[i]);
                    }
                }
            }
            comboBox2.SelectedItem = upgradeBuf[1];
            comboBox2_SelectedIndexChanged(null, null);
        }

        public void UpgradeShield()
        {
            upgradeBuf[2] = (string)comboBox3.SelectedItem;
            comboBox3.Items.Clear();
            comboBox3.Items.Add("нет");
            for (int i = 0; i < Program.shieldselected.Length; i++)
            {
                for (int j = 0; j < 25; j++)
                {
                    if (Program.shieldselected[i] == Program.inventory[j])
                    {
                        comboBox3.Items.Add(Program.shieldselected[i]);
                    }
                }
            }
            comboBox3.SelectedItem = upgradeBuf[2];
            comboBox3_SelectedIndexChanged(null, null);
        }

        public void UpgradeWeapon()
        {
            upgradeBuf[3] = (string)Program.f3.comboBox1.SelectedItem;
            Program.f3.comboBox1.Items.Clear();
            Program.f3.comboBox1.Items.Add("нет");
            for (int i = 0; i < Program.weaponselected.Length; i++)
            {
                for (int j = 27; j < 31; j++)
                {
                    if (Program.weaponselected[i] == Program.inventory[j])
                    {
                        Program.f3.comboBox1.Items.Add(Program.weaponselected[i]);
                    }
                }
            }
            Program.f3.comboBox1.SelectedItem = upgradeBuf[3];
            Program.f3.comboBox1_SelectedIndexChanged(null, null);
        }

        public void UpgradeArtefucts()
        {
            upgradeBuf[4] = (string)comboBox5.SelectedItem;
            comboBox5.Items.Clear();
            comboBox5.Items.Add("нет");
            for (int i = 0; i < Program.artefucktselected.Length; i++)
            {
                for (int j = 0; j < 25; j++)
                {
                    if (Program.artefucktselected[i] == Program.inventory[j])
                    {
                        comboBox5.Items.Add(Program.artefucktselected[i]);
                    }
                }
            }
            comboBox5.SelectedItem = upgradeBuf[4];
            comboBox5_SelectedIndexChanged(null, null);
        }
        public void UpgradeStaff()
        {
            upgradeBuf[5] = (string)comboBox4.SelectedItem;
            comboBox4.Items.Clear();
            comboBox4.Items.Add("нет");
            for (int i = 0; i < Program.staffselected.Length; i++)
            {
                for (int j = 0; j < 25; j++)
                {
                    if (Program.staffselected[i] == Program.inventory[j])
                    {
                        comboBox4.Items.Add(Program.staffselected[i]);
                    }
                }
            }
            comboBox4.SelectedItem = upgradeBuf[5];
            comboBox4_SelectedIndexChanged(null, null);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Program.f4.Hide();
            Program.Map.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.Text)
            {
                case "Кожаный шлем":
                    pictureBox2.Image = Properties.Resources.helmet_leather_cap;
                    Program.helmetDef = 2;
                    break;
                case "Кольчужный шлем":
                    pictureBox2.Image = Properties.Resources.helmet_chain_coif;
                    Program.helmetDef = 15;
                    break;
                case "Железный шлем":
                    pictureBox2.Image = Properties.Resources.helmet_corinthian;
                    Program.helmetDef = 21;
                    break;
                case "Блестящий шлем":
                    pictureBox2.Image = Properties.Resources.helmet_shiny;
                    Program.helmetDef = 24;
                    break;
                default:
                    pictureBox2.Image = null;
                    Program.helmetDef = 0;
                    break;
            }
            updef();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox2.Text)
            {
                case "Кожаная броня":
                    pictureBox3.Image = Properties.Resources.armor_leather;
                    Program.armorDef = 4;
                    break;
                case "Кольчужная броня":
                    pictureBox3.Image = Properties.Resources.armor_chain;
                    Program.armorDef = 18;
                    break;
                case "Железная броня":
                    pictureBox3.Image = Properties.Resources.cuirass_muscled;
                    Program.armorDef = 28;
                    break;
                case "Доспех Богов":
                    pictureBox3.Image = Properties.Resources.steel_armor;
                    Program.armorDef = 41;
                    break;
                default:
                    pictureBox3.Image = null;
                    Program.armorDef = 0;
                    break;
            }
            updef();
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox5.Text)
            {
                case "Малый амулет здоровья":
                    pictureBox6.Image = Properties.Resources.amla_default;
                    break;
                case "Кольцо \"Моя прелесть\"":
                    pictureBox6.Image = Properties.Resources.ring_gold;
                    break;
                case "Браслет Удачи":
                    pictureBox6.Image = Properties.Resources.circlet_winged;
                    break;
                case "Кольцо некроманта":
                    pictureBox6.Image = Properties.Resources.skull_ring;
                    break;
                case "Большой амулет здоровья":
                    pictureBox6.Image = Properties.Resources.jewelry_necklace_amber;
                    break;
                case "Кольцо \"IYX\"":
                    pictureBox6.Image = Properties.Resources.jewelry_ring_prismatic;
                    break;
                default:
                    pictureBox6.Image = null;
                    break;
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox3.Text)
            {
                case "Деревянный щит":
                    pictureBox4.Image = Properties.Resources.shield_wooden;
                    Program.shieldDef = 3;
                    break;
                case "Бойцовский щит":
                    pictureBox4.Image = Properties.Resources.shield_polished;
                    Program.shieldDef = 14;
                    break;
                case "Железный щит":
                    pictureBox4.Image = Properties.Resources.shield_steel;
                    Program.shieldDef = 22;
                    break;
                case "Адский щит":
                    pictureBox4.Image = Properties.Resources.shield_tower;
                    Program.shieldDef = 29;
                    break;
                default:
                    pictureBox4.Image = null;
                    Program.shieldDef = 0;
                    break;
            }
            updef();
        }
        public void updef()
        {
            label1.Text = "Общая защита: " + (Program.armorDef + Program.helmetDef + Program.shieldDef);
        }
        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox4.Text)
            {
                case "Посох ученика":
                    pictureBox5.Image = Properties.Resources.staff_magic;
                    break;
                case "Посох шамана":
                    pictureBox5.Image = Properties.Resources.staff_green;
                    break;
                case "Посох некроманта":
                    pictureBox5.Image = Properties.Resources.staff_plague;
                    break;
                case "Рубиновый посох":
                    pictureBox5.Image = Properties.Resources.staff_ruby;
                    break;
                default:
                    pictureBox5.Image = null;
                    break;
            }
        }



        private void HPtimer_Tick(object sender, EventArgs e)
        {

            if (Program.HP < Program.maxHP)
            {
                Program.HP++;
                progressBar1.Maximum = Program.maxHP;
                progressBar1.Value = Program.HP;
                label7.Text = Program.HP + "/" + Program.maxHP;
            }
            else
                HPtimer.Stop();
        }

        private void Form4_VisibleChanged(object sender, EventArgs e)
        {
            if (Program.person == 1)
            {
                pictureBox1.Image = Properties.Resources.haldric_ii;
            }
            if (Program.person == 2)
                pictureBox1.Image = Properties.Resources.human_princess;

            

            progressBar1.Maximum = Program.maxHP;
            progressBar1.Value = Program.HP;
            label7.Text = Program.HP + "/" + Program.maxHP;
            Program.Save(4);
            label8.Text = "Деньги: " + Program.money;
             while (Program.Exp >= Program.maxExp)
            {
                Program.Exp -= Program.maxExp;
                Program.level++;
                Program.maxSteps++;
                Program.maxHP = Program.maxHP + (int)Math.Round(Program.maxHP * 0.2, 0);
                Program.maxExp = Program.maxExp+ (int)Math.Round(Program.maxExp * 0.15, 0);
                Program.HP = Program.maxHP;
            }
            label9.Text = "Ур: " + Program.level + " Опыт: " + Program.Exp + "/" + Program.maxExp;
            progressBar1.Maximum = Program.maxHP;
            progressBar1.Value = progressBar1.Maximum;
            progressBar1.Maximum = Program.maxHP;
            progressBar1.Value = Program.HP;
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.SForm.Show();
        }

        private void обИгреToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Разработчики: студенты группы ИС-16-31 \nХандамов А̹̘͙̳̗ͮͭͬ̌͜͞м̘̝͇͔̟͡иͦ̀р̭͖͉̜̓̊ͫх̻͙̀͘͜а̨ͧͬ́н̢̨͈ͦ̏̇͌͢͟͠ и Скороходов В̛̛̜͈ͬа̴̰̻͍̲̕с̵̛͖̮̬и͕л̞̪̝̅и̸̵̣ͩ͐̿̑ͦ͜й͐͛ͩ́\n", "Об игре!", MessageBoxButtons.OK, MessageBoxIcon.None);
        }
    }
}
