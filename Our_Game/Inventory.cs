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
    public partial class Inventory : Form
    {
        public Inventory()
        {
            InitializeComponent();
            Program.pageInventory = 1;
        }
        public static int selected = 0, dropselected = 0, dropselectedtwo = 0;
        public static string select = "", selecttwo = "";
        int i = 0;
        Bitmap picture = null;
        public void Upgrade()
        {
            i = 33;
            Up();
            pictureBox18.Image = picture;

            i = 32;
            Up();
            pictureBox17.Image = picture;

            i = 31;
            Up();
            pictureBox16.Image = picture;

            i = 30;
            Up();
            pictureBox15.Image = picture;

            i = 29;
            Up();
            pictureBox14.Image = picture;

            i = 28;
            Up();
            pictureBox13.Image = picture;

            if (Program.pageInventory == 1)
            {
                i = 12;
                Up();
                pictureBox12.Image = picture;

                i = 11;
                Up();
                pictureBox11.Image = picture;

                i = 10;
                Up();
                pictureBox10.Image = picture;

                i = 9;
                Up();
                pictureBox9.Image = picture;

                i = 8;
                Up();
                pictureBox8.Image = picture;

                i = 7;
                Up();
                pictureBox7.Image = picture;

                i = 6;
                Up();
                pictureBox6.Image = picture;

                i = 5;
                Up();
                pictureBox5.Image = picture;

                i = 4;
                Up();
                pictureBox4.Image = picture;

                i = 3;
                Up();
                pictureBox3.Image = picture;

                i = 2;
                Up();
                pictureBox2.Image = picture;

                i = 1;
                Up();
                pictureBox1.Image = picture;
            }
            if (Program.pageInventory == 2)
            {



                i = 24;
                Up();
                pictureBox12.Image = picture;

                i = 23;
                Up();
                pictureBox11.Image = picture;

                i = 22;
                Up();
                pictureBox10.Image = picture;

                i = 21;
                Up();
                pictureBox9.Image = picture;

                i = 20;
                Up();
                pictureBox8.Image = picture;

                i = 19;
                Up();
                pictureBox7.Image = picture;

                i = 18;
                Up();
                pictureBox6.Image = picture;

                i = 17;
                Up();
                pictureBox5.Image = picture;

                i = 16;
                Up();
                pictureBox4.Image = picture;

                i = 15;
                Up();
                pictureBox3.Image = picture;

                i = 14;
                Up();
                pictureBox2.Image = picture;

                i = 13;
                Up();
                pictureBox1.Image = picture;
            }




        }

        public void Up()
        {
            switch ((string)Program.inventory[i])
            {
                case "Дубинка":
                    picture = Properties.Resources.CLUB;
                    break;
                case "Ржавый кинжал":
                    picture = Properties.Resources.dagger_undead;
                    break;
                case "Топор":
                    picture = Properties.Resources.axe_undead;
                    break;
                case "Меч":
                    picture = Properties.Resources.sword_human;
                    break;
                case "Булава":
                    picture = Properties.Resources.mace_spiked;
                    break;
                case "Кинжал ассасина":
                    picture = Properties.Resources.dagger_orcish;
                    break;
                case "Боевой топор":
                    picture = Properties.Resources.battleaxe;
                    break;
                case "Пика(чу)":
                    picture = Properties.Resources.PIKE;
                    break;
                case "Палица":
                    picture = Properties.Resources.MACE;
                    break;
                case "Рубиновый меч":
                    picture = Properties.Resources.SCIMITAR;
                    break;
                case "Святой меч":
                    picture = Properties.Resources.sword_holy;
                    break;
                case "Кожаная броня":
                    picture = Properties.Resources.armor_leather;
                    break;
                case "Кожаный шлем":
                    picture = Properties.Resources.helmet_leather_cap;
                    break;
                case "Деревянный щит":
                    picture = Properties.Resources.shield_wooden;
                    break;
                case "Кольчужная броня":
                    picture = Properties.Resources.armor_chain;
                    break;
                case "Кольчужный шлем":
                    picture = Properties.Resources.helmet_chain_coif;
                    break;
                case "Бойцовский щит":
                    picture = Properties.Resources.shield_polished;
                    break;
                case "Железная броня":
                    picture = Properties.Resources.cuirass_muscled;
                    break;
                case "Железный шлем":
                    picture = Properties.Resources.helmet_corinthian;
                    break;
                case "Железный щит":
                    picture = Properties.Resources.shield_steel;
                    break;
                case "Доспех Богов":
                    picture = Properties.Resources.steel_armor;
                    break;
                case "Блестящий шлем":
                    picture = Properties.Resources.helmet_shiny;
                    break;
                case "Адский щит":
                    picture = Properties.Resources.shield_tower;
                    break;
                case "Малый амулет здоровья":
                    picture = Properties.Resources.amla_default;
                    break;
                case "Посох ученика":
                    picture = Properties.Resources.staff_magic;
                    break;
                case "Кольцо \"Моя прелесть\"":
                    picture = Properties.Resources.ring_gold;
                    break;
                case "Браслет Удачи":
                    picture = Properties.Resources.circlet_winged;
                    break;
                case "Анкх":
                    picture = Properties.Resources.ankh_necklace;
                    break;
                case "Посох шамана":
                    picture = Properties.Resources.staff_green;
                    break;
                case "Кольцо некроманта":
                    picture = Properties.Resources.skull_ring;
                    break;
                case "Большой амулет здоровья":
                    picture = Properties.Resources.jewelry_necklace_amber;
                    break;
                case "Посох некроманта":
                    picture = Properties.Resources.staff_plague;
                    break;
                case "Кольцо \"IYX\"":
                    picture = Properties.Resources.jewelry_ring_prismatic;
                    break;
                case "Рубиновый посох":
                    picture = Properties.Resources.staff_ruby;
                    break;
                case "Зелье здоровья":
                    picture = Properties.Resources.potion_red_small;
                    break;
                case "Зелье маны":
                    picture = Properties.Resources.potion_green_small;
                    break;
                case "Свиток ускорения":
                    picture = Properties.Resources.scroll_red;
                    break;
                case "Большое зелье здоровья":
                    picture = Properties.Resources.potion_red_medium;
                    break;
                case "Большое зелье маны":
                    picture = Properties.Resources.potion_green_medium;
                    break;
                default:
                    picture = null;
                    break;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Program.f4.UpgradeWeapon();
            Program.inv.Hide();
            Program.f4.Show();
            Program.f3.UpBuff();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "Слоты 2 из 2";
            Program.pageInventory = 2;
            button2.Enabled = false;
            button1.Enabled = true;
            Upg();
            Upgrade();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Слоты 1 из 2";
            Program.pageInventory = 1;
            button1.Enabled = false;
            button2.Enabled = true;
            Upg();
            Upgrade();
        } /* !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!INVENTORY!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!*/

        public void pictureBox10_MouseClick(object sender, MouseEventArgs e)
        {
            switch (selected)
            {
                case 1:
                    pictureBox10.BorderStyle = BorderStyle.FixedSingle;
                    if (Program.pageInventory == 1)
                    {
                        selecttwo = Program.inventory[10];
                        Program.selecteditem[dropselected] = 0;
                        Program.inventory[dropselected] = selecttwo;
                        dropselected = 10;
                        Program.inventory[dropselected] = select;
                    }
                    if (Program.pageInventory == 2)
                    {
                        selecttwo = Program.inventory[22];
                        Program.selecteditem[dropselected] = 0;
                        Program.inventory[dropselected] = selecttwo;
                        dropselected = 22;
                        Program.inventory[dropselected] = select;
                    }
                    selected = 0;
                    function01();
                    function02();
                    Upg();
                    Upgrade();
                    break;

                case 0:
                    pictureBox10.BorderStyle = BorderStyle.Fixed3D;
                    if (Program.pageInventory == 1)
                    {
                        dropselected = 10;
                        Program.selecteditem[dropselected] = 1;
                        select = Program.inventory[dropselected];

                    }
                    if (Program.pageInventory == 2)
                    {
                        dropselected = 22;
                        Program.selecteditem[dropselected] = 1;
                        select = Program.inventory[dropselected];
                    }
                    selected = 1;
                    function01();
                    function02();
                    break;
            }
        }

        public void pictureBox9_MouseClick(object sender, MouseEventArgs e)
        {
            switch (selected)
            {
                case 1:
                    pictureBox9.BorderStyle = BorderStyle.FixedSingle;
                    if (Program.pageInventory == 1)
                    {
                        selecttwo = Program.inventory[9];
                        Program.selecteditem[dropselected] = 0;
                        Program.inventory[dropselected] = selecttwo;
                        dropselected = 9;
                        Program.inventory[dropselected] = select;
                    }
                    if (Program.pageInventory == 2)
                    {
                        selecttwo = Program.inventory[21];
                        Program.selecteditem[dropselected] = 0;
                        Program.inventory[dropselected] = selecttwo;
                        dropselected = 21;
                        Program.inventory[dropselected] = select;
                    }
                    selected = 0;
                    function01();
                    function02();
                    Upg();
                    Upgrade();
                    break;

                case 0:
                    pictureBox9.BorderStyle = BorderStyle.Fixed3D;
                    if (Program.pageInventory == 1)
                    {
                        dropselected = 9;
                        Program.selecteditem[dropselected] = 1;
                        select = Program.inventory[dropselected];

                    }
                    if (Program.pageInventory == 2)
                    {
                        dropselected = 21;
                        Program.selecteditem[dropselected] = 1;
                        select = Program.inventory[dropselected];
                    }
                    selected = 1;
                    function01();
                    function02();
                    break;
            }
        }

        public void pictureBox8_MouseClick(object sender, MouseEventArgs e)
        {
            switch (selected)
            {
                case 1:
                    pictureBox8.BorderStyle = BorderStyle.FixedSingle;
                    if (Program.pageInventory == 1)
                    {
                        selecttwo = Program.inventory[8];
                        Program.selecteditem[dropselected] = 0;
                        Program.inventory[dropselected] = selecttwo;
                        dropselected = 8;
                        Program.inventory[dropselected] = select;
                    }
                    if (Program.pageInventory == 2)
                    {
                        selecttwo = Program.inventory[20];
                        Program.selecteditem[dropselected] = 0;
                        Program.inventory[dropselected] = selecttwo;
                        dropselected = 20;
                        Program.inventory[dropselected] = select;
                    }
                    selected = 0;
                    function01();
                    function02();
                    Upg();
                    Upgrade();
                    break;

                case 0:
                    pictureBox8.BorderStyle = BorderStyle.Fixed3D;
                    if (Program.pageInventory == 1)
                    {
                        dropselected = 8;
                        Program.selecteditem[dropselected] = 1;
                        select = Program.inventory[dropselected];

                    }
                    if (Program.pageInventory == 2)
                    {
                        dropselected = 20;
                        Program.selecteditem[dropselected] = 1;
                        select = Program.inventory[dropselected];
                    }
                    selected = 1;
                    function01();
                    function02();
                    break;
            }
        }

        public void pictureBox7_MouseClick(object sender, MouseEventArgs e)
        {
            switch (selected)
            {
                case 1:
                    pictureBox7.BorderStyle = BorderStyle.FixedSingle;
                    if (Program.pageInventory == 1)
                    {
                        selecttwo = Program.inventory[7];
                        Program.selecteditem[dropselected] = 0;
                        Program.inventory[dropselected] = selecttwo;
                        dropselected = 7;
                        Program.inventory[dropselected] = select;
                    }
                    if (Program.pageInventory == 2)
                    {
                        selecttwo = Program.inventory[19];
                        Program.selecteditem[dropselected] = 0;
                        Program.inventory[dropselected] = selecttwo;
                        dropselected = 19;
                        Program.inventory[dropselected] = select;
                    }
                    selected = 0;
                    function01();
                    function02();
                    Upg();
                    Upgrade();
                    break;

                case 0:
                    pictureBox7.BorderStyle = BorderStyle.Fixed3D;
                    if (Program.pageInventory == 1)
                    {
                        dropselected = 7;
                        Program.selecteditem[dropselected] = 1;
                        select = Program.inventory[dropselected];

                    }
                    if (Program.pageInventory == 2)
                    {
                        dropselected = 19;
                        Program.selecteditem[dropselected] = 1;
                        select = Program.inventory[dropselected];
                    }
                    selected = 1;
                    function01();
                    function02();
                    break;
            }
        }

        public void pictureBox6_MouseClick(object sender, MouseEventArgs e)
        {
            switch (selected)
            {
                case 1:
                    pictureBox6.BorderStyle = BorderStyle.FixedSingle;
                    if (Program.pageInventory == 1)
                    {
                        selecttwo = Program.inventory[6];
                        Program.selecteditem[dropselected] = 0;
                        Program.inventory[dropselected] = selecttwo;
                        dropselected = 6;
                        Program.inventory[dropselected] = select;
                    }
                    if (Program.pageInventory == 2)
                    {
                        selecttwo = Program.inventory[18];
                        Program.selecteditem[dropselected] = 0;
                        Program.inventory[dropselected] = selecttwo;
                        dropselected = 18;
                        Program.inventory[dropselected] = select;
                    }
                    selected = 0;
                    function01();
                    function02();
                    Upg();
                    Upgrade();
                    break;

                case 0:
                    pictureBox6.BorderStyle = BorderStyle.Fixed3D;
                    if (Program.pageInventory == 1)
                    {
                        dropselected = 6;
                        Program.selecteditem[dropselected] = 1;
                        select = Program.inventory[dropselected];

                    }
                    if (Program.pageInventory == 2)
                    {
                        dropselected = 18;
                        Program.selecteditem[dropselected] = 1;
                        select = Program.inventory[dropselected];
                    }
                    selected = 1;
                    function01();
                    function02();
                    break;
            }
        }

        public void pictureBox5_MouseClick(object sender, MouseEventArgs e)
        {
            switch (selected)
            {
                case 1:
                    pictureBox5.BorderStyle = BorderStyle.FixedSingle;
                    if (Program.pageInventory == 1)
                    {
                        selecttwo = Program.inventory[5];
                        Program.selecteditem[dropselected] = 0;
                        Program.inventory[dropselected] = selecttwo;
                        dropselected = 5;
                        Program.inventory[dropselected] = select;
                    }
                    if (Program.pageInventory == 2)
                    {
                        selecttwo = Program.inventory[17];
                        Program.selecteditem[dropselected] = 0;
                        Program.inventory[dropselected] = selecttwo;
                        dropselected = 17;
                        Program.inventory[dropselected] = select;
                    }
                    selected = 0;
                    function01();
                    function02();
                    Upg();
                    Upgrade();
                    break;

                case 0:
                    pictureBox5.BorderStyle = BorderStyle.Fixed3D;
                    if (Program.pageInventory == 1)
                    {
                        dropselected = 5;
                        Program.selecteditem[dropselected] = 1;
                        select = Program.inventory[dropselected];

                    }
                    if (Program.pageInventory == 2)
                    {
                        dropselected = 17;
                        Program.selecteditem[dropselected] = 1;
                        select = Program.inventory[dropselected];
                    }
                    selected = 1;
                    function01();
                    function02();
                    break;
            }
        }

        public void pictureBox4_MouseClick(object sender, MouseEventArgs e)
        {
            switch (selected)
            {
                case 1:
                    pictureBox4.BorderStyle = BorderStyle.FixedSingle;
                    if (Program.pageInventory == 1)
                    {
                        selecttwo = Program.inventory[4];
                        Program.selecteditem[dropselected] = 0;
                        Program.inventory[dropselected] = selecttwo;
                        dropselected = 4;
                        Program.inventory[dropselected] = select;
                    }
                    if (Program.pageInventory == 2)
                    {
                        selecttwo = Program.inventory[16];
                        Program.selecteditem[dropselected] = 0;
                        Program.inventory[dropselected] = selecttwo;
                        dropselected = 16;
                        Program.inventory[dropselected] = select;
                    }
                    selected = 0;
                    function01();
                    function02();
                    Upg();
                    Upgrade();
                    break;

                case 0:
                    pictureBox4.BorderStyle = BorderStyle.Fixed3D;
                    if (Program.pageInventory == 1)
                    {
                        dropselected = 4;
                        Program.selecteditem[dropselected] = 1;
                        select = Program.inventory[dropselected];

                    }
                    if (Program.pageInventory == 2)
                    {
                        dropselected = 16;
                        Program.selecteditem[dropselected] = 1;
                        select = Program.inventory[dropselected];
                    }
                    selected = 1;
                    function01();
                    function02();
                    break;
            }
        }

        public void pictureBox3_MouseClick(object sender, MouseEventArgs e)
        {
            switch (selected)
            {
                case 1:
                    pictureBox3.BorderStyle = BorderStyle.FixedSingle;
                    if (Program.pageInventory == 1)
                    {
                        selecttwo = Program.inventory[3];
                        Program.selecteditem[dropselected] = 0;
                        Program.inventory[dropselected] = selecttwo;
                        dropselected = 3;
                        Program.inventory[dropselected] = select;
                    }
                    if (Program.pageInventory == 2)
                    {
                        selecttwo = Program.inventory[15];
                        Program.selecteditem[dropselected] = 0;
                        Program.inventory[dropselected] = selecttwo;
                        dropselected = 15;
                        Program.inventory[dropselected] = select;
                    }
                    selected = 0;
                    function01();
                    function02();
                    Upg();
                    Upgrade();
                    break;

                case 0:
                    pictureBox3.BorderStyle = BorderStyle.Fixed3D;
                    if (Program.pageInventory == 1)
                    {
                        dropselected = 3;
                        Program.selecteditem[dropselected] = 1;
                        select = Program.inventory[dropselected];

                    }
                    if (Program.pageInventory == 2)
                    {
                        dropselected = 15;
                        Program.selecteditem[dropselected] = 1;
                        select = Program.inventory[dropselected];
                    }
                    selected = 1;
                    function01();
                    function02();
                    break;
            }
        }

        public void pictureBox2_MouseClick(object sender, MouseEventArgs e)
        {
            switch (selected)
            {
                case 1:
                    pictureBox2.BorderStyle = BorderStyle.FixedSingle;
                    if (Program.pageInventory == 1)
                    {
                        selecttwo = Program.inventory[2];
                        Program.selecteditem[dropselected] = 0;
                        Program.inventory[dropselected] = selecttwo;
                        dropselected = 2;
                        Program.inventory[dropselected] = select;
                    }
                    if (Program.pageInventory == 2)
                    {
                        selecttwo = Program.inventory[14];
                        Program.selecteditem[dropselected] = 0;
                        Program.inventory[dropselected] = selecttwo;
                        dropselected = 14;
                        Program.inventory[dropselected] = select;
                    }
                    selected = 0;
                    function01();
                    function02();
                    Upg();
                    Upgrade();
                    break;

                case 0:
                    pictureBox2.BorderStyle = BorderStyle.Fixed3D;
                    if (Program.pageInventory == 1)
                    {
                        dropselected = 2;
                        Program.selecteditem[dropselected] = 1;
                        select = Program.inventory[dropselected];

                    }
                    if (Program.pageInventory == 2)
                    {
                        dropselected = 14;
                        Program.selecteditem[dropselected] = 1;
                        select = Program.inventory[dropselected];
                    }
                    selected = 1;
                    function01();
                    function02();
                    break;
            }
        }

        public void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            switch (selected)
            {
                case 1:
                    pictureBox1.BorderStyle = BorderStyle.FixedSingle;
                    if (Program.pageInventory == 1)
                    {
                        selecttwo = Program.inventory[1];
                        Program.selecteditem[dropselected] = 0;
                        Program.inventory[dropselected] = selecttwo;
                        dropselected = 1;
                        Program.inventory[dropselected] = select;
                    }
                    if (Program.pageInventory == 2)
                    {
                        selecttwo = Program.inventory[13];
                        Program.selecteditem[dropselected] = 0;
                        Program.inventory[dropselected] = selecttwo;
                        dropselected = 13;
                        Program.inventory[dropselected] = select;
                    }
                    selected = 0;
                    function01();
                    function02();
                    Upg();
                    Upgrade();
                    break;

                case 0:
                    pictureBox1.BorderStyle = BorderStyle.Fixed3D;
                    if (Program.pageInventory == 1)
                    {
                        dropselected = 1;
                        Program.selecteditem[dropselected] = 1;
                        select = Program.inventory[dropselected];

                    }
                    if (Program.pageInventory == 2)
                    {
                        dropselected = 13;
                        Program.selecteditem[dropselected] = 1;
                        select = Program.inventory[dropselected];
                    }
                    selected = 1;
                    function01();
                    function02();
                    break;
            }
        }

        private void Inventory_Load(object sender, EventArgs e)
        {

        }

        public void pictureBox12_MouseClick(object sender, MouseEventArgs e)
        {
            switch (selected)
            {
                case 1:
                    pictureBox12.BorderStyle = BorderStyle.FixedSingle;
                    if (Program.pageInventory == 1)
                    {
                        selecttwo = Program.inventory[12];
                        Program.selecteditem[dropselected] = 0;
                        Program.inventory[dropselected] = selecttwo;
                        dropselected = 12;
                        Program.inventory[dropselected] = select;
                    }
                    if (Program.pageInventory == 2)
                    {
                        selecttwo = Program.inventory[24];
                        Program.selecteditem[dropselected] = 0;
                        Program.inventory[dropselected] = selecttwo;
                        dropselected = 24;
                        Program.inventory[dropselected] = select;
                    }
                    selected = 0;
                    function01();
                    function02();
                    Upg();
                    Upgrade();
                    break;

                case 0:
                    pictureBox12.BorderStyle = BorderStyle.Fixed3D;
                    if (Program.pageInventory == 1)
                    {
                        dropselected = 12;
                        Program.selecteditem[dropselected] = 1;
                        select = Program.inventory[dropselected];

                    }
                    if (Program.pageInventory == 2)
                    {
                        dropselected = 24;
                        Program.selecteditem[dropselected] = 1;
                        select = Program.inventory[dropselected];
                    }
                    selected = 1;
                    function01();
                    function02();
                    break;
            }
        }

        public void pictureBox11_MouseClick(object sender, MouseEventArgs e)
        {
            switch (selected)
            {
                case 1:
                    pictureBox11.BorderStyle = BorderStyle.FixedSingle;
                    if (Program.pageInventory == 1)
                    {
                        selecttwo = Program.inventory[11];
                        Program.selecteditem[dropselected] = 0;
                        Program.inventory[dropselected] = selecttwo;
                        dropselected = 11;
                        Program.inventory[dropselected] = select;
                    }
                    if (Program.pageInventory == 2)
                    {
                        selecttwo = Program.inventory[23];
                        Program.selecteditem[dropselected] = 0;
                        Program.inventory[dropselected] = selecttwo;
                        dropselected = 23;
                        Program.inventory[dropselected] = select;
                    }
                    selected = 0;
                    Upg();
                    Upgrade();
                    break;

                case 0:
                    pictureBox11.BorderStyle = BorderStyle.Fixed3D;
                    if (Program.pageInventory == 1)
                    {
                        dropselected = 11;
                        Program.selecteditem[dropselected] = 1;
                        select = Program.inventory[dropselected];

                    }
                    if (Program.pageInventory == 2)
                    {
                        dropselected = 23;
                        Program.selecteditem[dropselected] = 1;
                        select = Program.inventory[dropselected];
                    }
                    selected = 1;
                    function01();
                    function02();
                    break;
            }
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            switch (selected)
            {
                case 1:
                    pictureBox14.BorderStyle = BorderStyle.FixedSingle;
                    selecttwo = Program.inventory[29];
                    Program.selecteditem[dropselected] = 0;
                    Program.inventory[dropselected] = selecttwo;
                    dropselected = 29;
                    Program.inventory[dropselected] = select;
                    selected = 0;
                    function01();
                    function02();
                    Upg();
                    Upgrade();
                    break;

                case 0:
                    pictureBox14.BorderStyle = BorderStyle.Fixed3D;
                    dropselected = 29;
                    Program.selecteditem[dropselected] = 1;
                    select = Program.inventory[dropselected];
                    selected = 1;
                    function01();
                    function02();
                    break;
            }
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            switch (selected)
            {
                case 1:
                    pictureBox18.BorderStyle = BorderStyle.FixedSingle;
                    selecttwo = Program.inventory[33];
                    Program.selecteditem[dropselected] = 0;
                    Program.inventory[dropselected] = selecttwo;
                    dropselected = 33;
                    Program.inventory[dropselected] = select;
                    selected = 0;
                    function01();
                    function02();
                    Upg();
                    Upgrade();
                    Program.f3.UpBuff();
                    break;

                case 0:
                    pictureBox18.BorderStyle = BorderStyle.Fixed3D;
                    dropselected = 33;
                    Program.selecteditem[dropselected] = 1;
                    select = Program.inventory[dropselected];
                    selected = 1;
                    function01();
                    function02();
                    break;
            }
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            switch (selected)
            {
                case 1:
                    pictureBox13.BorderStyle = BorderStyle.FixedSingle;
                    selecttwo = Program.inventory[28];
                    Program.selecteditem[dropselected] = 0;
                    Program.inventory[dropselected] = selecttwo;
                    dropselected = 28;
                    Program.inventory[dropselected] = select;
                    selected = 0;
                    function01();
                    function02();
                    Upg();
                    Upgrade();
                    break;

                case 0:
                    pictureBox13.BorderStyle = BorderStyle.Fixed3D;
                    dropselected = 28;
                    Program.selecteditem[dropselected] = 1;
                    select = Program.inventory[dropselected];
                    selected = 1;
                    function01();
                    function02();
                    break;
            }
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            switch (selected)
            {
                case 1:
                    pictureBox15.BorderStyle = BorderStyle.FixedSingle;
                    selecttwo = Program.inventory[30];
                    Program.selecteditem[dropselected] = 0;
                    Program.inventory[dropselected] = selecttwo;
                    dropselected = 30;
                    Program.inventory[dropselected] = select;
                    selected = 0;
                    function01();
                    function02();
                    Upg();
                    Upgrade();
                    break;

                case 0:
                    pictureBox15.BorderStyle = BorderStyle.Fixed3D;
                    dropselected = 30;
                    Program.selecteditem[dropselected] = 1;
                    select = Program.inventory[dropselected];
                    selected = 1;
                    function01();
                    function02();
                    break;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (selected == 1)
            {


                for (int i = 0; i < Program.armorselected.Length; i++)
                {
                    for (int j = 0; j < 25; j++)
                    {
                        if (Program.armorselected[i] == select)
                        {
                            Program.f4.comboBox2.SelectedItem = select;
                            break;
                        }
                    }
                }

            }
        }

        private void button4_VisibleChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < 35; i++)
            {
                Program.selecteditem[i] = 0;
            }
            selected = 0;
            Upg();
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            switch (selected)
            {
                case 1:
                    pictureBox16.BorderStyle = BorderStyle.FixedSingle;
                    selecttwo = Program.inventory[31];
                    Program.selecteditem[dropselected] = 0;
                    Program.inventory[dropselected] = selecttwo;
                    dropselected = 31;
                    Program.inventory[dropselected] = select;
                    selected = 0;
                    function01();
                    function02();
                    Upg();
                    Upgrade();
                    Program.f3.UpBuff();
                    break;

                case 0:
                    pictureBox16.BorderStyle = BorderStyle.Fixed3D;
                    dropselected = 31;
                    Program.selecteditem[dropselected] = 1;
                    select = Program.inventory[dropselected];
                    selected = 1;
                    function01();
                    function02();
                    break;
            }
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            switch (selected)
            {
                case 1:
                    pictureBox17.BorderStyle = BorderStyle.FixedSingle;
                    selecttwo = Program.inventory[32];
                    Program.selecteditem[dropselected] = 0;
                    Program.inventory[dropselected] = selecttwo;
                    dropselected = 32;
                    Program.inventory[dropselected] = select;
                    selected = 0;
                    function01();
                    function02();
                    Upg();
                    Upgrade();
                    Program.f3.UpBuff();
                    break;

                case 0:
                    pictureBox17.BorderStyle = BorderStyle.Fixed3D;
                    dropselected = 32;
                    Program.selecteditem[dropselected] = 1;
                    select = Program.inventory[dropselected];
                    selected = 1;
                    function01();
                    function02();
                    break;
            }
        }

        private void Inventory_VisibleChanged(object sender, EventArgs e)
        {
            dropselected = 12;
            Program.selecteditem[dropselected] = 1;
            select = Program.inventory[dropselected];
            selected = 1;
            selecttwo = Program.inventory[12];
            Program.selecteditem[dropselected] = 0;
            Program.inventory[dropselected] = selecttwo;
            dropselected = 12;
            Program.inventory[dropselected] = select;
            selected = 0;
            function01();
            function02();
            Upg();
            Upgrade();
            label1.Text = "Слоты 1 из 2";
            Program.pageInventory = 1;
            button1.Enabled = false;
            button2.Enabled = true;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Program.inventory[dropselected] = "";
            Program.money += 100;
            Program.selecteditem[dropselected] = 0;
            selected = 0;
            Upg();
            Upgrade();
            Program.f4.UpgradeWeapon();
            Program.inv.Upgrade();
            Program.f4.UpgradeHelmet();
            Program.f4.UpgradeArmor();
            Program.f4.UpgradeShield();
            Program.f4.UpgradeStaff();
            Program.f4.UpgradeArtefucts();
        }

        private void Inventory_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.SForm.button4_Click(null, null);
        }

        public void Upg()
        {
            if (Program.selecteditem[31] == 0)
            {
                pictureBox16.BorderStyle = BorderStyle.FixedSingle;
            }
            else pictureBox16.BorderStyle = BorderStyle.Fixed3D;

            if (Program.selecteditem[32] == 0)
            {
                pictureBox17.BorderStyle = BorderStyle.FixedSingle;
            }
            else pictureBox17.BorderStyle = BorderStyle.Fixed3D;

            if (Program.selecteditem[33] == 0)
            {
                pictureBox18.BorderStyle = BorderStyle.FixedSingle;
            }
            else pictureBox18.BorderStyle = BorderStyle.Fixed3D;

            if (Program.selecteditem[29] == 0)
            {
                pictureBox14.BorderStyle = BorderStyle.FixedSingle;
            }
            else pictureBox14.BorderStyle = BorderStyle.Fixed3D;

            if (Program.selecteditem[30] == 0)
            {
                pictureBox15.BorderStyle = BorderStyle.FixedSingle;
            }
            else pictureBox15.BorderStyle = BorderStyle.Fixed3D;

            if (Program.selecteditem[28] == 0)
            {
                pictureBox13.BorderStyle = BorderStyle.FixedSingle;
            }
            else pictureBox13.BorderStyle = BorderStyle.Fixed3D;

            if (Program.pageInventory == 1)
            {
                int t = 1;
                if (Program.selecteditem[t] == 0)
                {
                    pictureBox1.BorderStyle = BorderStyle.FixedSingle;
                }
                else pictureBox1.BorderStyle = BorderStyle.Fixed3D;
                t++; if (Program.selecteditem[t] == 0)
                {
                    pictureBox2.BorderStyle = BorderStyle.FixedSingle;
                }
                else pictureBox2.BorderStyle = BorderStyle.Fixed3D;
                t++; if (Program.selecteditem[t] == 0)
                {
                    pictureBox3.BorderStyle = BorderStyle.FixedSingle;
                }
                else pictureBox3.BorderStyle = BorderStyle.Fixed3D;
                t++; if (Program.selecteditem[t] == 0)
                {
                    pictureBox4.BorderStyle = BorderStyle.FixedSingle;
                }
                else pictureBox4.BorderStyle = BorderStyle.Fixed3D;
                t++; if (Program.selecteditem[t] == 0)
                {
                    pictureBox5.BorderStyle = BorderStyle.FixedSingle;
                }
                else pictureBox5.BorderStyle = BorderStyle.Fixed3D;
                t++; if (Program.selecteditem[t] == 0)
                {
                    pictureBox6.BorderStyle = BorderStyle.FixedSingle;
                }
                else pictureBox6.BorderStyle = BorderStyle.Fixed3D;
                t++; if (Program.selecteditem[t] == 0)
                {
                    pictureBox7.BorderStyle = BorderStyle.FixedSingle;
                }
                else pictureBox7.BorderStyle = BorderStyle.Fixed3D;
                t++; if (Program.selecteditem[t] == 0)
                {
                    pictureBox8.BorderStyle = BorderStyle.FixedSingle;
                }
                else pictureBox8.BorderStyle = BorderStyle.Fixed3D;
                t++; if (Program.selecteditem[t] == 0)
                {
                    pictureBox9.BorderStyle = BorderStyle.FixedSingle;
                }
                else pictureBox9.BorderStyle = BorderStyle.Fixed3D;
                t++; if (Program.selecteditem[t] == 0)
                {
                    pictureBox10.BorderStyle = BorderStyle.FixedSingle;
                }
                else pictureBox10.BorderStyle = BorderStyle.Fixed3D;
                t++; if (Program.selecteditem[t] == 0)
                {
                    pictureBox11.BorderStyle = BorderStyle.FixedSingle;
                }
                else pictureBox11.BorderStyle = BorderStyle.Fixed3D;
                t++; if (Program.selecteditem[t] == 0)
                {
                    pictureBox12.BorderStyle = BorderStyle.FixedSingle;
                }
                else pictureBox12.BorderStyle = BorderStyle.Fixed3D;
            }
            if (Program.pageInventory == 2)
            {
                int t = 13;
                if (Program.selecteditem[t] == 0)
                {
                    pictureBox1.BorderStyle = BorderStyle.FixedSingle;
                }
                else pictureBox1.BorderStyle = BorderStyle.Fixed3D;
                t++; if (Program.selecteditem[t] == 0)
                {
                    pictureBox2.BorderStyle = BorderStyle.FixedSingle;
                }
                else pictureBox2.BorderStyle = BorderStyle.Fixed3D;
                t++; if (Program.selecteditem[t] == 0)
                {
                    pictureBox3.BorderStyle = BorderStyle.FixedSingle;
                }
                else pictureBox3.BorderStyle = BorderStyle.Fixed3D;
                t++; if (Program.selecteditem[t] == 0)
                {
                    pictureBox4.BorderStyle = BorderStyle.FixedSingle;
                }
                else pictureBox4.BorderStyle = BorderStyle.Fixed3D;
                t++; if (Program.selecteditem[t] == 0)
                {
                    pictureBox5.BorderStyle = BorderStyle.FixedSingle;
                }
                else pictureBox5.BorderStyle = BorderStyle.Fixed3D;
                t++; if (Program.selecteditem[t] == 0)
                {
                    pictureBox6.BorderStyle = BorderStyle.FixedSingle;
                }
                else pictureBox6.BorderStyle = BorderStyle.Fixed3D;
                t++; if (Program.selecteditem[t] == 0)
                {
                    pictureBox7.BorderStyle = BorderStyle.FixedSingle;
                }
                else pictureBox7.BorderStyle = BorderStyle.Fixed3D;
                t++; if (Program.selecteditem[t] == 0)
                {
                    pictureBox8.BorderStyle = BorderStyle.FixedSingle;
                }
                else pictureBox8.BorderStyle = BorderStyle.Fixed3D;
                t++; if (Program.selecteditem[t] == 0)
                {
                    pictureBox9.BorderStyle = BorderStyle.FixedSingle;
                }
                else pictureBox9.BorderStyle = BorderStyle.Fixed3D;
                t++; if (Program.selecteditem[t] == 0)
                {
                    pictureBox10.BorderStyle = BorderStyle.FixedSingle;
                }
                else pictureBox10.BorderStyle = BorderStyle.Fixed3D;
                t++; if (Program.selecteditem[t] == 0)
                {
                    pictureBox11.BorderStyle = BorderStyle.FixedSingle;
                }
                else pictureBox11.BorderStyle = BorderStyle.Fixed3D;
                t++; if (Program.selecteditem[t] == 0)
                {
                    pictureBox12.BorderStyle = BorderStyle.FixedSingle;
                }
                else pictureBox12.BorderStyle = BorderStyle.Fixed3D;
            }
        }
        public void function01()
        {
            if (selected == 1&&select!="")
                button5.Enabled = true;
            else if (selected == 0) { button4.Enabled = false; button5.Enabled = false; button6.Enabled = false; }
        }
        public void function02()
        {

        }

    }
}
