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
    public partial class Form3 : Form
    {
        int stepsEnemy = 0;
        bool win = false;
        public Form3()
        {
            InitializeComponent();
        }
        int hpE;
        Random r = new Random();
        Bitmap[] images = new Bitmap[30];
        private void button5_Click(object sender, EventArgs e) // Кнопка Сбежать
        {
            Program.f3.Hide();
            Program.f4.Show();
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e) // Подстраховка, сохранение при выходе
        {
            Program.SForm.button4_Click(null, null);
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e) // кнопка выхода
        {
            Program.f3.Hide();
            Program.SForm.Show();
        }
        int plus = 0, plusXP = 0;
        int attack = 0;
        private void button1_Click(object sender, EventArgs e) // Кнопка атаки
        {
            if (Program.Steps >= Program.stepsWeapon)
            {
                Program.Steps -= Program.stepsWeapon;
                Defend = false;
                Random r = new Random();
                HeroAnimation.Start();
                
                if (Program.CriticalAttack < r.Next(1, 100))
                {
                    attack = (int)Math.Round((Program.baseAttack + Program.weaponAttack) * 1.5);
                }
                else
                {
                    attack = (Program.baseAttack + Program.weaponAttack);
                }
                if (enemyHP > attack)
                {
                    enemyHP -= attack;//атака на врага
                }
                else
                {
                    switch (Program.ivent)
                    {

                        case 1: // определение локации за которую будет засчитываться при выигрыше
                        case 2:
                        case 7:
                            Program.map1++;
                            plus = newProgressBar5.Maximum;
                            plusXP = (int)Math.Round(newProgressBar5.Maximum * 0.5, 0);
                            break;
                        case 3:
                        case 8:
                            Program.map2++;
                            plus = newProgressBar5.Maximum * 10;
                            plusXP = newProgressBar5.Maximum;
                            break;
                        case 4:
                        case 9:
                            Program.map3++;
                            plus = newProgressBar5.Maximum * 20;
                            plusXP = newProgressBar5.Maximum * 2;
                            break;
                        case 5:
                        case 10:
                            Program.map4++;
                            plus = newProgressBar5.Maximum * 30;
                            plusXP = newProgressBar5.Maximum * 4;
                            break;
                        case 6:
                        case 11:
                            Program.map5++;
                            plus = newProgressBar5.Maximum * 40;
                            plusXP = newProgressBar5.Maximum * 8;
                            break;
                        default:
                            break;

                    }
                    enemyHP = 0;
                    Program.f3.Hide();
                    MessageBox.Show("Вы получили " + plus + " золота!\nИ "+ plusXP +" Опыта!", "Победа!", MessageBoxButtons.OK, MessageBoxIcon.None);
                    Program.money += plus;
                   
                    Program.Exp += plusXP;
                    Program.f4.Show();
                    win = true;

                    //ПОБЕДА
                }
                stepsEnemy++;
                if (stepsEnemy > r.Next(stepsEnem - 4, 1 + stepsEnem))
                {
                    attackEnemy();
                    progressBarsCheck();
                    EnemyAnimation.Start();
                    stepsEnemy = 0;
                }
                progressBarsCheck();
            }
            else button1.Enabled = false;
            progressBarsCheck();
        }

        int HeroAni = 0;
        private void HeroAnimation_Tick(object sender, EventArgs e) // анимации героев 
        {

            HeroAni++;
            if (Program.person == 1)
                switch (HeroAni)
                {
                    case 1:
                        pictureBox1.Image = Properties.Resources.haldric_ii_sword_1;
                        break;
                    case 2:
                        pictureBox1.Image = Properties.Resources.haldric_ii_sword_2;
                        break;
                    case 3:
                        pictureBox1.Image = Properties.Resources.haldric_ii_sword_3;
                        break;
                    case 4:
                        pictureBox1.Image = Properties.Resources.haldric_ii_sword_4;
                        break;
                    default:
                        pictureBox1.Image = Properties.Resources.haldric_ii;
                        HeroAni = 0;
                        HeroAnimation.Stop();
                        break;
                }
            else if (Program.person == 2)
                switch (HeroAni)
                {
                    case 1:
                        pictureBox1.Image = Properties.Resources.human_princess_attack_1;
                        break;
                    case 2:
                        pictureBox1.Image = Properties.Resources.human_princess_attack_2;
                        break;
                    case 3:
                        pictureBox1.Image = Properties.Resources.human_princess_attack_3;
                        break;
                    case 4:
                        pictureBox1.Image = Properties.Resources.human_princess_attack_4;
                        break;
                    default:
                        pictureBox1.Image = Properties.Resources.human_princess;
                        HeroAni = 0;
                        HeroAnimation.Stop();
                        break;
                }
        }

        private void progressBarsCheck() // обновление прогресс баров
        {
            newProgressBar1.Maximum = Program.maxHP;
            newProgressBar1.Value = Program.HP;

            newProgressBar3.Maximum = Program.maxSteps;
            newProgressBar3.Value = Program.Steps;
            if (newProgressBar1.Value <= newProgressBar1.Maximum * 0.3)
                newProgressBar1.Brush = Brushes.Red;
            else newProgressBar1.Brush = Brushes.LimeGreen;
            newProgressBar5.Value = enemyHP;
            hpl.Text = "" + newProgressBar1.Value + "/" + newProgressBar1.Maximum;
            xpl.Text = newProgressBar3.Value + "/" + newProgressBar3.Maximum;
            label7.Text = newProgressBar5.Value + "/" + newProgressBar5.Maximum;
        }

        int dialog = 1;
        private void Ivents() // настройка диалогов
        {
            Event.Stop();

            switch (Program.ivent)
            {
                case 1: // начaльный ивент
                    EnemySet(1);
                    switch (dialog)
                    {

                        case 1:
                            button1.Enabled = false;
                            button3.Enabled = false;
                            button2.Enabled = true;
                            label4.TextAlign = ContentAlignment.TopRight;
                            label4.Text = "Ха- ха! Вот ты и попался!";
                            break;
                        case 2:
                            label4.TextAlign = ContentAlignment.TopLeft;
                            label4.Text = "Отпусти меня! (>.<)";
                            break;
                        case 3:
                            label4.TextAlign = ContentAlignment.TopRight;
                            label4.Text = "Нет, я тебя сейчас убью!";
                            break;
                        case 4:
                            label4.TextAlign = ContentAlignment.TopLeft;
                            label4.Text = "Чтож, буду защищаться!(￢_￢)";
                            break;
                        default:
                            label4.Text = "";
                            dialog = 1;
                            button1.Enabled = true;
                            button3.Enabled = true;
                            button2.Enabled = false;
                            break;
                    }
                    break;
                case 2: //Локация 1
                    label4.Text = "";
                    button1.Enabled = true;
                    button3.Enabled = true;
                    button2.Enabled = false;
                    EnemySet(r.Next(1, 10));
                    break;
                case 3: // Локация 2
                    label4.Text = "";
                    button1.Enabled = true;
                    button3.Enabled = true;
                    button2.Enabled = false;
                    EnemySet(r.Next(10, 19));
                    break;
                case 4: // Локация 3
                    label4.Text = "";
                    button1.Enabled = true;
                    button3.Enabled = true;
                    button2.Enabled = false;
                    EnemySet(r.Next(19, 28));
                    break;
                case 5://локация 4
                    label4.Text = "";
                    button1.Enabled = true;
                    button3.Enabled = true;
                    button2.Enabled = false;
                    EnemySet(r.Next(28, 37));
                    break;
                case 6:// локация 5
                    label4.Text = "";
                    button1.Enabled = true;
                    button3.Enabled = true;
                    button2.Enabled = false;
                    EnemySet(r.Next(37, 46));
                    break;
                case 7: //Босс первой локации
                    switch (dialog)
                    {
                        case 1:
                            button1.Enabled = false;
                            button3.Enabled = false;
                            button2.Enabled = true;
                            label4.TextAlign = ContentAlignment.TopRight;
                            label4.Text = "Ну здравствуй! Ты так далеко прошёл! Только жаль что зря. Ведь сейчас я тебя убью!";
                            break;
                        case 2:
                            label4.TextAlign = ContentAlignment.TopLeft;
                            label4.Text = "Я так просто не сдамся!";
                            break;
                        case 3:
                            label4.TextAlign = ContentAlignment.TopRight;
                            label4.Text = "Ахаха! Ну уж нет!";
                            break;
                        case 4:
                            label4.TextAlign = ContentAlignment.TopLeft;
                            label4.Text = "Вот увидишь, я тебя победю!";
                            break;
                        default:
                            label4.Text = "";
                            dialog = 1;
                            button1.Enabled = true;
                            button3.Enabled = true;
                            button2.Enabled = false;
                            break;
                    }
                    EnemySet(46);
                    break;
                case 8://Босс 2 локации
                    switch (dialog)
                    {
                        case 1:
                            button1.Enabled = false;
                            button3.Enabled = false;
                            button2.Enabled = true;
                            label4.TextAlign = ContentAlignment.TopRight;
                            label4.Text = "ЫЫЫЫ";
                            break;
                        case 2:
                            label4.TextAlign = ContentAlignment.TopLeft;
                            label4.Text = "Боже, неужели ещё один босс";
                            break;
                        case 3:
                            label4.TextAlign = ContentAlignment.TopRight;
                            label4.Text = "ыыЫЫЫыыыЫЫ!";
                            break;
                        case 4:
                            label4.TextAlign = ContentAlignment.TopLeft;
                            label4.Text = "Мдя, он слабоумный";
                            break;
                        default:
                            label4.Text = "";
                            dialog = 1;
                            button1.Enabled = true;
                            button3.Enabled = true;
                            button2.Enabled = false;
                            break;
                    }
                    EnemySet(47);
                    break;
                case 9://Босс 3 локации
                    switch (dialog)
                    {
                        case 1:
                            button1.Enabled = false;
                            button3.Enabled = false;
                            button2.Enabled = true;
                            label4.TextAlign = ContentAlignment.TopRight;
                            label4.Text = "Извени за моего тупого брата. Я слышал что ты его победил.";
                            break;
                        case 2:
                            label4.TextAlign = ContentAlignment.TopLeft;
                            label4.Text = "Ну да, даун был ещё тот.";
                            break;
                        case 3:
                            label4.TextAlign = ContentAlignment.TopRight;
                            label4.Text = "Ладно, я не разочарую тебя!";
                            break;
                        case 4:
                            label4.TextAlign = ContentAlignment.TopLeft;
                            label4.Text = "Мдя, он слабоумный";
                            break;
                        default:
                            label4.Text = "";
                            dialog = 1;
                            button1.Enabled = true;
                            button3.Enabled = true;
                            button2.Enabled = false;
                            break;
                    }
                    EnemySet(48);
                    break;
                case 10://Босс 4 локации
                    switch (dialog)
                    {
                        case 1:
                            button1.Enabled = false;
                            button3.Enabled = false;
                            button2.Enabled = true;
                            label4.TextAlign = ContentAlignment.TopRight;
                            label4.Text = "Давай сразу перейдём к делу!";
                            break;
                        case 2:
                            label4.TextAlign = ContentAlignment.TopLeft;
                            label4.Text = "Ещё один тупой дракон. Почему одни драконы? Я что, Довакин?";
                            break;
                        case 3:
                            label4.TextAlign = ContentAlignment.TopRight;
                            label4.Text = "Ненавижу разработчкиков";
                            break;
                        case 4:
                            label4.TextAlign = ContentAlignment.TopLeft;
                            label4.Text = "Я тоже";
                            break;
                        default:
                            label4.Text = "";
                            dialog = 1;
                            button1.Enabled = true;
                            button3.Enabled = true;
                            button2.Enabled = false;
                            break;
                    }
                    EnemySet(49);
                    break;
                case 11://Босс 5 локации
                    switch (dialog)
                    {
                        case 1:
                            button1.Enabled = false;
                            button3.Enabled = false;
                            button2.Enabled = true;
                            label4.TextAlign = ContentAlignment.TopRight;
                            label4.Text = "УУУУУ Я главный босс!";
                            break;
                        case 2:
                            label4.TextAlign = ContentAlignment.TopLeft;
                            label4.Text = "Неужто не дракон?";
                            break;
                        case 3:
                            label4.TextAlign = ContentAlignment.TopRight;
                            label4.Text = "Я Каспер, дружелюбное приведение, нах!";
                            break;
                        case 4:
                            label4.TextAlign = ContentAlignment.TopLeft;
                            label4.Text = "Ну тогда я GhostBuster";
                            break;
                        default:
                            label4.Text = "";
                            dialog = 1;
                            button1.Enabled = true;
                            button3.Enabled = true;
                            button2.Enabled = false;
                            break;
                    }
                    EnemySet(50);
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e) // Кнопка продолжить
        {
            dialog++;
            Ivents();
        }
        int longAnime = 0;
        int animation = 0;

        private void EnemyAnimation_Tick(object sender, EventArgs e) //анимация и атака врага
        {
            pictureBox2.Image = images[0];
            animation++;
            if (longAnime == animation)
            {
                animation = 0;
                pictureBox2.Image = images[0];//Кадр по дефолту
                EnemyAnimation.Stop();
            }
            if (longAnime >= 1 && animation == 1)// Анимация и ее установленный предел

                pictureBox2.Image = images[animation];
            if (longAnime >= 2 && animation == 2)

                pictureBox2.Image = images[animation];
            if (longAnime >= 3 && animation == 3)

                pictureBox2.Image = images[animation];
            if (longAnime >= 4 && animation == 4)

                pictureBox2.Image = images[animation];
            if (longAnime >= 5 && animation == 5)

                pictureBox2.Image = images[animation];
            if (longAnime >= 6 && animation == 6)

                pictureBox2.Image = images[animation];
            if (longAnime >= 7 && animation == 7)

                pictureBox2.Image = images[animation];
            if (longAnime >= 8 && animation == 8)

                pictureBox2.Image = images[animation];
            if (longAnime >= 9 && animation == 9)

                pictureBox2.Image = images[animation];
            if (longAnime >= 10 && animation == 10)
                pictureBox2.Image = images[animation];
            if (longAnime >= 11 && animation == 11)

                pictureBox2.Image = images[animation];
            if (longAnime >= 12 && animation == 12)

                pictureBox2.Image = images[animation];
            if (longAnime >= 13 && animation == 13)

                pictureBox2.Image = images[animation];
            if (longAnime >= 14 && animation == 14)

                pictureBox2.Image = images[animation];
            if (longAnime >= 15 && animation == 15)

                pictureBox2.Image = images[animation];

        }

        bool Defend = false;
        public void attackEnemy()
        {
            int eAttack = 0;
            if (Defend == false)
            {
                int eRAttack = r.Next(Program.enemyDamage - 3, Program.enemyDamage);
                eAttack = eRAttack;
                eAttack = eAttack - (Program.helmetDef + Program.armorDef + Program.shieldDef);
                if (eAttack < 1)
                {
                    eAttack = 1;
                }
                if (Program.HP < eAttack)
                {

                    Program.HP = 0;
                    //Game over
                    //if net ANKH
                    if (!win)
                    {

                        Program.f3.Hide();
                        MessageBox.Show("Вы умерли!", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Program.f1.Show();
                    }
                }
                else
                {
                    Program.HP -= eAttack;
                }
            }
            else
            {
                int eRAttack = (int)Math.Round(r.Next(Program.enemyDamage - 3, Program.enemyDamage) * 0.4);
                eAttack = eRAttack;
                eAttack = eAttack - (Program.helmetDef + Program.armorDef + Program.shieldDef);
                if (eAttack < 1)
                {
                    eAttack = 1;
                }
                if (Program.HP < eAttack)
                {
                    if (!win)
                    {
                        Program.HP = 0;
                        //Game over
                        MessageBox.Show("Вы умерли!", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Program.f3.Hide();
                        Program.f1.Show();
                    }
                }
                else
                {
                    Program.HP -= eAttack;
                }

            }
            progressBarsCheck();
        }

        int enemyHP;


        private void Event_Tick(object sender, EventArgs e) //костыль для реализации ивента
        {
            Ivents();
        }
        int stepsEnem;
        private void button3_Click(object sender, EventArgs e)
        {
            Defend = true;
            stepsEnemy++;
            if (stepsEnemy > r.Next(stepsEnem - 4, 1 + stepsEnem))
            {
                attackEnemy();
                progressBarsCheck();
                EnemyAnimation.Start();
                stepsEnemy = 0;
            }
            progressBarsCheck();
            int stepsplus = (int)Math.Round(Program.maxSteps * 0.2);
            if (stepsplus + Program.Steps < Program.maxSteps)
                Program.Steps += stepsplus;
            else Program.Steps = Program.maxSteps;
            progressBarsCheck();
            if (Program.stepsWeapon <= Program.Steps) button1.Enabled = true;
        }


        public void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Program.stepsWeapon <= Program.Steps) button1.Enabled = true;
            switch (comboBox1.Text)
            {

                case "Дубинка":
                    Program.weaponAttack = 2; Program.stepsWeapon = 1; pictureBox3.Image = Properties.Resources.CLUB;
                    break;
                case "Ржавый кинжал":
                    Program.weaponAttack = 10; Program.stepsWeapon = 2; pictureBox3.Image = Properties.Resources.dagger_undead;
                    break;
                case "Топор":
                    Program.weaponAttack = 20; Program.stepsWeapon = 2; pictureBox3.Image = Properties.Resources.axe_undead;
                    break;
                case "Меч":
                    Program.weaponAttack = 25; Program.stepsWeapon = 2; pictureBox3.Image = Properties.Resources.sword_human;
                    break;
                case "Булава":
                    Program.weaponAttack = 40; Program.stepsWeapon = 4; pictureBox3.Image = Properties.Resources.mace_spiked;
                    break;
                case "Кинжал ассасина":
                    Program.weaponAttack = 30; Program.stepsWeapon = 3; pictureBox3.Image = Properties.Resources.dagger_orcish;
                    break;
                case "Боевой топор":
                    Program.weaponAttack = 60; Program.stepsWeapon = 4; pictureBox3.Image = Properties.Resources.battleaxe;
                    break;
                case "Пика(чу)":
                    Program.weaponAttack = 85; Program.stepsWeapon = 9; pictureBox3.Image = Properties.Resources.PIKE;
                    break;
                case "Палица":
                    Program.weaponAttack = 115; Program.stepsWeapon = 15; pictureBox3.Image = Properties.Resources.MACE;
                    break;
                case "Рубиновый меч":
                    Program.weaponAttack = 100; Program.stepsWeapon = 12; pictureBox3.Image = Properties.Resources.SCIMITAR;
                    break;
                case "Святой меч":
                    Program.weaponAttack = 150; Program.stepsWeapon = 14; pictureBox3.Image = Properties.Resources.sword_holy;
                    break;
                default:
                    pictureBox3.Image = null;
                    Program.weaponAttack = 0;
                    Program.stepsWeapon = 1;
                    break;
            }

        }
        private void Form3_VisibleChanged(object sender, EventArgs e)
        {
            comboBox1_SelectedIndexChanged(null, null);
            win = false;
            progressBarsCheck();
            label5.Text = Program.Name;//Вставляем имя героя
            if (Program.person == 1)
                Program.f3.pictureBox1.Image = Properties.Resources.haldric_ii;
            if (Program.person == 2)
                Program.f3.pictureBox1.Image = Properties.Resources.human_princess;
            //Изображение героя
            newProgressBar3.Brush = Brushes.Orange;
            //Меняем цвета прогрессбаров 
            dialog = 1; // обнуление стадии диалога 
            Event.Start(); // запуск Ивента
            Program.Steps = Program.maxSteps;
            if (Program.f3.Visible == true)
                Program.f4.HPtimer.Stop();
            else
                Program.f4.HPtimer.Start();
        }

        public void EnemySet(int id) // настраивает изображение и здоровье врага
        {
            switch (id)
            {
                case 1:
                    hpE = 35;
                    stepsEnem = 6;
                    Program.Enemy = id;
                    label6.Text = "Гоблин";
                    pictureBox2.Image = Properties.Resources.impaler;
                    images[0] = Properties.Resources.impaler;//default
                    images[1] = Properties.Resources.impaler_attack_n;//attack1
                    images[2] = Properties.Resources.impaler_attack_ne;//attack2
                    longAnime = 3;
                    Program.enemyDamage = 4;
                    break;
                case 2:
                    hpE = 60;
                    stepsEnem = 6;
                    Program.Enemy = id;
                    label6.Text = "Злой программист";
                    pictureBox2.Image = Properties.Resources.fencer;
                    images[0] = Properties.Resources.fencer;
                    images[1] = Properties.Resources.fencer_attack_2;
                    images[2] = Properties.Resources.fencer_attack_3;
                    images[3] = Properties.Resources.fencer_attack_4;
                    images[4] = Properties.Resources.fencer_attack_5;
                    images[5] = Properties.Resources.fencer_attack_6;
                    images[6] = Properties.Resources.fencer_attack_7;
                    images[7] = Properties.Resources.fencer_attack_8;
                    images[8] = Properties.Resources.fencer_attack_9;
                    longAnime = 9;
                    Program.enemyDamage = 10;
                    break;
                case 3:
                    stepsEnem = 8;
                    hpE = 120;
                    Program.Enemy = id;
                    longAnime = 16;
                    Program.enemyDamage = 14;
                    label6.Text = "Стальной человек";
                    pictureBox2.Image = Properties.Resources.heavyinfantry;
                    images[0] = Properties.Resources.heavyinfantry;
                    images[1] = Properties.Resources.heavyinfantry_attack_1;
                    images[2] = Properties.Resources.heavyinfantry_attack_2;
                    images[3] = Properties.Resources.heavyinfantry_attack_3;
                    images[4] = Properties.Resources.heavyinfantry_attack_4;
                    images[5] = Properties.Resources.heavyinfantry_attack_5;
                    images[6] = Properties.Resources.heavyinfantry_attack_6;
                    images[7] = Properties.Resources.heavyinfantry_attack_7;
                    images[8] = Properties.Resources.heavyinfantry_attack_8;
                    images[9] = Properties.Resources.heavyinfantry_attack_9;
                    images[10] = Properties.Resources.heavyinfantry_attack_10;
                    images[11] = Properties.Resources.heavyinfantry_attack_11;
                    images[12] = Properties.Resources.heavyinfantry_attack_12;
                    images[13] = Properties.Resources.heavyinfantry_attack_13;
                    images[14] = Properties.Resources.heavyinfantry_attack_14;
                    images[15] = Properties.Resources.heavyinfantry_attack_15;

                    break;
                case 4:
                    hpE = 20;
                    stepsEnem = 6;
                    Program.Enemy = id;
                    label6.Text = "Крестьянин";
                    pictureBox2.Image = Properties.Resources.peasant;
                    longAnime = 7;
                    Program.enemyDamage = 4;
                    images[0] = Properties.Resources.peasant;
                    images[1] = Properties.Resources.peasant_attack;
                    images[2] = Properties.Resources.peasant_attack1;
                    images[3] = Properties.Resources.peasant_attack2;
                    images[4] = Properties.Resources.peasant_attack3;
                    images[5] = Properties.Resources.peasant_attack4;
                    images[6] = Properties.Resources.peasant_attack5;
                    break;
                case 5:
                    hpE = 100;
                    stepsEnem = 9;
                    Program.Enemy = id;
                    label6.Text = "Пьяный трактирщик";
                    pictureBox2.Image = Properties.Resources.young_ogre;
                    longAnime = 5;
                    Program.enemyDamage = 12;
                    images[0] = Properties.Resources.young_ogre;
                    images[1] = Properties.Resources.young_ogre_attack1;
                    images[2] = Properties.Resources.young_ogre_attack2;
                    images[3] = Properties.Resources.young_ogre_attack3;
                    images[4] = Properties.Resources.young_ogre_attack4;
                    break;
                case 6:
                    hpE = 180;
                    stepsEnem = 12;
                    Program.Enemy = id;
                    label6.Text = "Горный огр";
                    pictureBox2.Image = Properties.Resources.ogre;
                    longAnime = 6;
                    Program.enemyDamage = 18;
                    images[0] = Properties.Resources.ogre;
                    images[1] = Properties.Resources.ogre_attack1;
                    images[2] = Properties.Resources.ogre_attack2;
                    images[3] = Properties.Resources.ogre_attack3;
                    images[4] = Properties.Resources.ogre_attack4;
                    images[5] = Properties.Resources.ogre_attack5;
                    break;
                case 7:
                    hpE = 95;
                    stepsEnem = 7;
                    Program.Enemy = id;
                    label6.Text = "Орк-сержант";
                    pictureBox2.Image = Properties.Resources.leader;
                    longAnime = 6;
                    Program.enemyDamage = 11;
                    images[0] = Properties.Resources.leader;
                    images[1] = Properties.Resources.leader_attack_1;
                    images[2] = Properties.Resources.leader_attack_2;
                    images[3] = Properties.Resources.leader_attack_3;
                    images[4] = Properties.Resources.leader_attack_4;
                    images[5] = Properties.Resources.leader_attack_5;
                    break;
                case 8:
                    stepsEnem = 6;
                    hpE = 80;
                    Program.Enemy = id;
                    longAnime = 10;
                    Program.enemyDamage = 18;
                    label6.Text = "Ассасин";
                    pictureBox2.Image = Properties.Resources.nightblade;
                    images[0] = Properties.Resources.nightblade;
                    images[1] = Properties.Resources.nightblade_attack_se1;
                    images[2] = Properties.Resources.nightblade_attack_se2;
                    images[3] = Properties.Resources.nightblade_attack_se3;
                    images[4] = Properties.Resources.nightblade_attack_se4;
                    images[5] = Properties.Resources.nightblade_attack_se5;
                    images[6] = Properties.Resources.nightblade_attack_se6;
                    images[7] = Properties.Resources.nightblade_attack_se7;
                    images[8] = Properties.Resources.nightblade_attack_se8;
                    images[9] = Properties.Resources.nightblade_attack_se9;
                    break;
                case 9:
                    hpE = 175;
                    stepsEnem = 10;
                    Program.Enemy = id;
                    label6.Text = "Орк-ветеран";
                    pictureBox2.Image = Properties.Resources.warrior;
                    longAnime = 5;
                    Program.enemyDamage = 13;
                    images[0] = Properties.Resources.warrior;
                    images[1] = Properties.Resources.warrior_attack_1;
                    images[2] = Properties.Resources.warrior_attack_2;
                    images[3] = Properties.Resources.warrior_attack_3;
                    images[4] = Properties.Resources.warrior_attack_4;
                    break;
                case 10:
                    hpE = 60;
                    stepsEnem = 8;
                    Program.Enemy = id;
                    label6.Text = "Незнакомец";
                    pictureBox2.Image = Properties.Resources.xbowman_melee;
                    longAnime = 5;
                    Program.enemyDamage = 9;
                    images[0] = Properties.Resources.xbowman_melee;
                    images[1] = Properties.Resources.xbowman_melee_attack_1;
                    images[2] = Properties.Resources.xbowman_melee_attack_2;
                    images[3] = Properties.Resources.xbowman_melee_attack_3;
                    images[4] = Properties.Resources.xbowman_melee_attack_4;
                    break;
                case 11:
                    hpE = 210;
                    stepsEnem = 12;
                    Program.Enemy = id;
                    label6.Text = "Тролль-воин";
                    pictureBox2.Image = Properties.Resources.grunt;
                    longAnime = 5;
                    Program.enemyDamage = 44;
                    images[0] = Properties.Resources.grunt;
                    images[1] = Properties.Resources.grunt_attack_1;
                    images[2] = Properties.Resources.grunt_attack_2;
                    images[3] = Properties.Resources.grunt_attack_3;
                    images[4] = Properties.Resources.grunt_attack_4;
                    break;
                case 12:
                    hpE = 185;
                    stepsEnem = 4;
                    Program.Enemy = id;
                    label6.Text = "Тролль-боксер";
                    pictureBox2.Image = Properties.Resources.shaman;
                    longAnime = 5;
                    Program.enemyDamage = 11;
                    images[0] = Properties.Resources.shaman;
                    images[1] = Properties.Resources.shaman_fist_1;
                    images[2] = Properties.Resources.shaman_fist_2;
                    images[3] = Properties.Resources.shaman_fist_3;
                    images[4] = Properties.Resources.shaman_fist_4;
                    break;
                case 13:
                    hpE = 360;
                    stepsEnem = 4;
                    Program.Enemy = id;
                    label6.Text = "Тролль-Вожак";
                    pictureBox2.Image = Properties.Resources.troll_hero;
                    longAnime = 6;
                    Program.enemyDamage = 16;
                    images[0] = Properties.Resources.troll_hero;
                    images[1] = Properties.Resources.troll_hero_attack_se_1;
                    images[2] = Properties.Resources.troll_hero_attack_se_2;
                    images[3] = Properties.Resources.troll_hero_attack_se_3;
                    images[4] = Properties.Resources.troll_hero_attack_se_4;
                    images[5] = Properties.Resources.troll_hero_attack_se_5;
                    break;
                case 14:
                    hpE = 320;
                    stepsEnem = 15;
                    Program.Enemy = id;
                    label6.Text = "Тролль-Ветеран";
                    pictureBox2.Image = Properties.Resources.warrior_attack_12__5_;
                    longAnime = 5;
                    Program.enemyDamage = 66;
                    images[0] = Properties.Resources.warrior_attack_12__5_;
                    images[1] = Properties.Resources.warrior_attack_12__1_;
                    images[2] = Properties.Resources.warrior_attack_12__2_;
                    images[3] = Properties.Resources.warrior_attack_12__3_;
                    images[4] = Properties.Resources.warrior_attack_12__4_;
                    break;
                case 15:
                    hpE = 60;
                    stepsEnem = 7;
                    Program.Enemy = id;
                    label6.Text = "Тролль-детеныш";
                    pictureBox2.Image = Properties.Resources.whelp;
                    longAnime = 4;
                    Program.enemyDamage = 8;
                    images[0] = Properties.Resources.whelp;
                    images[1] = Properties.Resources.whelp_attack_1;
                    images[2] = Properties.Resources.whelp_attack_2;
                    images[3] = Properties.Resources.whelp_attack_3;
                    break;
                case 16:
                    hpE = 100;
                    stepsEnem = 7;
                    Program.Enemy = id;
                    label6.Text = "Геолог";
                    pictureBox2.Image = Properties.Resources.explorer_melee_1;
                    longAnime = 5;
                    Program.enemyDamage = 20;
                    images[0] = Properties.Resources.explorer_melee_1;
                    images[1] = Properties.Resources.explorer_melee_2;
                    images[2] = Properties.Resources.explorer_melee_3;
                    images[3] = Properties.Resources.explorer_melee_4;
                    images[4] = Properties.Resources.explorer_melee_5;
                    break;
                case 17:
                    hpE = 90;
                    stepsEnem = 8;
                    Program.Enemy = id;
                    label6.Text = "Лесник";
                    pictureBox2.Image = Properties.Resources.fighter;
                    longAnime = 5;
                    Program.enemyDamage = 15;
                    images[0] = Properties.Resources.fighter;
                    images[1] = Properties.Resources.fighter_se_axe2;
                    images[2] = Properties.Resources.fighter_se_axe3;
                    images[3] = Properties.Resources.fighter_se_axe4;
                    images[4] = Properties.Resources.fighter_se_axe5;
                    break;
                case 18:
                    hpE = 170;
                    stepsEnem = 8;
                    Program.Enemy = id;
                    label6.Text = "Заблудший легионер";
                    pictureBox2.Image = Properties.Resources.guard_attack_1;
                    longAnime = 5;
                    Program.enemyDamage = 26;
                    images[0] = Properties.Resources.guard_attack_1;
                    images[1] = Properties.Resources.guard_attack_2;
                    images[2] = Properties.Resources.guard_attack_3;
                    images[3] = Properties.Resources.guard_attack_4;
                    images[4] = Properties.Resources.guard_attack_5;
                    break;
                case 19:
                    hpE = 400;
                    stepsEnem = 12;
                    Program.Enemy = id;
                    label6.Text = "Богатырь";
                    pictureBox2.Image = Properties.Resources.lord;
                    longAnime = 5;
                    Program.enemyDamage = 32;
                    images[0] = Properties.Resources.lord;
                    images[1] = Properties.Resources.lord_se_axe2;
                    images[2] = Properties.Resources.lord_se_axe3;
                    images[3] = Properties.Resources.lord_se_axe4;
                    images[4] = Properties.Resources.lord_se_axe5;
                    break;
                case 20:
                    hpE = 200;
                    stepsEnem = 15;
                    Program.Enemy = id;
                    label6.Text = "Мастер рун";
                    pictureBox2.Image = Properties.Resources.runesmith_attack_se_4;
                    longAnime = 5;
                    Program.enemyDamage = 66;
                    images[0] = Properties.Resources.runesmith_attack_se_4;
                    images[1] = Properties.Resources.runesmith_attack_se_5;
                    images[2] = Properties.Resources.runesmith_attack_se_6;
                    images[3] = Properties.Resources.runesmith_attack_se_7;
                    images[4] = Properties.Resources.runesmith_attack_se_8;
                    break;
                case 21:
                    hpE = 170;
                    stepsEnem = 8;
                    Program.Enemy = id;
                    label6.Text = "Дворф-воин";
                    pictureBox2.Image = Properties.Resources.steelclad;
                    longAnime = 5;
                    Program.enemyDamage = 40;
                    images[0] = Properties.Resources.steelclad;
                    images[1] = Properties.Resources.steelclad_se_axe2;
                    images[2] = Properties.Resources.steelclad_se_axe3;
                    images[3] = Properties.Resources.steelclad_se_axe4;
                    images[4] = Properties.Resources.steelclad_se_axe5;
                    break;
                case 22:
                    hpE = 222;
                    stepsEnem = 1;
                    Program.Enemy = id;
                    label6.Text = "Ульфсерк";
                    pictureBox2.Image = Properties.Resources.ulfserker_attack_1;
                    longAnime = 5;
                    Program.enemyDamage = 15;
                    images[0] = Properties.Resources.ulfserker_attack_1;
                    images[1] = Properties.Resources.ulfserker_attack_3;
                    images[2] = Properties.Resources.ulfserker_attack_4;
                    images[3] = Properties.Resources.ulfserker_attack_5;
                    images[4] = Properties.Resources.ulfserker_attack_6;
                    break;
                case 23:
                    hpE = 444;
                    stepsEnem = 4;
                    Program.Enemy = id;
                    label6.Text = "Берфсеркер";
                    pictureBox2.Image = Properties.Resources.berserker_attack_1;
                    longAnime = 5;
                    Program.enemyDamage = 25;
                    images[0] = Properties.Resources.berserker_attack_1;
                    images[1] = Properties.Resources.berserker_attack_2;
                    images[2] = Properties.Resources.berserker_attack_3;
                    images[3] = Properties.Resources.berserker_attack_4;
                    images[4] = Properties.Resources.berserker_attack_5;
                    break;
                case 24:
                    hpE = 210;
                    stepsEnem = 10;
                    Program.Enemy = id;
                    label6.Text = "Разбойник";
                    pictureBox2.Image = Properties.Resources.thunderer_se_blade2;
                    longAnime = 5;
                    Program.enemyDamage = 45;
                    images[0] = Properties.Resources.thunderer_se_blade2;
                    images[1] = Properties.Resources.thunderer_se_blade5;
                    images[2] = Properties.Resources.thunderer_se_blade6;
                    images[3] = Properties.Resources.thunderer_se_blade7;
                    images[4] = Properties.Resources.thunderer_se_blade8;
                    break;
                case 25:
                    hpE = 360;
                    stepsEnem = 20;
                    Program.Enemy = id;
                    label6.Text = "Атаман";
                    pictureBox2.Image = Properties.Resources.thunderguard_se_blade3;
                    longAnime = 5;
                    Program.enemyDamage = 80;
                    images[0] = Properties.Resources.thunderguard_se_blade3;
                    images[1] = Properties.Resources.thunderguard_se_blade4;
                    images[2] = Properties.Resources.thunderguard_se_blade5;
                    images[3] = Properties.Resources.thunderguard_se_blade6;
                    images[4] = Properties.Resources.thunderguard_se_blade7;
                    break;
                case 26:
                    hpE = 230;
                    stepsEnem = 8;
                    Program.Enemy = id;
                    label6.Text = "Лесной охотник";
                    pictureBox2.Image = Properties.Resources.archer_sword;
                    longAnime = 5;
                    Program.enemyDamage = 36;
                    images[0] = Properties.Resources.archer_sword;
                    images[1] = Properties.Resources.archer_sword_1;
                    images[2] = Properties.Resources.archer_sword_2;
                    images[3] = Properties.Resources.archer_sword_3;
                    images[4] = Properties.Resources.archer_sword_defend;
                    break;
                case 27:
                    hpE = 390;
                    stepsEnem = 10;
                    Program.Enemy = id;
                    label6.Text = "Егерь";
                    pictureBox2.Image = Properties.Resources.avenger_sword;
                    longAnime = 5;
                    Program.enemyDamage = 66;
                    images[0] = Properties.Resources.avenger_sword;
                    images[1] = Properties.Resources.avenger_sword_1;
                    images[2] = Properties.Resources.avenger_sword_2;
                    images[3] = Properties.Resources.avenger_sword_3;
                    images[4] = Properties.Resources.avenger_sword_defend;
                    break;
                case 28:
                    hpE = 500;
                    stepsEnem = 18;
                    Program.Enemy = id;
                    label6.Text = "Чемпион";
                    pictureBox2.Image = Properties.Resources.champion;
                    longAnime = 5;
                    Program.enemyDamage = 80;
                    images[0] = Properties.Resources.champion;
                    images[1] = Properties.Resources.champion_attack_2;
                    images[2] = Properties.Resources.champion_attack_3;
                    images[3] = Properties.Resources.champion_attack_4;
                    images[4] = Properties.Resources.champion_attack_5;
                    break;
                case 29:
                    hpE = 400;
                    stepsEnem = 18;
                    Program.Enemy = id;
                    label6.Text = "Снайпер";
                    pictureBox2.Image = Properties.Resources.champion_bow;
                    longAnime = 5;
                    Program.enemyDamage = 60;
                    images[0] = Properties.Resources.champion_bow;
                    images[1] = Properties.Resources.champion_bow_attack1;
                    images[2] = Properties.Resources.champion_bow_attack2;
                    images[3] = Properties.Resources.champion_bow_attack3;
                    images[4] = Properties.Resources.champion_bow_attack4;
                    break;
                case 30:
                    hpE = 700;
                    stepsEnem = 20;
                    Program.Enemy = id;
                    label6.Text = "Бомжихо";
                    pictureBox2.Image = Properties.Resources.druid;
                    longAnime = 3;
                    Program.enemyDamage = 30;
                    images[0] = Properties.Resources.druid;
                    images[1] = Properties.Resources.druid_defend_2;
                    images[2] = Properties.Resources.druid_attack;
                    break;
                case 31:
                    hpE = 300;
                    stepsEnem = 14;
                    Program.Enemy = id;
                    label6.Text = "Бешеная волшебница";
                    pictureBox2.Image = Properties.Resources.enchantress;
                    longAnime = 5;
                    Program.enemyDamage = 68;
                    images[0] = Properties.Resources.enchantress;
                    images[1] = Properties.Resources.enchantress_melee_2;
                    images[2] = Properties.Resources.enchantress_melee_3;
                    images[3] = Properties.Resources.enchantress_melee_4;
                    images[4] = Properties.Resources.enchantress_melee_5;
                    break;
                case 32:
                    hpE = 500;
                    stepsEnem = 8;
                    Program.Enemy = id;
                    label6.Text = "Мастер меча";
                    pictureBox2.Image = Properties.Resources.hero_defend;
                    longAnime = 5;
                    Program.enemyDamage = 44;
                    images[0] = Properties.Resources.hero_defend;
                    images[1] = Properties.Resources.hero_melee_1;
                    images[2] = Properties.Resources.hero_melee_2;
                    images[3] = Properties.Resources.hero_melee_3;
                    images[4] = Properties.Resources.hero_melee_4;
                    break;
                case 33:
                    hpE = 800;
                    stepsEnem = 5;
                    Program.Enemy = id;
                    label6.Text = "Высший эльф";
                    pictureBox2.Image = Properties.Resources.high_lord;
                    longAnime = 3;
                    Program.enemyDamage = 30;
                    images[0] = Properties.Resources.high_lord;
                    images[1] = Properties.Resources.high_lord_attack_sword_1;
                    images[2] = Properties.Resources.high_lord_attack_sword_2;
                    break;
                case 34:
                    hpE = 620;
                    stepsEnem = 24;
                    Program.Enemy = id;
                    label6.Text = "Элитный лучник";
                    pictureBox2.Image = Properties.Resources.marksman;
                    longAnime = 5;
                    Program.enemyDamage = 100;
                    images[0] = Properties.Resources.marksman;
                    images[1] = Properties.Resources.marksman_female_bow;
                    images[2] = Properties.Resources.marksman_female_bow_attack1;
                    images[3] = Properties.Resources.marksman_female_bow_attack2;
                    images[4] = Properties.Resources.marksman_female_bow_attack4;
                    break;
                case 35:
                    hpE = 620;
                    stepsEnem = 12;
                    Program.Enemy = id;
                    label6.Text = "Маршал";
                    pictureBox2.Image = Properties.Resources.marshal;
                    longAnime = 3;
                    Program.enemyDamage = 50;
                    images[0] = Properties.Resources.marshal;
                    images[1] = Properties.Resources.marshal_melee_1;
                    images[2] = Properties.Resources.marshal_melee_2;
                    break;
                case 36:
                    hpE = 800;
                    stepsEnem = 30;
                    Program.Enemy = id;
                    label6.Text = "Master of meat";
                    pictureBox2.Image = Properties.Resources.sharpshooter;
                    longAnime = 5;
                    Program.enemyDamage = 200;
                    images[0] = Properties.Resources.sharpshooter;
                    images[1] = Properties.Resources.sharpshooter_female_bow_attack1;
                    images[2] = Properties.Resources.sharpshooter_female_bow_attack2;
                    images[3] = Properties.Resources.sharpshooter_female_bow_attack3;
                    images[4] = Properties.Resources.sharpshooter_female_bow_attack4;
                    break;
                case 37:
                    hpE = 1000;
                    stepsEnem = 12;
                    Program.Enemy = id;
                    label6.Text = "Лесная фея";
                    pictureBox2.Image = Properties.Resources.shyde;
                    longAnime = 5;
                    Program.enemyDamage = 70;
                    images[0] = Properties.Resources.shyde;
                    images[1] = Properties.Resources.shyde_ftouch_attack1;
                    images[2] = Properties.Resources.shyde_ftouch_attack2;
                    images[3] = Properties.Resources.shyde_ftouch_attack3;
                    images[4] = Properties.Resources.shyde_healing9;
                    break;
                case 38:
                    hpE = 440;
                    stepsEnem = 7;
                    Program.Enemy = id;
                    label6.Text = "Ящер-воин";
                    pictureBox2.Image = Properties.Resources.ambusher;
                    longAnime = 5;
                    Program.enemyDamage = 37;
                    images[0] = Properties.Resources.ambusher;
                    images[1] = Properties.Resources.ambusher_se_melee1;
                    images[2] = Properties.Resources.ambusher_se_melee2;
                    images[3] = Properties.Resources.ambusher_se_melee3;
                    images[4] = Properties.Resources.ambusher_se_melee4;
                    break;
                case 39:
                    hpE = 660;
                    stepsEnem = 6;
                    Program.Enemy = id;
                    label6.Text = "Ящер-вожак";
                    pictureBox2.Image = Properties.Resources.flanker;
                    longAnime = 5;
                    Program.enemyDamage = 57;
                    images[0] = Properties.Resources.flanker;
                    images[1] = Properties.Resources.flanker_se_melee1;
                    images[2] = Properties.Resources.flanker_se_melee2;
                    images[3] = Properties.Resources.flanker_se_melee3;
                    images[4] = Properties.Resources.flanker_se_melee4;
                    break;
                case 40:
                    hpE = 220;
                    stepsEnem = 9;
                    Program.Enemy = id;
                    label6.Text = "Ящер-новобранец";
                    pictureBox2.Image = Properties.Resources.skirmisher_se_melee1;
                    longAnime = 5;
                    Program.enemyDamage = 18;
                    images[0] = Properties.Resources.skirmisher_se_melee1;
                    images[1] = Properties.Resources.skirmisher_se_melee2;
                    images[2] = Properties.Resources.skirmisher_se_melee3;
                    images[3] = Properties.Resources.skirmisher_se_melee4;
                    images[4] = Properties.Resources.skirmisher_se_melee5;
                    break;
                case 41:
                    hpE = 100;
                    stepsEnem = 10;
                    Program.Enemy = id;
                    label6.Text = "Мертвец";
                    pictureBox2.Image = Properties.Resources.skeleton;
                    longAnime = 5;
                    Program.enemyDamage = 100;
                    images[0] = Properties.Resources.skeleton;
                    images[1] = Properties.Resources.skeleton_se_melee3;
                    images[2] = Properties.Resources.skeleton_se_melee4;
                    images[3] = Properties.Resources.skeleton_se_melee5;
                    images[4] = Properties.Resources.skeleton_se_melee6;
                    break;
                case 42:
                    hpE = 300;
                    stepsEnem = 8;
                    Program.Enemy = id;
                    label6.Text = "Мертвец-лучник";
                    pictureBox2.Image = Properties.Resources.banebow;
                    longAnime = 5;
                    Program.enemyDamage = 120;
                    images[0] = Properties.Resources.banebow;
                    images[1] = Properties.Resources.banebow_bow;
                    images[2] = Properties.Resources.banebow_bow_attack_1;
                    images[3] = Properties.Resources.banebow_bow_attack_2;
                    images[4] = Properties.Resources.banebow_bow_attack_3;
                    break;
                case 43:
                    hpE = 500;
                    stepsEnem = 16;
                    Program.Enemy = id;
                    label6.Text = "Смертельный клинок";
                    pictureBox2.Image = Properties.Resources.deathblade;
                    longAnime = 5;
                    Program.enemyDamage = 150;
                    images[0] = Properties.Resources.deathblade;
                    images[1] = Properties.Resources.deathblade_attack1;
                    images[2] = Properties.Resources.deathblade_attack2;
                    images[3] = Properties.Resources.deathblade_attack3;
                    images[4] = Properties.Resources.deathblade_defend_1;
                    break;
                case 44:
                    hpE = 1000;
                    stepsEnem = 7;
                    Program.Enemy = id;
                    label6.Text = "Рыцарь смерти";
                    pictureBox2.Image = Properties.Resources.deathknight_lead_2;
                    longAnime = 5;
                    Program.enemyDamage = 150;
                    images[0] = Properties.Resources.deathknight_lead_2;
                    images[1] = Properties.Resources.deathknight_melee_attack_1;
                    images[2] = Properties.Resources.deathknight_melee_attack_2;
                    images[3] = Properties.Resources.deathknight_melee_attack_3;
                    images[4] = Properties.Resources.deathknight_melee_attack_4;
                    break;
                case 45:
                    hpE = 1200;
                    stepsEnem = 14;
                    Program.Enemy = id;
                    label6.Text = "Возрожденный";
                    pictureBox2.Image = Properties.Resources.revenant;
                    longAnime = 5;
                    Program.enemyDamage = 80;
                    images[0] = Properties.Resources.revenant;
                    images[1] = Properties.Resources.revenant_attack_5;
                    images[2] = Properties.Resources.revenant_attack_6;
                    images[3] = Properties.Resources.revenant_attack_7;
                    images[4] = Properties.Resources.revenant_attack_8;
                    break;
                case 46:
                    hpE = 330;
                    stepsEnem = 12;
                    Program.Enemy = id;
                    label6.Text = "Арбитр";
                    pictureBox2.Image = Properties.Resources.arbiter_blade_se_1;
                    longAnime = 5;
                    Program.enemyDamage = 33;
                    images[0] = Properties.Resources.arbiter_blade_se_1;
                    images[1] = Properties.Resources.arbiter_blade_se_2;
                    images[2] = Properties.Resources.arbiter_blade_se_3;
                    images[3] = Properties.Resources.arbiter_blade_se_4;
                    images[4] = Properties.Resources.arbiter_blade_se_5;
                    break;
                case 47:
                    hpE = 700;
                    stepsEnem = 12;
                    Program.Enemy = id;
                    label6.Text = "Красный дракон";
                    pictureBox2.Image = Properties.Resources.armageddon_melee_1;
                    longAnime = 5;
                    Program.enemyDamage = 70;
                    images[0] = Properties.Resources.armageddon_melee_1;
                    images[1] = Properties.Resources.armageddon_melee_2;
                    images[2] = Properties.Resources.armageddon_melee_3;
                    images[3] = Properties.Resources.armageddon_melee_4;
                    images[4] = Properties.Resources.armageddon_melee_5;
                    break;
                case 48:
                    hpE = 900;
                    stepsEnem = 16;
                    Program.Enemy = id;
                    label6.Text = "Истинный красный дракон";
                    pictureBox2.Image = Properties.Resources.fire;
                    longAnime = 5;
                    Program.enemyDamage = 100;
                    images[0] = Properties.Resources.fire;
                    images[1] = Properties.Resources.fire_fire_inhale_3;
                    images[2] = Properties.Resources.fire_fire_inhale_4;
                    images[3] = Properties.Resources.fire_fire_se_2;
                    images[4] = Properties.Resources.fire_fire_se_3;
                    break;
                case 49:
                    hpE = 1200;
                    stepsEnem = 16;
                    Program.Enemy = id;
                    label6.Text = "Боевой дракон";
                    pictureBox2.Image = Properties.Resources.thrasher_blade;
                    longAnime = 5;
                    Program.enemyDamage = 120;
                    images[0] = Properties.Resources.thrasher_blade;
                    images[1] = Properties.Resources.thrasher_blade_3;
                    images[2] = Properties.Resources.thrasher_blade_4;
                    images[3] = Properties.Resources.thrasher_blade_5;
                    images[4] = Properties.Resources.thrasher_blade_6;
                    break;
                case 50:
                    hpE = 5000;
                    stepsEnem = 2;
                    Program.Enemy = id;
                    label6.Text = "Fantom";
                    pictureBox2.Image = Properties.Resources.spectre_se_attack_1;
                    longAnime = 12;
                    Program.enemyDamage = 50;
                    images[0] = Properties.Resources.spectre_se_attack_1;
                    images[1] = Properties.Resources.spectre_se_attack_2;
                    images[2] = Properties.Resources.spectre_se_attack_3;
                    images[3] = Properties.Resources.spectre_se_attack_4;
                    images[4] = Properties.Resources.spectre_se_attack_5;
                    images[5] = Properties.Resources.spectre_se_attack_6;
                    images[6] = Properties.Resources.spectre_se_attack_7;
                    images[7] = Properties.Resources.spectre_se_attack_8;
                    images[8] = Properties.Resources.spectre_se_attack_9;
                    images[9] = Properties.Resources.spectre_se_attack_10;
                    images[10] = Properties.Resources.spectre_se_attack_11;
                    images[11] = Properties.Resources.spectre_se_attack_12;
                    break;
            }
            enemyHP = r.Next(hpE - 10, hpE + 11);
            newProgressBar5.Maximum = enemyHP;
            newProgressBar5.Value = newProgressBar5.Maximum;
            progressBarsCheck();
        }

        string potion;
        int num;
        PictureBox PB2;
        public void Use(int p)
        {

            switch (p)
            {
                case 1:
                    PB = pictureBox6;
                    num = 31;
                    break;
                case 2:
                    PB = pictureBox5;
                    Inventory INV2 = new Inventory();
                    PB2 = INV2.pictureBox17;
                    num = 32;
                    break;
                case 3:
                    PB = pictureBox4;
                    Inventory INV3 = new Inventory();
                    PB2 = INV3.pictureBox18;
                    num = 33;
                    break;
            }
            switch (i)
            {
                case "Зелье здоровья":
                    PB.Image = null;
                    Program.inventory[num] = "";
                    if (Program.HP + (int)Math.Round(Program.maxHP * 0.1) < Program.maxHP)
                    {
                        Program.HP += (int)Math.Round(Program.maxHP * 0.1);
                    }
                    else Program.HP = Program.maxHP;
                    break;
                case "Зелье маны":
                    PB.Image = null;
                    Program.inventory[num] = "";
                    break;
                case "Свиток ускорения":
                    PB.Image = null;
                    Program.inventory[num] = "";
                    if (Program.Steps + (int)Math.Round(Program.maxSteps * 0.5) < Program.maxSteps)
                    {
                        Program.Steps += (int)Math.Round(Program.maxSteps * 0.5);
                    }
                    else Program.Steps = Program.maxSteps;
                    break;
                case "Большое зелье здоровья":
                    PB.Image = null;
                    Program.inventory[num] = "";
                    if (Program.HP + (int)Math.Round(Program.maxHP * 0.3) < Program.maxHP)
                    {
                        Program.HP += (int)Math.Round(Program.maxHP * 0.3);
                    }
                    else Program.HP = Program.maxHP;
                    break;
                case "Большое зелье маны":
                    PB.Image = null;
                    Program.inventory[num] = "";
                    break;
                default:
                    PB.Image = null;
                    break;
            }
            progressBarsCheck();
            Inventory up = new Inventory();
            up.Upgrade();
            up.Upg();
            UpBuff();

        }
        public void pictureBox6_Click(object sender, EventArgs e)
        {
            Use(1);
        }

        PictureBox PB;
        string i;
        public void upB(int j)
        {
            if (j == 1)
            {
                PB = pictureBox6;
                i = Program.inventory[31];
            }
            else if (j == 2)
            {
                PB = pictureBox5;
                i = Program.inventory[32];
            }
            else if (j == 3)
            {
                PB = pictureBox4;
                i = Program.inventory[33];
            }
            switch (i)
            {
                case "Зелье здоровья":
                    PB.Image = Properties.Resources.potion_red_small;
                    break;
                case "Зелье маны":
                    PB.Image = Properties.Resources.potion_green_small;
                    break;
                case "Свиток ускорения":
                    PB.Image = Properties.Resources.scroll_red;
                    break;
                case "Большое зелье здоровья":
                    PB.Image = Properties.Resources.potion_red_medium;
                    break;
                case "Большое зелье маны":
                    PB.Image = Properties.Resources.potion_green_medium;
                    break;
                default:
                    PB.Image = null;
                    break;
            }
        }
        public void UpBuff()
        {
            Inventory INV = new Inventory();
            if (Program.inventory[31] != "")
            {
                upB(1);
            }
            if (Program.inventory[32] != "")
            {
                upB(2);
            }
            if (Program.inventory[33] != "")
            {
                upB(3);
            }
            /* if (Program.inventory[31] == "")
             {
                 pictureBox6.Image = null;


             }
             if (Program.inventory[32] == "")
             {
                 pictureBox5.Image = null;

             }
             if (Program.inventory[33] == "")
             {
                 pictureBox4.Image = null;

             }*/
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Use(2);
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Use(3);
        }
    }
}
