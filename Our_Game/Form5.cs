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
    public partial class Shop : Form
    {
        public Shop()
        {
            InitializeComponent();
        }
        public static string item = "";
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch ((string)comboBox1.SelectedItem)
            {
                case "Дубинка":
                    pictureBox1.Image = Properties.Resources.CLUB;
                    Program.weapon = 1;
                    Program.cell = 100;
                    break;
                case "Ржавый кинжал":
                    pictureBox1.Image = Properties.Resources.dagger_undead;
                    Program.weapon = 2;
                    Program.cell = 2000;
                    break;
                case "Топор":
                    pictureBox1.Image = Properties.Resources.axe_undead;
                    Program.weapon = 3;
                    Program.cell = 30000;
                    break;
                case "Меч":
                    pictureBox1.Image = Properties.Resources.sword_human;
                    Program.weapon = 4;
                    Program.cell = 120000;
                    break;
                case "Булава":
                    pictureBox1.Image = Properties.Resources.mace_spiked;
                    Program.weapon = 5;
                    Program.cell = 200000;
                    break;
                case "Кинжал ассасина":
                    pictureBox1.Image = Properties.Resources.dagger_orcish;
                    Program.weapon = 6;
                    Program.cell = 400000;
                    break;
                case "Боевой топор":
                    pictureBox1.Image = Properties.Resources.battleaxe;
                    Program.weapon = 7;
                    Program.cell = 700000;
                    break;
                case "Пика(чу)":
                    pictureBox1.Image = Properties.Resources.PIKE;
                    Program.weapon = 8;
                    Program.cell = 1000000;
                    break;
                case "Палица":
                    pictureBox1.Image = Properties.Resources.MACE;
                    Program.weapon = 9;
                    Program.cell = 1500000;
                    break;
                case "Рубиновый меч":
                    pictureBox1.Image = Properties.Resources.SCIMITAR;
                    Program.weapon = 10;
                    Program.cell = 3000000;
                    break;
                case "Святой меч":
                    pictureBox1.Image = Properties.Resources.sword_holy;
                    Program.weapon = 11;
                    Program.cell = 9000000;
                    break;
                default:
                    break;
            }
            Program.Part = 1;
            description();
            label1.Text = Program.text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Program.f5.Hide();
            Program.Map.Show();
            label8.Text = "Денег: " + Program.money;
        }

        private void Shop_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.SForm.button4_Click(null, null);
        }

        int arm = 0;

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch ((string)comboBox2.SelectedItem)
            {
                case "Кожаная броня":
                    pictureBox1.Image = Properties.Resources.armor_leather;
                    Program.armor = 1; arm = 4;
                    Program.cell = 200;
                    break;
                case "Кожаный шлем":
                    pictureBox1.Image = Properties.Resources.helmet_leather_cap;
                    Program.armor = 2;
                    arm = 2;
                    Program.cell = 300;
                    break;
                case "Деревянный щит":
                    pictureBox1.Image = Properties.Resources.shield_wooden;
                    Program.armor = 3; arm = 3;
                    Program.cell = 250;
                    break;
                case "Кольчужная броня":
                    pictureBox1.Image = Properties.Resources.armor_chain;
                    Program.armor = 4; arm = 18;
                    Program.cell = 7000;
                    break;
                case "Кольчужный шлем":
                    pictureBox1.Image = Properties.Resources.helmet_chain_coif;
                    Program.armor = 5;
                    arm = 15;
                    Program.cell = 6000;
                    break;
                case "Бойцовский щит":
                    pictureBox1.Image = Properties.Resources.shield_polished;
                    Program.armor = 6; arm = 14;
                    Program.cell = 6500;
                    break;
                case "Железная броня":
                    pictureBox1.Image = Properties.Resources.cuirass_muscled;
                    Program.armor = 7; arm = 28;
                    Program.cell = 70000;
                    break;
                case "Железный шлем":
                    pictureBox1.Image = Properties.Resources.helmet_corinthian;
                    Program.armor = 8; arm = 21;
                    Program.cell = 65000;
                    break;
                case "Железный щит":
                    pictureBox1.Image = Properties.Resources.shield_steel;
                    Program.armor = 9; arm = 22;
                    Program.cell = 80000;
                    break;
                case "Доспех Богов":
                    pictureBox1.Image = Properties.Resources.steel_armor;
                    Program.armor = 10; arm = 41;
                    Program.cell = 560000;
                    break;
                case "Блестящий шлем":
                    pictureBox1.Image = Properties.Resources.helmet_shiny;
                    Program.armor = 11; arm = 24;
                    Program.cell = 490000;
                    break;
                case "Адский щит":
                    pictureBox1.Image = Properties.Resources.shield_tower;
                    Program.armor = 12; arm = 29;
                    Program.cell = 510000;
                    break;
            }
            Program.Part = 2;
            description();
            label1.Text = Program.text;
        }



        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch ((string)comboBox3.SelectedItem)
            {
                case "Малый амулет здоровья":
                    pictureBox1.Image = Properties.Resources.amla_default;
                    Program.artefuckt = 1;
                    Program.cell = 67000;
                    break;
                case "Посох ученика":
                    pictureBox1.Image = Properties.Resources.staff_magic;
                    Program.staff = 1;
                    Program.artefuckt = 0;
                    Program.cell = 110000;
                    break;
                case "Кольцо \"Моя прелесть\"":
                    pictureBox1.Image = Properties.Resources.ring_gold;
                    Program.artefuckt = 2;
                    Program.cell = 700000;
                    break;
                case "Браслет Удачи":
                    pictureBox1.Image = Properties.Resources.circlet_winged;
                    Program.artefuckt = 3;
                    Program.cell = 900000;
                    break;
                case "Анкх":
                    pictureBox1.Image = Properties.Resources.ankh_necklace;
                    Program.artefuckt = 4;
                    Program.cell = 120000;
                    break;
                case "Посох шамана":
                    pictureBox1.Image = Properties.Resources.staff_green;
                    Program.staff = 2;
                    Program.artefuckt = 0;
                    Program.cell = 670000;
                    break;
                case "Кольцо некроманта":
                    pictureBox1.Image = Properties.Resources.skull_ring;
                    Program.artefuckt = 5;
                    Program.cell = 43000;
                    break;
                case "Большой амулет здоровья":
                    pictureBox1.Image = Properties.Resources.jewelry_necklace_amber;
                    Program.artefuckt = 6;
                    Program.cell = 120000;
                    break;
                case "Посох некроманта":
                    pictureBox1.Image = Properties.Resources.staff_plague;
                    Program.staff = 3;
                    Program.artefuckt = 0;
                    Program.cell = 890000;
                    break;
                case "Кольцо \"IYX\"":
                    pictureBox1.Image = Properties.Resources.jewelry_ring_prismatic;
                    Program.artefuckt = 7;
                    Program.cell = 1300000;
                    break;
                case "Рубиновый посох":
                    pictureBox1.Image = Properties.Resources.staff_ruby;
                    Program.staff = 4;
                    Program.artefuckt = 0;
                    Program.cell = 900000;
                    break;
            }
            Program.Part = 3;
            description();
            label1.Text = Program.text;
        }

        public void description()
        {
            if (Program.Part == 1)
            {
                switch (Program.weapon)//ОПИСАНИЕ ОРУЖИЯ
                {
                    case 1:
                        Program.text = "Оружие известное своей незамыславатостью, подходит для начинающих путешевственников. Подходит чтобы выбить все из вашего врага.";

                        break;
                    case 2:
                        Program.text = "Кинжал побывавший в бою, неизвестно кем он использовался и сколько существ им было убито. В прочем хорошо режит, не взирая на то что лезвие покрылось карозией.";
                        break;
                    case 3:
                        Program.text = "Топор для воинов знающих толк в сражениях, очень популярен среди гномов. Гроздное оружие требующее некоторые умения владения боя.";
                        break;
                    case 4:
                        Program.text = "Железный меч, стандартное оружие имперской армии. Очень хорош в бою для воинов что привыкли быть на передовой.";
                        break;
                    case 5:
                        Program.text = "Оружие тяжелых пехотинцев империи. Дальний родственник дубинки, функции те же, но мощь оружия сравнительнее выше.";
                        break;
                    case 6:
                        Program.text = "Говорят, это оружие ассасина. Ухоженое лезвие, его острость невероятна. Относительно дорогое, но и эффективное оружие.";
                        break;
                    case 7:
                        Program.text = "Специализированный топор. Для серьезных войн и дуэлей...тяжелый в сравнении со своим собратом, но за счет веса имеет разрушительную мощь.";
                        break;
                    case 8:
                        Program.text = "Пика(чу) - автор этого оружия однозначно заядлый анимешник, но это не делает Пику тупее или менее эффективной в бою.";
                        break;
                    case 9:
                        Program.text = "Сбалансированное оружие сила которого, зависит в 50% от силы и мастерства владельца, поэтому при его приобретении, стоит несколько раз подумать.";
                        break;
                    case 10:
                        Program.text = "Сделанный эльфийскими кузнецами Рубиновый меч режет как масло доспехи врагов. Но даже такой меч требует великого мастерства.";
                        break;
                    case 11:
                        Program.text = "Благославленный Епископом этого континента меч был создан для уничтожения более сильных прислужников некромантов, позже оказалось что и против живых существ меч очень опасен.";
                        break;
                }
                switch (comboBox1.Text)
                {
                    //, , , , , ,, , , 
                    case "Дубинка":
                        Program.weaponAttack = 2; Program.stepsWeapon = 1;
                        break;
                    case "Ржавый кинжал":
                        Program.weaponAttack = 10; Program.stepsWeapon = 2;
                        break;
                    case "Топор":
                        Program.weaponAttack =20; Program.stepsWeapon = 2;
                        break;
                    case "Меч":
                        Program.weaponAttack = 25; Program.stepsWeapon = 2;
                        break;
                    case "Булава":
                        Program.weaponAttack = 40; Program.stepsWeapon = 4;
                        break;
                    case "Кинжал ассасина":
                        Program.weaponAttack = 30; Program.stepsWeapon = 3;
                        break;
                    case "Боевой топор":
                        Program.weaponAttack =60; Program.stepsWeapon = 4;
                        break;
                    case "Пика(чу)":
                        Program.weaponAttack =85; Program.stepsWeapon = 9;
                        break;
                    case "Палица":
                        Program.weaponAttack = 115; Program.stepsWeapon = 15;
                        break;
                    case "Рубиновый меч":
                        Program.weaponAttack = 100; Program.stepsWeapon = 12;
                        break;
                    case "Святой меч":
                        Program.weaponAttack = 150; Program.stepsWeapon = 14;
                        break;
                    default:
                        Program.weaponAttack = 0;
                        Program.stepsWeapon = 1;
                        break;
                }
                label6.Text = "Цена: " + Program.cell + " Урон: " + Program.weaponAttack + " Очки хода: " + Program.stepsWeapon;

            }
            if (Program.Part == 2)
            {
                switch (Program.armor)//ОПИСАНИЕ БРОНИ
                {
                    case 1:
                        Program.text = "Броня не имеющая особых свойств, часто можно увидеть на кочевниках или разбойниках, так как очень проста и удобна.";
                        break;
                    case 2:
                        Program.text = "Как дополнение к к коженой броне, надевается есстественно на голову.";
                        break;
                    case 3:
                        Program.text = "Примитивный щит, сделанный из древесины, можно защититься от стрел и колющего, и режущего оружия.";
                        break;
                    case 4:
                        Program.text = "Данная броня обладает отличными защитными качествами, в бою может не раз спасти жизнь от неменуемой гибели. Если конечно удары не дробящие.";
                        break;
                    case 5:
                        Program.text = "Шлем от кольчуги, как ее дополнение, так же хорошо защищает своего владельца.";
                        break;
                    case 6:
                        Program.text = "Щит сделанный в имперских кузницах. По качествам лучше своего предшественника.";
                        break;
                    case 7:
                        Program.text = "Железная броня, сделанная из цельных пластин железа отлично защищает от всех видов урона.";
                        break;
                    case 8:
                        Program.text = "Шлем который может вас спасти от хорошего удара по голове.)";
                        break;
                    case 9:
                        Program.text = "Тяжелый железный щит, отличное дополнение к железному снаряжению.";
                        break;
                    case 10:
                        Program.text = "Неизвестно кем, и неизвестно когда, неизвестно был ли он действительно выкован человеком, но данный доспех обладает непостижимыми свойствами защиты.";
                        break;
                    case 11:
                        Program.text = "Шлем выкованный эльфийским мастером, может светиться в темноте, кроме этого отлично защищает черепную коробку.";
                        break;
                    case 12:
                        Program.text = "Этот щит нестолько защищает, сколько атакует...но все же этот щит остается щитом.";
                        break;
                }
                label6.Text = "Цена: " + Program.cell + " Защита: " + arm;
            }
            if (Program.Part == 3)
            {
                switch (Program.staff)
                {
                    case 1:
                        Program.text = "Посох для новичков в магии. Дает возможность использовать магию первого уровня.";
                        break;
                    case 2:
                        Program.text = "Шаманский посох требующий высоких знаний для эффективного управления. Дает возможность использовать магию второго уровня.";
                        break;
                    case 3:
                        Program.text = "По его виду понятно, что данный посох принадлежал некроманту. Не рекомендуется использовать в целях \"поиграть\".";
                        break;
                    case 4:
                        Program.text = "Посох с рубином из недр земли. Таит в себе большую опасность, как и силу. Таким же посохом обладал один из магов континента.";
                        break;
                }

                switch (Program.artefuckt)//АРТЕФАКТЫ
                {
                    case 1:
                        Program.text = "Базовый амулет всех путешевственников, добавляет небольшой процент к максимальному здоровью.";
                        break;
                    case 2:
                        Program.text = "Данное кольцо отнимает магию у владельца, но в обмен дает внушающию силу и скорость регенерации.";
                        break;
                    case 3:
                        Program.text = "Браслет удачи делает своего владельца по своему же названию более удачливым, то бишь плюс к критическому урону и деньгам.";
                        break;
                    case 4:
                        Program.text = "Когда-то эта вещь была благославлена одним из египетских богов, поэтому она может возрадить из мертвых, но лишь раз.";
                        break;
                    case 5:
                        Program.text = "Кольцо улучшающие магические способности своего владельца, несмотря на то что он был некроманта, от него нет враждебной ауры.";
                        break;
                    case 6:
                        Program.text = "Артефакт намного сильнее своего предшевственика, добавляет процент к максимальному здоровью, плюс регенеративную способность.";
                        break;
                    case 7:
                        Program.text = "Кольцо \"IYX\", существует еще до формирования континента, невероятная сила скрывается в нем.";
                        break;
                }
                label6.Text = "Цена: " + Program.cell;
            }
            if (Program.Part == 4)
            {
                switch (Program.items)//rashodniki
                {
                    case 1:
                        Program.text = "Восстанавливает 10% здоровья.";
                        break;
                    case 2:
                        Program.text = "Восстанавливает 10% маны.";
                        break;
                    case 3:
                        Program.text = "Восстанавливает 30% очков ходов.";
                        break;
                    case 4:
                        Program.text = "Восстанавливает 30% здоровья.";
                        break;
                    case 5:
                        Program.text = "Восстанавливает 30% маны.";
                        break;
                }
                label6.Text = "Цена: " + Program.cell;
            }

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch ((string)comboBox4.SelectedItem)
            {
                case "Зелье здоровья":
                    pictureBox1.Image = Properties.Resources.potion_red_small;
                    Program.items = 1; Program.cell = 2000;
                    break;
                case "Зелье маны":
                    pictureBox1.Image = Properties.Resources.potion_green_small;
                    Program.items = 2; Program.cell = 0;
                    break;
                case "Свиток ускорения":
                    pictureBox1.Image = Properties.Resources.scroll_red;
                    Program.items = 3; Program.cell = 10000;
                    break;
                case "Большое зелье здоровья":
                    pictureBox1.Image = Properties.Resources.potion_red_medium;
                    Program.items = 4; Program.cell = 4000;
                    break;
                case "Большое зелье маны":
                    pictureBox1.Image = Properties.Resources.potion_green_medium;
                    Program.items = 5; Program.cell = 0;
                    break;
            }
            Program.Part = 4;
            description();
            label1.Text = Program.text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            additem();
        }

        public void additem()
        {
            if (Program.money >= Program.cell)
            {

                int number = 0;
                bool cell = false;
                switch (Program.Part)
                {
                    case 1:
                        item = (string)comboBox1.SelectedItem;
                        break;
                    case 2:
                        item = (string)comboBox2.SelectedItem;
                        break;
                    case 3:
                        item = (string)comboBox3.SelectedItem;
                        break;
                    case 4:
                        item = (string)comboBox4.SelectedItem;
                        break;
                }

                while (!cell || number != 25)
                {
                    label7.Text = item;
                    number++;
                    if (number == 25)
                    {
                        label7.Text = "Нет места в ивентаре";
                        break;
                    }
                    if (Program.inventory[number] == "")
                    {
                        Program.money -= Program.cell;
                        Program.f4.UpgradeWeapon();
                        Program.inventory[number] = item;
                        Program.inv.Upgrade();
                        Program.f4.UpgradeHelmet();
                        Program.f4.UpgradeArmor();
                        Program.f4.UpgradeShield();
                        Program.f4.UpgradeStaff();
                        Program.f4.UpgradeArtefucts();
                        cell = true;
                        break;
                    }
                }
            }
            else label7.Text = "Не хватает деняк";
            label8.Text = "Денег: " + Program.money;
        }

        private void Shop_VisibleChanged(object sender, EventArgs e)
        {
            label8.Text = "Денег: " + Program.money;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Program.money = 99999999;
            Program.maxHP = 9999;
            Program.HP = 9999;
            Program.map1 = 50;
            Program.map2 = 50;
            Program.map3 = 50;
            Program.map4 = 50;
            Program.map5 = 50;
            Program.maxSteps = 5000;
        }

        private void button2_VisibleChanged(object sender, EventArgs e)
        {

        }
    }
}